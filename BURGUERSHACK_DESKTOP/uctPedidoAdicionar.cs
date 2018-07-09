using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BURGUERSHACK_COMMON.UTIL;
using BURGUERSHACK_DESKTOP.UTIL;

namespace BURGUERSHACK_DESKTOP
{
    public partial class uctPedidoAdicionar : UserControl
    {

        private frmPedido _form;

        private clnUtilFormValidar _validar;

        private clnItem _objItem;
        private List<clnItemIngrediente> _objItemIngredientes;

        public clnItem ObjItem { get => _objItem; set => _objItem = value; }
        public frmPedido Form { get => _form; set => _form = value; }
        public List<clnItemIngrediente> ObjItemIngredientes { get => _objItemIngredientes; set => _objItemIngredientes = value; }

        public uctPedidoAdicionar()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.INT, clnUtilFormValidar.Validacao.QUANTIDADE });
        }

        private void selecionaCategoria(int categoria)
        {
            ObjItem = null;

            grbDetalhes.Hide();
            btnConfirmar.Hide();

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
            ObjItem = objPedido;
            ObjItemIngredientes = objIngredientes;

            if (ObjItemIngredientes.Count == 0)
            {
                grbIngredientes.Hide();
            }

            exibirProduto(objProduto, objPedido);

            btnConfirmar.Show();
        }

        private void atualizarValor()
        {
            decimal valor = clnUtilPedido.calcularValor(ObjItem, ObjItemIngredientes);

            lblValor.Text = "Valor: " + clnUtilFormatar.formatarValor(valor);
        }

        private void selecionarProduto(int categoria)
        {
            clnProduto objProdutos = new clnProduto
            {
                CodTipo = categoria,
                Situacao = clnProduto.produtoSituacao.DISPONIVEL
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
                Cod = ObjItem.CodProduto
            }.obterPorCod();

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

            atualizarValor();
        }

        private void confirmarItem()
        {
            if (ObjItem != null)
            {
                if (_validar.validar(this))
                {
                    ObjItem.Adicional = txtAdicional.Text;
                    ObjItem.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                    Form.adicionarItem(ObjItem, ObjItemIngredientes);
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
                Opcoes = ObjItemIngredientes,
                Icone = Properties.Resources.ingrediente,
                Titulo = "Selecione o Ingrediente"
            };
            clnUtilVisualizar<uctPedidoAdicionar, clnItemIngrediente> objVisualizar = new clnUtilVisualizar<uctPedidoAdicionar, clnItemIngrediente>
            {
                ObjListar = objListar,
                Callback = new CallbackAlterar(),
                Obj = this
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
                clnItemIngrediente objItemIngrediente = new clnItemIngrediente
                {
                    Quantidade = objSelecionar.Quantidade,
                    CodIngrediente = objSelecionar.Selecionado.Cod,
                    CodProdutoIngrediente = null
                };

                clnUtilMensagem.mostrarOk("Ingrediente", "Ingrediente adicionado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                clnUtilPedido.adicionarIngrediente(ObjItemIngredientes, objItemIngrediente);

                exibirDetalhes();
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmarItem();
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

        private class CallbackAlterar : clnUtilVisualizar.IVisualizarCallback<uctPedidoAdicionar, clnItemIngrediente>
        {
            public clnUtilVisualizar.visualizarAction call(uctPedidoAdicionar uctAdicionar, clnItemIngrediente objItemIngrediente)
            {
                clnProdutoIngrediente objProdutoIngrediente = null;
                if (objItemIngrediente.CodProdutoIngrediente != null)
                {
                    objProdutoIngrediente = new clnProdutoIngrediente
                    {
                        Cod = (int)objItemIngrediente.CodProdutoIngrediente
                    }.obterPorCod();
                }

                if (objProdutoIngrediente == null || objProdutoIngrediente.Alterar || objProdutoIngrediente.Remover)
                {
                    frmItemIngrediente frmIngrediente = new frmItemIngrediente
                    {
                        ObjItemIngrediente = objItemIngrediente
                    };
                    frmIngrediente.btnAlterar.Visible = objProdutoIngrediente == null || objProdutoIngrediente.Alterar;
                    frmIngrediente.btnRemover.Visible = objProdutoIngrediente == null || objProdutoIngrediente.Remover;
                    frmIngrediente.ShowDialog();

                    if (frmIngrediente.ObjItemIngrediente == null)
                    {
                        uctAdicionar.ObjItemIngredientes.Remove(objItemIngrediente);
                    }
                    else if (objItemIngrediente != frmIngrediente.ObjItemIngrediente)
                    {
                        clnUtil.listTrocar(uctAdicionar.ObjItemIngredientes, objItemIngrediente, frmIngrediente.ObjItemIngrediente);
                    }
                }
                else
                {
                    clnUtilMensagem.mostrarOk("Ingredientes", "Esse ingrediente não pode ser alterado ou removido.", clnUtilMensagem.MensagemIcone.ERRO);
                }
                return clnUtilVisualizar.visualizarAction.NADA;
            }
        }

    }
}
