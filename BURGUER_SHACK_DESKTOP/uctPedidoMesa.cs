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
    public partial class uctPedidoMesa : UserControl
    {
        public uctPedidoMesa()
        {
            InitializeComponent();
        }
        frmPedido frmPedido = new frmPedido();

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoNovo(), "Teste");
        }

        private void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(frmPedido.pnlConteudo, uctConteudo, frmPedido.uctUIX, titulo);
        }

        private void uctPedidoMesa_Load(object sender, EventArgs e)
        {
            pnlLivre.BackColor = System.Drawing.Color.White;
        }
    }
}
