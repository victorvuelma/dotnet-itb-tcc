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

        private clnValidar _validar;

        private clnPedidoProduto _pedidoProduto;
        private List<clnPedidoProdutoIngrediente> _ingredientes;

        public clnPedidoProduto PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public frmPedido Form { get => _form; set => _form = value; }
        public List<clnPedidoProdutoIngrediente> Ingredientes { get => _ingredientes; set => _ingredientes = value; }

        public uctPedidoAdicionar()
        {
            InitializeComponent();

            _validar = new clnValidar();
            _validar.addValidacao(txtQuantidade, new clnValidar.ValidarTipo[] { clnValidar.ValidarTipo.VAZIO, clnValidar.ValidarTipo.INT });
        }

        private void selecionaCategoria(int categoria)
        {
            PedidoProduto = null;

            esconderDetalhes();

            selecionarProduto(categoria);
        }

        private void selecionarProduto(int categoria)
        {
            clnProduto objProdutos = new clnProduto
            {
                Categoria = categoria
            };

            clnSelecionarProduto objSelecionar = new clnSelecionarProduto
            {
                Opcoes = objProdutos.obterPorCategoria()
            };

            frmSelecionar frmSelecionarProduto = new frmSelecionar
            {
                Icone = BURGUER_SHACK_DESKTOP.Properties.Resources.produto,
                Selecionando = "Selecione o produto",
                ObjSelecionar = objSelecionar
            };

            frmSelecionarProduto.ShowDialog();            
        }

        private void carregaProdutos(int categoria)
        {
            clnProduto objProdutos = new clnProduto
            {
                Categoria = categoria
            };

            List<Control> produtoControles = new List<Control>();
            foreach (clnProduto objProduto in objProdutos.obterPorCategoria())
            {
                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = objProduto.Nome,
                    Name = "btnProduto" + objProduto.Cod,
                    Size = new Size(100, 100),
                    Image = objProduto.Imagem
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    selecionaProduto(objProduto);
                };

                produtoControles.Add(btn);
            }

        }

        private void selecionaProduto(clnProduto objProduto)
        {
            List<clnPedidoProdutoIngrediente> objPedidoIngredientes = new List<clnPedidoProdutoIngrediente>();
            foreach (clnProdutoIngrediente objProdutoIngrediente in objProduto.Ingredientes)
            {
                clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente
                {
                    Ingrediente = objProdutoIngrediente.Ingrediente,
                    Quantidade = objProdutoIngrediente.Quantidade,
                    Substituindo = true
                };

                objPedidoIngredientes.Add(objPedidoIngrediente);
            }

            clnPedidoProduto objPedidoProduto = new clnPedidoProduto
            {
                Produto = objProduto.Cod,
                Quantidade = 1,
                Ingredientes = objPedidoIngredientes
            };

            frmPedidoProduto frmEditarProduto = new frmPedidoProduto
            {
                PedidoProduto = objPedidoProduto
            };
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
                if (_validar.valido())
                {
                    PedidoProduto.Adicional = txtAdicional.Text;
                    PedidoProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                    Form.addProduto(PedidoProduto, Ingredientes);
                }
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

        private void uctPedidoAdicionar_Load(object sender, EventArgs e)
        {
            esconderDetalhes();
        }

        class clnSelecionarProduto : clnSelecionar<clnProduto>
        {

            internal override string Detalhes(clnProduto obj)
            {
                String detalhes = "";
                detalhes += "Categoria: " + obj.Categoria;
                detalhes += "\n";
                detalhes += "Código: " + obj.Cod;

                return detalhes;
            }

            internal override Image Imagem(clnProduto obj)
            {
                return obj.Imagem;
            }

            internal override string Nome(clnProduto obj)
            {
                return obj.Nome;
            }

            internal override int Cod(clnProduto obj)
            {
                return obj.Cod;
            }

        }

    }
}
