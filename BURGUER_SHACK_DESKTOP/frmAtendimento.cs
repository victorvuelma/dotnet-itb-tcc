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
    public partial class frmAtendimento : Form
    {

        private int _codAtendimento;

        public int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }

        public frmAtendimento()
        {
            InitializeComponent();
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, "Atendimento " + CodAtendimento + " :: " + titulo);
        }

        public void abrirPedidos()
        {
            List<clnPedido> objPedidos = new clnPedido
            {
                CodAtendimento = CodAtendimento
            }.obterPorAtendimento();

            uctAtendimentoPedidos uctPedidos = new uctAtendimentoPedidos
            {
                CodAtendimento = CodAtendimento,
                ObjPedidos = objPedidos
            };
            alterarConteudo(uctPedidos, "Pedidos");
        }

        private void abrirConta()
        {
            uctMesaConta uctConta = new uctMesaConta
            {
                Atendimento = CodAtendimento
            };
            alterarConteudo(uctConta, "Conta");
        }

        private void abrirNovoPedido()
        {
            frmPedido frmNovoPedido = new frmPedido
            {
                Pedido = new clnPedido(),
                PedidosProdutos = new Dictionary<clnPedidoProduto, List<clnPedidoProdutoIngrediente>>()
            };
            frmNovoPedido.ShowDialog();
        }

        private void frmMesa_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnSair, App.AppVisualStyle.ButtonWarningColor);

            abrirPedidos();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            abrirPedidos();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            abrirConta();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            abrirNovoPedido();
        }

    }
}
