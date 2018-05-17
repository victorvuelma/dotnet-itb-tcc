using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnPedidoReceita
    {

        private int _cod;

        private int _codIngrediente;
        private int _codReceita;
        private int _codPedido;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodIngrediente { get => _codIngrediente; set => _codIngrediente = value; }
        public int CodReceita { get => _codReceita; set => _codReceita = value; }
        public int CodPedido { get => _codPedido; set => _codPedido = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public clnPedidoReceita localizaPorPedidoProduto()
        {
            clnPedidoReceita objPedidoIngrediente = new clnPedidoReceita();
            objPedidoIngrediente.CodPedido = CodPedido;
            objPedidoIngrediente.CodIngrediente = 1;
            objPedidoIngrediente.Quantidade = 1;

            return objPedidoIngrediente;
        }

    }
}
