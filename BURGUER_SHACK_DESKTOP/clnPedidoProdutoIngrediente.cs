using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnPedidoProdutoIngrediente
    {

        private int _pedidoProduto;
        private clnIngrediente _ingrediente;

        private int _quantidade;
        private int _produtoQuantidade;

        public clnIngrediente Ingrediente { get => _ingrediente; set => _ingrediente = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public int PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public int ProdutoQuantidade { get => _produtoQuantidade; set => _produtoQuantidade = value; }

        public clnPedidoProdutoIngrediente localizaPorPedidoProduto()
        {
            clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente();
            objPedidoIngrediente.PedidoProduto = PedidoProduto;
            objPedidoIngrediente.Ingrediente = new clnIngrediente { Cod = 1}.obterPorCodigo();
            objPedidoIngrediente.Quantidade = 1;

            return objPedidoIngrediente;
        }

    }
}
