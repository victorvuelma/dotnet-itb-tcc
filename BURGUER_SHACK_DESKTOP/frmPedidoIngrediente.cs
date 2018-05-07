using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmPedidoIngrediente : Form
    {

        private List<clnPedidoProdutoIngrediente> _ingredientes;

        public List<clnPedidoProdutoIngrediente> Ingredientes { get => _ingredientes; set => _ingredientes = value; }

        public frmPedidoIngrediente()
        {
            InitializeComponent();
        }

        private void escolherAlterar()
        {
            clnSelecionarIngrediente objSelecionar = new clnSelecionarIngrediente
            {
                Opcoes = Ingredientes
            };

            frmSelecionar frmSelecionar = new frmSelecionar
            {
                ObjSelecionar = objSelecionar,
                Selecionando = "Selecione o ingrediente para alterar",
            };
            frmSelecionar.txtQuantidade.Hide();
            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                exibirIngredienteAntigo(objSelecionar.Selecionado);
            }
        }

        private void exibirIngredienteAntigo(clnPedidoProdutoIngrediente objIngrediente)
        {
            picAntigo.Image = objIngrediente.Ingrediente.Imagem;
            lblAntigoNome.Text = objIngrediente.Ingrediente.Nome;
            lblQuantidade.Text = "Quantidade: " + objIngrediente.Quantidade;

            picAntigo.Show();
            lblAntigoNome.Show();
            lblQuantidade.Show();
        }

        private void frmAlteraIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarTabIndex(Controls);
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);

            UIX.uixButton.btnApply(btnRemover, clnApp.AppVisualStyle.ButtonWarningColor);

            picAntigo.Hide();
            lblAntigoNome.Hide();
            lblQuantidade.Hide();

            picNovo.Hide();
            lblNovoNome.Hide();
            txtQuantidade.Hide();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            escolherAlterar();
        }

        class clnSelecionarIngrediente : clnSelecionar<clnPedidoProdutoIngrediente>
        {
            internal override int Cod(clnPedidoProdutoIngrediente obj)
            {
                return obj.Ingrediente.Cod;
            }

            internal override string Detalhes(clnPedidoProdutoIngrediente obj)
            {
                string detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;

                return detalhes;
            }

            internal override Image Imagem(clnPedidoProdutoIngrediente obj)
            {
                return obj.Ingrediente.Imagem;
            }

            internal override string Nome(clnPedidoProdutoIngrediente obj)
            {
                return obj.Ingrediente.Nome;
            }
        }


    }
}
