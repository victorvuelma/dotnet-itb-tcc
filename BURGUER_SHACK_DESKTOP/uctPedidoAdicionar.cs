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
    public partial class uctPedidoAdicionar : UserControl
    {

        private frmPedido _form;

        private clnPedidoProduto _pedidoProduto;
        private List<clnPedidoProdutoIngrediente> _ingredientes;

        public clnPedidoProduto PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public frmPedido Form { get => _form; set => _form = value; }
        public List<clnPedidoProdutoIngrediente> Ingredientes { get => _ingredientes; set => _ingredientes = value; }

        public uctPedidoAdicionar()
        {
            InitializeComponent();

            grbProduto.Hide();

            esconderDetalhes();
        }

        private void selecionaCategoria(int categoria)
        {
            clnUtil.resetarCampos(grbProduto.Controls);
            grbProduto.Show();

            PedidoProduto = null;

            esconderDetalhes();

            carregaProdutos(categoria);
        }

        private void carregaProdutos(int categoria)
        {
            pnlProdutos.Visible = false;
            pnlProdutos.Controls.Clear();

            clnProduto objProdutos = new clnProduto();
            objProdutos.Categoria = categoria;
            objProdutos.Nome = txtProdutoPesquisar.Text;

            List<Control> produtoControles = new List<Control>();
            foreach (clnProduto objProduto in objProdutos.obterPorNomeCategoria())
            {
                UIX.btnUIX btn = new UIX.btnUIX();
                btn.Description = objProduto.Nome;
                btn.Name = "btnProduto" + objProduto.Cod;
                btn.Size = new Size(100, 100);
                btn.Image = objProduto.Imagem;
                btn.Click += (object sender, EventArgs e) =>
                {
                    selecionaProduto(objProduto);
                };

                produtoControles.Add(btn);
            }

            clnUtil.adicionarControles(pnlProdutos, produtoControles, 10);

            clnApp.AppVisualTemplate.pnlApply(pnlProdutos);

            pnlProdutos.Visible = true;
        }

        private void selecionaProduto(clnProduto objProduto)
        {
            frmPedidoProduto frmEditarProduto = new frmPedidoProduto();

            clnPedidoProduto objPedidoProduto = new clnPedidoProduto();
            objPedidoProduto.Produto = objProduto.Cod;
            objPedidoProduto.Quantidade = 1;

            List<clnPedidoProdutoIngrediente> objPedidoIngredientes = new List<clnPedidoProdutoIngrediente>();
            foreach (clnProdutoIngrediente objProdutoIngrediente in objProduto.Ingredientes)
            {
                clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente();
                objPedidoIngrediente.Ingrediente = objProdutoIngrediente.Ingrediente;
                objPedidoIngrediente.Quantidade = objProdutoIngrediente.Quantidade;

                objPedidoIngredientes.Add(objPedidoIngrediente);
            }
            objPedidoProduto.Ingredientes = objPedidoIngredientes;

            frmEditarProduto.PedidoProduto = objPedidoProduto;
            frmEditarProduto.btnRemover.Visible = false;
            frmEditarProduto.btnVoltar.Description = "Cancelar";

            frmEditarProduto.ShowDialog();

            //O pedido não foi cancelado
            if (frmEditarProduto.PedidoProduto != null)
            {
                objPedidoProduto = frmEditarProduto.PedidoProduto;

                clnUtil.resetarCampos(grbDetalhes.Controls);
                txtQuantidade.Text = Convert.ToString(objPedidoProduto.Quantidade);
                grbDetalhes.Show();

                clnUtil.resetarCampos(grbAdicional.Controls);
                grbAdicional.Show();

                PedidoProduto = objPedidoProduto;
            }
        }

        private void adicionarProduto()
        {
            if (PedidoProduto != null)
            {
                //VALIDA QUANTIDADE
                PedidoProduto.Adicional = txtAdicional.Text;
                PedidoProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                Form.addProduto(PedidoProduto, Ingredientes);
            }
            else
            {
                clnMensagem.mostrarOk("Pedido", "Selecione o produto antes de finalizar", clnMensagem.MensagemIcone.ERRO);
            }
        }

        private void esconderDetalhes()
        {
            grbDetalhes.Hide();
            grbAdicional.Hide();
        }

        private void btnLanche_Click(object sender, EventArgs e)
        {
            selecionaCategoria(1);
        }

        private void btnAcompanhamento_Click(object sender, EventArgs e)
        {
            selecionaCategoria(2);
        }

        private void btnBebida_Click(object sender, EventArgs e)
        {
            selecionaCategoria(3);
        }

        private void btnSobremesa_Click(object sender, EventArgs e)
        {
            selecionaCategoria(4);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionarProduto();
        }

    }
}
