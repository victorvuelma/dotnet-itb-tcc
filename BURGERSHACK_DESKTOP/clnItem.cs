using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public class clnItem
    {

        public enum itemSituacao
        {
            CANCELADO,
            REALIZADO,
            PREPARO,
            PRONTO
        }

        private int _cod = -1;

        private int _codProduto = -1;
        private int _codPedido = -1;

        private itemSituacao _situacao;

        private int _quantidade;
        private String _adicional;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public int CodPedido { get => _codPedido; set => _codPedido = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public string Adicional { get => _adicional; set => _adicional = value; }
        public itemSituacao Situacao { get => _situacao; set => _situacao = value; }

        private clnItem obter(SqlDataReader reader) => new clnItem
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodPedido = UtilConvert.ToInt(reader["id_pedido"]),
            CodProduto = UtilConvert.ToInt(reader["id_produto"]),
            Adicional = UtilConvert.ToString(reader["adicional"]),
            Quantidade = UtilConvert.ToInt(reader["quantidade"]),
            Situacao = situacao(UtilConvert.ToChar(reader["situacao"]))
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
            objInsert.Value.val("id_pedido", CodPedido)
                            .val("id_produto", CodProduto)
                            .val("adicional", Adicional)
                            .val("quantidade", Quantidade)
                            .val("situacao", prefixo(Situacao));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("item");
            objUpdate.Value.val("adicional", Adicional)
                         .val("quantidade", Quantidade)
                         .val("situacao", prefixo(Situacao));
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
        }

        internal void remover()
        {
            throw new NotImplementedException();
        }

        public char prefixo(itemSituacao situacao)
        {
            switch (situacao)
            {
                case itemSituacao.CANCELADO:
                    return 'C';
                case itemSituacao.PREPARO:
                    return 'E';
                case itemSituacao.REALIZADO:
                    return 'R';
            }
            return 'P';
        }

        public itemSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'C':
                    return itemSituacao.CANCELADO;
                case 'E':
                    return itemSituacao.PREPARO;
                case 'R':
                    return itemSituacao.REALIZADO;
            }
            return itemSituacao.PRONTO;
        }

    }
}
