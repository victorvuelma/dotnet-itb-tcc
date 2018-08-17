using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    class clnUtilConta
    {

        private static int codItem = 0;

        public static decimal calcularValorPago(int codConta)
        {
            decimal valorPago = 0;
            clnPagamento objPagamentos = new clnPagamento
            {
                CodConta = codConta
            };
            foreach (clnPagamento objPagamento in objPagamentos.obterPorConta())
            {
                valorPago += objPagamento.Valor;
            }

            return valorPago;
        }

        public static decimal calcularValor(clnConta objConta)
        {
            return calcularValor(objConta.Valor, objConta.TaxaServico, objConta.Desconto);
        }

        public static string gerarConta(clnAtendimento objAtendimento, int pessoas, bool incluirGorjeta, decimal desconto)
        {
            List<clnPedido> objPedidos = new clnPedido
            {
                CodAtendimento = objAtendimento.Cod
            }.obterPorAtendimento();

            decimal valorSubTotal = clnUtilPedido.calcularValor(objAtendimento);
            decimal valorTotal = calcularValor(valorSubTotal, incluirGorjeta, desconto);

            StringBuilder contaBuilder = new StringBuilder();
            codItem = 1;
            foreach (String line in obterTemplate())
            {
                if (line.Equals("{@items}"))
                {
                    foreach (clnPedido objPedido in objPedidos)
                    {
                        gerarConta(contaBuilder, objPedido);
                    }
                }
                else if (line.Equals("{@valorsubtotal}"))
                {
                    contaBuilder.Append(UtilFormatar.formatarValor(valorSubTotal));
                }
                else if (line.Equals("{@valortotal}"))
                {
                    contaBuilder.Append(UtilFormatar.formatarValor(valorTotal));
                }
                else if (line.Equals("{@valorpessoa}"))
                {
                    contaBuilder.Append(UtilFormatar.formatarValor(valorTotal / pessoas));
                }
                else if (line.Equals("{@gorjeta}"))
                {
                    if (incluirGorjeta)
                    {
                        contaBuilder.Append("<tr><td colspan='3' class='left'>+ Taxa de Serviço (10,0%)</td>");
                        contaBuilder.Append("<td colspan='3' class='right'>").Append(UtilFormatar.formatarValor(valorSubTotal * (decimal)0.1)).Append("</td></tr>");
                    }
                }
                else if (line.Equals("{@desconto}"))
                {
                    if (desconto > 0)
                    {
                        contaBuilder.Append("<tr><td colspan='3' class='left'>- Desconto (" + desconto.ToString("N") + "%)</td>");
                        contaBuilder.Append("<td colspan='3' class='right'>").Append(UtilFormatar.formatarValor(valorSubTotal * (desconto / 100))).Append("</td></tr>");
                    }
                }
                else if (line.Equals("{@pessoas}"))
                {
                    contaBuilder.Append(pessoas);
                }
                else if (line.Equals("{@datahora}"))
                {
                    contaBuilder.Append(UtilFormatar.formatarDataHora(DateTime.Now));
                }
                else
                {
                    contaBuilder.Append(line);
                }
            }

            return contaBuilder.ToString();
        }

        public static decimal calcularValor(decimal subTotal, bool incluirComissao, decimal desconto)
        {
            decimal valor = subTotal;
            if (incluirComissao)
            {
                valor += subTotal * (decimal)0.1;
            }
            if (desconto > 0)
            {
                valor -= subTotal * (desconto / 100);
            }
            return valor;
        }

        public static void gerarConta(StringBuilder contaBuilder, clnPedido objPedido)
        {
            List<clnItem> objItens = new clnItem
            {
                CodPedido = objPedido.Cod
            }.obterPorPedido();

            foreach (clnItem objItem in objItens)
            {
                gerarConta(contaBuilder, objItem);
            }
        }

        public static void gerarConta(StringBuilder contaBuilder, clnItem objItem)
        {
            clnProduto objProduto = new clnProduto
            {
                Cod = objItem.CodProduto
            }.obterPorCod();
            clnItemIngrediente objItemIngredientes = new clnItemIngrediente
            {
                CodItem = objItem.Cod
            };

            adicionarItem(contaBuilder, codItem++, "PROD-" + objProduto.Cod, objProduto.Nome, objItem.Quantidade, objProduto.Valor);

            foreach (clnItemIngrediente objItemIngrediente in objItemIngredientes.obterPorItem())
            {
                int quantidade = 0;
                if (objItemIngrediente.CodProdutoIngrediente == null)
                {
                    quantidade = objItemIngrediente.Quantidade;
                }
                else
                {
                    clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                    {
                        Cod = (int)objItemIngrediente.CodProdutoIngrediente
                    }.obterPorCod();
                    if (objProdutoIngrediente != null)
                    {
                        quantidade = objItemIngrediente.Quantidade - objProdutoIngrediente.Quantidade;
                    }
                    else
                    {
                        quantidade = objItemIngrediente.Quantidade;
                    }
                }

                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = objItemIngrediente.CodIngrediente
                }.obterPorCod();

                if (quantidade > 0)
                {
                    adicionarItem(contaBuilder, codItem++, "INGR-" + objIngrediente.Cod, "+ " + objIngrediente.Nome, quantidade, objIngrediente.Valor);
                }
            }
        }

        public static void adicionarItem(StringBuilder htmlBuilder, int item, string cod, string descricao, int quantidade, decimal valor)
        {
            htmlBuilder.Append(@"<tr>")
                       .Append(@"<td class='left'>").Append(item).Append("</td>")
                       .Append(@"<td class='left'>").Append(cod).Append("</td>")
                       .Append(@"<td class='left'>").Append(descricao).Append("</td>")
                       .Append(@"<td class='right'>").Append(quantidade).Append("</td>")
                       .Append(@"<td class='right'>").Append(UtilFormatar.formatarValor(valor)).Append("</td>")
                       .Append(@"<td class='right'>").Append(UtilFormatar.formatarValor(valor * quantidade)).Append("</td>")
                       .Append(@"</tr>");
        }

        public static IEnumerable<string> obterTemplate()
        {
            return File.ReadLines(global::BurgerShack.Common.Properties.Resources.html_template_conta);
        }

    }
}
