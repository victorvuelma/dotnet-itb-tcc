using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class clnIngrediente
    {

        private int _cod;

        private String _nome;
        private double _valor;

        private Image _imagem;
        private int _tipo;

        public int Cod { get => _cod; set => _cod = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public Image Imagem { get => _imagem; set => _imagem = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }

        public clnIngrediente obterPorCodigo()
        {
            clnIngrediente objIngrediente = new clnIngrediente();
            objIngrediente.Cod = Cod;
            objIngrediente.Nome = "Ingrediente " + Cod;
            objIngrediente.Valor = Cod * 15.5;
            objIngrediente.Imagem = global::BURGUER_SHACK_DESKTOP.Properties.Resources.modelo;
            objIngrediente.Tipo = 1;

            return objIngrediente;
        }

        public List<clnIngrediente> obterPorTipo()
        {
            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            for (int i = 0; i < 10; i++)
            {
                clnIngrediente objIngrediente = new clnIngrediente();
                objIngrediente.Cod = i;

                objIngredientes.Add(objIngrediente.obterPorCodigo());
            }

            return objIngredientes;
        }

    }
}
