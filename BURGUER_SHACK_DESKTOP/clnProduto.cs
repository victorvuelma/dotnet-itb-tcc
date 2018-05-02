using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    class clnProduto
    {

        private int _cod;

        private int _categoria;

        private String _nome;
        private double _valor;

        private List<int> _ingredientes = new List<int>();

        public int Cod { get => _cod; set => _cod = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public List<int> Ingredientes { get => _ingredientes; set => _ingredientes = value; }
        public int Categoria { get => _categoria; set => _categoria = value; }

        public List<clnProduto> getProdutos()
        {
            List<clnProduto> produtos = new List<clnProduto>();

            for (int i = 0; i <= 24; i++)
            {
                if (Categoria == i % 5)
                {
                    clnProduto produto = new clnProduto();
                    produto.Cod = i;
                    produto.Nome = "Produto " + i;
                    produto.Valor = i * 10.0d;
                    produto.Categoria = i % 3;
                    produto.Ingredientes.Add(1);

                    produtos.Add(produto);
                }
            }

            return produtos;
        }

    }
}
