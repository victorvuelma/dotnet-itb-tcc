using BurgerShack.Common;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Common
{
    public class clnArquivo
    {

        public static UtilCache CACHE = new UtilCache("arquivo");

        private int _cod = -1;

        private String _local;

        public int Cod { get => _cod; set => _cod = value; }
        public String Local { get => _local; set => _local = value; }

        private static int tempId = 0;

        public static String tempImage(Image img)
        {
            byte[] conteudo = null;
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                conteudo = ms.ToArray();
                ms.Close();
            }
            return CACHE.guardar("tempimage" + tempId++, conteudo);

        }

        public clnArquivo obterPorCod()
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
                    reader.Close();
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
            objInsert.Value.val("conteudo", conteudo);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);

            CACHE.guardar(Convert.ToString(Cod), conteudo);
        }
    }
}
