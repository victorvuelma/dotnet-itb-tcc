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

            clnProdutoIngrediente objProdutoIngredientes = new clnProdutoIngrediente
            {
                CodProduto = objProduto.Cod
            };

            foreach (clnProdutoIngrediente objProdutoIngrediente in objProdutoIngredientes.obterPorProduto())
            {
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

            clnProduto.clnListar objListar = new clnProduto.clnListar
            {
                Opcoes = objProdutos.obterPorTipoSituacao(),
                Icone = Properties.Resources.produto,
                Titulo = "Selecione o Produto",
            };
            clnUtilSelecionar<clnProduto> objSelecionar = new clnUtilSelecionar<clnProduto>
            {
                ObjListar = objListar
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
            {
                ObjSelecionar = objSelecionar
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                selecionaProduto(objSelecionar.Selecionado, objSelecionar.Quantidade);
            }
        }

        private void alterarProduto()
        {
            clnProduto objProdutoAtual = new clnProduto
            {
                Cod = PedidoProduto.CodProduto
            }.obterPorCodigo();

            List<clnProduto> objProdutos = new clnProduto
            {
                CodTipo = objProdutoAtual.CodTipo,
                Situacao = clnProduto.produtoSituacao.DISPONIVEL
            }.obterPorTipoSituacao();
            objProdutos.RemoveAll(obj => obj.Cod.Equals(objProdutoAtual.Cod));

            if (objProdutos.Count > 0)
            {
                clnProduto.clnListar objListar = new clnProduto.clnListar
                {
                    Opcoes = objProdutos,
                    Titulo = "Selecione o Produto",
                    Icone = Properties.Resources.produto
                };
                clnUtilSelecionar<clnProduto> objSelecionar = new clnUtilSelecionar<clnProduto>
                {
                    ObjListar = objListar,
                    Selecionado = objProdutoAtual
                };

                frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
                {
                    ObjSelecionar = objSelecionar
                };
                frmSelecionar.ShowDialog();

                if (objSelecionar.Selecionado != null)
                {
                    selecionaProduto(objSelecionar.Selecionado, objSelecionar.Quantidade);
                }
            }
            else
            {
                clnUtilMensagem.mostrarOk("Produto", "Não há outros produtos disponiveis.", clnUtilMensagem.MensagemIcone.ERRO);
            }
        }

        private void exibirProduto(clnProduto objProduto, clnItem objPedidoProduto)
        {
            grbProduto.Hide();

            clnArquivo objArquivo = new clnArquivo
            {
                Cod = objProduto.CodImagem
            }.obterPorCodigo();

            picProduto.ImageLocation = objArquivo.Local;
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
            clnItemIngrediente.clnListar objListar = new clnItemIngrediente.clnListar
            {
                Opcoes = Ingredientes,
                Icone = Properties.Resources.ingrediente,
                Titulo = "Selecione o Ingrediente"
            };
            clnUtilVisualizar<clnPedido, clnItemIngrediente> objVisualizar = new clnUtilVisualizar<clnPedido, clnItemIngrediente>
            {
                ObjListar = objListar
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

            clnIngrediente.clnListar objListar = new clnIngrediente.clnListar
            {
                Opcoes = objIngredientes.obterIngredientes(),
                Titulo = "Adicionar um Ingrediente",
                Icone = Properties.Resources.ingrediente
            };
            clnUtilSelecionar<clnIngrediente> objSelecionar = new clnUtilSelecionar<clnIngrediente>
            {
                ObjListar = objListar
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
            {
                ObjSelecionar = objSelecionar
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                clnItemIngrediente objPedidoIngrediente = new clnItemIngrediente
                {
                    Quantidade = objSelecionar.Quantidade,
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
