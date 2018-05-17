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
        private List<clnPedidoReceita> _ingredientes;

        public clnPedidoProduto PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public frmPedido Form { get => _form; set => _form = value; }
        public List<clnPedidoReceita> Ingredientes { get => _ingredientes; set => _ingredientes = value; }

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
            List<clnPedidoReceita> objIngredientes = new List<clnPedidoReceita>();
            foreach (int codProdutoIngrediente in objProduto.CodReceitas)
            {
                clnProdutoReceita objProdutoIngrediente = new clnProdutoReceita
                {
                    Cod = codProdutoIngrediente
                }.obterPorProdutoIngrediente();

                clnPedidoReceita objPedidoIngrediente = new clnPedidoReceita
                {
                    CodIngrediente = objProdutoIngrediente.CodIngrediente,
                    Quantidade = objProdutoIngrediente.Quantidade,
                    CodReceita = objProdutoIngrediente.Cod
                };
                objIngredientes.Add(objPedidoIngrediente);
            }

            clnPedidoProduto objPedido = new clnPedidoProduto
            {
                CodProduto = objProduto.Cod,
                Quantidade = quantidade,
                Adicional = "",
                Ingredientes = objIngredientes
            };
            PedidoProduto = objPedido;

            exibirProduto(objProduto, objPedido);
        }

        private void selecionarProduto(int categoria)
        {
            clnProduto objProdutos = new clnProduto
            {
                CodTipo = categoria
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
                Cod = PedidoProduto.CodProduto
            }.obterPorCodigo();

            clnProduto objProdutos = new clnProduto
            {
                CodTipo = objProdutoAtual.CodTipo
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
            clnVisualizarPedidoIngrediente objVisualizar = new clnVisualizarPedidoIngrediente
            {
                Opcoes = PedidoProduto.Ingredientes
            };

            frmVisualizar frmVisualizar = new frmVisualizar
            {
                ObjVisualizar = objVisualizar
            };

            frmVisualizar.Show();

            //frmPedidoIngrediente frmIngredientes = new frmPedidoIngrediente {
            //    Ingredientes = PedidoProduto.Ingredientes
            //};

            //frmIngredientes.ShowDialog();
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
            clnUtil.abrirNumBoard(txtQuantidade);

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
                detalhes += "Categoria: " + obj.CodTipo;
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

        class clnVisualizarPedidoIngrediente : clnVisualizar<clnPedidoReceita>
        {

            internal override string Detalhes(clnPedidoReceita obj)
            {
                String detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;
                detalhes += "\n";
                detalhes += "Código: " + obj.Cod;

                return detalhes;
            }

            internal override Image Imagem(clnPedidoReceita obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Imagem;
            }

            internal override string Nome(clnPedidoReceita obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Nome;
            }

            internal override int Cod(clnPedidoReceita obj)
            {
                return obj.Cod;
            }

            internal override void Abrir(clnPedidoReceita obj)
            {
                throw new NotImplementedException();
            }
        }

    }
}
