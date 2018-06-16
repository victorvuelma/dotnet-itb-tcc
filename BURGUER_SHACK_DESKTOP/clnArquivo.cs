using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class clnArquivo
    {

        private static clnUtilCache CACHE = new clnUtilCache("arquivo");

        private int _cod;
        private String _arquivo;

        public int Cod { get => _cod; set => _cod = value; }
        public String Arquivo { get => _arquivo; set => _arquivo = value; }

        private static int tempId = 0;

        public static String tempImage(Image img)
        {
            byte[] conteudo = null;
            using(var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                conteudo = ms.ToArray();
                ms.Close();
            }
            return CACHE.guardar("tempimage" + tempId++, conteudo);
            
        }

        public clnArquivo obterPorCodigo()
        {
            string arquivo = CACHE.obter(Convert.ToString(Cod));
            if (arquivo != null)
            {
                return new clnArquivo { Cod = Cod, Arquivo = arquivo };
            }
            else
            {
                sqlCommandSelect objSelect = new sqlCommandSelect();
                objSelect.table("arquivo");
                objSelect.Where.where("id", Cod);

                SqlDataReader reader = objSelect.select(App.AppDatabase);

                if (reader.Read())
                {
                    arquivo = CACHE.guardar(Convert.ToString(Cod), (byte[])reader["conteudo"]);
                    return new clnArquivo { Cod = Cod, Arquivo = arquivo };
                }

                return new clnArquivo { Cod = Cod, Arquivo = "" };
            }
        }

        public void gravar()
        {
            byte[] conteudo = File.ReadAllBytes(Arquivo);

            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("arquivo");
            objInsert.Insert.val("conteudo", conteudo);

            Cod = objInsert.insertWithOutput(App.AppDatabase);

            CACHE.guardar(Convert.ToString(Cod), conteudo);
        }
    }
}
