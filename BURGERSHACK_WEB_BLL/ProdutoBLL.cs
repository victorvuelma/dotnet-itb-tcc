using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGERSHACK_WEB_BLL
{
    public class ProdutoBLL
    {

        public string listarProdutos(List<clnProduto> objProdutos)
        {
           if(objProdutos.Count == 0)
            {
                return "<h3>Não há produtos cadastrados.</h3>";
            } else
            {
                StringBuilder builder = new StringBuilder();

                foreach (clnProduto objProduto in objProdutos)
                {
                    List<clnProdutoIngrediente> objProdutoIngredientes = new clnProdutoIngrediente
                    {
                        CodProduto = objProduto.Cod
                    }.obterPorProduto();

                    foreach (clnProdutoIngrediente objProdutoIngrediente in objProdutoIngredientes)
                    {
                        clnIngrediente objIngrediente = new clnIngrediente
                        {
                            Cod = objProdutoIngrediente.CodIngrediente
                        }.obterPorCod();
                    }
                }

                return builder.ToString();
            }
        }

    }
}
