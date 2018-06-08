using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;

namespace BURGUER_SHACK_DESKTOP
{
    class clnIngredienteTipo
    {

        private int _cod;
        private String _nome;

        public int Cod { get => _cod; set => _cod = value; }
        public String Nome { get => _nome; set => _nome = value; }

        private clnIngredienteTipo obter(SqlDataReader reader) => new clnIngredienteTipo
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            Nome = clnUtilConvert.ToString(reader["nome"])
        };

        public clnIngredienteTipo obterPorCodigo()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("ingrediente_tipo");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.select(App.AppDatabase);
            clnIngredienteTipo objTipo = null;
            if (reader.Read())
                objTipo = obter(reader);
            reader.Close();

            return objTipo;
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("ingrediente_tipo");
            objInsert.Insert.val("nome", Nome);

            objInsert.insert(App.AppDatabase);
        }

    }
}
