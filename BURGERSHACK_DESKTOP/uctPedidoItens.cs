using BurgerShack.Desktop.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;

namespace BurgerShack.Desktop
{
    public partial class uctPedidoItens : UserControl
    {

        private frmPedido _form;

        private int _codAtendimento;

        private clnPedido _objPedido;
        private Dictionary<clnItem, List<clnItemIngrediente>> _objItens;

        public frmPedido Form { get => _form; set => _form = value; }
        public int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
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

        private bool editarItem(clnItem objItem)
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
                    UtilMensagem.mostrarOk("Pedido", "Produto removido do pedido");
                    exibirProdutos();

                    return true;
                }
                else if (objItem.Cod == -1 && frmEditarItem.ObjItem != objItem || frmEditarItem.ObjItemIngredientes != objItemIngredientes)
                {
                    clnUtil.dictTrocar(ObjItens, objItem, frmEditarItem.ObjItem, frmEditarItem.ObjItemIngredientes);

                    exibirProdutos();
                }
            }
            else
            {
                UtilMensagem.mostrarOk("Pedido", "Não é possivel alterar esse item pois ele está em prepardo.");
            }
            return false;
        }

        private void exibirProdutos()
        {
            lstProdutos.LimparOpcoes();
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

                lstProdutos.Adicionar(objProduto.Cod, objProduto.Nome, objArquivo.Local, AppDesktop.VisualStyle.ButtonImageColor, () =>
                {
                    ;
                    return (editarItem(objItem) ? UIXItemsList.ListResult.REMOVER : UIXItemsList.ListResult.NENHUM);
                });
            }
            lstProdutos.exibirItens();
        }

        private void uctPedidoProdutos_Load(object sender, EventArgs e)
        {
            exibirProdutos();
        }

    }
}
