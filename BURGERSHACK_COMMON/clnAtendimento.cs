﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vitorrdgs.SqlMaster;
using System.Data.SqlClient;

using BurgerShack.Common;
using vitorrdgs.SqlMaster.Command;
using vitorrdgs.Util.Data;

namespace BurgerShack.Common
{
    public class clnAtendimento
    {

        public enum atendimentoSituacao
        {
            ANDAMENTO,
            FINALIZADO
        }

        private int _cod = -1;
        private int? _codCliente;
        private int _codFuncionario = -1;
        private int? _codReserva;
        private List<int> _codMesas = new List<int>();

        private DateTime _inicio;
        private DateTime? _fim;
        private atendimentoSituacao _situacao;

        public int Cod { get => _cod; set => _cod = value; }
        public int? CodCliente { get => _codCliente; set => _codCliente = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public int? CodReserva { get => _codReserva; set => _codReserva = value; }
        public List<int> CodMesas { get => _codMesas; set => _codMesas = value; }
        public DateTime Inicio { get => _inicio; set => _inicio = value; }
        public DateTime? Fim { get => _fim; set => _fim = value; }
        public atendimentoSituacao Situacao { get => _situacao; set => _situacao = value; }

        private clnAtendimento obter(SqlDataReader reader)
        {
            clnAtendimento objAtendimento = new clnAtendimento
            {
                Cod = UtilConvert.ToInt(reader["id"]),
                CodCliente = UtilConvert.ToNullableInt(reader["id_cliente"]),
                CodFuncionario = UtilConvert.ToInt(reader["id_funcionario"]),
                CodReserva = UtilConvert.ToNullableInt(reader["id_reserva"]),
                Inicio = UtilConvert.ToDateTime(reader["inicio"]),
                Fim = UtilConvert.ToNullableDateTime(reader["fim"]),
                Situacao = situacao(UtilConvert.ToChar(reader["situacao"]))
            };
            objAtendimento.obterMesas();

            return objAtendimento;
        }

        private void obterMesas()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("atendimento_mesa").Columns.select("id_mesa");
            objSelect.Where.where("id_atendimento", Cod);

            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
                CodMesas.Add(UtilConvert.ToInt(reader["id_mesa"]));
            reader.Close();
        }

        public clnAtendimento obterPorCod()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("atendimento");
            objSelect.Where.where("id", Cod);

            clnAtendimento objAtendimento = null;
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            if (reader.Read())
                objAtendimento = obter(reader);
            reader.Close();

            return objAtendimento;
        }

        public List<clnAtendimento> obterAtendimentos()
        {
            sqlSelect objSelect = new sqlSelect();
            objSelect.table("atendimento");

            List<clnAtendimento> objAtendimentos = new List<clnAtendimento>();
            SqlDataReader reader = objSelect.execute(App.DatabaseSql);
            while (reader.Read())
            {
                objAtendimentos.Add(obter(reader));
            }
            reader.Close();

            return objAtendimentos;
        }

        public void gravar()
        {
            sqlInsert objInsert = new sqlInsert();
            objInsert.table("atendimento");
            objInsert.Value.val("id_cliente", CodCliente)
                            .val("id_funcionario", CodFuncionario)
                            .val("id_reserva", CodReserva)
                            .val("inicio", Inicio)
                            .val("fim", Fim)
                            .val("situacao", prefixo(Situacao));

            Cod = objInsert.executeWithOutput(App.DatabaseSql);
            this.obterMesas();
        }

        public void alterar()
        {
            sqlUpdate objUpdate = new sqlUpdate();
            objUpdate.Value.val("fim", Fim)
                         .val("situacao", prefixo(Situacao));
            objUpdate.Where.where("id", Cod);
            objUpdate.table("atendimento");

            objUpdate.execute(App.DatabaseSql);
        }

        public void adicionarMesa(int codMesa)
        {
            if (!CodMesas.Contains(codMesa))
            {
                CodMesas.Add(codMesa);
                sqlInsert objInsert = new sqlInsert();
                objInsert.table("atendimento_mesa");
                objInsert.Value.val("id_atendimento", Cod)
                                .val("id_mesa", codMesa);
                objInsert.execute(App.DatabaseSql);

                clnMesa objMesa = new clnMesa
                {
                    Cod = codMesa
                }.obterPorCod();
                objMesa.Situacao = clnMesa.mesaSituacao.OCUPADA;
                objMesa.alterar();
            }
        }

        public void removerMesa(int codMesa)
        {
            if (CodMesas.Contains(codMesa))
            {
                CodMesas.Remove(codMesa);
                sqlDelete objDelete = new sqlDelete();
                objDelete.table("atendimento_mesa");
                objDelete.Where.where("id_atendimento", Cod)
                                .where("id_mesa", codMesa);
                objDelete.execute(App.DatabaseSql);

                clnMesa objMesa = new clnMesa
                {
                    Cod = codMesa
                }.obterPorCod();
                objMesa.Situacao = clnMesa.mesaSituacao.DISPONIVEL;
                objMesa.alterar();
            }
        }

        public atendimentoSituacao situacao(char prefixo)
        {
            switch (prefixo)
            {
                case 'A':
                    return atendimentoSituacao.ANDAMENTO;
                default:
                    return atendimentoSituacao.FINALIZADO;
            }
        }

        public char prefixo(atendimentoSituacao situacao)
        {
            switch (situacao)
            {
                case atendimentoSituacao.ANDAMENTO:
                    return 'A';
                default:
                    return 'F';
            }
        }

    }
}
