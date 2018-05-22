using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnAtendimento
    {

        private int _cod;
        private List<int> _codMesas;

        private DateTime _inicio;
        private DateTime _fim;

        private bool _finalizado;

        public int Cod { get => _cod; set => _cod = value; }
        public List<int> CodMesas { get => _codMesas; set => _codMesas = value; }
        public DateTime Inicio { get => _inicio; set => _inicio = value; }
        public DateTime Fim { get => _fim; set => _fim = value; }
        public bool Finalizado { get => _finalizado; set => _finalizado = value; }

        public void addMesa(int codMesa)
        {
            if (!CodMesas.Contains(codMesa))
            {
                CodMesas.Add(codMesa);
            }
        }

        public clnAtendimento obterPorCodigo()
        {
            return new clnAtendimento();
        }

        public void gravar()
        {
            throw new NotImplementedException();
        }
    }
}
