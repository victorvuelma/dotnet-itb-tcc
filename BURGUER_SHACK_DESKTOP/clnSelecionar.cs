using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{

    abstract class clnSelecionar
    {

        public abstract object getSelecionado();

        public abstract bool setSelecionado(object obj);

        public abstract IList getOpcoes();

        public abstract Image getImagem(object obj);

        public abstract String getNome(object obj);

        public abstract String getDetalhes(object obj);

        public abstract int getCod(object obj);

    }

    abstract class clnSelecionar<T> : clnSelecionar
    {
        private List<T> _opcoes;
        private T _selecionado;

        public List<T> Opcoes { get => _opcoes; set => _opcoes = value; }
        public T Selecionado { get => _selecionado; set => _selecionado = value; }

        public override IList getOpcoes()
        {
            return Opcoes;
        }

        public override object getSelecionado()
        {
            return Selecionado;
        }

        public override bool setSelecionado(object obj)
        {
            if (obj is T && !obj.Equals(Selecionado))
            {
                Selecionado = (T)obj;
                return true;
            }
            return false;
        }

        internal abstract Image Imagem(T obj);

        public override Image getImagem(object obj)
        {
            if (obj is T)
            {
                return Imagem((T)obj);
            }
            return null;
        }

        internal abstract String Nome(T obj);

        public override string getNome(object obj)
        {
            if (obj is T)
            {
                return Nome((T)obj);
            }
            return null;
        }

        internal abstract String Detalhes(T obj);

        public override string getDetalhes(object obj)
        {
            if (obj is T)
            {
                return Detalhes((T)obj);
            }
            return null;
        }

        internal abstract int Cod(T obj);

        public override int getCod(object obj)
        {
            if (obj is T)
            {
                return Cod((T)obj);
            }
            return -1;
        }

    }
}
