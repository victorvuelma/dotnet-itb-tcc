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

        private int _codTipo;
        private List<int> _codReceitas;

        private String _nome;
        private String _descricao;
        private double _valor;

        private Image _imagem;

        public int Cod { get => _cod; set => _cod = value; }
        public String Nome { get => _nome; set => _nome = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public List<int> CodReceitas { get => _codReceitas; set => _codReceitas = value; }
        public int CodTipo { get => _codTipo; set => _codTipo = value; }
        public Image Imagem { get => _imagem; set => _imagem = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }

        public List<clnProduto> obterPorCategoria()
        {
            List<clnProduto> objProdutos = new List<clnProduto>();
            for (int i = 0; i <= 100; i++)
            {
                if (CodTipo == i % 5)
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
            objProduto.CodTipo = Cod % 3;
            objProduto.Imagem = global::BURGUER_SHACK_DESKTOP.Properties.Resources.hamburger;

            clnProdutoReceita objProdutoIngredientes = new clnProdutoReceita();
            objProdutoIngredientes.CodProduto = objProduto.Cod;
            objProduto.CodReceitas = objProdutoIngredientes.obterPorProduto();

            return objProduto;
        }

    }
}
