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

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, "Mesa " + Mesa + " :: " + titulo);
        }

        public void abrirPedidos()
        {
            alterarConteudo(new uctMesaPedidos(), "Pedidos");
        }

        private void abrirConta()
        {
            uctMesaConta uctConta = new uctMesaConta();
            uctConta.Atendimento = Mesa;
            alterarConteudo(uctConta, "Conta");
        }

        private void abrirNovoPedido()
        {
            frmPedido frmNovoPedido = new frmPedido();
            frmNovoPedido.Pedido = new clnPedido();
            frmNovoPedido.PedidosProdutos = new List<clnPedidoProduto>();

            frmNovoPedido.ShowDialog();
        }

        private void frmMesa_Load(object sender, EventArgs e)
        {
            clnApp.AppVisualTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnSair, clnApp.AppVisualStyle.WarningButtonColor);

            abrirPedidos();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            abrirPedidos();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            abrirConta();
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
            abrirNovoPedido();
        }

    }
}
