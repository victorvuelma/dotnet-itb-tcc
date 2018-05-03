using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnAtendimento
    {

        private int _mesa;

        private DateTime _tempoInicio;

        private bool _status;

        public int Mesa { get => _mesa; set => _mesa = value; }
        public DateTime TempoInicio { get => _tempoInicio; set => _tempoInicio = value; }
        public bool Status { get => _status; set => _status = value; }
    }
}
