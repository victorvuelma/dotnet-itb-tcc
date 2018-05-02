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

        private frmPedidoProduto _frm;
        private clnPedidoProduto _objPedidoProduto;

        public frmPedidoProduto Frm { get => _frm; set => _frm = value; }
        public clnPedidoProduto ObjPedidoProduto { get => _objPedidoProduto; set => _objPedidoProduto = value; }

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            _frm.Close();
        }
    }
}
