using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnMesa
    {

        private int _cod;

        private bool _ocupada;

        public int Cod { get => _cod; set => _cod = value; }
        public bool Ocupada { get => _ocupada; set => _ocupada = value; }


        public List<clnMesa> obterMesas()
        {
            List<clnMesa> objMesas = new List<clnMesa>();
            for (int i = 1; i <= 25; i++)
            {
                clnMesa objMesa = new clnMesa();
                objMesa.Cod = i;

                objMesas.Add(objMesa.obterPorCodigo());
            }

            return objMesas;
        }

        public clnMesa obterPorCodigo()
        {
            clnMesa objMesa = new clnMesa();
            objMesa.Cod = Cod;
            objMesa.Ocupada = (Cod % 3 == 0);

            return objMesa;
        }

        internal int obterCodAtendimento()
        {
            throw new NotImplementedException();
        }

        internal void alterar()
        {
            throw new NotImplementedException();
        }
    }
}
