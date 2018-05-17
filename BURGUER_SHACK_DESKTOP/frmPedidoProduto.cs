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
    public partial class frmPedidoProduto : Form
    {

        private clnPedidoProduto _pedidoProduto;
        private List<clnPedidoReceita> _ingredientes;

        private bool _remover;

        public clnPedidoProduto PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public bool Remover { get => _remover; set => _remover = value; }
        public List<clnPedidoReceita> Ingredientes { get => _ingredientes; set => _ingredientes = value; }

        public frmPedidoProduto()
        {
            InitializeComponent();
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
        }

        internal void abrirVisualizar()
        {
            uctPedidoProdutoVer uctVer = new uctPedidoProdutoVer
            {
                Form = this,
                PedidoProduto = PedidoProduto
            };

            alterarConteudo(uctVer, "Produto :: Visualizar");
        }

        internal void removerIngrediente(clnPedidoReceita pedidoIngrediente)
        {
            if (Ingredientes.Count > 1)
            {
                Ingredientes.Remove(pedidoIngrediente);

                abrirDetalhes();

                clnUtilMensagem.mostrarOk("Produto", "Ingrediente removido do produto.", clnUtilMensagem.MensagemIcone.ERRO);
            }
            else
            {
                clnUtilMensagem.mostrarOk("Produto", "Você não pode remover o único ingrediente do produto.", clnUtilMensagem.MensagemIcone.ERRO);
            }
        }

        internal void adicionaIngrediente(clnPedidoReceita pedidoIngrediente)
        {
            Ingredientes.Add(pedidoIngrediente);

            abrirDetalhes();

            clnUtilMensagem.mostrarOk("Produto", "Ingrediente adicionado com sucesso.", clnUtilMensagem.MensagemIcone.OK);
        }

        internal void substiuiIngrediente(clnPedidoReceita pedidoIngredienteSubstituir, clnPedidoReceita pedidoIngrediente)
        {
            clnUtil.listTrocar(Ingredientes, pedidoIngredienteSubstituir, pedidoIngrediente);

            abrirDetalhes();

            clnUtilMensagem.mostrarOk("Produto", "Ingrediente alterado com sucesso.", clnUtilMensagem.MensagemIcone.OK);
        }

        private void abrirDetalhes()
        {
            uctPedidoProdutoDetalhes uctAlterar = new uctPedidoProdutoDetalhes
            {
                PedidoProduto = PedidoProduto,
                FormProduto = this
            };

            alterarConteudo(uctAlterar, "Produto :: Alterar");

            PedidoProduto = uctAlterar.PedidoProduto;
        }

        private void fechar()
        {
            if (clnUtilMensagem.mostrarSimNao("Produto", "Deseja cancelar as alterações realizadas no produto?", clnUtilMensagem.MensagemIcone.INFO))
            {
                //Novo Pedido - Cancelado
                //Edicao - Sem alteracoes.
                PedidoProduto = null;
                Remover = false;

                Close();
            }
        }

        private void removerProduto()
        {
            if (clnUtilMensagem.mostrarSimNao("Produto", "Deseja realmente remover esse produto do produto?", clnUtilMensagem.MensagemIcone.ERRO))
            {
                PedidoProduto = null;
                Remover = true;

                Close();
            }
        }

        private void frmPedidoProduto_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnRemover, App.AppVisualStyle.ButtonWarningColor);

            abrirVisualizar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            abrirVisualizar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            abrirDetalhes();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            removerProduto();
        }

    }
}
