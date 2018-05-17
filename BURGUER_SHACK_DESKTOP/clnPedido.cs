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

        private int _codAtendimento;
        private int _codFuncionario;

        private int _valor;
        private String estado;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodAtendimento { get => _codAtendimento; set => _codAtendimento = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public int Valor { get => _valor; set => _valor = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
