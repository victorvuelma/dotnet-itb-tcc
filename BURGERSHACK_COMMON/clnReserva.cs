using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element.Where;
using vitorrdgs.Util.Data;

namespace BurgerShack.Common
{
    public class clnReserva
    {

        public enum reservaSituacao
        {
            CANCELADA,
            CONFIRMADA,
            MARCADA,
            UTILIZADA
        }

        private int _cod = -1;

        private bool _ativo = true;

        private int _codCliente = -1;
        private int? _codFuncionario = null;
        private List<int> _codMesas = new List<int>();

        private reservaSituacao _situacao;
        private int _pessoas;

        private DateTime _agendado;
        private DateTime _agendamento;

        private string _informacoes;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodCliente { get => _codCliente; set => _codCliente = value; }
        public int? CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public List<int> CodMesas { get => _codMesas; set => _codMesas = value; }
        public reservaSituacao Situacao { get => _situacao; set => _situacao = value; }
        public int Pessoas { get => _pessoas; set => _pessoas = value; }
        public DateTime Agendado { get => _agendado; set => _agendado = value; }
        public DateTime Agendamento { get => _agendamento; set => _agendamento = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }
        public string Informacoes { get => _informacoes; set => _informacoes = value; }

        private clnReserva obter(SqlDataReader reader)
        {
            clnReserva objReserva = new clnReserva
            {
                Cod = UtilConvert.ToInt(reader["id"]),
                CodCliente = UtilConvert.ToInt(reader["id_cliente"]),
                CodFuncionario = UtilConvert.ToNullableInt(reader["id_funcionario"]),
                Situacao = situacao(UtilConvert.ToChar(reader["situacao"])),
                Pessoas = UtilConvert.ToInt(reader["pessoas"]),
                Agendado = UtilConvert.ToDateTime(reader["agendado"]),
                Agendamento = UtilConvert.ToDateTime(reader["agendamento"]),
                Informacoes = UtilConvert.ToString(reader["informacoes"]),
                Ativo = UtilConvert.ToBool(reader["ativo"])
            };
            objReserva.obterMesas();

            return objReserva;
        }

        private void obterMesas()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("reserva_mesa").Columns.select("id_mesa");
            objSelect.Where.where("id_reserva", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                CodMesas.Add(UtilConvert.ToInt(reader["id_mesa"]));
            reader.Close();
        }

        public clnReserva obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("reserva");
            objSelect.Where.where("id", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            clnReserva objReserva = null;
            if (reader.Read())
                objReserva = obter(reader);
            reader.Close();

            return objReserva;
        }

        public List<clnReserva> obterPorDataAgendada()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("reserva");
            objSelect.Where.where("CONVERT(DATE, AGENDADO)", Agendado.Date)
                           .where("ativo", UtilConvert.ToBit(Ativo));

            List<clnReserva> objReservas = new List<clnReserva>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objReservas.Add(obter(reader));
            reader.Close();

            return objReservas;
        }

        public List<clnReserva> obterPorCliente()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("reserva");
            objSelect.Where.where("id_cliente", CodCliente)
                           .where("ativo", UtilConvert.ToBit(Ativo));
            objSelect.Order.order("agendado");

            List<clnReserva> objReservas = new List<clnReserva>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objReservas.Add(obter(reader));
            reader.Close();

