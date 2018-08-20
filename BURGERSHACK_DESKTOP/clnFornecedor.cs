using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element.Where;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    class clnFornecedor
    {

        private int _cod;
        private bool _ativo = true;

        private string _razaoSocial;
        private string _cnpj;

        private string _email;
        private string _telefone;

        private String _endLogradouro;
        private String _endNumero;
        private String _endComplemento;
        private String _endCEP;
        private String _endBairro;
        private String _endLocalidade;
        private String _endUF;

        public int Cod { get => _cod; set => _cod = value; }
        public string RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string EndLogradouro { get => _endLogradouro; set => _endLogradouro = value; }
        public string EndNumero { get => _endNumero; set => _endNumero = value; }
        public string EndComplemento { get => _endComplemento; set => _endComplemento = value; }
        public string EndCEP { get => _endCEP; set => _endCEP = value; }
        public string EndBairro { get => _endBairro; set => _endBairro = value; }
        public string EndLocalidade { get => _endLocalidade; set => _endLocalidade = value; }
        public string EndUF { get => _endUF; set => _endUF = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnFornecedor obter(SqlDataReader reader) => new clnFornecedor
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            RazaoSocial = UtilConvert.ToString(reader["razao_social"]),
            Email = UtilConvert.ToString(reader["email"]),
            Cnpj = UtilConvert.ToString(reader["cnpj"]),
            Telefone = UtilConvert.ToString(reader["telefone"]),
            EndLogradouro = UtilConvert.ToString(reader["end_logradouro"]),
            EndNumero = UtilConvert.ToString(reader["end_nr"]),
            EndComplemento = UtilConvert.ToString(reader["end_complemento"]),
            EndCEP = UtilConvert.ToString(reader["end_cep"]),
            EndBairro = UtilConvert.ToString(reader["end_bairro"]),
            EndLocalidade = UtilConvert.ToString(reader["end_localidade"]),
            EndUF = UtilConvert.ToString(reader["end_uf"]),
            Ativo = UtilConvert.ToBool(reader["ativo"])
        };

        public clnFornecedor obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("fornecedor");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnFornecedor objFornecedor = null;
            if (reader.Read())
                objFornecedor = obter(reader);
            reader.Close();

            return objFornecedor;
        }

        public clnFornecedor obterPorCNPJ()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("fornecedor");
            objSelect.Where.where("cnpj", Cnpj);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnFornecedor objFornecedor = null;
            if (reader.Read())
                objFornecedor = obter(reader);
            reader.Close();

            return objFornecedor;
        }

        public List<clnFornecedor> obterPorRazaoCNPJ()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("fornecedor");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("cnpj", sqlElementWhereCommon.whereOperation.LIKE, "%" + Cnpj + "%", sqlElementWhere.whereAssociation.OR)
                           .where("razao_social", sqlElementWhereCommon.whereOperation.LIKE, "%" + RazaoSocial + "%");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnFornecedor> objFornecedor = new List<clnFornecedor>();
            while (reader.Read())
                objFornecedor.Add(obter(reader));
            reader.Close();

            return objFornecedor;
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("fornecedor");
            objUpdate.Where.where("id", Cod);
            objUpdate.Value.val("razao_social", RazaoSocial)
                         .val("email", Email)
                         .val("telefone", Telefone)
                         .val("ativo", UtilConvert.ToBit(Ativo))
                         .val("end_logradouro", EndLogradouro)
                         .val("end_nr", EndNumero)
                         .val("end_complemento", EndComplemento)
                         .val("end_cep", EndCEP)
                         .val("end_bairro", EndBairro)
                         .val("end_localidade", EndLocalidade)
                         .val("end_uf", EndUF);

            objUpdate.execute(App.DatabaseSql);
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("fornecedor");
            objInsert.Value.val("razao_social", RazaoSocial)
                            .val("cnpj", Cnpj)
                            .val("email", Email)
                            .val("telefone", Telefone)
                            .val("ativo", UtilConvert.ToBit(Ativo))
                            .val("end_logradouro", EndLogradouro)
                            .val("end_nr", EndNumero)
                            .val("end_complemento", EndComplemento)
                            .val("end_cep", EndCEP)
                            .val("end_bairro", EndBairro)
                            .val("end_localidade", EndLocalidade)
                            .val("end_uf", EndUF);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

    }
}
