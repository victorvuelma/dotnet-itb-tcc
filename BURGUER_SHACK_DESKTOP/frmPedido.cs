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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            clnTemplate.CommonTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnSair, clnTemplate.CommonTemplate.Style.WarningButtonColor);
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoNovo(), "Novo Pedido");
        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoAlterar(), "Alterar Pedido");
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPrincipalCardapio(), "Cardápio");
        }

        private void btnApagarPedido_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoRemover(), "Remover Pedido");
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctMesaPedidos(), "Pedidos");
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
                alterarConteudo(new uctMesaConta(), "Conta");
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void fechar()
        {
            if(clnMensagem.mostrarSimNao("Pedido","Deseja cancelar o pedido?", clnMensagem.MSG_ERRO))
            {
                Close();
            }
        }

        private void uctUIX_Min(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
