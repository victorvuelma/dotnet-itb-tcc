using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnItem
    {

        private int _cod = -1;

        private int _codProduto = -1;
        private int _codPedido = -1;

        private int _quantidade;
        private String _adicional;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public int CodPedido { get => _codPedido; set => _codPedido = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public string Adicional { get => _adicional; set => _adicional = value; }

        private clnItem obter(SqlDataReader reader) => new clnItem
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            CodPedido = clnUtilConvert.ToInt(reader["id_pedido"]),
            CodProduto = clnUtilConvert.ToInt(reader["id_produto"]),
            Adicional = clnUtilConvert.ToString(reader["adicional"]),
            Quantidade = clnUtilConvert.ToInt(reader["quantidade"])
        };

        public List<clnItem> obterPorPedido()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("item");
            objSelect.Where.where("id_pedido", CodPedido);

            SqlDataReader reader = objSelect.execute(App.AppDatabase);
            List<clnItem> objItens = new List<clnItem>();
            while (reader.Read())
                objItens.Add(obter(reader));
            reader.Close();

            return objItens;
        }

        public void gravar()
        {
            sqlCommandInsert objInsert = new sqlCommandInsert();
            objInsert.table("item");
            objInsert.Insert.val("id_pedido", CodPedido)
                            .val("id_produto", CodProduto)
                            .val("adicional", Adicional)
                            .val("quantidade", Quantidade);

            Cod = objInsert.executeWithOutput(App.AppDatabase);
        }

        public void alterar()
        {
            sqlCommandUpdate objUpdate = new sqlCommandUpdate();
            objUpdate.table("item");
            objUpdate.Set.val("adicional", Adicional)
                         .val("quantidade", Quantidade);
            objUpdate.Where.where("id", Cod);

            objUpdate.execute(App.AppDatabase);
        }

    }
}
