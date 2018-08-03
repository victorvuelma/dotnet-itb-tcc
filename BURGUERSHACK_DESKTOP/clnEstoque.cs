﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using vitorrdgs.SqlMaster;
using BURGERSHACK_COMMON.UTIL;
using BURGERSHACK_COMMON;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element;

namespace BURGERSHACK_DESKTOP
{
    public class clnEstoque
    {

        private int _cod = -1;

        private int _codIngrediente;
        private int _codFornecedor;

        private DateTime _entrada;
        private DateTime _validade;

        private int _total;
        private decimal _valor;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodIngrediente { get => _codIngrediente; set => _codIngrediente = value; }
        public int CodFornecedor { get => _codFornecedor; set => _codFornecedor = value; }
        public DateTime Entrada { get => _entrada; set => _entrada = value; }
        public DateTime Validade { get => _validade; set => _validade = value; }
        public int Total { get => _total; set => _total = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        private clnEstoque obter(SqlDataReader reader) => new clnEstoque
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            CodFornecedor = clnUtilConvert.ToInt(reader["id_fornecedor"]),
            CodIngrediente = clnUtilConvert.ToInt(reader["id_ingrediente"]),
            Entrada = clnUtilConvert.ToDateTime(reader["entrada"]),
            Validade = clnUtilConvert.ToDateTime(reader["validade"]),
            Quantidade = clnUtilConvert.ToInt(reader["quantidade"]),
            Total = clnUtilConvert.ToInt(reader["total"]),
            Valor = clnUtilConvert.ToDecimal(reader["valor"])
        };

        public clnEstoque obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("estoque");
            objSelect.Where.where("id", Cod);

            clnEstoque objEstoque = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objEstoque = obter(reader);
            reader.Close();

            return objEstoque;
        }

        public List<clnEstoque> obterEstoques()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("estoque");

            List<clnEstoque> objEstoques = new List<clnEstoque>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objEstoques.Add(obter(reader));
            reader.Close();

            return objEstoques;
        }

        public int obterQuantidadePorIngrediente()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("estoque");
            objSelect.Columns.select("quantidade", sqlElementTable.selectOperation.SUM, "quantidade", 0);
            objSelect.Where.where("id_ingrediente", CodIngrediente);

            int quantidade = 0;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                quantidade = clnUtilConvert.ToInt(reader["quantidade"]);
            reader.Close();

            return quantidade;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("estoque");
            objInsert.Insert.val("id_ingrediente", CodIngrediente)
                            .val("id_fornecedor", CodFornecedor)
                            .val("entrada", Entrada)
                            .val("validade", Validade)
                            .val("quantidade", Quantidade)
                            .val("total", Total)
                            .val("valor", Valor);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);

            atualizarIngrediente();
        }

        public void alterar()
        {
            sqlUpdate objInsert = new sqlUpdate();
            objInsert.table("estoque");
            objInsert.Where.where("id", Cod);
            objInsert.Set.val("quantidade", Quantidade);

            objInsert.execute(App.DatabaseSql);

            atualizarIngrediente();
        }

        public void atualizarIngrediente()
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = CodIngrediente
            }.obterPorCod();

            if (objIngrediente != null)
            {
                objIngrediente.atualizarEstoque(true);
            }
        }

    }
}
