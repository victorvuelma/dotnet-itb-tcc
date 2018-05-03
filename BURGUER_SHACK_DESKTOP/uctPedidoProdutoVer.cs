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

        private frmPedidoProduto _form;

        private clnPedidoProduto _pedidoProduto;

        public frmPedidoProduto Form { get => _form; set => _form = value; }
        public clnPedidoProduto PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }

        public uctPedidoProdutoVer()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            _form.Close();
        }
    }
}
