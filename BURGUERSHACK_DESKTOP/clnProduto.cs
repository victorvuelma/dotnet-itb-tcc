using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using vitorrdgs.SqlMaster;
using System.Data.SqlClient;
using System.IO;
using BURGERSHACK_COMMON.UTIL;
using BURGERSHACK_COMMON;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element;

namespace BURGERSHACK_DESKTOP
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

        private int _codImagem = -1;
        private int _codTipo = -1;

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
        internal produtoSituacao Situacao { get => _situacao; set => _situacao = value; }

        private clnProduto obter(SqlDataReader reader) => new clnProduto
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            CodImagem = clnUtilConvert.ToInt(reader["id_imagem"]),
            CodTipo = clnUtilConvert.ToInt(reader["id_tipo"]),
            Descricao = clnUtilConvert.ToString(reader["descricao"]),
            Nome = clnUtilConvert.ToString(reader["nome"]),
            Situacao = situacao(clnUtilConvert.ToChar(reader["situacao"])),
            Valor = clnUtilConvert.ToDecimal(reader["valor"])
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
            objSelect.Where.where("id_tipo", CodTipo)
                           .where("situacao", prefixo(Situacao));

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnProduto> objProdutos = new List<clnProduto>();
            while (reader.Read())
                objProdutos.Add(obter(reader));
            reader.Close();

            return objProdutos;
        }


        internal List<clnProduto> obterPorNome()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("produto");
            objSelect.Where.where("nome", sqlElementWhereCommon.whereOperation.LIKE, "%" + Nome + "%");

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
            objInsert.Insert.val("id_imagem", CodImagem)
                            .val("id_tipo", CodTipo)
                            .val("nome", Nome)
                            .val("descricao", Descricao)
                            .val("valor", Valor)
                            .val("situacao", prefixo(Situacao));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("produto");
            objUpdate.Set.val("id_imagem", CodImagem)
                         .val("id_tipo", CodTipo)
                         .val("nome", Nome)
                         .val("descricao", Descricao)
                         .val("valor", Valor)
                         .val("situacao", prefixo(Situacao));
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
        }

        public void atualizarEstoque()
        {
            if (Situacao != clnProduto.produtoSituacao.INDISPONIVEL)
            {
                clnProdutoIngrediente objProdutoIngredientes = new clnProdutoIngrediente
                {
                    CodProduto = Cod
                };

                clnProduto.produtoSituacao situacao = clnProduto.produtoSituacao.DISPONIVEL;

                foreach (clnProdutoIngrediente objProdutoIngrediente in objProdutoIngredientes.obterPorProduto())
                {
                    clnIngrediente objIngrediente = new clnIngrediente
                    {
                        Cod = objProdutoIngrediente.CodIngrediente
                    }.obterPorCod();

                    if (objIngrediente.Situacao == clnIngrediente.ingredienteSituacao.FORADEESTOQUE)
                    {
                        situacao = clnProduto.produtoSituacao.FORADEESTOQUE;
                        break;
                    }
                }
                if (Situacao != situacao)
                {
                    Situacao = situacao;
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
                }.obterPorCodigo();
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
