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
            double atendimentoValor = 0.0;

            clnPedido objPedidos = new clnPedido
            {
                CodAtendimento = objAtendimento.Cod
            };

            foreach (clnPedido objPedido in objPedidos.obterPorAtendimento())
            {
                atendimentoValor += calcularValor(objPedido);
            }

            return Math.Round(atendimentoValor, 2);
        }

        public static double calcularValor(clnPedido objPedido)
        {
            double pedidoValor = 0.0;

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

            return Math.Round(pedidoValor, 2);
        }

        public static double calcularValor(Dictionary<clnItem, List<clnItemIngrediente>> objItens)
        {
            double pedidoValor = 0.0;

            foreach (KeyValuePair<clnItem, List<clnItemIngrediente>> objItem in objItens)
            {
                pedidoValor += calcularValor(objItem.Key, objItem.Value);
            }

            return Math.Round(pedidoValor, 2);
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

            return Math.Round(itemValor, 2);
        }

        public static double calcularValor(clnItemIngrediente objItemIngrediente)
        {
            double ingredienteValor = 0.0;

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
