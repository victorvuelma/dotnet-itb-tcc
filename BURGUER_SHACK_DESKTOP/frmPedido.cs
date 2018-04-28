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
            uctUIX.UIXTitle = tplBurguerShack.AppName + " - Garçom";
            tplBurguerShack.CommonTemplate.frmApply(this, uctUIX);
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
            uctUIX.UIXTitle = tplBurguerShack.AppName + " - Alterar Pedido";
        }

        private void btnApagarPedido_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoRemover(), "Remover Pedido");
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoListar(), "Pedidos");
        }

        private void alterarConteudo(UserControl conteudo, String titulo)
        {
            if(pnlConteudo.Controls.Count == 1)
            {
                pnlConteudo.Controls.Remove(pnlConteudo.Controls[0]);
            }
            tplBurguerShack.CommonTemplate.uctApply(conteudo);

            pnlConteudo.Controls.Add(conteudo);
            conteudo.Location = new Point(0, 0);
            conteudo.Size = pnlConteudo.Size;

            uctUIX.UIXTitle = tplBurguerShack.AppName + " - " + titulo;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
