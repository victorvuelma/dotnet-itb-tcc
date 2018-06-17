using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using SQL_POWERUP;
using System.Data.SqlClient;
using System.IO;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnIngrediente
    {
        public enum ingredienteSituacao
        {
            DISPONIVEL,
            INDISPONIVEL,
            FORADEESTOQUE
        }

        private int _cod;

        private int _codImagem;
        private int _codTipo;

        private String _nome;
        private double _valor;

        private ingredienteSituacao _situacao;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodTipo { get => _codTipo; set => _codTipo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public ingredienteSituacao Situacao { get => _situacao; set => _situacao = value; }
        public int CodImagem { get => _codImagem; set => _codImagem = value; }

        private clnIngrediente obter(SqlDataReader reader)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = clnUtilConvert.ToInt(reader["id"]),
                CodImagem = clnUtilConvert.ToInt(reader["id_imagem"]),
                CodTipo = clnUtilConvert.ToInt(reader["id_tipo"]),
                Nome = clnUtilConvert.ToString(reader["nome"]),
                Valor = clnUtilConvert.ToDouble(reader["valor"]),
                Situacao = situacao(clnUtilConvert.ToChar(reader["situacao"])),
            };

            return objIngrediente;
        }

        public clnIngrediente obterPorCodigo()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("ingrediente");
            objSelect.Where.where("id", Cod);

            clnIngrediente objIngrediente = null;
            SqlDataReader reader = objSelect.select(App.AppDatabase);
            if (reader.Read())
                objIngrediente = obter(reader);
            reader.Close();

            return objIngrediente;
        }

        public List<clnIngrediente> obterPorTipo()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("ingrediente");
            objSelect.Where.where("id_tipo", CodTipo);

            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            SqlDataReader reader = objSelect.select(App.AppDatabase);
            while (reader.Read())
                objIngredientes.Add(obter(reader));
            reader.Close();

            return objIngredientes;
        }

        internal List<clnIngrediente> obterIngredientes()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("ingrediente");

            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            SqlDataReader reader = objSelect.select(App.AppDatabase);
            while (reader.Read())
                objIngredientes.Add(obter(reader));
            reader.Close();

            return objIngredientes;
        }


        internal List<clnIngrediente> obterPorNome()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("ingrediente");
            objSelect.Where.where("nome", sqlObjWhereCommon.whereOperation.LIKE, "%" + Nome + "%");

            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            SqlDataReader reader = objSelect.select(App.AppDatabase);
            while (reader.Read())
                objIngredientes.Add(obter(reader));
            reader.Close();

            return objIngredientes;
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("ingrediente");
            objInsert.Insert.val("id_tipo", CodTipo)
                            .val("id_imagem", CodImagem)
                            .val("nome", Nome)
                            .val("valor", Valor)
                            .val("situacao", prefixo(Situacao));

            Cod = objInsert.insertWithOutput(App.AppDatabase);
        }

        internal void alterar()
        {
            sqlCommandUpdate objUpdate = new sqlCommandUpdate();
            objUpdate.table("ingrediente");
            objUpdate.Set.val("id_tipo", CodTipo)
                        .val("id_imagem", CodImagem)
                        .val("nome", Nome)
                        .val("valor", Valor)
                        .val("situacao", prefixo(Situacao));
            objUpdate.Where.where("id", Cod);

            objUpdate.update(App.AppDatabase);
        }

        private ingredienteSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'D':
                    return ingredienteSituacao.DISPONIVEL;
                case 'E':
                    return ingredienteSituacao.FORADEESTOQUE;
                default:
                    return ingredienteSituacao.INDISPONIVEL;
            }
        }

        private char prefixo(ingredienteSituacao situacao)
        {
            switch (situacao)
            {
                case ingredienteSituacao.DISPONIVEL:
                    return 'D';
                case ingredienteSituacao.FORADEESTOQUE:
                    return 'E';
                default:
                    return 'I';
            }
        }

        public class clnListar : clnUtilListar<clnIngrediente>
        {

            internal override int Cod(clnIngrediente obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnIngrediente obj)
            {
                string detalhes = "";
                detalhes += "Valor: " + obj.Valor;

                return detalhes;
            }

            internal override string Imagem(clnIngrediente obj)
            {
                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = obj.CodImagem
                }.obterPorCodigo();
                return objArquivo.Local;
            }

            internal override string Nome(clnIngrediente obj)
            {
                return obj.Nome;
            }
        }

    }
}
