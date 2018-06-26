using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtilConta
    {

        public static string gerarConta(clnAtendimento objAtendimento, int pessoas, bool incluirGorjeta, double desconto)
        {
            List<clnPedido> objPedidos = new clnPedido
            {
                CodAtendimento = objAtendimento.Cod
            }.obterPorAtendimento();

            StringBuilder contaBuilder = new StringBuilder();
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
                    contaBuilder.Append(clnUtil.formatarValor(clnUtilPedido.calcularValor(objAtendimento)));
                }
                else if (line.Equals("{@valortotal}"))
                {
                    contaBuilder.Append(clnUtil.formatarValor(calcularValor(clnUtilPedido.calcularValor(objAtendimento), incluirGorjeta, desconto)));
                }
                else if (line.Equals("{@valorpessoa}"))
                {
                    contaBuilder.Append(clnUtil.formatarValor(calcularValor(clnUtilPedido.calcularValor(objAtendimento), incluirGorjeta, desconto) / pessoas));
                }
                else if (line.Equals("{@gorjeta}"))
                {
                    if (incluirGorjeta)
                    {
                        contaBuilder.Append("<tr><td colspan='3' class='left'>+ Taxa de Serviço (10,0%)</td>");
                        contaBuilder.Append("<td colspan='3' class='right'>").Append(clnUtil.formatarValor(clnUtilPedido.calcularValor(objAtendimento) * 0.1)).Append("</td></tr>");
                    }
                }
                else if (line.Equals("{@desconto}"))
                {
                    if (desconto > 0.0)
                    {
                        contaBuilder.Append("<tr><td colspan='3' class='left'>- Desconto (" + desconto.ToString("N") + "%)</td>");
                        contaBuilder.Append("<td colspan='3' class='right'>").Append(clnUtil.formatarValor(clnUtilPedido.calcularValor(objAtendimento) * (desconto / 100))).Append("</td></tr>");
                    }
                }
                else if (line.Equals("{@pessoas}"))
                {
                    contaBuilder.Append(pessoas);
                }
                else if (line.Equals("{@datahora}"))
                {
                    contaBuilder.Append(clnUtil.formatarDataHora(DateTime.Now));
                }
                else
                {
                    contaBuilder.Append(line);
                }
            }

            return contaBuilder.ToString();
        }

        public static double calcularValor(double subTotal, bool incluirComissao, double desconto)
        {
            double valor = subTotal;
            if (incluirComissao)
            {
                valor += subTotal * 0.1;
            }
            if (desconto > 0.0)
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

            adicionarItem(contaBuilder, 1, "PROD-" + objProduto.Cod, objProduto.Nome, objItem.Quantidade, objProduto.Valor);

            foreach (clnItemIngrediente objItemIngrediente in objItemIngredientes.obterPorItem())
            {
                int quantidade = 0;
                if (objItemIngrediente.CodProdutoIngrediente == 0)
                {
                    quantidade = objItemIngrediente.Quantidade;
                }
                else
                {
                    clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                    {
                        Cod = objItemIngrediente.CodProdutoIngrediente
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
                    adicionarItem(contaBuilder, 1, "INGR-" + objIngrediente.Cod, "+ " + objIngrediente.Nome, quantidade, objIngrediente.Valor);
                }
            }
        }

        public static void adicionarItem(StringBuilder htmlBuilder, int item, String cod, String descricao, int quantidade, double valor)
        {
            htmlBuilder.Append(@"<tr>");
            htmlBuilder.Append(@"<td class='left'>").Append(item).Append("</td>");
            htmlBuilder.Append(@"<td class='left'>").Append(cod).Append("</td>");
            htmlBuilder.Append(@"<td class='left'>").Append(descricao).Append("</td>");
            htmlBuilder.Append(@"<td class='right'>").Append(quantidade).Append("</td>");
            htmlBuilder.Append(@"<td class='right'>").Append(clnUtil.formatarValor(valor)).Append("</td>");
            htmlBuilder.Append(@"<td class='right'>").Append(clnUtil.formatarValor(valor * quantidade)).Append("</td>");
            htmlBuilder.Append(@"</tr>");
        }


        public static IEnumerable<string> obterTemplate()
        {
            return File.ReadLines(Directory.GetParent(Directory.GetParent(Application.StartupPath.ToString()).ToString()).ToString() + @"\conta-template.html");
        }

    }
}
