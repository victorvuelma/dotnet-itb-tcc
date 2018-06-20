using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtilPedido
    {

        public static void inserirItem(int codPedido, clnItem objItem, List<clnItemIngrediente> objItemIngredientes)
        {
            objItem.CodPedido = codPedido;
            objItem.gravar();

            foreach (clnItemIngrediente objIngrediente in objItemIngredientes)
            {
                objIngrediente.CodItem = objItem.Cod;
                objIngrediente.gravar();
            }
        }

        public static double calcularValor(clnItem objItem, List<clnItemIngrediente> objItemIngredientes)
        {
            clnProduto objProduto = new clnProduto
            {
                Cod = objItem.CodProduto
            }.obterPorCod();
            double itemValor = objProduto.Valor;

            foreach (clnItemIngrediente objItemIngrediente in objItemIngredientes)
            {
                itemValor +=clnUtilPedido.calcularValor(objItemIngrediente);
            }

            return itemValor;
        }

        public static double calcularValor(clnItemIngrediente objItemIngrediente)
        {
            clnIngrediente objIngrediente = new clnIngrediente
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
                        return objIngrediente.Valor * (objItemIngrediente.Quantidade - objProdutoIngrediente.Quantidade);
                    } else
                    {
                        return 0.0;
                    }
                }
            }

            return objIngrediente.Valor * objItemIngrediente.Quantidade;
        }

    }
}
