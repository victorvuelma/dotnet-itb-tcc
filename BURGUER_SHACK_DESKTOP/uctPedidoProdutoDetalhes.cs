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
    public partial class uctPedidoProdutoDetalhes : UserControl
    {

        private int _mesa;

        private frmPedidoProduto _frm;

        public int Mesa { get => _mesa; set => _mesa = value; }
        public frmPedidoProduto Frm { get => _frm; set => _frm = value; }

        public uctPedidoProdutoDetalhes()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Frm.abrirVisualizar();
        }
    }
}
