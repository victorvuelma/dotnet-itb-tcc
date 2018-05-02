using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class uctPedidoProdutoIngrediente : UserControl
    {

        private bool _add;
        private frmPedidoProduto _frm;
        
        private clnPedidoProdutoIngrediente _pedidoIngrediente;

        public frmPedidoProduto Frm { get => _frm; set => _frm = value; }
        public bool Add { get => _add; set => _add = value; }
        public clnPedidoProdutoIngrediente PedidoIngrediente { get => _pedidoIngrediente; set => _pedidoIngrediente = value; }

        public uctPedidoProdutoIngrediente()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        private void selecionaIngrediente(clnIngrediente ingrediente)
        {
            exibirIngrediente(ingrediente);

            txtQuantidade.Text = "1";
        }

        private void exibirIngrediente(clnIngrediente ingrediente)
        {
            picIngrediente.Image = ingrediente.Imagem;
            lblIngredienteNome.Text = ingrediente.Nome;
            lblIngredienteDesc.Visible = false;

            grbIngrediente.Visible = true;
        }

        private void exibirIngredientes()
        {
            pnlIngredientes.Visible = false;
            pnlIngredientes.Controls.Clear();

            clnIngrediente objIngredientes = new clnIngrediente();
            //definir o tipo do ingrediente

            List<Control> ingredienteControles = new List<Control>();
            foreach (clnIngrediente ingrediente in objIngredientes.obterPorTipo())
            {
                UIX.btnUIX btn = new UIX.btnUIX();
                btn.Description = "INGREDIENTE " + ingrediente.Nome;
                btn.Image = ingrediente.Imagem;
                btn.Name = "btnIngrediente" + ingrediente.Cod;
                btn.Size = new Size(75, 75);

                btn.Click += (object sender, EventArgs e) =>
                {
                    selecionaIngrediente(ingrediente);
                };

                ingredienteControles.Add(btn);
            }

            clnUtil.adicionarControles(pnlIngredientes, ingredienteControles, 10);

            clnApp.CommonTemplate.pnlApply(pnlIngredientes);

            clnUtil.atualizarTabIndex(pnlIngredientes.Controls);

            pnlIngredientes.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Frm.abrirVisualizar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (clnMensagem.mostrarSimNao("Ingrediente", "Deseja realmente remover esse ingrediente do produto?", clnMensagem.MensagemIcone.ERRO))
            {
                Frm.removerIngrediente(PedidoIngrediente);

                Frm.abrirVisualizar();
            }
        }

        private void uctPedidoProdutoIngrediente_Load(object sender, EventArgs e)
        {
            exibirIngredientes();

            if(PedidoIngrediente != null)
            {
                txtQuantidade.Text = Convert.ToString(PedidoIngrediente.Quantidade);

                clnIngrediente objIngrediente = new clnIngrediente();
                objIngrediente.Cod = PedidoIngrediente.Ingrediente;

                exibirIngrediente(objIngrediente.obterPorCodigo());
            } else
            {
                txtQuantidade.Text = "1";
            }
        }
    }
}
