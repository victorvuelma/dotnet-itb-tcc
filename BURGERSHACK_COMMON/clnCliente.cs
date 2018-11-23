using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element.Where;
using vitorrdgs.Util;
using vitorrdgs.Util.Data;

namespace BurgerShack.Common
{
    public class clnCliente
    {

        private int _cod = -1;
        private bool _ativo = true;

        private int? _codFuncionario = null;

        private String _nome;
        private String _cpf;
        private String _hash;

        private string _telCelular;
        private string _email;

        private string _cartaoNumero;
        private string _cartaoValidade;
        private string _cartaoCVV;

        private DateTime _cadastro;

        public int Cod { get => _cod; set => _cod = value; }
        public int? CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string TelCelular { get => _telCelular; set => _telCelular = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime Cadastro { get => _cadastro; set => _cadastro = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
        public string CartaoNumero { get => _cartaoNumero; set => _cartaoNumero = value; }
        public string CartaoValidade { get => _cartaoValidade; set => _cartaoValidade = value; }
        public string CartaoCVV { get => _cartaoCVV; set => _cartaoCVV = value; }
        public string Hash { get => _hash; set => _hash = vitorrdgs.Util.Hash.Hash.HASH.cyph(value); }

        private clnCliente obter(SqlDataReader reader) => new clnCliente
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodFuncionario = UtilConvert.ToNullableInt(reader["id_funcionario"]),
            Nome = UtilConvert.ToString(reader["nome"]),
            Cpf = UtilConvert.ToString(reader["cpf"]),
            TelCelular = UtilConvert.ToString(reader["tel_cel"]),
            Email = UtilConvert.ToString(reader["email"]),
            Cadastro = UtilConvert.ToDateTime(reader["cadastro"]),
            Ativo = UtilConvert.ToBool(reader["ativo"]),
            CartaoNumero = UtilConvert.ToString(reader["cartao_numero"]),
            CartaoValidade = UtilConvert.ToString(reader["cartao_validade"]),
            CartaoCVV = UtilConvert.ToString(reader["cartao_cvv"])
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

        public clnCliente autenticarPorCPF()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("cliente");
            objSelect.Where.where("cpf", Cpf)
                           .where("hash", sqlElementWhereCommon.whereOperation.EQUALS, Hash);

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

        public clnCliente obterPorEmail()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("cliente");
            objSelect.Where.where("email", Email);

            clnCliente objCliente = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objCliente = obter(reader);
            reader.Close();

            return objCliente;
        }

        public List<clnCliente> obterPorNomeCPF()
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

        public string obterHash()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("cliente");
            objSelect.Columns.select("hash");
            objSelect.Where.where("id", Cod);

            string hash = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
            {
                hash = UtilConvert.ToString(reader["hash"]);
                for (int i = 0; i >= 100; i++)
                {
                    hash = vitorrdgs.Util.Hash.Hash.HASH.cyph(hash);
                }
            }
            reader.Close();

            return hash;
        }

        public void gravar()
        {
            if (String.IsNullOrEmpty(Hash))
            {
                string senha = UtilRandom.gerar(10);

                informarSenha(senha);

                Hash = senha;
            }

            sqlInsert objInsert = new sqlInsert();
            objInsert.table("cliente");
            objInsert.Value.val("id_funcionario", CodFuncionario)
                            .val("nome", Nome)
                            .val("cpf", Cpf)
                            .val("tel_cel", TelCelular)
                            .val("email", Email)
                            .val("cartao_numero", CartaoNumero)
                            .val("cartao_validade", CartaoValidade)
                            .val("cartao_cvv", CartaoCVV)
                            .val("cadastro", Cadastro)
                            .val("hash", Hash)
                            .val("ativo", UtilConvert.ToBit(Ativo));
            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("cliente");
            objUpdate.Where.where("id", Cod);
            objUpdate.Value.val("nome", Nome)
                            .val("tel_cel", TelCelular)
                            .val("email", Email)
                            .val("cartao_numero", CartaoNumero)
                            .val("cartao_validade", CartaoValidade)
                            .val("cartao_cvv", CartaoCVV)
                            .val("ativo", UtilConvert.ToBit(Ativo));

            if (!String.IsNullOrEmpty(Hash))
            {
                objUpdate.Value.val("hash", Hash);
            }

            objUpdate.execute(App.DatabaseSql);
        }

        private void informarSenha(String senha)
        {
            StringBuilder informativo = new StringBuilder();
            informativo.Append("Olá ").Append(Nome);
            informativo.Append("<br/>");
            informativo.Append("<br/>Seja bem-vindo ao ").Append(App.Name).Append("!");
            informativo.Append("<br/>Você foi cadastrado em nosso sistema, permitindo o acesso via nosso website e nosso Aplicativo para Android.");
            informativo.Append("<br/>");
            informativo.Append("<br/>Realize o acesso com o seu CPF e sua senha:");
            informativo.Append("<br/>Senha: ").Append(senha);
            informativo.Append("<br/>");
            informativo.Append("<br/>Atenciosamente,");
            informativo.Append("<br/>Equipe ").Append("<a href='").Append(App.Webiste).Append("'>").Append(App.Name).Append("</a>").Append(".");
            informativo.Append("<br/>");
            informativo.Append("<br/>(Esta mensagem é automática)");

            App.EmailClient.SendEmail(App.Name, App.EmailClient.CredentialEmail, Email, App.Name + " - Bem-vindo!", informativo, App.TemplateEmail);
        }

    }

}
