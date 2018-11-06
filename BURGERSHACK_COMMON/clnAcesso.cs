using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Hash;

namespace BurgerShack.Common
{
    public class clnAcesso
    {

        private int _codFuncionario = -1;
        private bool _ativo = true;

        private String _usuario;
        private String _senha;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { private get => Hash.HASH.cyph(_senha); set => _senha = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnAcesso obter(SqlDataReader reader) => new clnAcesso
        {
            CodFuncionario = UtilConvert.ToInt(reader["id_funcionario"]),
            Usuario = UtilConvert.ToString(reader["usuario"]),
            Ativo = UtilConvert.ToBool(reader["ativo"])
        };

        public int? autenticarPorUsuario()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("acesso");
            objSelect.Columns.select("id_funcionario");
            objSelect.Where.where("usuario", vitorrdgs.SqlMaster.Element.Where.sqlElementWhereCommon.whereOperation.EQUALS, Usuario)
                           .where("hash", vitorrdgs.SqlMaster.Element.Where.sqlElementWhereCommon.whereOperation.EQUALS, Senha)
                           .where("ativo", UtilConvert.ToBit(Ativo));

            int? codFuncionario = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                codFuncionario = UtilConvert.ToInt(reader["id_funcionario"]);
            reader.Close();

            return codFuncionario;
        }

        public string autenticarPorCodigo()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("acesso");
            objSelect.Columns.select("usuario");
            objSelect.Where.where("id_funcionario", CodFuncionario)
                           .where("hash", vitorrdgs.SqlMaster.Element.Where.sqlElementWhereCommon.whereOperation.EQUALS, Senha)
                           .where("ativo", UtilConvert.ToBit(Ativo));

            string usuario = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                usuario = UtilConvert.ToString(reader["usuario"]);
            reader.Close();

            return usuario;
        }

        public clnAcesso obterPorUsuario()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("acesso");
            objSelect.Where.where("usuario", Usuario);

            clnAcesso objAcesso = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objAcesso = obter(reader);
            reader.Close();

            return objAcesso;
        }

        public clnAcesso obterPorFuncionario()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("acesso");
            objSelect.Where.where("id_funcionario", CodFuncionario);

            clnAcesso objAcesso = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objAcesso = obter(reader);
            reader.Close();

            return objAcesso;
        }

        public List<clnAcesso> obterTodos()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("acesso");

            List<clnAcesso> objAcessos = new List<clnAcesso>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objAcessos.Add(obter(reader));
            reader.Close();

            return objAcessos;
        }

        public void gravar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("acesso");
            objUpdate.Where.where("id_funcionario", CodFuncionario);
            objUpdate.Value.val("hash", Senha)
                           .val("usuario", Usuario)
                           .val("ativo", UtilConvert.ToBit(Ativo));

            if (objUpdate.execute(App.DatabaseSql) == 0)
            {
                sqlInsert objInsert = new sqlInsert();
                objInsert.table("acesso");
                objInsert.Value.val("hash", Senha)
                               .val("usuario", Usuario)
                               .val("id_funcionario", CodFuncionario)
                               .val("ativo", UtilConvert.ToBit(Ativo));

                objInsert.execute(App.DatabaseSql);
            }
        }

        public void alterarEstado()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("acesso");
            objUpdate.Where.where("id_funcionario", CodFuncionario);
            objUpdate.Value.val("ativo", UtilConvert.ToBit(Ativo));

            objUpdate.execute(App.DatabaseSql);
        }

    }
}
