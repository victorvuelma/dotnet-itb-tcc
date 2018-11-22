using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Text;
using vitorrdgs.Util.Data;

namespace BurgerShack.Web.Bll
{
    public class ProdutoBLL
    {
        public string exibirProdutos(int codTipo)
        {
            List<clnProduto> objProdutos = null;
            if (codTipo == 0)
            {
                objProdutos = new clnProduto
                {
                    Situacao = clnProduto.produtoSituacao.DISPONIVEL,
                    Ativo = true
                }.obterPorSituacao();
            }
            else
            {
                objProdutos = new clnProduto
                {
                    Situacao = clnProduto.produtoSituacao.DISPONIVEL,
                    Ativo = true,
                    CodTipo = codTipo
                }.obterPorTipoSituacao();
            }

            if (objProdutos == null || objProdutos.Count == 0)
            {
                return "<div class='col-12'><h3>Não há produtos cadastrados.</h3></div>";
            }
            else
            {
                StringBuilder builder = new StringBuilder();

                foreach (clnProduto objProduto in objProdutos)
                {

                    clnArquivo objImagem = new clnArquivo
                    {
                        Cod = objProduto.CodImagem
                    }.obterPorCod();

                    StringBuilder produtoBuilder = new StringBuilder();

                    produtoBuilder.Append("<div class='col-md-6 col-lg-4 col-sm-12'>");
                    produtoBuilder.Append("<div class='card'>");
                    if (objImagem != null && objImagem.Conteudo != null)
                    {
                        produtoBuilder.Append("<img class='card-img-top' src='data:image/jpeg;base64,").Append(Convert.ToBase64String(objImagem.Conteudo)).Append("' alt='").Append(objProduto.Nome).Append("'>");
                    }
                    produtoBuilder.Append("<div class='card-body'>");
                    produtoBuilder.Append("<h5>").Append(objProduto.Nome).Append("</h5>");
                    produtoBuilder.Append("<small>").Append(tipoNome(objProduto.CodTipo)).Append("</small>");
                    produtoBuilder.Append("<p>").Append(objProduto.Descricao).Append("</p>");

                    List<clnProdutoIngrediente> objProdutoIngredientes = new clnProdutoIngrediente
                    {
                        CodProduto = objProduto.Cod
                    }.obterPorProduto();

                    if (objProdutoIngredientes.Count > 0)
                    {
                        produtoBuilder.Append("Ingredientes:");
                        produtoBuilder.Append("<ul>");

                        foreach (clnProdutoIngrediente objProdutoIngrediente in objProdutoIngredientes)
                        {
                            clnIngrediente objIngrediente = new clnIngrediente
                            {
                                Cod = objProdutoIngrediente.CodIngrediente
                            }.obterPorCod();

                            produtoBuilder.Append("<li>").Append(objIngrediente.Nome).Append("</li>");
                        }

                        produtoBuilder.Append("</ul>");

                    }

                    produtoBuilder.Append("</div>");
                    produtoBuilder.Append("<div class='panel-price'>").Append(UtilFormatar.formatarValor(objProduto.Valor)).Append("</div>");
                    produtoBuilder.Append("</div>");
                    produtoBuilder.Append("</div>");

                    builder.Append(produtoBuilder);
                }

                return builder.ToString();
            }
        }

        public string listarProdutos()
        {
            StringBuilder listarBuilder = new StringBuilder();

            List<clnProduto> objProdutos = new clnProduto
            {
                Situacao = clnProduto.produtoSituacao.DISPONIVEL,
                Ativo = true
            }.obterPorSituacao();

            foreach (clnProduto objProduto in objProdutos)
            {
                if (listarBuilder.Length > 0)
                {
                    listarBuilder.AppendLine("$");
                }
                listarBuilder.Append(objProduto.Cod);
                listarBuilder.Append("&").Append(objProduto.Nome);
                listarBuilder.Append("&").Append(objProduto.Descricao);

                List<clnProdutoIngrediente> objProdutoIngredientes = new clnProdutoIngrediente
                {
                    CodProduto = objProduto.Cod
                }.obterPorProduto();

                if (objProdutoIngredientes.Count > 0)
                {
                    listarBuilder.Append(".Ingredientes:");
                    foreach (clnProdutoIngrediente objProdutoIngrediente in objProdutoIngredientes)
                    {
                        clnIngrediente objIngrediente = new clnIngrediente
                        {
                            Cod = objProdutoIngrediente.CodIngrediente
                        }.obterPorCod();

                        listarBuilder.Append(".").Append(objIngrediente.Nome);
                    }
                }

                listarBuilder.Append("&").Append(objProduto.Valor);
                listarBuilder.Append("&").Append(objProduto.CodTipo);

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = objProduto.CodImagem
                }.obterPorCod();
                listarBuilder.Append("&").Append(Convert.ToBase64String(objArquivo.Conteudo));
            }

            return listarBuilder.ToString();
        }

        private string tipoNome(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return "Lanche";
                case 2:
                    return "Acompanhamento";
                case 3:
                    return "Bebida";
                case 4:
                    return "Sobremesa";
            }
            return "";
        }

    }
}
