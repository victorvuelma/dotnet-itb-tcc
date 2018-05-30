using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQL_POWERUP;
using System.Data.SqlClient;

namespace BURGUER_SHACK_DESKTOP
{
    class clnReserva
    {

        public enum reservaSituacao
        {
            CANCELADA,
            CONFIRMADA,
            MARCADA,
            UTILIZADA
        }

        private int _cod;

        private int _codCliente;
        private int _codFuncionario;
        private List<int> _codMesas;

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

        private clnReserva obter(SqlDataReader reader) => new clnReserva
        {
            Cod = clnUtilConvert.ToInt(reader["id"]),
            CodCliente = clnUtilConvert.ToInt(reader["id_cliente"]),
            CodFuncionario = clnUtilConvert.ToInt(reader["id_funcionario"]),
            CodMesas = new List<int>(),
            Situacao = situacao(clnUtilConvert.ToString(reader["situacao"])),
            Pessoas = clnUtilConvert.ToInt(reader["pessoas"]),
            Agendado = clnUtilConvert.ToDateTime(reader["agendado"]),
            Agendamento = clnUtilConvert.ToDateTime(reader["agendamento"])
        };

        public List<clnReserva> obterPorDataAgedada()
        {
            sqlCommandSelect objSelect = new sqlCommandSelect();
            objSelect.table("reserva");
            objSelect.Where.where("agendado", sqlObjWhere.whereOperation.MAJOR_EQUALS, Agendado)
                            .where("agendado", sqlObjWhere.whereOperation.LESS, Agendado.AddDays(1));

            List<clnReserva> objReservas = new List<clnReserva>();
            SqlDataReader reader = objSelect.select(App.AppDatabase);
            while (reader.Read())
            {
                objReservas.Add(obter(reader));
            }
            reader.Close();

            return objReservas;
        }

        private reservaSituacao situacao(String prefixo)
        {
            switch (prefixo.ToUpper())
            {
                case "A":
                    return reservaSituacao.CANCELADA;
                case "O":
                    return reservaSituacao.CONFIRMADA;
                case "M":
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
