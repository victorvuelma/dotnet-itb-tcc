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
        
        public frmPedidoProduto Frm { get => _frm; set => _frm = value; }
        public bool Add { get => _add; set => _add = value; }

        public uctPedidoProdutoIngrediente()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);

            List<Control> ingredientes = new List<Control>();
            for (int i = 1; i <= 10; i++)
            {
                int ingrediente = i;

                UIX.btnUIX btn = new UIX.btnUIX();
                btn.Description = "INGREDIENTE " + ingrediente;
                btn.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.hamburger;
                btn.Name = "btnIngrediente" + ingrediente;
                btn.Size = new Size(75, 75);

                btn.Click += (object sender, EventArgs e) =>
                {
                    selecionaIngrediente(ingrediente);
                };

                ingredientes.Add(btn);
            }

            clnUtil.adicionarControles(pnlIngredientes, ingredientes, 10);

            clnUtil.atualizarTabIndex(pnlIngredientes.Controls);
        }

        private void selecionaIngrediente(int ingrediente)
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
