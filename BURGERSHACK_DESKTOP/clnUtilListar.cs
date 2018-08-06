using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BURGERSHACK_DESKTOP
{

    public abstract class clnUtilListar
    {
        
        private Image _icone = Properties.Resources.lista;
        private String _titulo = "";

        public Image Icone { get => _icone; set => _icone = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }

        public abstract IList getOpcoes();

        public abstract String getImagem(object obj);

        public abstract String getNome(object obj);

        public abstract String getDetalhes(object obj);

        public abstract int getCod(object obj);

    }

    public abstract class clnUtilListar<T> : clnUtilListar
    {
        private List<T> _opcoes;

        public List<T> Opcoes { get => _opcoes; set => _opcoes = value; }

        public override IList getOpcoes() => Opcoes;

        internal abstract String Imagem(T val);

        public override String getImagem(object obj)
        {
            if (obj != null && obj is T val)
            {
                return Imagem(val);
            }
            return null;
        }

        internal abstract String Nome(T val);

        public override string getNome(object obj)
        {
            if (obj != null && obj is T val)
            {
                return Nome(val);
            }
            return null;
        }

        internal abstract String Detalhes(T val);

        public override string getDetalhes(object obj)
        {
            if (obj != null && obj is T val)
            {
                return Detalhes(val);
            }
            return null;
        }

        internal abstract int Cod(T val);

        public override int getCod(object obj)
        {
            if (obj != null && obj is T val)
            {
                return Cod(val);
            }
            return -1;
        }

    }
}
