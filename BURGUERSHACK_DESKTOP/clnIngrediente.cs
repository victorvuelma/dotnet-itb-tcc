﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using SQL_POWERUP;
using System.Data.SqlClient;
using System.IO;
using BURGUERSHACK_COMMON;

namespace BURGUERSHACK_DESKTOP
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

        private int _codImagem = -1;
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

        private clnIngrediente obter(SqlDataReader reader)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = clnUtilConvert.ToInt(reader["id"]),
                CodImagem = clnUtilConvert.ToInt(reader["id_imagem"]),
                CodTipo = clnUtilConvert.ToInt(reader["id_tipo"]),
                Nome = clnUtilConvert.ToString(reader["nome"]),
                Valor = clnUtilConvert.ToDecimal(reader["valor"]),
                Situacao = situacao(clnUtilConvert.ToChar(reader["situacao"])),
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

        internal List<clnIngrediente> obterIngredientes()
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


        internal List<clnIngrediente> obterPorNome()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("ingrediente");
            objSelect.Where.where("nome", sqlObjWhereCommon.whereOperation.LIKE, "%" + Nome + "%");

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
            objInsert.Insert.val("id_tipo", CodTipo)
                            .val("id_imagem", CodImagem)
                            .val("nome", Nome)
                            .val("valor", Valor)
                            .val("situacao", prefixo(Situacao));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        internal void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("ingrediente");
            objUpdate.Set.val("id_tipo", CodTipo)
                        .val("id_imagem", CodImagem)
                        .val("nome", Nome)
                        .val("valor", Valor)
                        .val("situacao", prefixo(Situacao));
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
        }

        public void atualizarEstoque(bool produtos)
        {
            int estoqueAtual = new clnEstoque
            {
                CodIngrediente = Cod
            }.obterQuantidadePorIngrediente();

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
                }.obterPorCodigo();
                return objArquivo.Local;
            }

            internal override string Nome(clnIngrediente obj)
            {
                return obj.Nome;
            }
        }

    }
}