using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmMesa : Form
    {

        private int _mesa;

        public int Mesa { get => _mesa; set => _mesa = value; }
        
        public frmMesa()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }
        
        public void abrirPedidos()
        {
            alterarConteudo(new uctMesaPedidos(), "Mesa " + Mesa + " :: Pedidos");
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        private void frmMesa_Load(object sender, EventArgs e)
        {
            clnApp.CommonTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnSair, clnApp.CommonTemplate.Style.WarningButtonColor);

            abrirPedidos();
        }
        
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            abrirPedidos();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            uctMesaConta conta = new uctMesaConta();
            conta.Mesa = Mesa;
            alterarConteudo(conta, "Mesa " + Mesa + " :: Conta");
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();

            pedido.abrirProdutos();
            
            pedido.ShowDialog();
        }

    }
}
