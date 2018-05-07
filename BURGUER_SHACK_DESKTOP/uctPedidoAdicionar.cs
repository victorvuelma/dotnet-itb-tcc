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
        
        private void selecionaProduto(clnProduto objProduto, int quantidade)
        {
            List<clnPedidoProdutoIngrediente> objIngredientes = new List<clnPedidoProdutoIngrediente>();
            foreach (clnProdutoIngrediente objIngrediente in objProduto.Ingredientes)
            {
                clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente
                {
                    Ingrediente = objIngrediente.Ingrediente,
                    Quantidade = objIngrediente.Quantidade,
                    ProdutoQuantidade = objIngrediente.Quantidade
                };
                objIngredientes.Add(objPedidoIngrediente);
            }

            clnPedidoProduto objPedido = new clnPedidoProduto
            {
                Produto = objProduto.Cod,
                Quantidade = quantidade,
                Adicional = ""
            };
            PedidoProduto = objPedido;

            exibirProduto(objProduto, objPedido);
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

            frmSelecionar frmSelecionar = new frmSelecionar
            {
                Icone = BURGUER_SHACK_DESKTOP.Properties.Resources.produto,
                Selecionando = "Produtos",
                ObjSelecionar = objSelecionar
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                selecionaProduto(objSelecionar.Selecionado, frmSelecionar.Quantidade);
            }
        }

        private void alterarProduto()
        {
            clnProduto objProdutoAtual = new clnProduto
            {
                Cod = PedidoProduto.Produto
            };
            objProdutoAtual = objProdutoAtual.obterPorCodigo();

            clnProduto objProdutos = new clnProduto
            {
                Categoria = objProdutoAtual.Categoria
            };

            clnSelecionarProduto objSelecionar = new clnSelecionarProduto
            {
                Opcoes = objProdutos.obterPorCategoria(),
                Selecionado = objProdutoAtual
            };

            frmSelecionar frmSelecionar = new frmSelecionar
            {
                ObjSelecionar = objSelecionar
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.getSelecionado() != null)
            {
                selecionaProduto(objSelecionar.Selecionado, frmSelecionar.Quantidade);
            }
        }

        private void exibirProduto(clnProduto objProduto, clnPedidoProduto objPedidoProduto)
        {
            grbProduto.Hide();

            picProduto.Image = objProduto.Imagem;
            lblProdutoNome.Text = objProduto.Nome;
            //lblDetalhes.Text = objPedidoProduto.Detalhes;
            txtQuantidade.Text = Convert.ToString(objPedidoProduto.Quantidade);

            grbProduto.Show();
        }

        private void adicionarProduto()
        {
            if (PedidoProduto != null)
            {
                if (_validar.valido())
                {
                    //PedidoProduto.Adicional = txtAdicional.Text;
                    PedidoProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                    Form.addProduto(PedidoProduto, Ingredientes);
                }
            }
            else
            {
                clnMensagem.mostrarOk("Pedido", "Selecione o produto antes de finalizar", clnMensagem.MensagemIcone.ERRO);
            }
        }

        private void abrirIngredientes()
        {
            
        }

        private void esconderDetalhes()
        {
            grbDetalhes.Hide();
            //grbAdicional.Hide();
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
            grbProduto.Hide();

            esconderDetalhes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarProduto();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            abrirIngredientes();
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
