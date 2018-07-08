using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;
using BURGUERSHACK_COMMON.UTIL;
using BURGUERSHACK_COMMON;

namespace BURGUERSHACK_DESKTOP
{
    class clnTipo
    {

        public enum tipo
        {
            PRODUTO,
            INGREDIENTE
        }

        private int _cod = -1;

        private String _nome;
        private tipo _tipo;

        public int Cod { get => _cod; set => _cod = value; }
        public String Nome { get => _nome; set => _nome = value; }
        internal tipo Tipo { get => _tipo; set => _tipo = value; }

        private clnTipo obter(SqlDataReader reader) => new clnTipo
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            Nome = clnUtilConvert.ToString(reader["nome"]),
            Tipo = Tipo
        };

        public clnTipo obterPorCodigo()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table(Tipo.ToString() + "_tipo");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnTipo objTipo = null;
            if (reader.Read())
                objTipo = obter(reader);
            reader.Close();

            return objTipo;
        }

        public List<clnTipo> obterTipos()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table(Tipo.ToString() + "_tipo");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnTipo> objTipos = new List<clnTipo>();
            while (reader.Read())
                objTipos.Add(obter(reader));
            reader.Close();

            return objTipos;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table(Tipo.ToString() + "_tipo");
            objInsert.Insert.val("nome", Nome);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        internal void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table(Tipo.ToString() + "_tipo");
            objUpdate.Set.val("nome", Nome);
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
        }
    }
}
