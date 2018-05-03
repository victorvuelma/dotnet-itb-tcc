using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnPedido
    {

        private int _cod;

        private int _atendimento;
        
        public int Cod { get => _cod; set => _cod = value; }
        public int Atendimento { get => _atendimento; set => _atendimento = value; }
    }
}
