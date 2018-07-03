using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using SQL_POWERUP;

namespace BURGUERSHACK_COMMON
{
    /*
     *SELECT  LOGRADOURO.NOME_COMPLETO AS LOGRADOURO, LOGRADOURO.COMPLEMENTO, BAIRRO.NOME AS BAIRRO, 
		LOCALIDADE.NOME AS LOCALIDADE, LOCALIDADE.UF AS UF FROM LOCALIDADE
FULL JOIN LOGRADOURO ON LOGRADOURO.ID_LOCALIDADE = LOCALIDADE.ID
FULL JOIN BAIRRO ON LOGRADOURO.ID_BAIRRO = BAIRRO.ID
WHERE LOCALIDADE.CEP = '69945000' OR LOGRADOURO.CEP = '69945000';
     * 
     */


    class clnEndereco
    {

        private string _logradouro;
        private string _complemento;
        private string _bairro;
        private string _localidade;
        private string _uf;

        public string Logradouro { get => _logradouro; set => _logradouro = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Localidade { get => _localidade; set => _localidade = value; }
        public string Uf { get => _uf; set => _uf = value; }

        private clnEndereco obter(SqlDataReader reader)
        {
            return new clnEndereco
            {

            };
        }

    }
}
