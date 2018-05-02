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
    public partial class uctPedidoProdutos : UserControl
    {
        private int _mesa;

        private frmPedido _frm;

        private List<clnPedidoProduto> _objPedidoProdutos;

        public frmPedido Frm { get => _frm; set => _frm = value; }
        public int Mesa { get => _mesa; set => _mesa = value; }
        internal List<clnPedidoProduto> ObjPedidoProdutos { get => _objPedidoProdutos; set => _objPedidoProdutos = value; }

        public uctPedidoProdutos()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        private void editarPedidoProduto(clnPedidoProduto pedidoProduto)
        {
            frmPedidoProduto frmEditarProduto = new frmPedidoProduto();

            frmEditarProduto.ObjPedidoProduto = pedidoProduto;

            frmEditarProduto.ShowDialog();

            if (frmEditarProduto.Remover)
            {
                ObjPedidoProdutos.Remove(pedidoProduto);
                clnMensagem.mostrarOk("Pedido", "Produto removido do pedido", clnMensagem.MensagemIcone.INFO);

                exibeProdutos();
            }
            else if(frmEditarProduto.ObjPedidoProduto != null)
            {
                //Atualizar pedido produto na lista.
                clnUtil.trocarValor(ObjPedidoProdutos, pedidoProduto, frmEditarProduto.ObjPedidoProduto);

                exibeProdutos();
            }
        }

        private void exibeProdutos()
        {
            dgvProdutos.Rows.Clear();

            foreach (clnPedidoProduto pedidoProduto in ObjPedidoProdutos)
            {
                dgvProdutos.Rows.Add(pedidoProduto.Produto, pedidoProduto.Quantidade);
            }

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (clnMensagem.mostrarSimNao("Pedido", "Deseja confirmar este pedido?", clnMensagem.MensagemIcone.OK))
            {
                //Confirma o pedido.

                Frm.Close();
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editarPedidoProduto(ObjPedidoProdutos[e.RowIndex]);
        }

        private void uctPedidoProdutos_Load(object sender, EventArgs e)
        {
            exibeProdutos();
        }
    }
}
