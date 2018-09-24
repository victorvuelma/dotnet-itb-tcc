using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using vitorrdgs.SqlMaster;
using System.Drawing;

using BurgerShack.Common;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public class clnProdutoIngrediente
    {

        private int _cod = -1;
        private bool _ativo = true;

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
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnProdutoIngrediente obter(SqlDataReader reader) => new clnProdutoIngrediente
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            CodProduto = UtilConvert.ToInt(reader["id_produto"]),
            CodIngrediente = UtilConvert.ToInt(reader["id_ingrediente"]),
            Quantidade = UtilConvert.ToInt(reader["quantidade"]),
            Remover = UtilConvert.ToBool(reader["remover"]),
            Alterar = UtilConvert.ToBool(reader["alterar"]),
            Ativo = UtilConvert.ToBool(reader["ativo"])
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
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("id_produto", CodProduto);

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
            objInsert.Value.val("id_produto", CodProduto)
                            .val("id_ingrediente", CodIngrediente)
                            .val("quantidade", Quantidade)
                            .val("ativo", UtilConvert.ToBit(Ativo))
                            .val("alterar", UtilConvert.ToBit(Alterar))
                            .val("remover", UtilConvert.ToBit(Remover));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        internal void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("produto_ingrediente");
            objUpdate.Value.val("quantidade", Quantidade)
                           .val("ativo", UtilConvert.ToBit(Ativo))
                           .val("alterar", UtilConvert.ToBit(Alterar))
                           .val("remover", UtilConvert.ToBit(Remover));
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.DatabaseSql);
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
                }.obterPorCod();

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
