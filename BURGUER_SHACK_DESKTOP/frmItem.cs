using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmItem : Form
    {
        private clnUtilValidar _validar;

        private clnItem _pedidoProduto;
        private List<clnItemIngrediente> _ingredientes;

        public clnItem PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public List<clnItemIngrediente> Ingredientes { get => _ingredientes; set => _ingredientes = value; }

        public frmItem()
        {
            InitializeComponent();

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.INT, clnUtilValidar.ValidarTipo.INT_MAIOR_0 });
        }

        private void fechar()
        {
            if (clnUtilMensagem.mostrarSimNao("Produto", "Deseja cancelar as alterações realizadas no produto?", clnUtilMensagem.MensagemIcone.INFO))
            {
                Close();
            }
        }

        private void abrirIngredientes()
        {
            clnItemIngrediente.clnListar objListar = new clnItemIngrediente.clnListar
            {
                Opcoes = Ingredientes,
                Icone = Properties.Resources.ingrediente,
                Titulo = "Selecione um Ingrediente"
            };

            clnUtilVisualizar<clnItemIngrediente> objVisualizar = new clnUtilVisualizar<clnItemIngrediente>
            {
                ObjListar = objListar,
                CallbackClick = new callbackVisualizar()
            };

            frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
            {
                ObjVisualizar = objVisualizar
            };
            frmVisualizar.Show();
        }

        private void exibirProduto(clnProduto objProduto, clnItem objPedidoProduto)
        {
            clnArquivo objArquivo = new clnArquivo
            {
                Cod = objProduto.CodImagem
            }.obterPorCodigo();

            picProduto.ImageLocation = objArquivo.Local;
            lblProdutoNome.Text = objProduto.Nome;
            txtQuantidade.Text = Convert.ToString(objPedidoProduto.Quantidade);
            txtAdicional.Text = objPedidoProduto.Adicional;
        }

        private void abrirAdicionarIngrediente()
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

        private void removerProduto()
        {
            if (clnUtilMensagem.mostrarSimNao("Produto", "Deseja realmente remover esse produto do produto?", clnUtilMensagem.MensagemIcone.ERRO))
            {
                PedidoProduto = null;

                Close();
            }
        }

        private void frmPedidoProduto_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            clnUtil.definirNumBoard(txtQuantidade);

            UIX.uixButton.btnApply(btnRemover, App.AppVisualStyle.ButtonWarningColor);

            clnProduto objProduto = new clnProduto
            {
                Cod = PedidoProduto.CodProduto
            }.obterPorCodigo();

            exibirProduto(objProduto, PedidoProduto);

            if (Ingredientes.Count == 0)
            {
                btnIngredienteAdd.Hide();
                btnIngredientes.Hide();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            abrirIngredientes();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            removerProduto();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_validar.valido())
            {
                Close();
            }
        }

        private void btnIngredienteAdd_Click(object sender, EventArgs e)
        {
            abrirAdicionarIngrediente();
        }

        private class callbackVisualizar : clnUtilCallback<clnUtilVisualizar, clnItemIngrediente>
        {
            public void call(clnUtilVisualizar objVisualizar, clnItemIngrediente obj)
            {
                clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                {
                    Cod = obj.CodProdutoIngrediente
                }.obterPorCod();

                if (objProdutoIngrediente.Alterar || objProdutoIngrediente.Remover)
                {
                    frmItemIngrediente frmIngrediente = new frmItemIngrediente
                    {
                        IngredienteAntigo = obj
                    };
                    frmIngrediente.btnAlterar.Visible = objProdutoIngrediente.Alterar;
                    frmIngrediente.btnRemover.Visible = objProdutoIngrediente.Remover;
                    frmIngrediente.ShowDialog();

                    if (frmIngrediente.IngredienteNovo == null)
                    {
                        objVisualizar.ObjListar.getOpcoes().Remove(frmIngrediente.IngredienteAntigo);
                    }
                    else if (frmIngrediente.IngredienteAntigo != frmIngrediente.IngredienteNovo)
                    {
                        clnUtil.listTrocar(objVisualizar.ObjListar.getOpcoes(), frmIngrediente.IngredienteAntigo, frmIngrediente.IngredienteNovo);
                    }
                }
                else
                {
                    clnUtilMensagem.mostrarOk("Ingredientes", "Esse ingrediente não pode ser alterado ou removido.", clnUtilMensagem.MensagemIcone.ERRO);
                }
            }
        }
    }
}
