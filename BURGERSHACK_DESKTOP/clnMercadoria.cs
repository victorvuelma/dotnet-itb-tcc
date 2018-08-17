using BurgerShack.Common;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    class clnMercadoria
    {

        private int _cod = -1;

        private string _descricao;
        private int _codigoBarras;

        public int Cod { get => _cod; set => _cod = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int CodigoBarras { get => _codigoBarras; set => _codigoBarras = value; }

        private clnMercadoria obter(SqlDataReader reader) => new clnMercadoria
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            Descricao = UtilConvert.ToString(reader["descricao"]),
            CodigoBarras = UtilConvert.ToInt(reader["codigo_barras"])
        };

        public clnMercadoria obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("mercadoria");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnMercadoria objMercadoria = null;
            if (reader.Read())
                objMercadoria = obter(reader);
            reader.Close();

            return objMercadoria;
        }


    }
}
