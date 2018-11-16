using Caelum.Stella.CSharp.Http;
using System;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element.Where;
using vitorrdgs.Util.Data;

namespace BurgerShack.Common
{

    public class Endereco
    {

        private static ViaCEP ViaCEP = new ViaCEP();

        public static Endereco obterEndereco(String cep)
        {
            try
            {
                Endereco objEndereco = new Endereco
                {
                    CEP = UtilFormatar.retirarFormatacao(cep)
                }.obterPorCep();

                if (objEndereco != null)
                    return objEndereco;
            }
            catch (Exception)
            {
            }
            try
            {
                return Endereco.Transform(ViaCEP.GetEndereco(cep));
            }
            catch (Exception)
            {
                return null;
            }
        }

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

        private Endereco obter(SqlDataReader reader)
        {
            return new Endereco
            {
                Logradouro = UtilConvert.ToString(reader["logradouro"]),
                Complemento = UtilConvert.ToString(reader["complemento"]),
                Bairro = UtilConvert.ToString(reader["bairro"]),
                Localidade = UtilConvert.ToString(reader["localidade"]),
                UF = UtilConvert.ToString(reader["uf"])
            };
        }

        public Endereco obterPorCep()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("endereco_localidade");
            objSelect.Columns.select("endereco_logradouro.nome_completo", "logradouro")
                             .select("endereco_logradouro.complemento", "complemento")
                             .select("endereco_bairro.nome", "bairro")
                             .select("endereco_localidade.nome", "localidade")
                             .select("endereco_localidade.uf", "uf");
            objSelect.Where.where("endereco_localidade.cep", CEP, sqlElementWhere.whereAssociation.OR)
                           .where("endereco_logradouro.cep", CEP);
            objSelect.Join.fullJoin("endereco_logradouro", "id_localidade", "endereco_localidade.id")
                          .fullJoin("endereco_bairro", "id", "endereco_logradouro.id_bairro");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            Endereco objEndereco = null;
            if (reader.Read())
                objEndereco = obter(reader);
            reader.Close();

            return objEndereco;
        }

        public static Endereco Transform(Caelum.Stella.CSharp.Http.Endereco endereco)
        {
            if (endereco != null)
            {
                return new Endereco
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
