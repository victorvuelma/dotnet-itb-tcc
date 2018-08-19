using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop
{
    public partial class frmCliente : Form
    {

        private clnUtilFormValidar _validar;

        private clnCliente _objCliente;

        internal clnCliente ObjCliente { get => _objCliente; set => _objCliente = value; }

        public frmCliente()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtNome, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(mtbCPF, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CPF });
            _validar.addValidacao(mtbDataNasc, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.DATA, clnUtilFormValidar.Validacao.DATA_NASC });
            _validar.addValidacao(mtbTelCel, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CELULAR });
            _validar.addValidacao(txtEmail, clnUtilFormValidar.Validacao.EMAIL);
            _validar.addValidacao(cboGenero, clnUtilFormValidar.Validacao.OBRIGATORIO);

            mtbCPF.Mask = UtilMask.MASK_CPF;
            mtbDataNasc.Mask = UtilMask.MASK_DATA;
            cboGenero.addRange(new String[] { "M", "F" });
            mtbTelCel.Mask = UtilMask.MASK_CEL;
        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                clnCliente objClienteCPF = new clnCliente
                {
                    Cpf = UtilFormatar.retirarFormatacao(mtbCPF.Text)
                }.obterPorCPF();

                if (ObjCliente == null)
                {
                    if (objClienteCPF == null)
                    {
                        clnCliente objCliente = new clnCliente
                        {
                            CodFuncionario = AppDesktop.FuncionarioAtual.Cod,
                            Nome = txtNome.Text,
                            Cpf = UtilFormatar.retirarFormatacao(mtbCPF.Text),
                            DataNascimento = UtilConvert.ObterNullableData(mtbDataNasc.Text),
                            Email = txtEmail.Text,
                            TelCelular = UtilFormatar.retirarFormatacao(mtbTelCel.Text),
                            Genero = cboGenero.Text,
                            Cadastro = DateTime.Now
                        };
                        objCliente.gravar();
                        ObjCliente = objCliente;
                        UtilMensagem.mostrarOk("Cadastro de Cliente", "Cliente cadastrado com sucesso!");
                        Close();
                    }
                    else
                    {
                        UtilMensagem.mostrarOk("Cadastro de Cliente", "Não foi possível cadastrar o cliente, o CPF já está cadastrado!");
                        mtbCPF.Focus();
                    }
                }
                else
                {
                    ObjCliente.Nome = txtNome.Text;
                    ObjCliente.DataNascimento = UtilConvert.ObterNullableData(mtbDataNasc.Text);
                    ObjCliente.Email = txtEmail.Text;
                    ObjCliente.TelCelular = UtilFormatar.retirarFormatacao(mtbTelCel.Text);
                    ObjCliente.Genero = cboGenero.Text;
                    ObjCliente.alterar();
                    UtilMensagem.mostrarOk("Alteração de Cliente", "Cliente alterado com sucesso!");
                    Close();
                }
            }
        }

        private void fechar()
        {
            if (ObjCliente == null)
            {
                if (UtilMensagem.mostrarSimNao("Cadastro de Cliente", "Deseja cancelar o cadastro?", UtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (btnEditar.Text == "Salvar")
                {
                    if (UtilMensagem.mostrarSimNao("Alteração de Cliente", "Deseja cancelar as alterações?", UtilMensagem.MensagemIcone.ERRO))
                    {
                        Close();
                    }
                } else
                {
                    Close();
                }
            }
        }

        private void excluir()
        {
            if (UtilMensagem.mostrarSimNao("Cliente", "Você deseja realmente excluir este cliente?", UtilMensagem.MensagemIcone.ERRO))
            {
                ObjCliente.Ativo = false;
                ObjCliente.alterar();

                btnEditar.Hide();
                UtilButton.restaurar(btnExcluir);
                UtilForm.Disable(grbInformacoes);
            }
        }

        private void restaurar()
        {
            if (UtilMensagem.mostrarSimNao("Cliente", "Você deseja realmente restaurar este cliente?", UtilMensagem.MensagemIcone.OK))
            {
                ObjCliente.Ativo = true;
                ObjCliente.alterar();

                btnEditar.Show();
                UtilButton.excluir(btnExcluir);
                UtilForm.Enable(grbInformacoes);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            if (ObjCliente == null)
            {
                hdrUIX.Title = App.Name + " - Novo Cliente";
            }
            else
            {
                hdrUIX.Title = App.Name + " - Cliente " + ObjCliente.Cod;
                mtbCPF.Enabled = false;
                txtNome.Text = ObjCliente.Nome;
                mtbCPF.Text = ObjCliente.Cpf;
                if (ObjCliente.DataNascimento != null)
                {
                    mtbDataNasc.Text = ((DateTime)ObjCliente.DataNascimento).ToString("dd/MM/yyyy");
                }
                mtbTelCel.Text = ObjCliente.TelCelular;
                txtEmail.Text = ObjCliente.Email;
                if (ObjCliente.Genero != null)
                {
                    cboGenero.Text = ObjCliente.Genero;
                }
                UtilForm.Disable(grbInformacoes);
                if (AppDesktop.FuncionarioAtual.CodCargo >= 3)
                {
                    btnExcluir.Show();
                    UtilButton.alterar(btnEditar);
                    UtilButton.voltar(btnVoltar);
                    if (ObjCliente.Ativo)
                    {
                        UtilButton.excluir(btnExcluir);
                    }
                    else
                    {
                        btnEditar.Hide();
                        UtilButton.restaurar(btnExcluir);
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Salvar")
            {
                salvar();
            }
            else
            {
                UtilForm.Enable(grbInformacoes);
                UtilButton.cancelar(btnEditar);
                UtilButton.salvar(btnEditar);
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ObjCliente.Ativo)
            {
                excluir();
            }
            else
            {
                restaurar();
            }
        }
    }
}
