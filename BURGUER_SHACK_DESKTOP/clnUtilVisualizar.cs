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

        private clnUtilListar objListar;

        public clnUtilListar ObjListar { get => objListar; set => objListar = value; }

        public abstract bool click(object obj);

    }

    public class clnUtilVisualizar<O, V> : clnUtilVisualizar
    {

        private clnUtilCallback<O, V> _callbackClick;
        private O _obj;

        public clnUtilVisualizar()
        {
            if(this is O obj)
            {
                Obj = obj;
            }
        }

        public O Obj { get => _obj; set => _obj = value; }
        internal clnUtilCallback<O, V> CallbackClick { get => _callbackClick; set => _callbackClick = value; }

        public override bool click(object obj)
        {
            if (CallbackClick != null && obj != null && obj is V val)
            {
                return CallbackClick.call(Obj, val);
            }
            return false;
        }

    }
}
