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

        private String _nome;
        private Image _foto;

        private String _docCPF;
        private String _docRG;

        private String _contatoTelCel;
        private String _contatoTelRes;
        private String _contatoEmail;

        public int Cod { get => _cod; set => _cod = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public Image Foto { get => _foto; set => _foto = value; }
        public string DocCPF { get => _docCPF; set => _docCPF = value; }
        public string DocRG { get => _docRG; set => _docRG = value; }
        public string ContatoTelCel { get => _contatoTelCel; set => _contatoTelCel = value; }
        public string ContatoTelRes { get => _contatoTelRes; set => _contatoTelRes = value; }
        public string ContatoEmail { get => _contatoEmail; set => _contatoEmail = value; }
    }
}
