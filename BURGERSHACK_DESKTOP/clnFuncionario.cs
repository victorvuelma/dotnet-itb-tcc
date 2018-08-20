using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element.Where;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    class clnFuncionario
    {

        public enum funcionarioSituacao
        {
            TREINAMENTO,
            PLENO,
            DEMITIDO
        }

        private int _cod = -1;
        private bool _ativo = true;

        private int _codCargo = -1;
        private int _codFoto = -1;

        private string _nome;
        private string _cpf;
        private string _rg;

        private string _genero;
        private DateTime _dataNascimento;

        private string _telRes;
        private string _telCel;
        private string _email;

        private decimal _salario;
        private DateTime _dataContratacao;
        private DateTime? _dataDemissao;
        private funcionarioSituacao _situacao;

        private string _endLogradouro;
        private string _endNumero;
        private string _endComplemento;
        private string _endCEP;
        private string _endBairro;
        private string _endLocalidade;
        private string _endUF;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodCargo { get => _codCargo; set => _codCargo = value; }
        public int CodFoto { get => _codFoto; set => _codFoto = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DateTime DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
        public string TelRes { get => _telRes; set => _telRes = value; }
        public string TelCel { get => _telCel; set => _telCel = value; }
        public string Email { get => _email; set => _email = value; }
        public decimal Salario { get => _salario; set => _salario = value; }
        public DateTime DataContratacao { get => _dataContratacao; set => _dataContratacao = value; }
        public DateTime? DataDemissao { get => _dataDemissao; set => _dataDemissao = value; }
        internal funcionarioSituacao Situacao { get => _situacao; set => _situacao = value; }
        public string EndLogradouro { get => _endLogradouro; set => _endLogradouro = value; }
        public string EndNumero { get => _endNumero; set => _endNumero = value; }
        public string EndComplemento { get => _endComplemento; set => _endComplemento = value; }
        public string EndCEP { get => _endCEP; set => _endCEP = value; }
        public string EndBairro { get => _endBairro; set => _endBairro = value; }
        public string EndLocalidade { get => _endLocalidade; set => _endLocalidade = value; }
        public string EndUF { get => _endUF; set => _endUF = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnFuncionario obter(SqlDataReader reader) => new clnFuncionario
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodCargo = UtilConvert.ToInt(reader["id_cargo"]),
            CodFoto = UtilConvert.ToInt(reader["id_foto"]),
            Nome = UtilConvert.ToString(reader["nome"]),
            Cpf = UtilConvert.ToString(reader["cpf"]),
            Rg = UtilConvert.ToString(reader["rg"]),
            Genero = UtilConvert.ToString(reader["genero"]),
            DataNascimento = UtilConvert.ToDateTime(reader["data_nascimento"]),
            TelRes = UtilConvert.ToString(reader["tel_res"]),
            TelCel = UtilConvert.ToString(reader["tel_cel"]),
            Email = UtilConvert.ToString(reader["email"]),
            Salario = UtilConvert.ToDecimal(reader["salario"]),
            DataContratacao = UtilConvert.ToDateTime(reader["data_contratacao"]),
            DataDemissao = UtilConvert.ToNullableDateTime(reader["data_demissao"]),
            Situacao = situacao(UtilConvert.ToChar(reader["situacao"])),
            Ativo = UtilConvert.ToBool(reader["ativo"]),
            EndLogradouro = UtilConvert.ToString(reader["end_logradouro"]),
            EndNumero = UtilConvert.ToString(reader["end_nr"]),
            EndComplemento = UtilConvert.ToString(reader["end_complemento"]),
            EndCEP = UtilConvert.ToString(reader["end_cep"]),
            EndBairro = UtilConvert.ToString(reader["end_bairro"]),
            EndLocalidade = UtilConvert.ToString(reader["end_localidade"]),
            EndUF = UtilConvert.ToString(reader["end_uf"])
        };

        public clnFuncionario obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("funcionario");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnFuncionario objFuncionario = null;
            if (reader.Read())
                objFuncionario = obter(reader);
            reader.Close();

            return objFuncionario;
        }

        public clnFuncionario obterPorCPF()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("funcionario");
            objSelect.Where.where("cpf", Cpf);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnFuncionario objFuncionario = null;
            if (reader.Read())
                objFuncionario = obter(reader);
            reader.Close();

            return objFuncionario;
        }

        public List<clnFuncionario> obterPorNomeCPF()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("funcionario");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("nome", sqlElementWhereCommon.whereOperation.LIKE, "%" + Nome + "%", sqlElementWhere.whereAssociation.OR)
                           .where("cpf", sqlElementWhereCommon.whereOperation.LIKE, "%" + Cpf + "%");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnFuncionario> objFuncionarios = new List<clnFuncionario>();
            while (reader.Read())
                objFuncionarios.Add(obter(reader));
            reader.Close();

            return objFuncionarios;
        }

        public List<clnFuncionario> obterTodos()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("funcionario");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnFuncionario> objFuncionarios = new List<clnFuncionario>();
            while (reader.Read())
                objFuncionarios.Add(obter(reader));
            reader.Close();

            return objFuncionarios;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("funcionario");
            objInsert.Insert.val("id_cargo", CodCargo)
                            .val("id_foto", CodFoto)
                            .val("nome", Nome)
                            .val("cpf", Cpf)
                            .val("rg", Rg)
                            .val("genero", Genero)
                            .val("data_nascimento", DataNascimento)
                            .val("tel_res", TelRes)
                            .val("tel_cel", TelCel)
                            .val("email", Email)
                            .val("salario", Salario)
                            .val("data_contratacao", DataContratacao)
                            .val("data_demissao", DataDemissao)
                            .val("situacao", prefixo(Situacao))
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

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("funcionario");
            objUpdate.Where.where("id", Cod);
            objUpdate.Set.val("id_cargo", CodCargo)
                            .val("id_foto", CodFoto)
                            .val("nome", Nome)
                            .val("rg", Rg)
                            .val("genero", Genero)
                            .val("data_nascimento", DataNascimento)
                            .val("tel_res", TelRes)
                            .val("tel_cel", TelCel)
                            .val("email", Email)
                            .val("salario", Salario)
                            .val("ativo", UtilConvert.ToBit(Ativo))
                            .val("data_contratacao", DataContratacao)
                            .val("data_demissao", DataDemissao)
                            .val("situacao", prefixo(Situacao))
                            .val("end_logradouro", EndLogradouro)
                            .val("end_nr", EndNumero)
                            .val("end_complemento", EndComplemento)
                            .val("end_cep", EndCEP)
                            .val("end_bairro", EndBairro)
                            .val("end_localidade", EndLocalidade)
                            .val("end_uf", EndUF);

            objUpdate.execute(App.DatabaseSql);
        }

        private char prefixo(funcionarioSituacao situacao)
        {
            switch (situacao)
            {
                case funcionarioSituacao.DEMITIDO:
                    return 'D';
                case funcionarioSituacao.PLENO:
                    return 'P';
                default:
                    return 'T';
            }
        }

        private funcionarioSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'D':
                    return funcionarioSituacao.DEMITIDO;
                case 'P':
                    return funcionarioSituacao.PLENO;
                default:
                    return funcionarioSituacao.TREINAMENTO;
            }
        }

    }
}
