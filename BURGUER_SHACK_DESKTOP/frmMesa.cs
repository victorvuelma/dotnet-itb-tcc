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
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, "Mesa " + Mesa + " :: " + titulo);
        }

        public void abrirPedidos()
        {
            uctMesaPedidos uctPedidos = new uctMesaPedidos
            {
            };
            alterarConteudo(uctPedidos, "Pedidos");
        }

        private void abrirConta()
        {
            uctMesaConta uctConta = new uctMesaConta
            {
                Atendimento = Mesa
            };
            alterarConteudo(uctConta, "Conta");
        }

        private void abrirNovoPedido()
        {
            frmPedido frmNovoPedido = new frmPedido
            {
                Pedido = new clnPedido(),
                PedidosProdutos = new List<clnPedidoProduto>()
            };
            frmNovoPedido.ShowDialog();
        }

        private void frmMesa_Load(object sender, EventArgs e)
        {
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnSair, clnApp.AppVisualStyle.ButtonWarningColor);

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

        private void hdrUIX_Close(object sender, EventArgs e)
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
