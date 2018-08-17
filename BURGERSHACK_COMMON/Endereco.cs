using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using vitorrdgs.SqlMaster;
using Caelum.Stella.CSharp.Http;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element;
using vitorrdgs.Util.Data;
using vitorrdgs.SqlMaster.Element.Where;

namespace BurgerShack.Common
{

    public class Endereco
    {


        private static ViaCEP ViaCEP = new ViaCEP();

        public static Endereco obterEndereco(String cep)
        {
            Endereco objEndereco = new Endereco
            {
                CEP = UtilFormatar.retirarFormatacao(cep)
            }.obterPorCep();
            if (objEndereco == null)
            {
                try
                {
                    return Endereco.Transform(ViaCEP.GetEndereco(cep));
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return objEndereco;
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
            objSelect.table("localidade");
            objSelect.Columns.select("logradouro.nome_completo", "logradouro")
                             .select("logradouro.complemento", "complemento")
                             .select("bairro.nome", "bairro")
                             .select("localidade.nome", "localidade")
                             .select("localidade.uf", "uf");
            objSelect.Where.where("localidade.cep", CEP, sqlElementWhere.whereAssociation.OR)
                           .where("logradouro.cep", CEP);
            objSelect.Join.fullJoin("logradouro", "id_localidade", "localidade.id")
                          .fullJoin("bairro", "id", "logradouro.id_bairro");

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
