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
            _validar.addValidacao(mtbTelCel, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CELULAR });
            _validar.addValidacao(txtEmail, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.EMAIL });

            mtbCPF.Mask = UtilMask.MASK_CPF;
            mtbTelCel.Mask = UtilMask.MASK_CEL;
        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                if (ObjCliente == null)
                {
                    clnCliente objClienteCPF = new clnCliente
                    {
                        Cpf = UtilFormatar.retirarFormatacao(mtbCPF.Text)
                    }.obterPorCPF();

                    if (objClienteCPF == null)
                    {
                        clnCliente objClienteEmail = new clnCliente
                        {
                            Email = txtEmail.Text
                        }.obterPorEmail();

                        if (objClienteEmail == null)
                        {
                            ObjCliente = new clnCliente
                            {
                                CodFuncionario = AppDesktop.FuncionarioAtual.Cod,
                                Nome = txtNome.Text,
                                Cpf = UtilFormatar.retirarFormatacao(mtbCPF.Text),
                                Email = txtEmail.Text,
                                TelCelular = UtilFormatar.retirarFormatacao(mtbTelCel.Text),
                                Cadastro = DateTime.Now
                            };
                            ObjCliente.gravar();
                            UtilMensagem.mostrarOk("Cadastro de Cliente", "Cliente cadastrado com sucesso!");
                            Close();
                        }
                        else
                        {
                            UtilMensagem.mostrarOk("Cadastro de Cliente", "Não foi possível cadastrar o cliente, o email já está cadastrado!");
                            mtbCPF.Focus();
                        }
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
                    ObjCliente.Email = txtEmail.Text;
                    ObjCliente.TelCelular = UtilFormatar.retirarFormatacao(mtbTelCel.Text);
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
                if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (UtilMensagem.mostrarSimNao("Alteração de Cliente", "Deseja cancelar as alterações?", UtilMensagem.MensagemIcone.ERRO))
                    {
                        Close();
                    }
                }
                else
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

                btnAlterar.Hide();
                UtilButton.restaurar(btnExcluir);
                UtilForm.Disable(this);
            }
        }

        private void restaurar()
        {
            if (UtilMensagem.mostrarSimNao("Cliente", "Você deseja realmente restaurar este cliente?", UtilMensagem.MensagemIcone.OK))
            {
                ObjCliente.Ativo = true;
                ObjCliente.alterar();

                btnAlterar.Show();
                UtilButton.excluir(btnExcluir);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            txtNome.Focus();
            if (ObjCliente == null)
            {
                hdrUIX.Title = App.Name + " - Novo Cliente";
            }
            else
            {
                hdrUIX.Title = App.Name + " - Cliente " + ObjCliente.Cod;
                txtNome.Text = ObjCliente.Nome;
                mtbCPF.Text = ObjCliente.Cpf;
                mtbTelCel.Text = ObjCliente.TelCelular;
                txtEmail.Text = ObjCliente.Email;
                UtilForm.Disable(this);

                if (AppDesktop.FuncionarioAtual.CodCargo >= 3)
                {
                    btnExcluir.Show();
                    UtilButton.alterar(btnAlterar);
                    UtilButton.voltar(btnVoltar);
                    if (ObjCliente.Ativo)
                    {
                        UtilButton.excluir(btnExcluir);
                    }
                    else
                    {
                        btnAlterar.Hide();
                        UtilButton.restaurar(btnExcluir);
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
            {
                salvar();
            }
            else
            {
                UtilForm.Enable(this);
                mtbCPF.Enabled = false;
                txtEmail.Enabled = false;

                UtilButton.cancelar(btnVoltar);
                UtilButton.salvar(btnAlterar);
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
            UtilButton.voltar(btnVoltar);
        }
    }
}
