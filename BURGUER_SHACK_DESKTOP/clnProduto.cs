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
    class clnProduto
    {

        public enum produtoSituacao
        {
            DISPONIVEL,
            INDISPONIVEL,
            FORADEESTOQUE
        }

        private int _cod;

        private int _codTipo;
        private List<int> _codIngredientes;

        private String _nome;
        private String _descricao;
        private double _valor;
        private produtoSituacao _situacao;

        private Image _imagem;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodTipo { get => _codTipo; set => _codTipo = value; }
        public List<int> CodIngredientes { get => _codIngredientes; set => _codIngredientes = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public double Valor { get => _valor; set => _valor = value; }
        internal produtoSituacao Situacao { get => _situacao; set => _situacao = value; }
        public Image Imagem { get => _imagem; set => _imagem = value; }

        private clnProduto obter(SqlDataReader reader)
        {
            clnProduto objProduto = new clnProduto
            {
                Cod = clnUtilConvert.ToInt(reader["id"]),
                CodTipo = clnUtilConvert.ToInt(reader["id_tipo"]),
                Descricao = clnUtilConvert.ToString(reader["descricao"]),
                Nome = clnUtilConvert.ToString(reader["nome"]),
                Situacao = situacao(clnUtilConvert.ToChar(reader["situacao"])),
                Valor = clnUtilConvert.ToDouble(reader["valor"])
            };

            FileStream objArquivo = new clnArquivo
            {
                Cod = clnUtilConvert.ToInt(reader["id_arquivo"])
            }.obterPorCodigo();
            if (objArquivo != null)
            {
                objProduto.Imagem = Image.FromStream(objArquivo);
                objArquivo.Close();
            } else
            {
                objProduto.Imagem = null;
            }

            objProduto.obterIngredientes();

            return objProduto;
        }

        private void obterIngredientes()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("produto_ingrediente");
            objSelect.Select.select("id");
            objSelect.Where.where("id_produto", Cod);

            SqlDataReader reader = objSelect.select(App.AppDatabase);
            List<int> objIngredientes = new List<int>();
            while (reader.Read())
                objIngredientes.Add(clnUtilConvert.ToInt(reader["id"]));
            reader.Close();

            CodIngredientes = objIngredientes;
        }
        
        public clnProduto obterPorCodigo()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("produto");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.select(App.AppDatabase);
            clnProduto objProduto = null;
            if (reader.Read())
                objProduto = obter(reader);
            reader.Close();

            return objProduto;
        }

        public List<clnProduto> obterPorTipo()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("produto");
            objSelect.Where.where("id_tipo", CodTipo);

            SqlDataReader reader = objSelect.select(App.AppDatabase);
            List<clnProduto> objProdutos = new List<clnProduto>();
            while (reader.Read())
                objProdutos.Add(obter(reader));
            reader.Close();

            return objProdutos;
        }

        private produtoSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'D':
                    return produtoSituacao.DISPONIVEL;
                case 'E':
                    return produtoSituacao.FORADEESTOQUE;
                default:
                    return produtoSituacao.INDISPONIVEL;
            }
        }

        private char prefixo(produtoSituacao situacao)
        {
            switch (situacao)
            {
                case produtoSituacao.DISPONIVEL:
                    return 'D';
                case produtoSituacao.FORADEESTOQUE:
                    return 'E';
                default:
                    return 'I';
            }
        }

        public class clnSelecionar : clnUtilSelecionar<clnProduto>
        {

            internal override string Detalhes(clnProduto obj)
            {
                String detalhes = "";
                detalhes += "Categoria: " + obj.CodTipo;
                detalhes += "\n";
                detalhes += "Código: " + obj.Cod;

                return detalhes;
            }

            internal override Image Imagem(clnProduto obj)
            {
                return obj.Imagem;
            }

            internal override string Nome(clnProduto obj)
            {
                return obj.Nome;
            }

            internal override int Cod(clnProduto obj)
            {
                return obj.Cod;
            }

        }

    }
}
