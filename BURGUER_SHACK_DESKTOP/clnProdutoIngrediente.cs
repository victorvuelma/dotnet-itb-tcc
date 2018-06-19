using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using SQL_POWERUP;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnProdutoIngrediente
    {

        private int _cod;

        private int _codProduto;
        private int _codIngrediente;

        private bool _remover;
        private bool _alterar;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public int CodIngrediente { get => _codIngrediente; set => _codIngrediente = value; }
        public bool Remover { get => _remover; set => _remover = value; }
        public bool Alterar { get => _alterar; set => _alterar = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        private clnProdutoIngrediente obter(SqlDataReader reader) => new clnProdutoIngrediente
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            CodProduto = clnUtilConvert.ToInt(reader["id_produto"]),
            CodIngrediente = clnUtilConvert.ToInt(reader["id_ingrediente"]),
            Quantidade = clnUtilConvert.ToInt(reader["quantidade"]),
            Remover = clnUtilConvert.ToBool(reader["remover"]),
            Alterar = clnUtilConvert.ToBool(reader["alterar"])
        };

        public clnProdutoIngrediente obterPorCod()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("produto_ingrediente");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.AppDatabase);
            clnProdutoIngrediente objProdutoIngrediente = null;
            if (reader.Read())
                objProdutoIngrediente = obter(reader);
            reader.Close();

            return objProdutoIngrediente;
        }

        public List<clnProdutoIngrediente> obterPorProduto()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("produto_ingrediente");
            objSelect.Where.where("id_produto", CodProduto);

            SqlDataReader reader = objSelect.execute(App.AppDatabase);
            List<clnProdutoIngrediente> objProdutoIngredientes = new List<clnProdutoIngrediente>();
            while (reader.Read())
                objProdutoIngredientes.Add(obter(reader));
            reader.Close();

            return objProdutoIngredientes;
        }

        internal void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("produto_ingrediente");
            objInsert.Insert.val("id_produto", CodProduto)
                            .val("id_ingrediente", CodIngrediente)
                            .val("quantidade", Quantidade)
                            .val("alterar", clnUtilConvert.ToBit(Alterar))
                            .val("remover", clnUtilConvert.ToBit(Remover));

            Cod = objInsert.executeWithOutput(App.AppDatabase);
        }

        internal void alterar()
        {
            sqlCommandUpdate objUpdate = new sqlCommandUpdate();
            objUpdate.table("produto_ingrediente");
            objUpdate.Set.val("quantidade", Quantidade)
                            .val("alterar", clnUtilConvert.ToBit(Alterar))
                            .val("remover", clnUtilConvert.ToBit(Remover));
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.AppDatabase);
        }

        internal void remover()
        {
            sqlCommandDelete objDelete = new sqlCommandDelete();
            objDelete.table("produto_ingrediente");
            objDelete.Where.where("id", Cod);

            objDelete.execute(App.AppDatabase);
        }

        public class clnListar : clnUtilListar<clnProdutoIngrediente>
        {

            internal override String Imagem(clnProdutoIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCod();

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = objIngrediente.CodImagem
                }.obterPorCodigo();

                return objArquivo.Local;
            }

            internal override string Nome(clnProdutoIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCod();

                return objIngrediente.Nome;
            }

            internal override int Cod(clnProdutoIngrediente obj)
            {
                return obj.Cod;
            }

            internal override String Detalhes(clnProdutoIngrediente obj)
            {
                string detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;
                return detalhes;
            }

        }
    }
}
