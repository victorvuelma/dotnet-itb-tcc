using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BURGUERSHACK_DESKTOP
{

    public abstract class clnUtilVisualizar
    {

        public enum visualizarAction
        {
            FECHAR,
            REMOVER_ITEM,
            NADA
        }

        internal interface visualizarCallback<X, Y> : clnUtilResponseCallback<visualizarAction, X, Y> { };

        private clnUtilListar objListar;

        public clnUtilListar ObjListar { get => objListar; set => objListar = value; }

        public abstract clnUtilVisualizar.visualizarAction action(object obj);

    }

    public class clnUtilVisualizar<O, V> : clnUtilVisualizar
    {

        private clnUtilVisualizar.visualizarCallback<O, V> _callbackClick;
        private O _obj;

        public clnUtilVisualizar()
        {
            if (this is O obj)
            {
                Obj = obj;
            }
        }

        public O Obj { get => _obj; set => _obj = value; }
        internal clnUtilVisualizar.visualizarCallback<O, V> Callback { get => _callbackClick; set => _callbackClick = value; }

        public override clnUtilVisualizar.visualizarAction action(object obj)
        {
            if (Callback != null && obj != null && obj is V val)
            {
                return Callback.call(Obj, val);
            }
            return clnUtilVisualizar.visualizarAction.NADA;
        }

    }
}
