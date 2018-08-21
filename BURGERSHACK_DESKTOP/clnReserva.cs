using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.SqlMaster.Element.Where;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
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
        private int _codFuncionario = -1;
        private List<int> _codMesas = new List<int>();

        private reservaSituacao _situacao;
        private int _pessoas;

        private DateTime _agendado;
        private DateTime _agendamento;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodCliente { get => _codCliente; set => _codCliente = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public List<int> CodMesas { get => _codMesas; set => _codMesas = value; }
        internal reservaSituacao Situacao { get => _situacao; set => _situacao = value; }
        public int Pessoas { get => _pessoas; set => _pessoas = value; }
        public DateTime Agendado { get => _agendado; set => _agendado = value; }
        public DateTime Agendamento { get => _agendamento; set => _agendamento = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        private clnReserva obter(SqlDataReader reader)
        {
            clnReserva objReserva = new clnReserva
            {
                Cod = UtilConvert.ToInt(reader["id"]),
                CodCliente = UtilConvert.ToInt(reader["id_cliente"]),
                CodFuncionario = UtilConvert.ToInt(reader["id_funcionario"]),
                Situacao = situacao(UtilConvert.ToChar(reader["situacao"])),
                Pessoas = UtilConvert.ToInt(reader["pessoas"]),
                Agendado = UtilConvert.ToDateTime(reader["agendado"]),
                Agendamento = UtilConvert.ToDateTime(reader["agendamento"]),
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
            objSelect.Where.between("agendado", Agendado, Agendado.AddDays(1))
                           .where("ativo", UtilConvert.ToBit(Ativo));

            List<clnReserva> objReservas = new List<clnReserva>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                objReservas.Add(obter(reader));
            reader.Close();

            return objReservas;
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
            objSelect.Where.between("reserva.agendado", Agendado, Agendado.AddDays(1))
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
                         .val("situacao", prefixo(Situacao));
            objUpdate.execute(App.DatabaseSql);
        }

        internal void addMesa(int mesa)
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

        internal void removerMesa(int mesa)
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

        private char prefixo(reservaSituacao situacao)
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
