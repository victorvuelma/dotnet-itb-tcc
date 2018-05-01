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
    public partial class uctPedidoProdutos : UserControl
    {
        private int _mesa;

        private frmPedido _frm;
                
        public frmPedido Frm { get => _frm; set => _frm = value; }
        public int Mesa { get => _mesa; set => _mesa = value; }

        public uctPedidoProdutos()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);

            dgvProdutos.Rows.Add("Produto 1", "1");
        }

        private void editarPedidoProduto(int pedidoProduto)
        {
            frmPedidoProduto frmPedidoProduto = new frmPedidoProduto();

            frmPedidoProduto.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (clnMensagem.mostrarSimNao("Pedido", "Deseja confirmar este pedido?", clnMensagem.MSG_OK))
            {
                //Confirma o pedido.

                Frm.Close();
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editarPedidoProduto(e.RowIndex);
        }
    }
}
