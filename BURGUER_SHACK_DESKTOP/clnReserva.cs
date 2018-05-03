using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnReserva
    {

        private int _cod;

        //funcionario
        //cliente
        private int _agendadoPor;
        private int _agendadoPara;

        private DateTime _dataAgendamento;
        private DateTime _dataAgendada;

        private int _pessoas;
        private List<int> _mesas;

        public int Cod { get => _cod; set => _cod = value; }
        public int AgendadoPor { get => _agendadoPor; set => _agendadoPor = value; }
        public int AgendadoPara { get => _agendadoPara; set => _agendadoPara = value; }
        public DateTime DataAgendamento { get => _dataAgendamento; set => _dataAgendamento = value; }
        public DateTime DataAgendada { get => _dataAgendada; set => _dataAgendada = value; }
        public int Pessoas { get => _pessoas; set => _pessoas = value; }
        public List<int> Mesas { get => _mesas; set => _mesas = value; }
    }
}
