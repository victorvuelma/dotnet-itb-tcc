using BurgerShack.Common;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    class clnMercadoria
    {

        private int _cod = -1;
        private bool _ativo = true;

        private string _descricao;
        private int _codigoBarras;

        public int Cod { get => _cod; set => _cod = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int CodigoBarras { get => _codigoBarras; set => _codigoBarras = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnMercadoria obter(SqlDataReader reader) => new clnMercadoria
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            Descricao = UtilConvert.ToString(reader["descricao"]),
            CodigoBarras = UtilConvert.ToInt(reader["codigo_barras"]),
            Ativo = UtilConvert.ToBool(reader["ativo"])
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

        public clnMercadoria obterPorCodigoBarras()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("mercadoria");
            objSelect.Where.where("codigo_barras", CodigoBarras);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnMercadoria objMercadoria = null;
            if (reader.Read())
                objMercadoria = obter(reader);
            reader.Close();

            return objMercadoria;
        }

        internal List<clnMercadoria> obterMercadorias()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("mercadoria");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("descricao", "%" + Descricao + "%", vitorrdgs.SqlMaster.Element.Where.sqlElementWhere.whereAssociation.OR)
                           .where("codigo_barras", CodigoBarras);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnMercadoria> objMercadorias = new List<clnMercadoria>();
            while (reader.Read())
                objMercadorias.Add(obter(reader));
            reader.Close();

            return objMercadorias;
        }

        internal void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("mercadoria");
            objUpdate.Where.where("id", Cod);
            objUpdate.Value.val("ativo", UtilConvert.ToBit(Ativo))
                           .val("descricao", Descricao)
                           .val("codigo_barras", CodigoBarras);

            objUpdate.execute(App.DatabaseSql);
        }

        internal void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("mercadoria");
            objInsert.Value.val("ativo", UtilConvert.ToBit(Ativo))
                           .val("descricao", Descricao)
                           .val("codigo_barras", CodigoBarras);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        internal class clnListar : clnUtilListar<clnMercadoria>
        {
            internal override int Cod(clnMercadoria val)
            {
                return val.Cod;
            }

            internal override string Detalhes(clnMercadoria val)
            {
                return "Código de barras: " + val.CodigoBarras;
            }

            internal override string Imagem(clnMercadoria val)
            {
                return clnArquivo.tempImage(Properties.Resources.mercadoria);
            }

            internal override string Nome(clnMercadoria val)
            {
                return val.Descricao;
            }
        }

    }
}
