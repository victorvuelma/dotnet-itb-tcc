using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtilCache
    {

        private static String CACHE = Application.StartupPath + @"\cache\";

        private String PASTA;

        public clnUtilCache(String prefix)
        {
            PASTA = CACHE + prefix + @"\";
            Directory.CreateDirectory(PASTA);

            foreach (string arquivo in Directory.GetFiles(PASTA))
            {
                File.Delete(arquivo);
            }
        }

        public string guardar(String cod, byte[] conteudo)
        {
            String arquivo = PASTA + cod + ".temp";
            File.WriteAllBytes(arquivo, conteudo);
            return arquivo;
        }

        public string guardar(String cod, String conteudo)
        {
            String arquivo = PASTA + cod + ".temp";
            File.WriteAllText(arquivo, conteudo);
            return arquivo;
        }

        public string obter(String cod)
        {
            String arquivo = PASTA + cod + ".temp";
            if (File.Exists(arquivo))
                return arquivo;
            return null;
        }
    }
}
