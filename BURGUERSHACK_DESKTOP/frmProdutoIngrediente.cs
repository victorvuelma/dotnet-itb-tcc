using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIX;

namespace BURGUERSHACK_DESKTOP
{
    public partial class frmProdutoIngrediente : Form
    {

        private clnUtilFormValidar _validar;

        private clnProdutoIngrediente _objProdutoIngrediente;

        public clnProdutoIngrediente ObjProdutoIngrediente { get => _objProdutoIngrediente; set => _objProdutoIngrediente = value; }

        public frmProdutoIngrediente()
        {
            InitializeComponent();

            hdrUIX.Title = App.Name + " - Ingrediente";

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilFormValidar.ValidarTipo[] { clnUtilFormValidar.ValidarTipo.OBRIGATORIO, clnUtilFormValidar.ValidarTipo.INT, clnUtilFormValidar.ValidarTipo.INT_MAIOR_0 });
        }

        private void exibir()
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = ObjProdutoIngrediente.CodIngrediente
            }.obterPorCod();

            clnArquivo objArquivo = new clnArquivo
            {
                Cod = objIngrediente.CodImagem
            }.obterPorCodigo();
            picIngrediente.ImageLocation = objArquivo.Local;

            lblNome.Text = objIngrediente.Nome;
            txtQuantidade.Text = Convert.ToString(ObjProdutoIngrediente.Quantidade);
            chkAlterar.Checked = ObjProdutoIngrediente.Alterar;
            chkRemover.Checked = ObjProdutoIngrediente.Remover;

            picIngrediente.Show();
            lblNome.Show();
            txtQuantidade.Show();
        }

        private void finalizar()
        {
            if (clnUtilMensagem.mostrarSimNao("Ingrediente", "Deseja cancelar as alterações no ingrediente?", clnUtilMensagem.MensagemIcone.ERRO))
            {
                Close();
            }

        }

        private void remover()
        {
            if (ObjProdutoIngrediente.Cod == -1)
            {
                if (clnUtilMensagem.mostrarSimNao("Ingrediente", "Você deseja realmente cancelar a adição deste ingrediente?", clnUtilMensagem.MensagemIcone.INFO))
                {
                    ObjProdutoIngrediente = null;

                    Close();
                }
            }
            else
            {
                if (clnUtilMensagem.mostrarSimNao("Ingrediente", "Você deseja realmente remover este ingrediente?", clnUtilMensagem.MensagemIcone.INFO))
                {
                    ObjProdutoIngrediente = null;

                    Close();
                }
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            finalizar();
        }

        private void frmAlteraIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);

            UIX.uixButton.btnApply(btnRemover, AppDesktop.VisualStyle.ButtonWarningColor);

            picIngrediente.Hide();
            lblNome.Hide();
            txtQuantidade.Hide();

            exibir();

            if (ObjProdutoIngrediente.Cod == -1)
            {
                btnRemover.Text = "Cancelar";
            }
            else
            {
                btnRemover.Text = "Remover";
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            remover();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_validar.valido())
            {
                ObjProdutoIngrediente.Quantidade = clnUtilConvert.ToInt(txtQuantidade.Text);
                ObjProdutoIngrediente.Remover = chkRemover.Checked;
                ObjProdutoIngrediente.Alterar = chkAlterar.Checked;

                Close();
            }
        }

    }
}
