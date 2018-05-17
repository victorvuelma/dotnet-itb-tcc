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

        private frmPedido _form;

        private int _atendimento;
        private List<clnPedidoProduto> _pedidoProdutos;

        public frmPedido Form { get => _form; set => _form = value; }
        public int Atendimento { get => _atendimento; set => _atendimento = value; }
        internal List<clnPedidoProduto> PedidoProdutos { get => _pedidoProdutos; set => _pedidoProdutos = value; }

        public uctPedidoProdutos()
        {
            InitializeComponent();
        }

        private void editarPedidoProduto(clnPedidoProduto pedidoProduto)
        {
            frmPedidoProduto frmEditarProduto = new frmPedidoProduto
            {
                PedidoProduto = pedidoProduto
            };
            frmEditarProduto.ShowDialog();

            if (frmEditarProduto.Remover)
            {
                PedidoProdutos.Remove(pedidoProduto);
                clnUtilMensagem.mostrarOk("Pedido", "Produto removido do pedido", clnUtilMensagem.MensagemIcone.INFO);

                exibirProdutos();
            }
            else if (frmEditarProduto.PedidoProduto != null)
            {
                clnUtil.listTrocar(PedidoProdutos, pedidoProduto, frmEditarProduto.PedidoProduto);

                exibirProdutos();
            }
        }

        private void exibirProdutos()
        {
            dgvProdutos.Rows.Clear();

            foreach (clnPedidoProduto pedidoProduto in PedidoProdutos)
            {
                clnProduto objProduto = new clnProduto
                {
                    Cod = pedidoProduto.CodProduto
                }.obterPorCodigo();

                dgvProdutos.Rows.Add(objProduto.Nome, pedidoProduto.Quantidade);
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (clnUtilMensagem.mostrarSimNao("Pedido", "Deseja confirmar este pedido?", clnUtilMensagem.MensagemIcone.OK))
            {
                //Confirma o pedido.

                Form.Close();
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editarPedidoProduto(PedidoProdutos[e.RowIndex]);
            }
        }

        private void uctPedidoProdutos_Load(object sender, EventArgs e)
        {
            exibirProdutos();
        }
    }
}
