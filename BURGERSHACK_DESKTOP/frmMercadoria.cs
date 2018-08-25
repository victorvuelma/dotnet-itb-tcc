using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop
{
    public partial class frmMercadoria : Form
    {

        private clnUtilFormValidar _validar;

        private clnMercadoria _objMercadoria;

        internal clnMercadoria ObjMercadoria { get => _objMercadoria; set => _objMercadoria = value; }

        public frmMercadoria()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtDescricao, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO });
            _validar.addValidacao(txtCodigoBarras, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.QUANTIDADE });

        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                clnMercadoria objMercadoriaCodigoBarras = new clnMercadoria
                {
                    CodigoBarras = UtilConvert.ToInt(txtCodigoBarras.Text)
                }.obterPorCodigoBarras();

                if (ObjMercadoria == null)
                {
                    if (objMercadoriaCodigoBarras == null)
                    {
                        clnMercadoria objMercadoria = new clnMercadoria
                        {
                            Descricao = txtDescricao.Text,
                            CodigoBarras = UtilConvert.ToInt(txtCodigoBarras.Text)
                        };
                        objMercadoria.gravar();
                        ObjMercadoria = objMercadoria;
                        UtilMensagem.mostrarOk("Cadastro de Mercadoria", "Mercadoria cadastrada com sucesso!");
                        Close();
                    }
                    else
                    {
                        UtilMensagem.mostrarOk("Cadastro de Mercadoria", "Não foi possível cadastrar a mercadoria, o CÓDIGO DE BARRAS já está cadastrado!");
                        txtCodigoBarras.Focus();
                    }
                }
                else
                {
                    ObjMercadoria.Descricao = txtDescricao.Text;
                    ObjMercadoria.CodigoBarras = UtilConvert.ToInt(txtCodigoBarras.Text);

                    ObjMercadoria.alterar();
                    UtilMensagem.mostrarOk("Alteração de Mercadoria", "Mercadoria alterada com sucesso!");
                    Close();
                }
            }
        }

        private void fechar()
        {
            if (ObjMercadoria == null)
            {
                if (UtilMensagem.mostrarSimNao("Cadastro de Mercadoria", "Deseja cancelar o cadastro?", UtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (UtilMensagem.mostrarSimNao("Alteração de Mercadoria", "Deseja cancelar as alterações?", UtilMensagem.MensagemIcone.ERRO))
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
            if (UtilMensagem.mostrarSimNao("Mercadoria", "Você deseja realmente excluir esta mercadoria?", UtilMensagem.MensagemIcone.ERRO))
            {
                ObjMercadoria.Ativo = false;
                ObjMercadoria.alterar();

                btnAlterar.Hide();
                UtilButton.restaurar(btnExcluir);
                UtilForm.Disable(this);
            }
        }

        private void restaurar()
        {
            if (UtilMensagem.mostrarSimNao("Mercadoria", "Você deseja realmente restaurar esta mercadoria?", UtilMensagem.MensagemIcone.OK))
            {
                ObjMercadoria.Ativo = true;
                ObjMercadoria.alterar();

                btnAlterar.Show();
                UtilButton.excluir(btnExcluir);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            if (ObjMercadoria == null)
            {
                hdrUIX.Title = App.Name + " - Nova Mercadoria";

                lblSituacao.Text = "Situação: " + clnMesa.mesaSituacao.DISPONIVEL.ToString();
            }
            else
            {
                hdrUIX.Title = App.Name + " - Mercadoria " + ObjMercadoria.Cod;
                txtDescricao.Text = ObjMercadoria.Descricao;
                txtCodigoBarras.Text = UtilConvert.ToString(ObjMercadoria.CodigoBarras);
                UtilForm.Disable(this);

                if (AppDesktop.FuncionarioAtual.CodCargo >= 3)
                {
                    btnExcluir.Show();
                    UtilButton.alterar(btnAlterar);
                    UtilButton.voltar(btnVoltar);
                    if (ObjMercadoria.Ativo)
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

            txtDescricao.Focus();
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
            if (ObjMercadoria.Ativo)
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
