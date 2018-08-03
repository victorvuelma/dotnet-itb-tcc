using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using vitorrdgs.SqlMaster;
using System.Data.SqlClient;
using BURGERSHACK_COMMON.UTIL;
using BURGERSHACK_COMMON;
using vitorrdgs.SqlMaster.Command;

namespace BURGERSHACK_DESKTOP
{
    class clnCargo 
    {

        private int _cod = -1;

        private String _nome;

        public int Cod { get => _cod; set => _cod = value; }
        public string Nome { get => _nome; set => _nome = value; }

        private clnCargo obter(SqlDataReader reader) => new clnCargo
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            Nome = clnUtilConvert.ToString(reader["nome"])
        };

        public clnCargo obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("cargo");
            objSelect.Where.where("id", Cod);

            clnCargo objCargo = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objCargo = obter(reader);
            reader.Close();

            return objCargo;
        }

        public List<clnCargo> obterCargos()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("cargo");

            List<clnCargo> objCargos = new List<clnCargo>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objCargos.Add(obter(reader));
            reader.Close();

            return objCargos;
        }

    }
}
