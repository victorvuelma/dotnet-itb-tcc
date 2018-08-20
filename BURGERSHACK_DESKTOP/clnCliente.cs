using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element.Where;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    class clnCliente
    {

        private int _cod = -1;
        private bool _ativo = true;

        private int _codFuncionario = -1;

        private String _nome;
        private String _cpf;

        private DateTime? _dataNascimento;
        private string _genero;

        private string _telCelular;
        private string _email;

        private DateTime _cadastro;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public DateTime? DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public string TelCelular { get => _telCelular; set => _telCelular = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime Cadastro { get => _cadastro; set => _cadastro = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnCliente obter(SqlDataReader reader) => new clnCliente
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodFuncionario = UtilConvert.ToInt(reader["id_funcionario"]),
            Nome = UtilConvert.ToString(reader["nome"]),
            Cpf = UtilConvert.ToString(reader["cpf"]),
            DataNascimento = UtilConvert.ToNullableDateTime(reader["data_nascimento"]),
            Genero = UtilConvert.ToString(reader["genero"]),
            TelCelular = UtilConvert.ToString(reader["tel_cel"]),
            Email = UtilConvert.ToString(reader["email"]),
            Cadastro = UtilConvert.ToDateTime(reader["cadastro"]),
            Ativo = UtilConvert.ToBool(reader["ativo"])
        };

        public clnCliente obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("cliente");
            objSelect.Where.where("id", Cod);

            clnCliente objCliente = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objCliente = obter(reader);
            reader.Close();

            return objCliente;
        }

        public clnCliente obterPorCPF()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("cliente");
            objSelect.Where.where("cpf", Cpf);

            clnCliente objCliente = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objCliente = obter(reader);
            reader.Close();

            return objCliente;
        }

        internal List<clnCliente> obterPorNomeCPF()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("cliente");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("nome", sqlElementWhereCommon.whereOperation.LIKE, "%" + Nome + "%", sqlElementWhere.whereAssociation.OR)
                           .where("cpf", sqlElementWhereCommon.whereOperation.LIKE, Cpf + "%");

            List<clnCliente> objClientes = new List<clnCliente>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objClientes.Add(obter(reader));
            reader.Close();

            return objClientes;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("cliente");
            objInsert.Value.val("id_funcionario", CodFuncionario)
                            .val("nome", Nome)
                            .val("cpf", Cpf)
                            .val("data_nascimento", DataNascimento)
                            .val("genero", Genero)
                            .val("tel_cel", TelCelular)
                            .val("email", Email)
                            .val("cadastro", Cadastro)
                            .val("ativo", UtilConvert.ToBit(Ativo));
            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("cliente");
            objUpdate.Where.where("id", Cod);
            objUpdate.Value.val("nome", Nome)
                            .val("data_nascimento", DataNascimento)
                            .val("genero", Genero)
                            .val("tel_cel", TelCelular)
                            .val("email", Email)
                            .val("ativo", UtilConvert.ToBit(Ativo));
            objUpdate.execute(App.DatabaseSql);
        }

    }
}
