using BurgerShack.Common;
using vitorrdgs.Util;

namespace BurgerShack.Desktop
{

    public abstract class clnUtilVisualizar
    {

        public enum VisualizarResult
        {
            FECHAR,
            REMOVER,
            NENHUM
        }

        internal interface IVisualizarCallback<X, Y> : IUtilResponseCallback<VisualizarResult, X, Y> { };

        private clnUtilListar objListar;

        public clnUtilListar ObjListar { get => objListar; set => objListar = value; }

        public abstract clnUtilVisualizar.VisualizarResult execute(object obj);

    }

    public class clnUtilVisualizar<O, V> : clnUtilVisualizar
    {

        private clnUtilVisualizar.IVisualizarCallback<O, V> _callbackClick;
        private O _obj;

        public O Obj { get => _obj; set => _obj = value; }
        internal clnUtilVisualizar.IVisualizarCallback<O, V> Callback { get => _callbackClick; set => _callbackClick = value; }

        public override clnUtilVisualizar.VisualizarResult execute(object obj)
        {
            if (Obj == null && typeof(O).Equals(typeof(clnUtilVisualizar)))
            {
                Obj = (O)(object)this;
            }
            if (Callback != null && obj != null && obj is V val)
            {
                return Callback.call(Obj, val);
            }
            return clnUtilVisualizar.VisualizarResult.NENHUM;
        }

    }
}
