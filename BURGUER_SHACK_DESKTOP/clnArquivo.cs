using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    class clnArquivo
    {

        private int _cod;

        private String _arquivo;

        public int Cod { get => _cod; set => _cod = value; }
        public String Arquivo { get => _arquivo; set => _arquivo = value; }

        public FileStream obterPorCodigo()
        {
            String path = Application.StartupPath + "/arquivos/arquivo-" + Cod + ".temp";

            if (File.Exists(path))
            {
                return File.Open(path, FileMode.Open);
            }
            else
            {
                sqlCommandSelect objSelect = new sqlCommandSelect();
                objSelect.table("arquivos");
                objSelect.Where.where("id", Cod);

                SqlDataReader reader = objSelect.select(App.AppDatabase);

                if (reader.Read())
                {
                    clnArquivo objArquivo = new clnArquivo();
                    objArquivo.Cod = clnUtilConvert.ToInt(reader["id"]);

                    File.WriteAllBytes(path, (byte[])reader["conteudo"]);
                    reader.Close();

                    return File.Open(path, FileMode.Open);
                }
            }

            return null;
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("arquivo");
            objInsert.Insert.val("conteudo", File.ReadAllBytes(Arquivo));

            objInsert.insert(App.AppDatabase);
        }
    }
}
