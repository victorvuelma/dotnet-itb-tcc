using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.UiX.Component;

namespace BurgerShack.Desktop
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

        private List<clnItemIngrediente> obterIngredientes(clnItem objItem)
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
            return objIngredientes;
        }

        private void editarItem(clnItem objItem)
        {
            if (ObjPedido.Situacao == clnPedido.pedidoSituacao.REALIZADO)
            {
                List<clnItemIngrediente> objItemIngredientes = obterIngredientes(objItem);
                frmItem frmEditarItem = new frmItem
                {
                    ObjItem = objItem,
                    ObjItemIngredientes = objItemIngredientes
                };
                frmEditarItem.ShowDialog();

                if (frmEditarItem.ObjItem == null)
                {
                    ObjItens.Remove(objItem);
                    clnUtilMensagem.mostrarOk("Pedido", "Produto removido do pedido");

                    exibirProdutos();
                }
                else if (objItem.Cod == -1 && frmEditarItem.ObjItem != objItem || frmEditarItem.ObjItemIngredientes != objItemIngredientes)
                {
                    clnUtil.dictTrocar(ObjItens, objItem, frmEditarItem.ObjItem, frmEditarItem.ObjItemIngredientes);

                    exibirProdutos();
                }
            }
            else
            {
                clnUtilMensagem.mostrarOk("Pedido", "Não é possivel alterar esse item pois ele está em prepardo.");
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

                UIXButton btn = new UIXButton
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
                    uixButton.btnApply(btn, AppDesktop.VisualStyle.ButtonImageColor);
                }
            }
            opcoesControles.Clear();

            pnlProdutos.BackColor = grbProdutos.BackColor;
        }

        private void uctPedidoProdutos_Load(object sender, EventArgs e)
        {
            exibirProdutos();
        }

    }
}
