using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.Util.Data
{
    public class UtilCache
    {

        private static String CACHE_DIR = AppDomain.CurrentDomain.BaseDirectory + @"cache\";

        private String _dir;

        public UtilCache(String prefix)
        {
            DIR = CACHE_DIR + prefix + @"\";
            Directory.CreateDirectory(DIR);

            foreach (string arquivo in Directory.GetFiles(DIR))
            {
                File.Delete(arquivo);
            }
        }

        public string DIR { get => _dir; set => _dir = value; }

        public string guardar(String cod, byte[] conteudo)
        {
            String arquivo = DIR + cod + ".temp";
            File.WriteAllBytes(arquivo, conteudo);
            return arquivo;
        }

        public string guardar(String cod, String conteudo)
        {
            String arquivo = DIR + cod + ".temp";
            File.WriteAllText(arquivo, conteudo);
            return arquivo;
        }

        public string obter(String cod)
        {
            String arquivo = DIR + cod + ".temp";
            if (File.Exists(arquivo))
                return arquivo;
            return null;
        }
    }
}
