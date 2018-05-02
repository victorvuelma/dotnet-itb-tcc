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

        private frmPedido _frm;
        private clnPedidoProduto _objPedidoProduto;

        public clnPedidoProduto ObjPedidoProduto { get => _objPedidoProduto; set => _objPedidoProduto = value; }
        public frmPedido Frm { get => _frm; set => _frm = value; }

        public uctPedidoAdicionar()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);

            grbProduto.Hide();

            esconderDetalhes();
        }

        private void selecionaCategoria(int categoria)
        {
            clnUtil.resetarCampos(grbProduto.Controls);
            grbProduto.Show();

            ObjPedidoProduto = null;

            esconderDetalhes();

            carregaProdutos(categoria);
        }

        private void carregaProdutos(int categoria)
        {
            pnlProdutos.Visible = false;
            pnlProdutos.Controls.Clear();

            clnProduto objProduto = new clnProduto();
            objProduto.Categoria = categoria;
            objProduto.Nome = txtProdutoPesquisar.Text;

            List<Control> produtoControles = new List<Control>();

            foreach (clnProduto produto in objProduto.getProdutos())
            {
                UIX.btnUIX btn = new UIX.btnUIX();
                btn.Description = produto.Nome;
                btn.Name = "btnProduto" + produto.Cod;
                btn.Size = new Size(100, 100);
                btn.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.hamburger;

                btn.Click += (object sender, EventArgs e) =>
                {
                    selecionaProduto(produto);
                };

                produtoControles.Add(btn);
            }

            clnUtil.adicionarControles(pnlProdutos, produtoControles, 10);

            clnApp.CommonTemplate.pnlApply(pnlProdutos);

            clnUtil.atualizarTabIndex(pnlProdutos.Controls);

            pnlProdutos.Visible = true;
        }

        private void selecionaProduto(clnProduto produto)
        {
            frmPedidoProduto frmEditarProduto = new frmPedidoProduto();

            clnPedidoProduto pedidoProduto = new clnPedidoProduto();
            pedidoProduto.Produto = produto.Cod;
            pedidoProduto.Quantidade = 1;
            pedidoProduto.Ingredientes = new List<int>(produto.Ingredientes);

            frmEditarProduto.ObjPedidoProduto = pedidoProduto;
            frmEditarProduto.btnRemover.Visible = false;
            frmEditarProduto.btnVoltar.Description = "Cancelar";

            frmEditarProduto.ShowDialog();

            //O pedido não foi cancelado
            if (frmEditarProduto.ObjPedidoProduto != null)
            {
                pedidoProduto = frmEditarProduto.ObjPedidoProduto;

                clnUtil.resetarCampos(grbDetalhes.Controls);
                txtQuantidade.Text = "1";
                grbDetalhes.Show();

                clnUtil.resetarCampos(grbAdicional.Controls);
                grbAdicional.Show();

                ObjPedidoProduto = pedidoProduto;
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
            if (ObjPedidoProduto != null)
            {
                //VALIDA QUANTIDADE
                ObjPedidoProduto.Adicional = txtAdicional.Text;
                ObjPedidoProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                Frm.addProduto(ObjPedidoProduto);
            }
            else
            {
                clnMensagem.mostrarOk("Pedido", "Selecione o produto antes de finalizar", clnMensagem.MensagemIcone.ERRO);
            }
        }
    }
}
