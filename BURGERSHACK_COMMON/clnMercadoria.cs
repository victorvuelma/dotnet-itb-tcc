using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Common
{
    public class clnMercadoria
    {

        private int _cod = -1;
        private bool _ativo = true;

        private string _descricao;
        private string _codigoBarras;

        private bool _baixar = true;

        public int Cod { get => _cod; set => _cod = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string CodigoBarras { get => _codigoBarras; set => _codigoBarras = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
        public bool Baixar { get => _baixar; set => _baixar = value; }

        private clnMercadoria obter(SqlDataReader reader) => new clnMercadoria
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            Descricao = UtilConvert.ToString(reader["descricao"]),
            CodigoBarras = UtilConvert.ToString(reader["codigo_barras"]),
            Ativo = UtilConvert.ToBool(reader["ativo"]),
            Baixar = UtilConvert.ToBool(reader["baixar"])
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

        public List<clnMercadoria> obterMercadorias()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("mercadoria");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("descricao", "%" + Descricao + "%", vitorrdgs.SqlMaster.Element.Where.sqlElementWhere.whereAssociation.OR)
                           .where("codigo_barras", "%" + CodigoBarras + "%");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            List<clnMercadoria> objMercadorias = new List<clnMercadoria>();
            while (reader.Read())
                objMercadorias.Add(obter(reader));
            reader.Close();

            return objMercadorias;
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("mercadoria");
            objUpdate.Where.where("id", Cod);
            objUpdate.Value.val("ativo", UtilConvert.ToBit(Ativo))
                           .val("descricao", Descricao)
                           .val("baixar", UtilConvert.ToBit(Baixar))
                           .val("codigo_barras", CodigoBarras);

            objUpdate.execute(App.DatabaseSql);
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("mercadoria");
            objInsert.Value.val("ativo", UtilConvert.ToBit(Ativo))
                           .val("baixar", UtilConvert.ToBit(Baixar))
                           .val("descricao", Descricao)
                           .val("codigo_barras", CodigoBarras);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
        }

        public class clnListar : clnUtilListar<clnMercadoria>
        {
            private string _imagem = clnArquivo.tempImage(Properties.Resources.mercadoria);

            internal override int Cod(clnMercadoria obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnMercadoria obj)
            {
                StringBuilder detalhesBuilder = new StringBuilder();
                detalhesBuilder.Append("Código de barras: ").Append(obj.CodigoBarras);
                detalhesBuilder.Append("\n").Append("Descrição: ").Append(obj.Descricao);
                return detalhesBuilder.ToString();
            }

            internal override string Imagem(clnMercadoria obj)
            {
                return _imagem;
            }

            internal override string Nome(clnMercadoria obj)
            {
                return obj.Descricao;
            }
        }

    }
}
