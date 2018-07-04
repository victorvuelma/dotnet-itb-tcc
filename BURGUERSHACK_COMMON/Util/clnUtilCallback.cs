using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUERSHACK_COMMON
{

    public interface clnUtilResponseCallback<R>
    {
        R call();
    }


    public interface clnUtilResponseCallback<R, X, Y>
    {
        R call(X x, Y y);
    }

    public interface clnUtilResponseCallback<R, X>
    {
        R call(X x);
    }

    public interface clnUtilCallback : clnUtilResponseCallback<bool> { };

    public interface clnUtilCallback<X> : clnUtilResponseCallback<bool, X> { };

    public interface clnUtilCallback<X, Y> : clnUtilResponseCallback<bool, X, Y> { };

}