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

        private clnPedidoProduto _objPedidoProduto;
        private bool _remover;

        private int _mesa;

        public int Mesa { get => _mesa; set => _mesa = value; }
        public clnPedidoProduto ObjPedidoProduto { get => _objPedidoProduto; set => _objPedidoProduto = value; }
        public bool Remover { get => _remover; set => _remover = value; }

        public frmPedidoProduto()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        public void abrirVisualizar()
        {
            uctPedidoProdutoVer uctVer = new uctPedidoProdutoVer();

            uctVer.Frm = this;
            uctVer.ObjPedidoProduto = ObjPedidoProduto;

            alterarConteudo(uctVer, "Produto :: Visualizar");
        }

        private void fechar()
        {
            if (clnMensagem.mostrarSimNao("Produto", "Deseja cancelar as alterações realizadas no produto?", clnMensagem.MensagemIcone.INFO))
            {
                //Novo Pedido - Cancelado
                //Edicao - Sem alteracoes.
                ObjPedidoProduto = null;
                Remover = false;

                Close();
            }
        }

        private void frmPedidoProduto_Load(object sender, EventArgs e)
        {
            clnApp.CommonTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnRemover, clnApp.CommonTemplate.Style.WarningButtonColor);

            abrirVisualizar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            abrirVisualizar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            uctPedidoProdutoDetalhes alterar = new uctPedidoProdutoDetalhes();

            alterar.ObjPedidoProduto = ObjPedidoProduto;
            alterar.Frm = this;

            alterarConteudo(alterar, "Produto :: Alterar");

            ObjPedidoProduto = alterar.ObjPedidoProduto;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (clnMensagem.mostrarSimNao("Produto", "Deseja realmente remover esse produto do produto?", clnMensagem.MensagemIcone.ERRO))
            {
                ObjPedidoProduto = null;
                Remover = true;

                //faz e tal
                Close();
            }
        }
    }
}
