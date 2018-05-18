using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnIngrediente
    {

        private int _cod;

        private int _codTipo;

        private String _nome;
        private double _valor;

        private Image _imagem;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodTipo { get => _codTipo; set => _codTipo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public Image Imagem { get => _imagem; set => _imagem = value; }

        public clnIngrediente obterPorCodigo()
        {
            clnIngrediente objIngrediente = new clnIngrediente();
            objIngrediente.Cod = Cod;
            objIngrediente.Nome = nomes[Cod % 7];
            objIngrediente.Valor = Cod * 15.5;
            objIngrediente.Imagem = global::BURGUER_SHACK_DESKTOP.Properties.Resources.modelo;
            objIngrediente.CodTipo = 1;

            return objIngrediente;
        }

        public List<clnIngrediente> obterPorTipo()
        {
            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            for (int i = 0; i < 7; i++)
            {
                clnIngrediente objIngrediente = new clnIngrediente();
                objIngrediente.Cod = i;

                objIngredientes.Add(objIngrediente.obterPorCodigo());
            }

            return objIngredientes;
        }

        internal List<clnIngrediente> obterIngredientes()
        {
            List<clnIngrediente> objIngredientes = new List<clnIngrediente>();
            for (int i = 0; i < 7; i++)
            {
                clnIngrediente objIngrediente = new clnIngrediente();
                objIngrediente.Cod = i;

                objIngredientes.Add(objIngrediente.obterPorCodigo());
            }

            return objIngredientes;
        }

        private String[] nomes = new String[] { "Hambuguer", "Queijo", "Pão", "Alface", "Tomate", "Maionese", "Bacon", "Cheddar" };

        public class clnSelecionarIngrediente : clnUtilSelecionar<clnIngrediente>
        {
            internal override int Cod(clnIngrediente obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnIngrediente obj)
            {
                string detalhes = "";
                detalhes += "Valor: " + obj.Valor;

                return detalhes;
            }

            internal override Image Imagem(clnIngrediente obj)
            {
                return obj.Imagem;
            }

            internal override string Nome(clnIngrediente obj)
            {
                return obj.Nome;
            }
        }

    }
}
