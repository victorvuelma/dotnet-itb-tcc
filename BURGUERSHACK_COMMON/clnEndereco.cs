using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using SQL_POWERUP;
using Caelum.Stella.CSharp.Http;
using BURGUERSHACK_COMMON.UTIL;

namespace BURGUERSHACK_COMMON
{

    public class clnEndereco
    {

        private string _logradouro;
        private string _complemento;
        private string _bairro;
        private string _localidade;
        private string _uf;
        private string _cep;

        public string Logradouro { get => _logradouro; set => _logradouro = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Localidade { get => _localidade; set => _localidade = value; }
        public string UF { get => _uf; set => _uf = value; }
        public string CEP { get => _cep; set => _cep = value; }

        private clnEndereco obter(SqlDataReader reader)
        {
            return new clnEndereco
            {
                Logradouro = clnUtilConvert.ToString(reader["logradouro"]),
                Complemento = clnUtilConvert.ToString(reader["complemento"]),
                Bairro = clnUtilConvert.ToString(reader["bairro"]),
                Localidade = clnUtilConvert.ToString(reader["localidade"]),
                UF = clnUtilConvert.ToString(reader["uf"])
            };
        }

        public clnEndereco obterPorCep()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("localidade");
            objSelect.Columns.select("logradouro.nome_completo", "logradouro")
                             .select("logradouro.complemento", "complemento")
                             .select("bairro.nome", "bairro")
                             .select("localidade.nome", "localidade")
                             .select("localidade.uf", "uf");
            objSelect.Where.where("localidade.cep", CEP, sqlObjWhere.whereAssociation.OR)
                           .where("logradouro.cep", CEP);
            objSelect.Join.fullJoin("logradouro", "id_localidade", "localidade.id")
                          .fullJoin("bairro", "id", "logradouro.id_bairro");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnEndereco objEndereco = null;
            if (reader.Read())
                objEndereco = obter(reader);
            reader.Close();

            return objEndereco;
        }

        public static clnEndereco Transform(Endereco endereco)
        {
            if (endereco != null)
            {
                return new clnEndereco
                {
                    Bairro = endereco.Bairro,
                    CEP = endereco.CEP,
                    Complemento = endereco.Complemento,
                    Localidade = endereco.Localidade,
                    Logradouro = endereco.Logradouro,
                    UF = endereco.UF
                };
            }
            return null;
        }

    }
}
