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

        public static void adicionarIngrediente(clnItem objItem, clnItemIngrediente objIngrediente)
        {
            clnItemIngrediente objIngredientes = new clnItemIngrediente
            {
                CodItem = objItem.Cod
            };

            foreach (clnItemIngrediente objItemIngrediente in objIngredientes.obterPorItem())
            {
                if (objItemIngrediente.CodIngrediente == objIngrediente.CodIngrediente)
                {
                    objItemIngrediente.Quantidade += objIngrediente.Quantidade;
                    objItemIngrediente.alterar();
                    return;
                }
            }

            objIngrediente.gravar();
        }

        public static void adicionarIngrediente(List<clnItemIngrediente> objItemIngredientes, clnItemIngrediente objIngrediente)
        {
            foreach (clnItemIngrediente objItemIngrediente in objItemIngredientes)
            {
                if (objItemIngrediente.CodIngrediente == objIngrediente.CodIngrediente)
                {
                    objItemIngrediente.Quantidade += objIngrediente.Quantidade;
                    return;
                }
            }

            objItemIngredientes.Add(objIngrediente);
        }

        public static double calcularValor(clnAtendimento objAtendimento)
        {
            clnPedido objPedidos = new clnPedido
            {
                CodAtendimento = objAtendimento.Cod
            };

            double valor = 0.0d;
            foreach (clnPedido objPedido in objPedidos.obterPorAtendimento())
            {
                valor += calcularValor(objPedido);
            }

            return valor;
        }

        public static double calcularValor(clnPedido objPedido)
        {
            double valorTotal = 0.0;

            clnItem objItens = new clnItem
            {
                CodPedido = objPedido.Cod
            };

            foreach (clnItem objItem in objItens.obterPorPedido())
            {
                clnItemIngrediente objIngredientes = new clnItemIngrediente
                {
                    CodItem = objItem.Cod
                };

                valorTotal += calcularValor(objItem, objIngredientes.obterPorItem());
            }

            return valorTotal;
        }

        public static double calcularValor(Dictionary<clnItem, List<clnItemIngrediente>> objItens)
        {
            double valorTotal = 0.0;

            foreach (KeyValuePair<clnItem, List<clnItemIngrediente>> objItem in objItens)
            {
                valorTotal += calcularValor(objItem.Key, objItem.Value);
            }

            return valorTotal;
        }

        public static double calcularValor(clnItem objItem, List<clnItemIngrediente> objItemIngredientes)
        {
            clnProduto objProduto = new clnProduto
            {
                Cod = objItem.CodProduto
            }.obterPorCod();
            double itemValor = objProduto.Valor * objItem.Quantidade;

            foreach (clnItemIngrediente objItemIngrediente in objItemIngredientes)
            {
                itemValor += clnUtilPedido.calcularValor(objItemIngrediente) * objItem.Quantidade;
            }

            return itemValor;
        }

        public static double calcularValor(clnItemIngrediente objItemIngrediente)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = objItemIngrediente.CodIngrediente
            }.obterPorCod();

            if (objItemIngrediente.CodProdutoIngrediente != null)
            {
                clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                {
                    Cod = (int) objItemIngrediente.CodProdutoIngrediente
                }.obterPorCod();

                if (objProdutoIngrediente != null)
                {
                    if (objItemIngrediente.Quantidade > objProdutoIngrediente.Quantidade)
                    {
                        return objIngrediente.Valor * (objItemIngrediente.Quantidade - objProdutoIngrediente.Quantidade);
                    }
                    else
                    {
                        return 0.0;
                    }
                }
            }

            return objIngrediente.Valor * objItemIngrediente.Quantidade;
        }

    }
}
