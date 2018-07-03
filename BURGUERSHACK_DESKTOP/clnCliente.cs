using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;
using BURGUERSHACK_COMMON;

namespace BURGUERSHACK_DESKTOP
{
    class clnCliente
    {

        private int _cod = -1;
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

        private clnCliente obter(SqlDataReader reader) => new clnCliente
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            CodFuncionario = clnUtilConvert.ToInt(reader["id_funcionario"]),
            Nome = clnUtilConvert.ToString(reader["nome"]),
            Cpf = clnUtilConvert.ToString(reader["cpf"]),
            DataNascimento = clnUtilConvert.ToNullableDateTime(reader["data_nascimento"]),
            Genero = clnUtilConvert.ToString(reader["genero"]),
            TelCelular = clnUtilConvert.ToString(reader["tel_cel"]),
            Email = clnUtilConvert.ToString(reader["email"]),
            Cadastro = clnUtilConvert.ToDateTime(reader["cadastro"])
        };

        public clnCliente obterPorCod()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
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
            sqlCommandSelect objSelect = new sqlCommandSelect();
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
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("cliente");
            objSelect.Where.where("nome", sqlObjWhereCommon.whereOperation.LIKE, "%" + Nome + "%", sqlObjWhere.whereAssociation.OR)
                           .where("cpf", sqlObjWhereCommon.whereOperation.LIKE, Cpf + "%");
                    

            List<clnCliente> objClientes = new List<clnCliente>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objClientes.Add(obter(reader));
            reader.Close();
            return objClientes;
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("cliente");
            objInsert.Insert.val("id_funcionario", CodFuncionario)
                            .val("nome", Nome)
                            .val("cpf", Cpf)
                            .val("data_nascimento", DataNascimento)
                            .val("genero", Genero)
                            .val("tel_cel", TelCelular)
                            .val("email", Email)
                            .val("cadastro", Cadastro);
            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        public void alterar()
        {
            sqlCommandUpdate objUpdate = new sqlCommandUpdate();
            objUpdate.table("cliente");
            objUpdate.Where.where("id", Cod);
            objUpdate.Set.val("nome", Nome)
                            .val("data_nascimento", DataNascimento)
                            .val("genero", Genero)
                            .val("tel_cel", TelCelular)
                            .val("email", Email);
            objUpdate.execute(App.DatabaseSql);
        }

    }
}
