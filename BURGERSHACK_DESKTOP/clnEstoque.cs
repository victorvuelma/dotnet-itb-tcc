using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using vitorrdgs.SqlMaster;

using BurgerShack.Common;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public class clnEstoque
    {

        private int _cod = -1;

        private int _codMercadoria;
        private int _codFornecedor;

        private DateTime _entrada;
        private DateTime _validade;

        private int _total;
        private decimal _valor;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodMercadoria { get => _codMercadoria; set => _codMercadoria = value; }
        public int CodFornecedor { get => _codFornecedor; set => _codFornecedor = value; }
        public DateTime Entrada { get => _entrada; set => _entrada = value; }
        public DateTime Validade { get => _validade; set => _validade = value; }
        public int Total { get => _total; set => _total = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        private clnEstoque obter(SqlDataReader reader) => new clnEstoque
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodFornecedor = UtilConvert.ToInt(reader["id_fornecedor"]),
            CodMercadoria = UtilConvert.ToInt(reader["id_mercadoria"]),
            Entrada = UtilConvert.ToDateTime(reader["entrada"]),
            Validade = UtilConvert.ToDateTime(reader["validade"]),
            Quantidade = UtilConvert.ToInt(reader["quantidade"]),
            Total = UtilConvert.ToInt(reader["total"]),
            Valor = UtilConvert.ToDecimal(reader["valor"])
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

        public int obterQuantidadePorMercadoria()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("estoque");
            objSelect.Columns.select("quantidade", sqlElementTable.selectOperation.SUM, "quantidade", 0);
            objSelect.Where.where("id_mercadoria", CodMercadoria);

            int quantidade = 0;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                quantidade = UtilConvert.ToInt(reader["quantidade"]);
            reader.Close();

            return quantidade;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("estoque");
            objInsert.Insert.val("id_mercadoria", CodMercadoria)
                            .val("id_fornecedor", CodFornecedor)
                            .val("entrada", Entrada)
                            .val("validade", Validade)
                            .val("quantidade", Quantidade)
                            .val("total", Total)
                            .val("valor", Valor);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);

            atualizarIngredientes();
        }

        public void alterar()
        {
            sqlUpdate objInsert = new sqlUpdate();
            objInsert.table("estoque");
            objInsert.Where.where("id", Cod);
            objInsert.Set.val("quantidade", Quantidade);

            objInsert.execute(App.DatabaseSql);

            atualizarIngredientes();
            atualizarProdutos();
        }

        public void atualizarIngredientes()
        {
            List<clnIngrediente> objIngredientes = new clnIngrediente
            {
                CodMercadoria = CodMercadoria
            }.obterPorMercadoria();

            foreach(clnIngrediente objIngrediente in objIngredientes)
            {
                objIngrediente.atualizarEstoque(true);
            }
        }

        public void atualizarProdutos()
        {
            List<clnProduto> objProdutos = new clnProduto
            {
                CodMercadoria = CodMercadoria
            }.obterPorMercadoria();

            foreach (clnProduto objProduto in objProdutos)
            {
                objProduto.atualizarEstoque();
            }
        }

    }
}
