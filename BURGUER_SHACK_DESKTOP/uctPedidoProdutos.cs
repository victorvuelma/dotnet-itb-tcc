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
    public partial class uctPedidoProdutos : UserControl
    {

        private frmPedido _form;

        private int _codAtendimento;
        private int _codFuncionario;

        private Dictionary<clnItem, List<clnItemIngrediente>> _objItens;

        public frmPedido Form { get => _form; set => _form = value; }
        internal Dictionary<clnItem, List<clnItemIngrediente>> ObjItens { get => _objItens; set => _objItens = value; }
        public int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }

        public uctPedidoProdutos()
        {
            InitializeComponent();
        }

        private void editarPedidoProduto(clnItem obtPedidoProduto, List<clnItemIngrediente> objIngredientes)
        {
            frmItem frmEditarProduto = new frmItem
            {
                PedidoProduto = obtPedidoProduto,
                Ingredientes = objIngredientes
            };
            frmEditarProduto.ShowDialog();

            if (frmEditarProduto.PedidoProduto == null)
            {
                ObjItens.Remove(obtPedidoProduto);
                clnUtilMensagem.mostrarOk("Pedido", "Produto removido do pedido", clnUtilMensagem.MensagemIcone.INFO);

                exibirProdutos();
            }
            else if (frmEditarProduto.PedidoProduto != obtPedidoProduto || frmEditarProduto.Ingredientes != objIngredientes)
            {
                clnUtil.dictTrocar(ObjItens, obtPedidoProduto, frmEditarProduto.PedidoProduto, frmEditarProduto.Ingredientes);

                exibirProdutos();
            }
        }

        private void exibirProdutos()
        {
            pnlProdutos.Controls.Clear();

            List<Control> opcoesControles = new List<Control>();
            foreach (KeyValuePair<clnItem, List<clnItemIngrediente>> objPedidoIngredientes in ObjItens)
            {
                clnItem objPedidoProduto = objPedidoIngredientes.Key;
                List<clnItemIngrediente> objIngredientes = objPedidoIngredientes.Value;

                clnProduto objProduto = new clnProduto
                {
                    Cod = objPedidoProduto.CodProduto
                }.obterPorCodigo();

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = objProduto.CodImagem
                }.obterPorCodigo();

                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = objProduto.Nome,
                    Name = "btnProduto" + objProduto.Cod,
                    Size = new Size(110, 110),
                    Image = Image.FromFile(objArquivo.Local)
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    editarPedidoProduto(objPedidoProduto, objIngredientes);
                };

                opcoesControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlProdutos, opcoesControles, 20);

            foreach (Control control in opcoesControles)
            {
                if (control is Button btn)
                {
                    UIX.uixButton.btnApply(btn, App.AppVisualStyle.ButtonImageColor);
                    btn.ForeColor = App.AppVisualStyle.ButtonImageColor.ContentColor;
                }
            }
            opcoesControles.Clear();

            pnlProdutos.BackColor = grbProdutos.BackColor;
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (clnUtilMensagem.mostrarSimNao("Pedido", "Deseja confirmar este pedido?", clnUtilMensagem.MensagemIcone.OK))
            {
                //Confirma o pedido.
                double valor = calculaValor();

                clnPedido objPedido = new clnPedido
                {
                    CodAtendimento = CodAtendimento,
                    CodFuncionario = CodFuncionario,
                    Valor = valor,
                    Situacao = clnPedido.pedidoSituacao.REALIZADO
                };
                objPedido.gravar();

                foreach (KeyValuePair<clnItem, List<clnItemIngrediente>> objPair in ObjItens)
                {
                    clnItem objItem = objPair.Key;
                    objItem.CodPedido = objPedido.Cod;
                    objItem.gravar();

                    foreach(clnItemIngrediente objIngrediente in objPair.Value)
                    {
                        objIngrediente.CodItem = objItem.Cod;
                        objIngrediente.gravar();
                    }                    
                }

                Form.Close();
            }
        }

        private void uctPedidoProdutos_Load(object sender, EventArgs e)
        {
            exibirProdutos();
        }

        private double calculaValor()
        {
            double valor = 0;

            foreach (KeyValuePair<clnItem, List<clnItemIngrediente>> objPair in ObjItens)
            {
                double itemValor = 0;
                clnItem objItem = objPair.Key;
                clnProduto objProduto = new clnProduto
                {
                    Cod = objItem.CodProduto
                }.obterPorCodigo();
                itemValor += objProduto.Valor;
                foreach (clnItemIngrediente objItemIngrediente in objPair.Value)
                {
                    double ingredienteValor = 0;
                    clnIngrediente objIngredienteAtual = new clnIngrediente
                    {
                        Cod = objItemIngrediente.CodIngrediente
                    }.obterPorCod();
                    if (objItemIngrediente.CodProdutoIngrediente != -1)
                    {
                        clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                        {
                            Cod = objItemIngrediente.CodProdutoIngrediente
                        }.obterPorCod();
                        if (objProdutoIngrediente != null)
                        {
                            if (objItemIngrediente.Quantidade > objProdutoIngrediente.Quantidade)
                            {
                                ingredienteValor = objIngredienteAtual.Valor * (objItemIngrediente.Quantidade - objProdutoIngrediente.Quantidade);
                            }
                        }
                        else
                        {
                            ingredienteValor = objIngredienteAtual.Valor * objItemIngrediente.Quantidade;
                        }
                    }
                    else
                    {
                        ingredienteValor = objIngredienteAtual.Valor * objItemIngrediente.Quantidade;
                    }
                    itemValor += ingredienteValor;
                }
                valor += itemValor;
            }

            return valor;
        }
    }
}
