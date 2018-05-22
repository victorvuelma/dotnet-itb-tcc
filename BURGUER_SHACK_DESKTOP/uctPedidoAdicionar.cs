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

        private clnUtilValidar _validar;

        private clnPedidoProduto _pedidoProduto;
        private List<clnPedidoProdutoIngrediente> _ingredientes;

        public clnPedidoProduto PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public frmPedido Form { get => _form; set => _form = value; }
        public List<clnPedidoProdutoIngrediente> Ingredientes { get => _ingredientes; set => _ingredientes = value; }

        public uctPedidoAdicionar()
        {
            InitializeComponent();

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.VAZIO, clnUtilValidar.ValidarTipo.INT });
        }

        private void selecionaCategoria(int categoria)
        {
            PedidoProduto = null;

            grbDetalhes.Hide();

            selecionarProduto(categoria);
        }

        private void selecionaProduto(clnProduto objProduto, int quantidade)
        {
            List<clnPedidoProdutoIngrediente> objIngredientes = new List<clnPedidoProdutoIngrediente>();
            foreach (int codProdutoIngrediente in objProduto.CodReceitas)
            {
                clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                {
                    Cod = codProdutoIngrediente
                }.obterPorProdutoIngrediente();

                clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente
                {
                    CodIngrediente = objProdutoIngrediente.CodIngrediente,
                    Quantidade = objProdutoIngrediente.Quantidade,
                    CodProdutoIngrediente = objProdutoIngrediente.Cod
                };
                objIngredientes.Add(objPedidoIngrediente);
            }

            clnPedidoProduto objPedido = new clnPedidoProduto
            {
                CodProduto = objProduto.Cod,
                Quantidade = quantidade,
                Adicional = ""
            };
            PedidoProduto = objPedido;
            Ingredientes = objIngredientes;

            exibirProduto(objProduto, objPedido);
        }

        private void selecionarProduto(int categoria)
        {
            clnProduto objProdutos = new clnProduto
            {
                CodTipo = categoria
            };

            clnProduto.clnSelecionar objSelecionar = new clnProduto.clnSelecionar
            {
                Opcoes = objProdutos.obterPorCategoria()
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
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

            clnProduto.clnSelecionar objSelecionar = new clnProduto.clnSelecionar
            {
                Opcoes = objProdutos.obterPorCategoria(),
                Selecionado = objProdutoAtual
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
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
            txtQuantidade.Text = Convert.ToString(objPedidoProduto.Quantidade);
            txtAdicional.Text = "";

            grbProduto.Show();

            exibirDetalhes();
        }

        private void exibirDetalhes()
        {
            grbDetalhes.Show();
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
                clnUtilMensagem.mostrarOk("Pedido", "Selecione o produto antes de finalizar", clnUtilMensagem.MensagemIcone.ERRO);
            }
        }

        private void abrirIngredientes()
        {
            clnPedidoProdutoIngrediente.clnVisualizar objVisualizar = new clnPedidoProdutoIngrediente.clnVisualizar
            {
                Opcoes = Ingredientes
            };

            frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
            {
                ObjVisualizar = objVisualizar
            };

            frmVisualizar.Show();

            exibirDetalhes();
        }

        private void adicionarIngrediente()
        {
            clnIngrediente objIngredientes = new clnIngrediente();

            clnIngrediente.clnSelecionar objSelecionar = new clnIngrediente.clnSelecionar
            {
                Opcoes = objIngredientes.obterIngredientes()
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
            {
                ObjSelecionar = objSelecionar,
                Selecionando = "Adicionar um Ingrediente"
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.getSelecionado() != null)
            {
                clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente
                {
                    Quantidade = frmSelecionar.Quantidade,
                    CodIngrediente = objSelecionar.Selecionado.Cod
                };

                clnUtilMensagem.mostrarOk("Ingrediente", "Ingrediente adicionado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                Ingredientes.Add(objPedidoIngrediente);
            }
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
            grbDetalhes.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarProduto();
        }

        private void btnIngredienteAdd_Click(object sender, EventArgs e)
        {
            adicionarIngrediente();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            abrirIngredientes();
        }

    }
}
