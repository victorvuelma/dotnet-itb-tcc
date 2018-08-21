using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop
{
    public partial class frmMesa : Form
    {

        private clnUtilFormValidar _validar;

        private clnMesa _objMesa;

        internal clnMesa ObjMesa { get => _objMesa; set => _objMesa = value; }

        public frmMesa()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtLugares, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.QUANTIDADE });
            _validar.addValidacao(txtNumero, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.QUANTIDADE });

        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                clnMesa objMesaNumero = new clnMesa
                {
                    Numero = UtilConvert.ToInt(txtNumero.Text),
                    Ativo = true
                }.obterPorNumero();

                if (ObjMesa == null)
                {
                    if (objMesaNumero == null)
                    {
                        clnMesa objMesa = new clnMesa
                        {
                            Numero = UtilConvert.ToInt(txtNumero.Text),
                            Lugares = UtilConvert.ToInt(txtLugares.Text),
                            Situacao = clnMesa.mesaSituacao.DISPONIVEL
                        };
                        objMesa.gravar();
                        ObjMesa = objMesa;
                        UtilMensagem.mostrarOk("Cadastro de Mesa", "Mesa cadastrada com sucesso!");
                        Close();
                    }
                    else
                    {
                        UtilMensagem.mostrarOk("Cadastro de Mesa", "Não foi possível cadastrar a mesa, o NÚMERO já está cadastrado!");
                        txtNumero.Focus();
                    }
                }
                else
                {
                    ObjMesa.Numero = UtilConvert.ToInt(txtNumero.Text);
                    ObjMesa.Lugares = UtilConvert.ToInt(txtLugares.Text);

                    ObjMesa.alterar();
                    UtilMensagem.mostrarOk("Alteração de Mesa", "Mesa alterada com sucesso!");
                    Close();
                }
            }
        }

        private void fechar()
        {
            if (ObjMesa == null)
            {
                if (UtilMensagem.mostrarSimNao("Cadastro de Mesa", "Deseja cancelar o cadastro?", UtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (btnAlterar.Text == "Salvar")
                {
                    if (UtilMensagem.mostrarSimNao("Alteração de Mesa", "Deseja cancelar as alterações?", UtilMensagem.MensagemIcone.ERRO))
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
            if (UtilMensagem.mostrarSimNao("Mesa", "Você deseja realmente excluir esta mesa?", UtilMensagem.MensagemIcone.ERRO))
            {
                ObjMesa.Ativo = false;
                ObjMesa.alterar();

                btnAlterar.Hide();
                UtilButton.restaurar(btnExcluir);
                UtilForm.Disable(this);
            }
        }

        private void restaurar()
        {
            if (UtilMensagem.mostrarSimNao("Mesa", "Você deseja realmente restaurar esta mesa?", UtilMensagem.MensagemIcone.OK))
            {
                ObjMesa.Ativo = true;
                ObjMesa.alterar();

                btnAlterar.Show();
                UtilButton.excluir(btnExcluir);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            if (ObjMesa == null)
            {
                hdrUIX.Title = App.Name + " - Nova Mesa";

                lblSituacao.Text = "Situação: " + clnMesa.mesaSituacao.DISPONIVEL.ToString();
            }
            else
            {
                hdrUIX.Title = App.Name + " - Mesa " + ObjMesa.Cod;
                txtLugares.Text = UtilConvert.ToString(ObjMesa.Lugares);
                txtNumero.Text = UtilConvert.ToString(ObjMesa.Numero);
                lblSituacao.Text = "Situação: " + UtilConvert.ToString(ObjMesa.Situacao);
                UtilForm.Disable(this);

                if (AppDesktop.FuncionarioAtual.CodCargo >= 3)
                {
                    btnExcluir.Show();
                    UtilButton.alterar(btnAlterar);
                    UtilButton.voltar(btnVoltar);
                    if (ObjMesa.Ativo)
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
            if (ObjMesa.Ativo)
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
