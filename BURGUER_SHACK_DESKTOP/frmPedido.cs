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
            uctUIX.UIXTitle = clnTemplate.AppName + " - Garçom";
            clnTemplate.CommonTemplate.frmApply(this, uctUIX);
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoNovo(), "Novo Pedido");
        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoAlterar(), "Alterar Pedido");
        }

        private void btnPedidoRemover_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoAlterar(), "Alterar Pedido");
        }

        private void btnApagarPedido_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoRemover(), "Remover Pedido");
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoListar(), "Pedidos");
        }

        private void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uctUIX_Min(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
