using BurgerShack.Common;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element.Where;
using vitorrdgs.Util.Data;

namespace BurgerShack.Common
{
    public class clnProduto
    {

        public enum produtoSituacao
        {
            DISPONIVEL,
            INDISPONIVEL,
            FORADEESTOQUE
        }

        private int _cod = -1;
        private bool _ativo = true;

        private int _codImagem = -1;
        private int _codTipo = -1;
        private int? _codMercadoria = null;

        private string _nome;
        private string _descricao;
        private decimal _valor;
        private produtoSituacao _situacao;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodImagem { get => _codImagem; set => _codImagem = value; }
        public int CodTipo { get => _codTipo; set => _codTipo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public produtoSituacao Situacao { get => _situacao; set => _situacao = value; }
        public int? CodMercadoria { get => _codMercadoria; set => _codMercadoria = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnProduto obter(SqlDataReader reader) => new clnProduto
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodImagem = UtilConvert.ToInt(reader["id_imagem"]),
            CodTipo = UtilConvert.ToInt(reader["id_tipo"]),
            Descricao = UtilConvert.ToString(reader["descricao"]),
            Nome = UtilConvert.ToString(reader["nome"]),
            Situacao = situacao(UtilConvert.ToChar(reader["situacao"])),
            Valor = UtilConvert.ToDecimal(reader["valor"]),
            Ativo = UtilConvert.ToBool(reader["ativo"]),
            CodMercadoria = UtilConvert.ToNullableInt(reader["id_mercadoria"])
        };

        public clnProduto obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("produto");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnProduto objProduto = null;
            if (reader.Read())
                objProduto = obter(reader);
            reader.Close();

            return objProduto;
        }

        public List<clnProduto> obterPorTipoSituacao()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("produto");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("id_tipo", CodTipo)
                           .where("situacao", prefixo(Situacao));

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnProduto> objProdutos = new List<clnProduto>();
            while (reader.Read())
                objProdutos.Add(obter(reader));
            reader.Close();

            return objProdutos;
        }

        public List<clnProduto> obterPorNome()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("produto");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("nome", sqlElementWhereCommon.whereOperation.LIKE, "%" + Nome + "%");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnProduto> objProdutos = new List<clnProduto>();
            while (reader.Read())
                objProdutos.Add(obter(reader));
            reader.Close();

            return objProdutos;
        }

        internal List<clnProduto> obterPorMercadoria()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("produto");
            objSelect.Where.where("id_mercadoria", CodMercadoria);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnProduto> objProdutos = new List<clnProduto>();
            while (reader.Read())
                objProdutos.Add(obter(reader));
            reader.Close();

            return objProdutos;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("produto");
            objInsert.Value.val("id_imagem", CodImagem)
                            .val("id_tipo", CodTipo)
                            .val("nome", Nome)
                            .val("descricao", Descricao)
                            .val("valor", Valor)
                            .val("situacao", prefixo(Situacao))
                            .val("ativo", UtilConvert.ToBit(Ativo));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);

            atualizarEstoque();
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("produto");
            objUpdate.Value.val("id_imagem", CodImagem)
                             .val("id_tipo", CodTipo)
                             .val("nome", Nome)
                             .val("descricao", Descricao)
                             .val("valor", Valor)
                             .val("situacao", prefixo(Situacao))
                             .val("ativo", UtilConvert.ToBit(Ativo))
                             .val("id_mercadoria", CodMercadoria);
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
        }

        public void atualizarEstoque()
        {
            if (Situacao != clnProduto.produtoSituacao.INDISPONIVEL)
            {
                clnProduto.produtoSituacao novaSituacao = clnProduto.produtoSituacao.DISPONIVEL;

                if (CodMercadoria != null)
                {
                    int estoqueAtual = new clnEstoque
                    {
                        CodMercadoria = (int)CodMercadoria
                    }.obterQuantidadePorMercadoria();

                    if (Situacao != clnProduto.produtoSituacao.INDISPONIVEL)
                    {
                        if (estoqueAtual > 0)
                        {
                            novaSituacao = clnProduto.produtoSituacao.DISPONIVEL;
                        }
                        else
                        {
                            novaSituacao = clnProduto.produtoSituacao.FORADEESTOQUE;
                        }
                    }
                }
                else
                {
                    List<clnProdutoIngrediente> objProdutoIngredientes = new clnProdutoIngrediente
                    {
                        CodProduto = Cod
                    }.obterPorProduto();

                    foreach (clnProdutoIngrediente objProdutoIngrediente in objProdutoIngredientes)
                    {
                        clnIngrediente objIngrediente = new clnIngrediente
                        {
                            Cod = objProdutoIngrediente.CodIngrediente
                        }.obterPorCod();

                        if (objIngrediente.Situacao == clnIngrediente.ingredienteSituacao.FORADEESTOQUE)
                        {
                            novaSituacao = clnProduto.produtoSituacao.FORADEESTOQUE;
                            break;
                        }
                    }
                }
                if (Situacao != novaSituacao)
                {
                    Situacao = novaSituacao;
                    alterar();
                }
            }
        }

        private produtoSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'D':
                    return produtoSituacao.DISPONIVEL;
                case 'E':
                    return produtoSituacao.FORADEESTOQUE;
                default:
                    return produtoSituacao.INDISPONIVEL;
            }
        }

        private char prefixo(produtoSituacao situacao)
        {
            switch (situacao)
            {
                case produtoSituacao.DISPONIVEL:
                    return 'D';
                case produtoSituacao.FORADEESTOQUE:
                    return 'E';
                default:
                    return 'I';
            }
        }

        public class clnListar : clnUtilListar<clnProduto>
        {

            internal override string Detalhes(clnProduto obj)
            {
                string detalhes = "";
                detalhes += "Categoria: " + obj.CodTipo;
                detalhes += "\n";
                detalhes += "Código: " + obj.Cod;

                return detalhes;
            }

            internal override string Imagem(clnProduto obj)
            {
                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = obj.CodImagem
                }.obterPorCod();
                return objArquivo.Local;
            }

            internal override string Nome(clnProduto obj)
            {
                return obj.Nome;
            }

            internal override int Cod(clnProduto obj)
            {
                return obj.Cod;
            }

        }

    }
}
