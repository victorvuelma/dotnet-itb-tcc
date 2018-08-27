using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public class clnPagamento
    {

        private int _cod = -1;

        private int _codForma = -1;
        private int _codConta = -1;
        private int? _codCliente = null;

        private string _cpf;

        private decimal _valor;
        private DateTime _data;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodForma { get => _codForma; set => _codForma = value; }
        public int CodConta { get => _codConta; set => _codConta = value; }
        public int? CodCliente { get => _codCliente; set => _codCliente = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }

        private clnPagamento obter(SqlDataReader reader) => new clnPagamento
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodConta = UtilConvert.ToInt(reader["id_conta"]),
            CodForma = UtilConvert.ToInt(reader["id_forma"]),
            CodCliente = UtilConvert.ToNullableInt(reader["id_cliente"]),
            Valor = UtilConvert.ToDecimal(reader["valor"]),
            Data = UtilConvert.ToDateTime(reader["data"]),
            Cpf = UtilConvert.ToString(reader["cpf"])
        };

        public clnPagamento obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
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
            sqlSelect objSelect = new sqlSelect();
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
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("pagamento");
            objInsert.Value.val("id_conta", CodConta)
                            .val("id_cliente", CodCliente)
                            .val("id_forma", CodForma)
                            .val("valor", Valor)
                            .val("data", Data)
                            .val("cpf", Cpf);

            objInsert.execute(App.DatabaseSql);
        }

        internal IEnumerable<clnPagamento> obterPagamentosPorCpf()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("pagamento");
            objSelect.Where.where("cpf", "%" + Cpf + "%");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnPagamento> objPagamentos = new List<clnPagamento>();
            while (reader.Read())
                objPagamentos.Add(obter(reader));
            reader.Close();

            return objPagamentos;
        }
    }
}