            return objReservas;
        }

        public List<clnReserva> obterPorClienteData()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("reserva");
            objSelect.Where.where("id_cliente", CodCliente)
                           .where("CONVERT(DATE, AGENDADO)", Agendado.Date)
                           .where("ativo", UtilConvert.ToBit(Ativo));

            List<clnReserva> objReservas = new List<clnReserva>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objReservas.Add(obter(reader));
            reader.Close();

            return objReservas;
        }

        public int obterLugaresDisponiveis()
        {
            int lugares = new clnMesa().obterLugares();

            List<int> codMesas = obterMesasReservadas();
            foreach (int codMesa in codMesas)
            {
                clnMesa objMesa = new clnMesa
                {
                    Cod = codMesa
                }.obterPorCod();

                lugares -= objMesa.Lugares;
            }

            return lugares;

        }

        public List<clnReserva> obterReservas()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("reserva");
            objSelect.Where.where("ativo", UtilConvert.ToBit(Ativo));

            List<clnReserva> objReservas = new List<clnReserva>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objReservas.Add(obter(reader));
            reader.Close();

            return objReservas;
        }

        public List<int> obterMesasReservadas()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("mesa");
            objSelect.Columns.select("mesa.id");
            objSelect.Join.innerJoin("reserva_mesa", "id_mesa", "mesa.id")
                          .innerJoin("reserva", "id", "reserva_mesa.id_reserva");
            objSelect.Where.where("CONVERT(DATE, reserva.AGENDADO)", Agendado)
                           .where("reserva.ativo", UtilConvert.ToBit(Ativo))
                           .where("reserva.situacao", sqlElementWhereCommon.whereOperation.UNEQUAL, prefixo(reservaSituacao.CANCELADA));

            List<int> objMesas = new List<int>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objMesas.Add(UtilConvert.ToInt(reader["id"]));
            reader.Close();

            return objMesas;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("reserva");
            objInsert.Value.val("id_cliente", CodCliente)
                            .val("id_funcionario", CodFuncionario)
                            .val("situacao", prefixo(Situacao))
                            .val("pessoas", Pessoas)
                            .val("agendado", Agendado)
                            .val("informacoes", Informacoes)
                            .val("agendamento", Agendamento);

            Cod = objInsert.executeWithOutput(App.DatabaseSql);

            gravarMesas();
        }

        private void gravarMesas()
        {
            foreach (int codMesa in CodMesas)
            {
                sqlInsert objInsert = new sqlInsert();
                objInsert.table("reserva_mesa");
                objInsert.Value.val("id_reserva", Cod)
                                .val("id_mesa", codMesa);
                objInsert.execute(App.DatabaseSql);
            }
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.table("reserva");
            objUpdate.Where.where("id", Cod);
            objUpdate.Value.val("pessoas", Pessoas)
                           .val("ativo", UtilConvert.ToBit(Ativo))
                           .val("informacoes", Informacoes)
                           .val("agendado", Agendado)
                           .val("situacao", prefixo(Situacao));
            objUpdate.execute(App.DatabaseSql);
        }

        public void addMesa(int mesa)
        {
            if (!CodMesas.Contains(mesa))
            {
                CodMesas.Add(mesa);
                if (Cod != -1)
                {
                    sqlInsert objInsert = new sqlInsert();
                    objInsert.table("reserva_mesa");
                    objInsert.Value.val("id_reserva", Cod)
                                    .val("id_mesa", mesa);

                    objInsert.execute(App.DatabaseSql);
                }
            }
        }

        public void removerMesa(int mesa)
        {
            if (CodMesas.Contains(mesa))
            {
                CodMesas.Remove(mesa);
                if (Cod != -1)
                {
                    sqlDelete objDelete = new sqlDelete();
                    objDelete.table("reserva_mesa");
                    objDelete.Where.where("id_reserva", Cod)
                                   .where("id_mesa", mesa);

                    objDelete.execute(App.DatabaseSql);
                }
            }
        }

        private reservaSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'A':
                    return reservaSituacao.CANCELADA;
                case 'O':
                    return reservaSituacao.CONFIRMADA;
                case 'M':
                    return reservaSituacao.MARCADA;
                default:
                    return reservaSituacao.UTILIZADA;
            }
        }

        public char prefixo(reservaSituacao situacao)
        {
            switch (situacao)
            {
                case reservaSituacao.CANCELADA:
                    return 'A';
                case reservaSituacao.CONFIRMADA:
                    return 'O';
                case reservaSituacao.MARCADA:
                    return 'M';
                default:
                    return 'U';
            }
        }

    }
}
