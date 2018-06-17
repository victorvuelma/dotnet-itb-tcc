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

        public abstract void abrir(object obj);

    }

    public class clnUtilVisualizar<T> : clnUtilVisualizar
    {

        private clnUtilCallback<clnUtilVisualizar, T> _callbackClick;

        internal clnUtilCallback<clnUtilVisualizar, T> CallbackClick { get => _callbackClick; set => _callbackClick = value; }

        public override void abrir(object obj)
        {
            if (obj != null && obj is T val)
            {
                CallbackClick.call(this, val);
            }
        }

    }
}
