using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnProduto
    {

        private int _cod;

        private String _nome;
        private double _valor;

        private List<clnIngrediente> _ingredientes;

        public int Cod { get => _cod; set => _cod = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public List<clnIngrediente> Ingredientes { get => _ingredientes; set => _ingredientes = value; }
    }
}
