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

        private clnItem _pedidoProduto;
        private List<clnItemIngrediente> _ingredientes;

        public clnItem PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public frmPedido Form { get => _form; set => _form = value; }
        public List<clnItemIngrediente> Ingredientes { get => _ingredientes; set => _ingredientes = value; }

        public uctPedidoAdicionar()
        {
            InitializeComponent();

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.INT, clnUtilValidar.ValidarTipo.INT_MAIOR_0 });
        }

        private void selecionaCategoria(int categoria)
        {
            PedidoProduto = null;

            grbDetalhes.Hide();

            selecionarProduto(categoria);
        }

        private void selecionaProduto(clnProduto objProduto, int quantidade)
        {
            List<clnItemIngrediente> objIngredientes = new List<clnItemIngrediente>();
            foreach (int codProdutoIngrediente in objProduto.CodIngredientes)
            {
                clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                {
                    Cod = codProdutoIngrediente
                }.obterPorProdutoIngrediente();

                clnItemIngrediente objPedidoIngrediente = new clnItemIngrediente
                {
                    CodIngrediente = objProdutoIngrediente.CodIngrediente,
                    Quantidade = objProdutoIngrediente.Quantidade,
                    CodProdutoIngrediente = objProdutoIngrediente.Cod
                };
                objIngredientes.Add(objPedidoIngrediente);
            }

            clnItem objPedido = new clnItem
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
                Opcoes = objProdutos.obterPorTipo()
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
                Opcoes = objProdutos.obterPorTipo(),
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

        private void exibirProduto(clnProduto objProduto, clnItem objPedidoProduto)
        {
            grbProduto.Hide();

            clnArquivo objArquivo = new clnArquivo
            {
                Cod = objProduto.CodImagem
            }.obterPorCodigo();

            picProduto.ImageLocation = objArquivo.Arquivo;
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
            clnItemIngrediente.clnVisualizar objVisualizar = new clnItemIngrediente.clnVisualizar
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
                clnItemIngrediente objPedidoIngrediente = new clnItemIngrediente
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
            clnUtil.definirNumBoard(txtQuantidade);

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
