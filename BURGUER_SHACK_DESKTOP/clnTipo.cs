using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;

namespace BURGUER_SHACK_DESKTOP
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
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table(Tipo.ToString() + "_tipo");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.AppDatabase);
            clnTipo objTipo = null;
            if (reader.Read())
                objTipo = obter(reader);
            reader.Close();

            return objTipo;
        }

        public List<clnTipo> obter()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table(Tipo.ToString() + "_tipo");

            SqlDataReader reader = objSelect.execute(App.AppDatabase);
            List<clnTipo> objTipos = new List<clnTipo>();
            while (reader.Read())
                objTipos.Add(obter(reader));
            reader.Close();

            return objTipos;
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table(Tipo.ToString() + "_tipo");
            objInsert.Insert.val("nome", Nome);

            Cod = objInsert.executeWithOutput(App.AppDatabase);
        }

        internal void alterar()
        {
            sqlCommandUpdate objUpdate = new sqlCommandUpdate();
            objUpdate.table(Tipo.ToString() + "_tipo");
            objUpdate.Set.val("nome", Nome);
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.AppDatabase);
        }
    }
}
