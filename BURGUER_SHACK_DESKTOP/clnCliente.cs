using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnCliente
    {

        private int _cod;

        private int _reserva;

        private String _nome;
        private String _docCPF;

        private String _sexo;
        private DateTime _dataNascimento;

        private String _contatoTelCel;
        private String _contatoEmail;

        public DateTime DataNascimento { get => DataNascimento1; set => DataNascimento1 = value; }
        public int Cod { get => _cod; set => _cod = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string DocCPF { get => _docCPF; set => _docCPF = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public DateTime DataNascimento1 { get => _dataNascimento; set => _dataNascimento = value; }
        public string ContatoTelCel { get => _contatoTelCel; set => _contatoTelCel = value; }
        public string ContatoEmail { get => _contatoEmail; set => _contatoEmail = value; }
        public int Reserva { get => _reserva; set => _reserva = value; }
    }
}
