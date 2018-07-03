using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUERSHACK_DESKTOP
{
    public partial class frmPedido : Form
    {
        private int _codAtendimento;
        private int _codFuncionario;

        private clnPedido _objPedido;
        private Dictionary<clnItem, List<clnItemIngrediente>> _objItens;

        internal int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        internal clnPedido ObjPedido { get => _objPedido; set => _objPedido = value; }
        internal Dictionary<clnItem, List<clnItemIngrediente>> ObjItens { get => _objItens; set => _objItens = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }

        public frmPedido()
        {
            InitializeComponent();
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
        }

        private void abrirItens()
        {
            uctPedidoItens uctProdutos = new uctPedidoItens
            {
                Form = this,
                CodAtendimento = CodAtendimento,
                CodFuncionario = CodFuncionario,
                ObjItens = ObjItens,
                ObjPedido = ObjPedido
            };
            alterarConteudo(uctProdutos, "Pedido :: Produtos");
        }

        public void adicionarItem(clnItem objItem, List<clnItemIngrediente> objItemIngredientes)
        {
            if (ObjPedido.Cod == -1)
            {
                ObjItens.Add(objItem, objItemIngredientes);
            }
            else
            {
                clnUtilPedido.inserirItem(ObjPedido.Cod, objItem, objItemIngredientes);
            }

            abrirItens();
        }

        private void fechar()
        {
            if (ObjPedido.Cod == -1)
            {
                if (clnUtilMensagem.mostrarSimNao("Pedido", "Deseja cancelar o pedido?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void finalizar()
        {
            abrirItens();

            if (ObjPedido.Cod == -1)
            {
                if (ObjItens.Count == 0)
                {
                    if(clnUtilMensagem.mostrarSimNao("Pedido", "Não foi encontrado nenhum item no pedido, deseja adicionar?", clnUtilMensagem.MensagemIcone.OK))
                    {
                        abrirAdicionar();
                    } else
                    {
                        Close();
                    }                   
                }
                else if (clnUtilMensagem.mostrarSimNao("Pedido", "Deseja finalizar o pedido?", clnUtilMensagem.MensagemIcone.OK))
                {
                    decimal valor = clnUtilPedido.calcularValor(ObjItens);

                    ObjPedido = new clnPedido
                    {
                        CodAtendimento = CodAtendimento,
                        CodFuncionario = CodFuncionario,
                        Valor = valor,
                        Situacao = clnPedido.pedidoSituacao.REALIZADO
                    };
                    ObjPedido.gravar();

                    foreach (KeyValuePair<clnItem, List<clnItemIngrediente>> objPair in ObjItens)
                    {
                        clnUtilPedido.inserirItem(ObjPedido.Cod, objPair.Key, objPair.Value);
                    }

                    Close();
                }
            }
            else
            {
                if (clnUtilMensagem.mostrarSimNao("Pedido", "Deseja cancelar o pedido?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
        }

        private void abrirAdicionar()
        {
            uctPedidoAdicionar uctAdicionar = new uctPedidoAdicionar
            {
                Form = this,
            };

            alterarConteudo(uctAdicionar, "Pedido :: Adicionar Produto");
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            UIX.uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            if (ObjPedido.Cod == -1)
            {
                ObjItens = new Dictionary<clnItem, List<clnItemIngrediente>>();
            }
            else
            {
                UIX.uixButton.btnApply(btnConfirmar, AppDesktop.VisualStyle.ButtonWarningColor);

                btnConfirmar.Description = "Excluir";
                btnConfirmar.Image = Properties.Resources.excluir;
                btnConfirmar.Hide();
                btnAdicionar.Hide();
            }

            abrirItens();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            abrirAdicionar();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            finalizar();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            abrirItens();
        }
    }
}
