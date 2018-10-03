using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element.Where;
using vitorrdgs.Util.Data;

namespace BurgerShack.Common
{
    public class clnIngrediente
    {
        public enum ingredienteSituacao
        {
            DISPONIVEL,
            INDISPONIVEL,
            FORADEESTOQUE
        }

        private int _cod = -1;
        private bool _ativo = true;

        private int _codImagem = -1;
        private int _codMercadoria = -1;
        private int _codTipo = -1;

        private String _nome;
        private decimal _valor;

        private ingredienteSituacao _situacao;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodTipo { get => _codTipo; set => _codTipo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public ingredienteSituacao Situacao { get => _situacao; set => _situacao = value; }
        public int CodImagem { get => _codImagem; set => _codImagem = value; }
        public int CodMercadoria { get => _codMercadoria; set => _codMercadoria = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnIngrediente obter(SqlDataReader reader)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = UtilConvert.ToInt(reader["id"]),
                CodImagem = UtilConvert.ToInt(reader["id_imagem"]),
                CodTipo = UtilConvert.ToInt(reader["id_tipo"]),
                Nome = UtilConvert.ToString(reader["nome"]),
                Valor = UtilConvert.ToDecimal(reader["valor"]),
                Situacao = situacao(UtilConvert.ToChar(reader["situacao"])),
                Ativo = UtilConvert.ToBool(reader["ativo"]),
                CodMercadoria = UtilConvert.ToInt(reader["id_mercadoria"])
            };

            return objIngrediente;
        }

        public clnIngrediente obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("ingrediente");
            objSelect.Where.where("id", Cod);

            clnIngrediente objIngrediente = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objIngrediente = obter(reader);
            reader.Close();

            return objIngrediente;
        }

        public List<clnIngrediente> obterPorTipoSituacao()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("ingrediente");
            objSelect.Where.where("id_tipo", CodTipo)
                           .where("situacao", prefixo(Situacao));

            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objIngredientes.Add(obter(reader));
            reader.Close();

            return objIngredientes;
        }

        public List<clnIngrediente> obterIngredientes()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("ingrediente");

            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objIngredientes.Add(obter(reader));
            reader.Close();

            return objIngredientes;
        }


        public List<clnIngrediente> obterPorNome()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("ingrediente");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("nome", sqlElementWhereCommon.whereOperation.LIKE, "%" + Nome + "%");

            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objIngredientes.Add(obter(reader));
            reader.Close();

            return objIngredientes;
        }

        internal List<clnIngrediente> obterPorMercadoria()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("ingrediente");
            objSelect.Where.where("id_mercadoria", CodMercadoria);

            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objIngredientes.Add(obter(reader));
            reader.Close();

            return objIngredientes;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("ingrediente");
            objInsert.Value.val("id_tipo", CodTipo)
                            .val("id_imagem", CodImagem)
                            .val("nome", Nome)
                            .val("valor", Valor)
                            .val("id_mercadoria", CodMercadoria)
                            .val("situacao", prefixo(Situacao))
                            .val("ativo", UtilConvert.ToBit(Ativo));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);

            atualizarEstoque(true);
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("ingrediente");
            objUpdate.Value.val("id_tipo", CodTipo)
                        .val("id_imagem", CodImagem)
                        .val("nome", Nome)
                        .val("valor", Valor)
                        .val("id_mercadoria", CodMercadoria)
                        .val("situacao", prefixo(Situacao))
                        .val("ativo", UtilConvert.ToBit(Ativo));
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
        }

        public void atualizarEstoque(bool produtos)
        {
            int estoqueAtual = new clnEstoque
            {
                CodMercadoria = CodMercadoria
            }.obterQuantidadePorMercadoria();

            if (Situacao != clnIngrediente.ingredienteSituacao.INDISPONIVEL)
            {
                if (estoqueAtual > 0)
                {
                    Situacao = clnIngrediente.ingredienteSituacao.DISPONIVEL;
                }
                else
                {
                    Situacao = clnIngrediente.ingredienteSituacao.FORADEESTOQUE;
                }
            }
            alterar();

            if (produtos)
            {
                clnProdutoIngrediente objProdutos = new clnProdutoIngrediente
                {
                    CodIngrediente = Cod
                };
                foreach (clnProdutoIngrediente objProdutoIngrediente in objProdutos.obterPorIngrediente())
                {
                    clnProduto objProduto = new clnProduto
                    {
                        Cod = objProdutoIngrediente.CodProduto
                    }.obterPorCod();

                    if (objProduto != null)
                    {
                        objProduto.atualizarEstoque();
                    }
                }
            }
        }

        private ingredienteSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'D':
                    return ingredienteSituacao.DISPONIVEL;
                case 'E':
                    return ingredienteSituacao.FORADEESTOQUE;
                default:
                    return ingredienteSituacao.INDISPONIVEL;
            }
        }

        private char prefixo(ingredienteSituacao situacao)
        {
            switch (situacao)
            {
                case ingredienteSituacao.DISPONIVEL:
                    return 'D';
                case ingredienteSituacao.FORADEESTOQUE:
                    return 'E';
                default:
                    return 'I';
            }
        }

        public class clnListar : clnUtilListar<clnIngrediente>
        {

            internal override int Cod(clnIngrediente obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnIngrediente obj)
            {
                string detalhes = "";
                detalhes += "Valor: " + obj.Valor;

                return detalhes;
            }

            internal override string Imagem(clnIngrediente obj)
            {
                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = obj.CodImagem
                }.obterPorCod();
                return objArquivo.Local;
            }

            internal override string Nome(clnIngrediente obj)
            {
                return obj.Nome;
            }
        }

    }
}
