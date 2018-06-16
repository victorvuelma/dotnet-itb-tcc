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
        private Dictionary<clnItem, List<clnItemIngrediente>> _pedidoProdutos;

        public frmPedido Form { get => _form; set => _form = value; }
        public int Atendimento { get => _atendimento; set => _atendimento = value; }
        internal Dictionary<clnItem, List<clnItemIngrediente>> PedidoProdutos { get => _pedidoProdutos; set => _pedidoProdutos = value; }

        public uctPedidoProdutos()
        {
            InitializeComponent();
        }

        private void editarPedidoProduto(clnItem obtPedidoProduto, List<clnItemIngrediente> objIngredientes)
        {
            frmItem frmEditarProduto = new frmItem
            {
                PedidoProduto = obtPedidoProduto,
                Ingredientes = objIngredientes
            };
            frmEditarProduto.ShowDialog();

            if (frmEditarProduto.PedidoProduto == null)
            {
                PedidoProdutos.Remove(obtPedidoProduto);
                clnUtilMensagem.mostrarOk("Pedido", "Produto removido do pedido", clnUtilMensagem.MensagemIcone.INFO);

                exibirProdutos();
            }
            else if (frmEditarProduto.PedidoProduto != obtPedidoProduto || frmEditarProduto.Ingredientes != objIngredientes)
            {
                clnUtil.dictTrocar(PedidoProdutos, obtPedidoProduto, frmEditarProduto.PedidoProduto, frmEditarProduto.Ingredientes);

                exibirProdutos();
            }
        }

        private void exibirProdutos()
        {
            pnlProdutos.Controls.Clear();

            List<Control> opcoesControles = new List<Control>();
            foreach (KeyValuePair<clnItem, List<clnItemIngrediente>> objPedidoIngredientes in PedidoProdutos)
            {
                clnItem objPedidoProduto = objPedidoIngredientes.Key;
                List<clnItemIngrediente> objIngredientes = objPedidoIngredientes.Value;

                clnProduto objProduto = new clnProduto
                {
                    Cod = objPedidoProduto.CodProduto
                }.obterPorCodigo();

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = objProduto.CodImagem
                }.obterPorCodigo();

                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = objProduto.Nome,
                    Name = "btnProduto" + objProduto.Cod,
                    Size = new Size(110, 110),
                    Image = Image.FromFile(objArquivo.Local)
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    editarPedidoProduto(objPedidoProduto, objIngredientes);
                };

                opcoesControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlProdutos, opcoesControles, 20);

            foreach (Control control in opcoesControles)
            {
                if (control is Button btn)
                {
                    UIX.uixButton.btnApply(btn, App.AppVisualStyle.ButtonImageColor);
                    btn.ForeColor = App.AppVisualStyle.ButtonImageColor.ContentColor;
                }
            }
            opcoesControles.Clear();

            pnlProdutos.BackColor = grbProdutos.BackColor;
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (clnUtilMensagem.mostrarSimNao("Pedido", "Deseja confirmar este pedido?", clnUtilMensagem.MensagemIcone.OK))
            {
                //Confirma o pedido.

                Form.Close();
            }
        }

        private void uctPedidoProdutos_Load(object sender, EventArgs e)
        {
            exibirProdutos();
        }
    }
}
