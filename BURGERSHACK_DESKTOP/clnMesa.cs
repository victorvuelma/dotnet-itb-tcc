using BurgerShack.Common;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public class clnMesa
    {

        public enum mesaSituacao
        {
            DISPONIVEL,
            OCUPADA,
            RESERVADA
        }

        private int _cod = -1;
        private bool _ativo = true;

        private mesaSituacao _situacao;

        private int _numero;
        private int _lugares;

        public int Cod { get => _cod; set => _cod = value; }
        public mesaSituacao Situacao { get => _situacao; set => _situacao = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public int Lugares { get => _lugares; set => _lugares = value; }

        private clnMesa obter(SqlDataReader reader) => new clnMesa
        {
            Cod = UtilConvert.ToInt(reader["id"]),
            Situacao = situacao(UtilConvert.ToChar(reader["situacao"])),
            Ativo = UtilConvert.ToBool(reader["ativo"]),
            Numero = UtilConvert.ToInt(reader["numero"]),
            Lugares = UtilConvert.ToInt(reader["lugares"])
        };

        public List<clnMesa> obterMesas()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("MESA");

            List<clnMesa> objMesas = new List<clnMesa>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objMesas.Add(obter(reader));
            reader.Close();

            return objMesas;
        }

        public clnMesa obterPorCodigo()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("MESA");
            objSelect.Where.where("id", Cod);

            clnMesa objMesa = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objMesa = obter(reader);
            reader.Close();

            return objMesa;
        }

        public clnMesa obterPorNumero()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("MESA");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo))
                           .where("numero", Numero);

            clnMesa objMesa = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objMesa = obter(reader);
            reader.Close();

            return objMesa;
        }

        internal int? obterCodAtendimento()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("ATENDIMENTO");
            objSelect.Columns.select("ATENDIMENTO.ID");
            objSelect.Where.where("ATENDIMENTO.SITUACAO", 'A').where("ATENDIMENTO_MESA.ID_MESA", Cod);
            objSelect.Join.innerJoin("ATENDIMENTO_MESA", "ID_ATENDIMENTO", "ATENDIMENTO.ID");

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            int? codAtendimento = null;
            if (reader.Read())
                codAtendimento = UtilConvert.ToInt(reader["id"]);
            reader.Close();

            return codAtendimento;
        }

        internal void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("mesa");
            objUpdate.Where.where("id", Cod);
            objUpdate.Value.val("situacao", prefixo(Situacao))
                         .val("ativo", UtilConvert.ToBit(Ativo))
                         .val("lugares", Lugares)
                         .val("numero", Numero);
            objUpdate.execute(App.DatabaseSql);
        }

        internal void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("mesa");
            objInsert.Value.val("situacao", prefixo(Situacao))
                            .val("ativo", UtilConvert.ToBit(Ativo))
                            .val("lugares", Lugares)
                            .val("numero", Numero);
            Cod = objInsert.execute(App.DatabaseSql);
        }

        private char prefixo(mesaSituacao situacao)
        {
            switch (Situacao)
            {
                case mesaSituacao.OCUPADA:
                    return 'O';
                case mesaSituacao.RESERVADA:
                    return 'R';
                default:
                    return 'D';
            }
        }

        private mesaSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'O':
                    return mesaSituacao.OCUPADA;
                case 'R':
                    return mesaSituacao.RESERVADA;
                default:
                    return mesaSituacao.DISPONIVEL;
            }
        }

        internal List<clnMesa> obterPorSituacao()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("MESA").Where.where("situacao", prefixo(Situacao));

            List<clnMesa> objMesas = new List<clnMesa>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objMesas.Add(obter(reader));
            reader.Close();

            return objMesas;
        }

        public class clnListar : clnUtilListar<clnMesa>
        {
            internal override int Cod(clnMesa obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnMesa obj)
            {
                return "";
            }

            internal override string Imagem(clnMesa obj)
            {
                return clnArquivo.tempImage(Properties.Resources.mesa);
            }

            internal override string Nome(clnMesa obj)
            {
                return "Mesa " + obj.Cod;
            }
        }

    }
}
