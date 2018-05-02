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

        private clnPedido _objPedido;
        private List<clnPedidoProduto> _objPedidosProdutos;

        private int _mesa;

        public int Mesa { get => _mesa; set => _mesa = value; }
        internal clnPedido ObjPedido { get => _objPedido; set => _objPedido = value; }
        internal List<clnPedidoProduto> ObjPedidosProdutos { get => _objPedidosProdutos; set => _objPedidosProdutos = value; }

        public frmPedido()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        public void abrirProdutos()
        {
            uctPedidoProdutos uctProdutos = new uctPedidoProdutos();

            uctProdutos.Frm = this;
            uctProdutos.Mesa = Mesa;
            uctProdutos.ObjPedidoProdutos = ObjPedidosProdutos;

            alterarConteudo(uctProdutos, "Pedido :: Produtos");
        }

        public void addProduto(clnPedidoProduto pedidoProduto)
        {
            _objPedidosProdutos.Add(pedidoProduto);

            abrirProdutos();
        }

        private void fechar()
        {
            if (clnMensagem.mostrarSimNao("Pedido", "Deseja cancelar o pedido?", clnMensagem.MensagemIcone.ERRO))
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
            uctPedidoAdicionar uctAdicionar = new uctPedidoAdicionar();

            uctAdicionar.Frm = this;

            alterarConteudo(uctAdicionar, "Pedido :: Adicionar Produto");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (clnMensagem.mostrarSimNao("Pedido", "Deseja finalizar o pedido?", clnMensagem.MensagemIcone.OK))
            {
                Close();
            }
        }

    }
}
