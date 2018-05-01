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

        public frmMesa()
        {
            InitializeComponent();
        }

                public int Mesa { get => _mesa; set => _mesa = value; }

        public void abrirNovoPedido()
        {
            alterarConteudo(new uctPedidoNovo(), "Mesa " + Mesa + " :: Novo Pedido");
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        private void frmMesa_Load(object sender, EventArgs e)
        {
            clnTemplate.CommonTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnSair, clnTemplate.CommonTemplate.Style.WarningButtonColor);

            abrirNovoPedido();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            abrirNovoPedido();
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

    }
}
