using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using SQL_POWERUP;

namespace BURGUERSHACK_DESKTOP
{
    public class clnPagamento
    {

        private int _cod = -1;

        private int _codForma = -1;
        private int _codConta = -1;
        private int? _codCliente = null;

        private decimal _valor;
        private DateTime _data;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodForma { get => _codForma; set => _codForma = value; }
        public int CodConta { get => _codConta; set => _codConta = value; }
        public int? CodCliente { get => _codCliente; set => _codCliente = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public DateTime Data { get => _data; set => _data = value; }

        private clnPagamento obter(SqlDataReader reader) => new clnPagamento
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            CodConta = clnUtilConvert.ToInt(reader["id_conta"]),
            CodForma = clnUtilConvert.ToInt(reader["id_forma"]),
            CodCliente = clnUtilConvert.ToNullableInt(reader["id_cliente"]),
            Valor = clnUtilConvert.ToDecimal(reader["valor"]),
            Data = clnUtilConvert.ToDateTime(reader["data"])
        };

        public clnPagamento obterPorCod()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("pagamento");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnPagamento objPagamento = null;
            if (reader.Read())
                objPagamento = obter(reader);
            reader.Close();

            return objPagamento;
        }

        public List<clnPagamento> obterPorConta()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("pagamento");
            objSelect.Where.where("id_conta", CodConta);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnPagamento> objPagamentos = new List<clnPagamento>();
            while (reader.Read())
                objPagamentos.Add(obter(reader));
            reader.Close();

            return objPagamentos;
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("pagamento");
            objInsert.Insert.val("id_conta", CodConta)
                            .val("id_cliente", CodCliente)
                            .val("id_forma", CodForma)
                            .val("valor", Valor)
                            .val("data", Data);

            objInsert.execute(App.DatabaseSql);
        }

    }
} 
