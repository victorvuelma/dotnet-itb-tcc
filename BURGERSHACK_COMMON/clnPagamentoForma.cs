using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Common
{
    public class clnPagamentoForma
    {

        private int _cod;

        private String _nome;
        private String _bandeira;

        private double? _desconto;

        public int Cod { get => _cod; set => _cod = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Bandeira { get => _bandeira; set => _bandeira = value; }
        public double? Desconto { get => _desconto; set => _desconto = value; }

        private clnPagamentoForma obter(SqlDataReader reader) => new clnPagamentoForma
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            Nome = UtilConvert.ToString(reader["nome"]),
            Bandeira = UtilConvert.ToString(reader["bandeira"]),
            Desconto = UtilConvert.ToNullableDouble(reader["desconto"])
        };

        public clnPagamentoForma obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("pagamento_forma");
            objSelect.Where.where("id", Cod);

            clnPagamentoForma objForma = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objForma = obter(reader);
            reader.Close();

            return objForma;
        }

        public List<clnPagamentoForma> obterFormas()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("pagamento_forma");

            List<clnPagamentoForma> objFormas = new List<clnPagamentoForma>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objFormas.Add(obter(reader));
            reader.Close();

            return objFormas;
        }

    }
}
