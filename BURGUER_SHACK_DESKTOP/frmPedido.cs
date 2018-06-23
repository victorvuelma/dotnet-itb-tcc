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
        private int _codFuncionario;

        private clnPedido _objPedido;
        private Dictionary<clnItem, List<clnItemIngrediente>> _objItens;

        internal int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        internal clnPedido ObjPedido { get => _objPedido; set => _objPedido = value; }
        internal Dictionary<clnItem, List<clnItemIngrediente>> ObjItens { get => _objItens; set => _objItens = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }

        public frmPedido()
        {
            InitializeComponent();
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
        }

        private void abrirItens()
        {
            uctPedidoItens uctProdutos = new uctPedidoItens
            {
                Form = this,
                CodAtendimento = CodAtendimento,
                CodFuncionario = CodFuncionario,
                ObjItens = ObjItens,
                ObjPedido = ObjPedido
            };
            alterarConteudo(uctProdutos, "Pedido :: Produtos");
        }

        public void adicionarItem(clnItem objItem, List<clnItemIngrediente> objItemIngredientes)
        {
            if (ObjPedido.Cod == -1)
            {
                ObjItens.Add(objItem, objItemIngredientes);
            } else
            {
                clnUtilPedido.inserirItem(ObjPedido.Cod, objItem, objItemIngredientes);
            }

            abrirItens();
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
                Form = this,
            };

            alterarConteudo(uctAdicionar, "Pedido :: Adicionar Produto");
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            App.VisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnSair, App.VisualStyle.ButtonWarningColor);

            if (ObjPedido == null)
                ObjItens = new Dictionary<clnItem, List<clnItemIngrediente>>();

            abrirItens();
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
            abrirItens();
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
