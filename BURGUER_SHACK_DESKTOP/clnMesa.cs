using System;
using System.Collections.Generic;
using System.Drawing;
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
            return 1;
            //throw new NotImplementedException();
        }

        internal void alterar()
        {
            //throw new NotImplementedException();
        }

        internal List<clnMesa> obterPorOcupado()
        {
            return obterMesas();
        }

        public class clnSelecionar : clnUtilSelecionar<clnMesa>
        {
            internal override int Cod(clnMesa obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnMesa obj)
            {
                return "";
            }

            internal override Image Imagem(clnMesa obj)
            {
                if (obj.Ocupada)
                {
                    return Properties.Resources.mesauso;
                }
                else
                {
                    return Properties.Resources.mesa;
                }
            }

            internal override string Nome(clnMesa obj)
            {
                return "Mesa " + obj.Cod;
            }
        }

    }
}
