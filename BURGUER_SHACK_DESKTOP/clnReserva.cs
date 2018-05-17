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

        private int _codCliente;
        private int _codFuncionario;
        private List<int> _codMesas;

        private DateTime _quando;
        private DateTime _agendado;

        private String _estado;
        private int _pessoas;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodCliente { get => _codCliente; set => _codCliente = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public List<int> CodMesas { get => _codMesas; set => _codMesas = value; }
        public DateTime Quando { get => _quando; set => _quando = value; }
        public DateTime Agendado { get => _agendado; set => _agendado = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public int Pessoas { get => _pessoas; set => _pessoas = value; }
    }
}
