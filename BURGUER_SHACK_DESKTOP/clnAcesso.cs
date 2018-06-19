using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;

namespace BURGUER_SHACK_DESKTOP
{
    class clnAcesso
    {

        private int _codFuncionario = -1;

        private String _usuario;
        private String _senha;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }

        public int? acessar()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("acesso").Columns.select("id_funcionario");
            objSelect.Where.where("usuario", Usuario).where("senha", Senha);

            int? codFuncionario = null;
            SqlDataReader reader = objSelect.execute(App.AppDatabase);
            if (reader.Read())
                codFuncionario = clnUtilConvert.ToInt(reader["id_funcionario"]);
            reader.Close();

            return codFuncionario;
        }

    }
}
