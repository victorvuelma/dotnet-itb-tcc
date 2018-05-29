using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{

    public abstract class clnUtilSelecionar
    {

        public abstract object getSelecionado();

        public abstract bool setSelecionado(object obj);

        public abstract IList getOpcoes();

        public abstract Image getImagem(object obj);

        public abstract String getNome(object obj);

        public abstract String getDetalhes(object obj);

        public abstract int getCod(object obj);

    }

    public abstract class clnUtilSelecionar<T> : clnUtilSelecionar
    {
        private List<T> _opcoes;
        private T _selecionado;

        public List<T> Opcoes { get => _opcoes; set => _opcoes = value; }
        public T Selecionado { get => _selecionado; set => _selecionado = value; }

        public override IList getOpcoes() => Opcoes;

        public override object getSelecionado() => Selecionado;

        public override bool setSelecionado(object obj)
        {
            if (obj != null && obj is T val && !val.Equals(Selecionado))
            {
                Selecionado = val;
                return true;
            }
            return false;
        }

        internal abstract Image Imagem(T val);

        public override Image getImagem(object obj)
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
