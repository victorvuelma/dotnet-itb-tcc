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
        private int _codAtendimento;

        private clnPedido _pedido;
        private Dictionary<clnPedidoProduto, List<clnPedidoReceita>> _pedidosProdutos;

        internal int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        internal clnPedido Pedido { get => _pedido; set => _pedido = value; }
        internal Dictionary<clnPedidoProduto, List<clnPedidoReceita>> PedidosProdutos { get => _pedidosProdutos; set => _pedidosProdutos = value; }

        public frmPedido()
        {
            InitializeComponent();
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
        }

        private void abrirProdutos()
        {
            uctPedidoProdutos uctProdutos = new uctPedidoProdutos
            {
                Form = this,
                Atendimento = CodAtendimento,
                PedidoProdutos = PedidosProdutos
            };

            alterarConteudo(uctProdutos, "Pedido :: Produtos");
        }

        public void addProduto(clnPedidoProduto pedidoProduto, List<clnPedidoReceita> pedidoIngredientes)
        {
            PedidosProdutos.Add(pedidoProduto, pedidoIngredientes);

            abrirProdutos();
        }

        private void fechar()
        {
            if (clnUtilMensagem.mostrarSimNao("Pedido", "Deseja cancelar o pedido?", clnUtilMensagem.MensagemIcone.ERRO))
            {
                Close();
            }
        }

        private void finalizar()
        {
            if (clnUtilMensagem.mostrarSimNao("Pedido", "Deseja finalizar o pedido?", clnUtilMensagem.MensagemIcone.OK))
            {
                Close();
            }
        }

        private void abrirAdicionarProduto()
        {
            uctPedidoAdicionar uctAdicionar = new uctPedidoAdicionar
            {
                Form = this
            };

            alterarConteudo(uctAdicionar, "Pedido :: Adicionar Produto");
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnSair, App.AppVisualStyle.ButtonWarningColor);

            abrirProdutos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            abrirProdutos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            abrirAdicionarProduto();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            finalizar();
        }

    }
}
