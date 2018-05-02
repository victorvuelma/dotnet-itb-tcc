using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnPedidoProduto
    {

        private int _produto;
        private int _pedido;

        private int _quantidade;

        private String _adicional;

        private List<int> _ingredientes;

        public int Produto { get => _produto; set => _produto = value; }
        public int Pedido { get => _pedido; set => _pedido = value; }
        public List<int> Ingredientes { get => _ingredientes; set => _ingredientes = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public string Adicional { get => _adicional; set => _adicional = value; }

        public List<clnPedidoProduto> getPedidoProdutos()
        {
            List<clnPedidoProduto> pedidoProdutos = new List<clnPedidoProduto>();

            return pedidoProdutos;
        }
    }
}
