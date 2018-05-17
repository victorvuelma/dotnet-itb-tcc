using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnProdutoReceita
    {

        private int _cod;

        private int _codProduto;
        private int _codIngrediente;

        private bool _remover;
        private bool _alterar;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public int CodIngrediente { get => _codIngrediente; set => _codIngrediente = value; }
        public bool Remover { get => _remover; set => _remover = value; }
        public bool Alterar { get => _alterar; set => _alterar = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public clnProdutoReceita obterPorProdutoIngrediente()
        {
            clnProdutoReceita objProdutoIngrediente = new clnProdutoReceita();
            objProdutoIngrediente.CodProduto = CodProduto;
            objProdutoIngrediente.CodIngrediente = CodIngrediente;
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

        internal clnProdutoReceita obterPorCodigo()
        {
            throw new NotImplementedException();
        }
    }
}
