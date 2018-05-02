using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnProdutoIngrediente
    {

        private int _produto;
        private int _ingrediente;

        private int _quantidade;

        public int Produto { get => _produto; set => _produto = value; }
        public int Ingrediente { get => _ingrediente; set => _ingrediente = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public clnProdutoIngrediente obterPorProdutoIngrediente()
        {
            clnProdutoIngrediente produtoIngrediente = new clnProdutoIngrediente();

            produtoIngrediente.Produto = Produto;
            produtoIngrediente.Ingrediente = Ingrediente;
            produtoIngrediente.Quantidade = 1;

            return produtoIngrediente;
        }

        public List<clnProdutoIngrediente> obterPorProduto()
        {
            List<clnProdutoIngrediente> produtoIngredientes = new List<clnProdutoIngrediente>();

            for (int i = 1; i <= 32; i++)
            {
                clnProdutoIngrediente produtoIngrediente = new clnProdutoIngrediente();

                produtoIngrediente.Produto = Produto;
                produtoIngrediente.Quantidade = i % 3 + 1;
                produtoIngrediente.Ingrediente = i % 5 + 1;

                produtoIngredientes.Add(produtoIngrediente);
            }

            return produtoIngredientes;
        }

    }
}
