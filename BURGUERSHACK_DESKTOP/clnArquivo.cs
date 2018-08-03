using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using vitorrdgs.SqlMaster;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using BURGERSHACK_COMMON.UTIL;
using BURGERSHACK_COMMON;
using vitorrdgs.SqlMaster.Command;

namespace BURGERSHACK_DESKTOP
{
    class clnArquivo
    {

        public static clnUtilCache CACHE = new clnUtilCache("arquivo");

        private int _cod = -1;

        private String _local;

        public int Cod { get => _cod; set => _cod = value; }
        public String Local { get => _local; set => _local = value; }

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
                return new clnArquivo { Cod = Cod, Local = arquivo };
            }
            else
            {
                sqlSelect objSelect = new sqlSelect();
                objSelect.table("arquivo");
                objSelect.Where.where("id", Cod);

                SqlDataReader reader = objSelect.execute(App.DatabaseSql);

                if (reader.Read())
                {
                    arquivo = CACHE.guardar(Convert.ToString(Cod), (byte[])reader["conteudo"]);
                    return new clnArquivo { Cod = Cod, Local = arquivo };
                }

                return new clnArquivo { Cod = Cod, Local = "" };
            }
        }

        public void gravar()
        {
            byte[] conteudo = File.ReadAllBytes(Local);

            sqlInsert objInsert = new sqlInsert();
            objInsert.table("arquivo");
            objInsert.Insert.val("conteudo", conteudo);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);

            CACHE.guardar(Convert.ToString(Cod), conteudo);
        }
    }
}
