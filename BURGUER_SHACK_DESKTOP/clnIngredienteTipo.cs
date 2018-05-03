using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnIngredienteTipo
    {

        private int _cod;
        private String _nome;

        public int Cod { get => _cod; set => _cod = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public clnIngredienteTipo obterPorCodigo()
        {
            clnIngredienteTipo objIngredienteTipo = new clnIngredienteTipo();
            objIngredienteTipo.Cod = Cod;
            objIngredienteTipo.Nome = "" + Cod;

            return objIngredienteTipo;

        }

    }
}
