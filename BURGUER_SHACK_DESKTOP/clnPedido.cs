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

        private int _mesa;
        
        public int Cod { get => _cod; set => _cod = value; }
        public int Mesa { get => _mesa; set => _mesa = value; }
    }
}
