using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class clnProduto
    {

        private int _cod;

        private int _categoria;

        private String _nome;
        private double _valor;

        private Image _imagem;

        private List<clnProdutoIngrediente> _ingredientes;

        public int Cod { get => _cod; set => _cod = value; }
        public String Nome { get => _nome; set => _nome = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public List<clnProdutoIngrediente> Ingredientes { get => _ingredientes; set => _ingredientes = value; }
        public int Categoria { get => _categoria; set => _categoria = value; }
        public Image Imagem { get => _imagem; set => _imagem = value; }

        public List<clnProduto> obterPorCategoria()
        {
            List<clnProduto> objProdutos = new List<clnProduto>();
            for (int i = 0; i <= 100; i++)
            {
                if (Categoria == i % 5)
                {
                    clnProduto objProduto = new clnProduto();
                    objProduto.Cod = i;

                    objProdutos.Add(objProduto.obterPorCodigo());
                }
            }

            return objProdutos;
        }

        public clnProduto obterPorCodigo()
        {
            clnProduto objProduto = new clnProduto();
            objProduto.Cod = Cod;
            objProduto.Nome = "Produto " + Cod;
            objProduto.Valor = Cod * 10.0d;
            objProduto.Categoria = Cod % 3;
            objProduto.Imagem = global::BURGUER_SHACK_DESKTOP.Properties.Resources.hamburger;

            clnProdutoIngrediente objProdutoIngredientes = new clnProdutoIngrediente();
            objProdutoIngredientes.Produto = objProduto.Cod;
            objProduto.Ingredientes = objProdutoIngredientes.obterPorProduto();

            return objProduto;
        }

    }
}
