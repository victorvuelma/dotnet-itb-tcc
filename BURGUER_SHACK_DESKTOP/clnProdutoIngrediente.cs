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
            clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente();
            objProdutoIngrediente.Produto = Produto;
            objProdutoIngrediente.Ingrediente = Ingrediente;
            objProdutoIngrediente.Quantidade = 1;

            return objProdutoIngrediente;
        }

        public List<int> obterPorProduto()
        {
            List<int> objProdutoIngredientes = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                objProdutoIngredientes.Add(i);
            }

            return objProdutoIngredientes;
        }

    }
}
