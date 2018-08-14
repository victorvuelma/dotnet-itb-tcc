using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerShack.Common.UTIL
{

    public interface IUtilResponseCallback<R>
    {
        R call();
    }


    public interface IUtilResponseCallback<R, X, Y>
    {
        R call(X x, Y y);
    }

    public interface IUtilResponseCallback<R, X>
    {
        R call(X x);
    }

    public interface IUtilCallback : IUtilResponseCallback<bool> { };

    public interface IUtilCallback<X> : IUtilResponseCallback<bool, X> { };

    public interface IUtilCallback<X, Y> : IUtilResponseCallback<bool, X, Y> { };

}