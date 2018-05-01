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
        
        public int Mesa { get => _mesa; set => _mesa = value; }
        public frmPedido Frm { get => _frm; set => _frm = value; }

        public uctPedidoProdutos()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if(clnMensagem.mostrarSimNao("Pedido", "Deseja confirmar este pedido?", clnMensagem.MSG_OK))
            {
                //Confirma o pedido.


                Frm.Close();
            }
        }
    }
}
