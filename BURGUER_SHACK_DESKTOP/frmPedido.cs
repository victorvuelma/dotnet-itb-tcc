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
        private int _atendimento;

        private clnPedido _pedido;
        private List<clnPedidoProduto> _pedidosProdutos;

        internal int Atendimento { get => _atendimento; set => _atendimento = value; }
        internal clnPedido Pedido { get => _pedido; set => _pedido = value; }
        internal List<clnPedidoProduto> PedidosProdutos { get => _pedidosProdutos; set => _pedidosProdutos = value; }

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
                Atendimento = Atendimento,
                PedidoProdutos = PedidosProdutos
            };

            alterarConteudo(uctProdutos, "Pedido :: Produtos");
        }

        public void addProduto(clnPedidoProduto pedidoProduto, List<clnPedidoProdutoIngrediente> pedidoIngredientes)
        {
            PedidosProdutos.Add(pedidoProduto);

            abrirProdutos();
        }

        private void fechar()
        {
            if (clnMensagem.mostrarSimNao("Pedido", "Deseja cancelar o pedido?", clnMensagem.MensagemIcone.ERRO))
            {
                Close();
            }
        }

        private void finalizar()
        {
            if (clnMensagem.mostrarSimNao("Pedido", "Deseja finalizar o pedido?", clnMensagem.MensagemIcone.OK))
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
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnSair, clnApp.AppVisualStyle.ButtonWarningColor);

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
