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
    public partial class uctPedido : UserControl
    {
        public uctPedido()
        {
            InitializeComponent();
        }

        private void uctPedido_Load(object sender, EventArgs e)
        {
            uctPedido uctPedido = new uctPedido();
            uctPedido.Size = new Size(508, 649);
            grbAlterarItens.Visible = false;
            grbRemoverProduto.Visible = false;
            grbAdicionarItens.Visible = false;
            grpListaPedidos.Visible = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmPadrao objPadrao = new frmPadrao();

            objPadrao.uctUIX.UIXTitle = "Burguer Shack - Novo Pedido";
            btnPedido.Text = "Confirmar Pedido";
            grbAdicionarItens.Visible = true;
            grbAdicionarItens.Location = new Point(70, 3);
            grbAdicionarItens.Size = new Size(423, 510);

            grbAlterarItens.Visible = false;
            grbRemoverProduto.Visible = false;
            grpListaPedidos.Visible = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnPedido.Text = "Alterar Pedido";
            grbAlterarItens.Visible = true;
            grbAlterarItens.Location = new Point(70, 3);
            grbAlterarItens.Size = new Size(423, 510);

            grbAdicionarItens.Visible = false;
            grbRemoverProduto.Visible = false;
            grpListaPedidos.Visible = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            btnPedido.Text = "Remover Produtos";
            grbRemoverProduto.Visible = true;
            grbRemoverProduto.Location = new Point(70, 3);
            grbRemoverProduto.Size = new Size(423, 510);

            grbAdicionarItens.Visible = false;
            grbAlterarItens.Visible = false;
            grpListaPedidos.Visible = false;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            btnPedido.Text = "Lista de Pedidos";
            grpListaPedidos.Visible = true;
            grpListaPedidos.Location = new Point(70, 3);
            grpListaPedidos.Size = new Size(423, 510);

            grbAdicionarItens.Visible = false;
            grbAlterarItens.Visible = false;
            grbRemoverProduto.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

    }
}
