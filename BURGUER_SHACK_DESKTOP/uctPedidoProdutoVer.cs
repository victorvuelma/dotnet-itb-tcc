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
