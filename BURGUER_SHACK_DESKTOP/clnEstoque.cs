using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using SQL_POWERUP;

namespace BURGUER_SHACK_DESKTOP
{
    class clnEstoque
    {

        private int _cod;

        private int _codIngrediente;
        private int _codFornecedor;

        private DateTime _entrada;
        private DateTime _validade;

        private int _total;
        private double _valor;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodIngrediente { get => _codIngrediente; set => _codIngrediente = value; }
        public int CodFornecedor { get => _codFornecedor; set => _codFornecedor = value; }
        public DateTime Entrada { get => _entrada; set => _entrada = value; }
        public DateTime Validade { get => _validade; set => _validade = value; }
        public int Total { get => _total; set => _total = value; }
        public double Valor { get => _valor; set => _valor = value; }
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
            Valor = clnUtilConvert.ToDouble(reader["valor"])
        };

        public int obterQuantidadePorIngrediente()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("estoque");
            objSelect.Columns.select("quantidade");
            objSelect.Where.where("id_ingrediente", CodIngrediente);

            int quantidade = 0;
            SqlDataReader reader = objSelect.execute(App.AppDatabase);
            while (reader.Read())
                quantidade += clnUtilConvert.ToInt(reader["quantidade"]);

            return quantidade;
        }

    }
}
