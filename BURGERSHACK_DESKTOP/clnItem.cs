﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using vitorrdgs.SqlMaster;
using System.Data.SqlClient;
using BurgerShack.Common.UTIL;
using BurgerShack.Common;
using vitorrdgs.SqlMaster.Command;

namespace BurgerShack.Desktop
{
    public class clnItem
    {

        private int _cod = -1;

        private int _codProduto = -1;
        private int _codPedido = -1;

        private int _quantidade;
        private String _adicional;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public int CodPedido { get => _codPedido; set => _codPedido = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public string Adicional { get => _adicional; set => _adicional = value; }

        private clnItem obter(SqlDataReader reader) => new clnItem
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            CodPedido = clnUtilConvert.ToInt(reader["id_pedido"]),
            CodProduto = clnUtilConvert.ToInt(reader["id_produto"]),
            Adicional = clnUtilConvert.ToString(reader["adicional"]),
            Quantidade = clnUtilConvert.ToInt(reader["quantidade"])
        };

        public List<clnItem> obterPorPedido()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("item");
            objSelect.Where.where("id_pedido", CodPedido);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnItem> objItens = new List<clnItem>();
            while (reader.Read())
                objItens.Add(obter(reader));
            reader.Close();

            return objItens;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("item");
            objInsert.Insert.val("id_pedido", CodPedido)
                            .val("id_produto", CodProduto)
                            .val("adicional", Adicional)
                            .val("quantidade", Quantidade);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("item");
            objUpdate.Set.val("adicional", Adicional)
                         .val("quantidade", Quantidade);
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
        }

        internal void remover()
        {
            throw new NotImplementedException();
        }
    }
}
