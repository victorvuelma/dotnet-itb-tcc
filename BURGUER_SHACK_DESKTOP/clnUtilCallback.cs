using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    internal interface clnUtilCallback
    {

        bool call();

    }

    internal interface clnUtilCallback<X>
    {

        bool call(X x);

    }

    internal interface clnUtilResponseCallback<R, X, Y>
    {

        R call(X x, Y y);

    }

    internal interface clnUtilCallback<X, Y> : clnUtilResponseCallback<bool, X, Y> { };

}