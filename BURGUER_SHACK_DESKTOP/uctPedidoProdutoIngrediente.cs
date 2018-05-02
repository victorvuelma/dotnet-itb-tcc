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

            clnUtil.atualizarTabIndex(pnlIngredientes.Controls);
        }

        private void selecionaIngrediente(clnIngrediente ingrediente)
        {
            grbIngrediente.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {


            Frm.abrirVisualizar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
