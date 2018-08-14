using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using vitorrdgs.SqlMaster;
using System.Drawing;
using BurgerShack.Common.UTIL;
using BurgerShack.Common;
using vitorrdgs.SqlMaster.Command;

namespace BurgerShack.Desktop
{
    public class clnProdutoIngrediente
    {

        private int _cod = -1;

        private int _codProduto = -1;
        private int _codIngrediente = -1;

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
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("produto_ingrediente");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnProdutoIngrediente objProdutoIngrediente = null;
            if (reader.Read())
                objProdutoIngrediente = obter(reader);
            reader.Close();

            return objProdutoIngrediente;
        }

        public List<clnProdutoIngrediente> obterPorProduto()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("produto_ingrediente");
            objSelect.Where.where("id_produto", CodProduto);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnProdutoIngrediente> objProdutoIngredientes = new List<clnProdutoIngrediente>();
            while (reader.Read())
                objProdutoIngredientes.Add(obter(reader));
            reader.Close();

            return objProdutoIngredientes;
        }

        public List<clnProdutoIngrediente> obterPorIngrediente()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("produto_ingrediente");
            objSelect.Where.where("id_ingrediente", CodIngrediente);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnProdutoIngrediente> objProdutoIngredientes = new List<clnProdutoIngrediente>();
            while (reader.Read())
                objProdutoIngredientes.Add(obter(reader));
            reader.Close();

            return objProdutoIngredientes;
        }

        internal void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("produto_ingrediente");
            objInsert.Insert.val("id_produto", CodProduto)
                            .val("id_ingrediente", CodIngrediente)
                            .val("quantidade", Quantidade)
                            .val("alterar", clnUtilConvert.ToBit(Alterar))
                            .val("remover", clnUtilConvert.ToBit(Remover));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        internal void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("produto_ingrediente");
            objUpdate.Set.val("quantidade", Quantidade)
                            .val("alterar", clnUtilConvert.ToBit(Alterar))
                            .val("remover", clnUtilConvert.ToBit(Remover));
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
        }

        internal void remover()
        {
            sqlDelete objDelete = new sqlDelete();
            objDelete.table("produto_ingrediente");
            objDelete.Where.where("id", Cod);

            objDelete.execute(App.DatabaseSql);
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
