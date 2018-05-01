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
    public partial class uctPedidoProdutoVer : UserControl
    {

        private int _mesa;

        private frmPedido _frm;

        public int Mesa { get => _mesa; set => _mesa = value; }
        public frmPedido Frm { get => _frm; set => _frm = value; }

        public uctPedidoProdutoVer()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        private void editarPedidoProduto(int pedidoProduto)
        {
            frmPedidoProduto frmPedidoProduto = new frmPedidoProduto();

            MessageBox.Show(pedidoProduto + "");

            frmPedidoProduto.ShowDialog();
        }

    }
}
