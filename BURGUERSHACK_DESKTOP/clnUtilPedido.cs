using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUERSHACK_DESKTOP
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

        public static decimal calcularValor(clnAtendimento objAtendimento)
        {
            decimal atendimentoValor = 0;

            clnPedido objPedidos = new clnPedido
            {
                CodAtendimento = objAtendimento.Cod
            };

            foreach (clnPedido objPedido in objPedidos.obterPorAtendimento())
            {
                atendimentoValor += calcularValor(objPedido);
            }

            return atendimentoValor;
        }

        public static decimal calcularValor(clnPedido objPedido)
        {
            decimal pedidoValor = 0;

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
                pedidoValor += calcularValor(objItem, objIngredientes.obterPorItem());
            }

            return pedidoValor;
        }

        public static decimal calcularValor(Dictionary<clnItem, List<clnItemIngrediente>> objItens)
        {
            decimal pedidoValor = 0;

            foreach (KeyValuePair<clnItem, List<clnItemIngrediente>> objItem in objItens)
            {
                pedidoValor += calcularValor(objItem.Key, objItem.Value);
            }

            return pedidoValor;
        }

        public static decimal calcularValor(clnItem objItem, List<clnItemIngrediente> objItemIngredientes)
        {
            clnProduto objProduto = new clnProduto
            {
                Cod = objItem.CodProduto
            }.obterPorCod();
            decimal itemValor = objProduto.Valor * objItem.Quantidade;

            foreach (clnItemIngrediente objItemIngrediente in objItemIngredientes)
            {
                itemValor += calcularValor(objItemIngrediente) * objItem.Quantidade;
            }

            return itemValor;
        }

        public static decimal calcularValor(clnItemIngrediente objItemIngrediente)
        {
            decimal ingredienteValor = 0;

            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = objItemIngrediente.CodIngrediente
            }.obterPorCod();

            if (objItemIngrediente.CodProdutoIngrediente != null)
            {
                clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                {
                    Cod = (int)objItemIngrediente.CodProdutoIngrediente
                }.obterPorCod();

                if (objProdutoIngrediente != null)
                {
                    if (objItemIngrediente.Quantidade > objProdutoIngrediente.Quantidade)
                    {
                        ingredienteValor = objIngrediente.Valor * (objItemIngrediente.Quantidade - objProdutoIngrediente.Quantidade);
                    }
                } else
                {
                    ingredienteValor = objIngrediente.Valor * objItemIngrediente.Quantidade;
                }
            } else
            {
                ingredienteValor = objIngrediente.Valor * objItemIngrediente.Quantidade;
            }
            return Math.Round(ingredienteValor, 2);
        }

    }
}
