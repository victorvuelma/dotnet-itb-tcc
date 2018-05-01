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

        private int _mesa;

        public int Mesa { get => _mesa; set => _mesa = value; }

        public frmPedido()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        private void abrirProdutos()
        {
            uctPedidoProdutos produtos = new uctPedidoProdutos();
            produtos.Frm = this;
            produtos.Mesa =  Mesa;

            alterarConteudo(produtos, "Pedido :: Produtos");
        }

        private void fechar()
        {
            if (clnMensagem.mostrarSimNao("Pedido", "Deseja cancelar o pedido?", clnMensagem.MSG_ERRO))
            {
                Close();
            }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            clnApp.CommonTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnSair, clnApp.CommonTemplate.Style.WarningButtonColor);

            abrirProdutos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            abrirProdutos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoAdicionar(), "Pedido :: Adicionar Produto");
        }
    }
}
