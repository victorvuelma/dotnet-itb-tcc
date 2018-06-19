using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnItemIngrediente
    {

        private int _cod = -1;

        private int _codIngrediente = -1;
        private int _codProdutoIngrediente = -1;
        private int _codItem = -1;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodIngrediente { get => _codIngrediente; set => _codIngrediente = value; }
        public int CodProdutoIngrediente { get => _codProdutoIngrediente; set => _codProdutoIngrediente = value; }
        public int CodItem { get => _codItem; set => _codItem = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public clnItemIngrediente localizarPorItem()
        {
            clnItemIngrediente objPedidoIngrediente = new clnItemIngrediente();
            objPedidoIngrediente.CodItem = CodItem;
            objPedidoIngrediente.CodIngrediente = 1;
            objPedidoIngrediente.Quantidade = 1;

            return objPedidoIngrediente;
        }

        public List<clnItemIngrediente> obterPorItem()
        {
            return new List<clnItemIngrediente>();
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("item_ingrediente");
            objInsert.Insert.val("id_ingrediente", CodIngrediente)
                            .val("id_item", CodItem)
                            .val("id_produto_ingrediente", CodProdutoIngrediente)
                            .val("quantidade", Quantidade);

            objInsert.execute(App.AppDatabase);
        }

        public void alterar()
        {
            sqlCommandUpdate objUpdate = new sqlCommandUpdate();
            objUpdate.table("item_ingrediente");
            objUpdate.Set.val("id_ingrediente", CodIngrediente)
                         .val("quantidade", Quantidade);

            objUpdate.execute(App.AppDatabase);
        }

        public class clnListar : clnUtilListar<clnItemIngrediente>
        {
            internal override int Cod(clnItemIngrediente obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnItemIngrediente obj)
            {
                string detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;

                return detalhes;
            }

            internal override string Imagem(clnItemIngrediente obj)
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

            internal override string Nome(clnItemIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCod();

                return objIngrediente.Nome;
            }
        }

    }
}
