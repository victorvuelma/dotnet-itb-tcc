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
    public class clnMesa
    {

        public enum mesaSituacao
        {
            DISPONIVEL,
            OCUPADA,
            RESERVADA
        }

        private int _cod;
        private mesaSituacao _situacao;

        public int Cod { get => _cod; set => _cod = value; }
        public mesaSituacao Situacao { get => _situacao; set => _situacao = value; }

        private clnMesa obter(SqlDataReader reader) => new clnMesa
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            Situacao = situacao(clnUtilConvert.ToChar(reader["situacao"]))
        };

        public List<clnMesa> obterMesas()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("MESA");

            List<clnMesa> objMesas = new List<clnMesa>();
            SqlDataReader reader = objSelect.select(App.AppDatabase);
            while (reader.Read())
                objMesas.Add(obter(reader));
            reader.Close();

            return objMesas;
        }

        public clnMesa obterPorCodigo()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("MESA").Where.where("id", Cod);

            clnMesa objMesa = null;
            SqlDataReader reader = objSelect.select(App.AppDatabase);
            if (reader.Read())
                objMesa = obter(reader);
            reader.Close();

            return objMesa;
        }

        internal int? obterCodAtendimento()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("ATENDIMENTO");
            objSelect.Select.select("ATENDIMENTO.ID");
            objSelect.Where.where("ATENDIMENTO.SITUACAO", 'A').where("ATENDIMENTO_MESA.ID_MESA", Cod);
            objSelect.Join.innerJoin("ATENDIMENTO_MESA", "ID_ATENDIMENTO", "ATENDIMENTO.ID");

            SqlDataReader reader = objSelect.select(App.AppDatabase);
            int? codAtendimento = null;
            if (reader.Read())
                codAtendimento = clnUtilConvert.ToInt(reader["id"]);
            reader.Close();

            return codAtendimento;
        }

        internal void alterar()
        {
            sqlCommandUpdate objUpdate = new sqlCommandUpdate();
            objUpdate.table("MESA");
            objUpdate.Where.where("id", Cod);
            objUpdate.Set.val("situacao", prefixo(Situacao));
            objUpdate.update(App.AppDatabase);
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
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("MESA").Where.where("situacao", prefixo(Situacao));

            List<clnMesa> objMesas = new List<clnMesa>();
            SqlDataReader reader = objSelect.select(App.AppDatabase);
            while (reader.Read())
            {
                objMesas.Add(obter(reader));
            }
            reader.Close();

            return objMesas;
        }

        public class clnSelecionar : clnUtilSelecionar<clnMesa>
        {
            internal override int Cod(clnMesa obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnMesa obj)
            {
                return "";
            }

            internal override Image Imagem(clnMesa obj)
            {
                if (obj.Situacao == mesaSituacao.DISPONIVEL)
                {
                    return Properties.Resources.mesa;
                }
                else
                {
                    return Properties.Resources.mesauso;
                }
            }

            internal override string Nome(clnMesa obj)
            {
                return "Mesa " + obj.Cod;
            }
        }

    }
}
