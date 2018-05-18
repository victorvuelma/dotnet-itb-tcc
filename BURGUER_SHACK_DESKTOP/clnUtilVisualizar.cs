using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{

    public abstract class clnUtilVisualizar
    {

        public abstract IList getOpcoes();

        public abstract Image getImagem(object obj);

        public abstract String getNome(object obj);

        public abstract String getDetalhes(object obj);

        public abstract void abrir(object obj);

        public abstract int getCod(object obj);

    }

    public abstract class clnUtilVisualizar<T> : clnUtilVisualizar
    {
        private List<T> _opcoes;

        public List<T> Opcoes { get => _opcoes; set => _opcoes = value; }

        public override IList getOpcoes()
        {
            return Opcoes;
        }

        internal abstract Image Imagem(T obj);

        public override Image getImagem(object o)
        {
            if (o is T obj)
            {
                return Imagem(obj);
            }
            return null;
        }

        internal abstract String Nome(T obj);

        public override string getNome(object o)
        {
            if (o is T obj)
            {
                return Nome(obj);
            }
            return null;
        }

        internal abstract String Detalhes(T obj);

        public override string getDetalhes(object o)
        {
            if (o is T obj)
            {
                return Detalhes(obj);
            }
            return null;
        }

        internal abstract int Cod(T obj);

        public override int getCod(object o)
        {
            if (o is T obj)
            {
                return Cod(obj);
            }
            return -1;
        }

        internal abstract void Abrir(T obj);

        public override void abrir(object o)
        {
            if (o is T obj)
            {
                Abrir(obj);
            }
        }

    }
}
