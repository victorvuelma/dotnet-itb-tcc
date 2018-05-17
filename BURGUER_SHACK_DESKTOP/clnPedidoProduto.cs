using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnPedidoProduto
    {

        private int _cod;

        private int _codProduto;
        private int _codPedido;

        private int _quantidade;
        private String _adicional;

        private List<clnPedidoReceita> _ingredientes;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public int CodPedido { get => _codPedido; set => _codPedido = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public string Adicional { get => _adicional; set => _adicional = value; }
        public List<clnPedidoReceita> Ingredientes { get => _ingredientes; set => _ingredientes = value; }

        public List<clnPedidoProduto> obterPorPedido()
        {
            List<clnPedidoProduto> pedidoProdutos = new List<clnPedidoProduto>();

            return pedidoProdutos;
        }
    }
}
