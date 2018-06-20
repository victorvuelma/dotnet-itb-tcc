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
    public partial class uctPedidoItens : UserControl
    {

        private frmPedido _form;

        private int _codAtendimento;
        private int _codFuncionario;

        private clnPedido _objPedido;
        private Dictionary<clnItem, List<clnItemIngrediente>> _objItens;

        public frmPedido Form { get => _form; set => _form = value; }
        public int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public clnPedido ObjPedido { get => _objPedido; set => _objPedido = value; }
        public Dictionary<clnItem, List<clnItemIngrediente>> ObjItens { get => _objItens; set => _objItens = value; }

        public uctPedidoItens()
        {
            InitializeComponent();
        }

        private List<clnItem> obterItens()
        {
            if (ObjPedido == null || ObjPedido.Cod == -1)
            {
                return new List<clnItem>(ObjItens.Keys);
            }
            else
            {
                List<clnItem> objItens = new clnItem
                {
                    CodPedido = ObjPedido.Cod
                }.obterPorPedido();
                return objItens;
            }
        }
        
        private void editarItem(clnItem objItem)
        {
            List<clnItemIngrediente> objIngredientes = null;
            if (objItem.Cod == -1)
            {
                ObjItens.TryGetValue(objItem, out objIngredientes);
            }
            else
            {
                objIngredientes = new clnItemIngrediente
                {
                    CodItem = objItem.Cod
                }.obterPorItem();
            }

            frmItem frmEditarItem = new frmItem
            {
                ObjItem = objItem,
                ObjIngredientes = objIngredientes
            };
            frmEditarItem.ShowDialog();

            if (frmEditarItem.ObjItem == null)
            {
                ObjItens.Remove(objItem);
                clnUtilMensagem.mostrarOk("Pedido", "Produto removido do pedido", clnUtilMensagem.MensagemIcone.INFO);

                exibirProdutos();
            }
            else if (objItem.Cod == -1 && frmEditarItem.ObjItem != objItem || frmEditarItem.ObjIngredientes != objIngredientes)
            {
                clnUtil.dictTrocar(ObjItens, objItem, frmEditarItem.ObjItem, frmEditarItem.ObjIngredientes);

                exibirProdutos();
            }
        }

        private void exibirProdutos()
        {
            pnlProdutos.Controls.Clear();

            List<Control> opcoesControles = new List<Control>();
            foreach (clnItem objItem in obterItens())
            {
                clnProduto objProduto = new clnProduto
                {
                    Cod = objItem.CodProduto
                }.obterPorCod();

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = objProduto.CodImagem
                }.obterPorCodigo();

                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = objProduto.Nome,
                    Name = "btnItem" + objProduto.Cod,
                    Size = new Size(110, 110),
                    ImageLocation = objArquivo.Local
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    editarItem(objItem);
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
                    clnUtilPedido.inserirItem(objPedido.Cod, objPair.Key, objPair.Value);
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
                }.obterPorCod();
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
