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

        private int _codTipo;

        private String _nome;
        private double _valor;

        private Image _imagem;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodTipo { get => _codTipo; set => _codTipo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public Image Imagem { get => _imagem; set => _imagem = value; }

        private clnIngrediente obter(SqlDataReader reader)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = clnUtilConvert.ToInt(reader["id"]),
                CodTipo = clnUtilConvert.ToInt(reader["id_tipo"]),
                Nome = clnUtilConvert.ToString(reader["nome"]),
                Valor = clnUtilConvert.ToDouble(reader["valor"])
            };

            FileStream objArquivo = new clnArquivo
            {
                Cod = clnUtilConvert.ToInt(reader["id_arquivo"])
            }.obterPorCodigo();

            if (objArquivo != null)
            {
                objIngrediente.Imagem = Image.FromStream(objArquivo);
                objArquivo.Close();
            }
            else
            {
                objIngrediente.Imagem = null;
            }

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

        public class clnSelecionar : clnUtilSelecionar<clnIngrediente>
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

            internal override Image Imagem(clnIngrediente obj)
            {
                return obj.Imagem;
            }

            internal override string Nome(clnIngrediente obj)
            {
                return obj.Nome;
            }
        }

    }
}
