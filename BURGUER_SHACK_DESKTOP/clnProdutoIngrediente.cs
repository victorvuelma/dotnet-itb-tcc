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

        public List<clnProdutoIngrediente> obterPorProduto()
        {
            List<clnProdutoIngrediente> objProdutoIngredientes = new List<clnProdutoIngrediente>();
            for (int i = 1; i <= 5; i++)
            {
                clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente();
                objProdutoIngrediente.Produto = Produto;
                objProdutoIngrediente.Quantidade = i % 3 + 1;
                objProdutoIngrediente.Ingrediente = i % 5 + 1;

                objProdutoIngredientes.Add(objProdutoIngrediente);
            }

            return objProdutoIngredientes;
        }

    }
}
