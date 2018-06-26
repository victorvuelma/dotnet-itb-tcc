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

        private clnAcesso obter(SqlDataReader reader) => new clnAcesso
        {
            CodFuncionario = clnUtilConvert.ToInt(reader["id_funcionario"]),
            Usuario = clnUtilConvert.ToString(reader["usuario"]),
            Senha = clnUtilConvert.ToString(reader["senha"])
        };

        public int? acessar()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("acesso");
            objSelect.Columns.select("id_funcionario");
            objSelect.Where.where("usuario", Usuario)
                           .where("senha", Senha);

            int? codFuncionario = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                codFuncionario = clnUtilConvert.ToInt(reader["id_funcionario"]);
            reader.Close();

            return codFuncionario;
        }

        internal clnAcesso obterPorFuncionario()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("acesso");
            objSelect.Where.where("id_funcionario", CodFuncionario);

            clnAcesso objAcesso = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objAcesso = obter(reader);
            reader.Close();

            return objAcesso;
        }

        public void gravar()
        {
            sqlCommandUpdate objUpdate = new sqlCommandUpdate();
            objUpdate.table("acesso");
            objUpdate.Where.where("id_funcionario", CodFuncionario);
            objUpdate.Set.val("senha", Senha)
                         .val("usuario", Usuario);

            if (objUpdate.execute(App.DatabaseSql) == 0)
            {
                sqlCommandInsert objInsert = new sqlCommandInsert();
                objInsert.table("acesso");
                objInsert.Insert.val("senha", Senha)
                                .val("usuario", Usuario)
                                .val("id_funcionario", CodFuncionario);

                objInsert.execute(App.DatabaseSql);
            }
        }

    }
}
