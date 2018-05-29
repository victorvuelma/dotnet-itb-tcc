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

        public override IList getOpcoes() => Opcoes;

        internal abstract Image Imagem(T val);

        public override Image getImagem(object obj)
        {
            if (obj !=null && obj is T val)
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
            if (obj !=null && obj is T val)
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

        internal abstract void Abrir(T val);

        public override void abrir(object obj)
        {
            if (obj != null && obj is T val)
            {
                Abrir(val);
            }
        }

    }
}
