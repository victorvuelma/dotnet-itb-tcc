using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class clnFuncionario
    {

        private int _cod;

        private int _codCargo;
        private int _codEndereco;

        private String _nome;
        private Image _foto;
        private String _sexo;

        private double _salario;

        private String _docCPF;
        private String _docRG;

        private DateTime _dataNascimento;
        private DateTime _dataContratado;

        private String _contatoTelCel;
        private String _contatoTelRes;
        private String _contatoEmail;

        public int Cod { get => _cod; set => _cod = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public Image Foto { get => _foto; set => _foto = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public string DocCPF { get => _docCPF; set => _docCPF = value; }
        public string DocRG { get => _docRG; set => _docRG = value; }
        public DateTime DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
        public DateTime DataContratado { get => _dataContratado; set => _dataContratado = value; }
        public string ContatoTelCel { get => _contatoTelCel; set => _contatoTelCel = value; }
        public string ContatoTelRes { get => _contatoTelRes; set => _contatoTelRes = value; }
        public string ContatoEmail { get => _contatoEmail; set => _contatoEmail = value; }
        public int CodEndereco { get => _codEndereco; set => _codEndereco = value; }
        public int CodCargo { get => _codCargo; set => _codCargo = value; }
    }
}
