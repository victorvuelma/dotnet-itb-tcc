using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.Util
{

    public interface IUtilResponseCallback<R>
    {
        R call();
    }

    public interface IUtilResponseCallback<R, A>
    {
        R call(A a);
    }

    public interface IUtilResponseCallback<R, A, B>
    {
        R call(A a, B b);
    }

    public interface IUtilResponseCallback<R, A, B, C>
    {
        R call(A a, B b, C c);
    }

    public interface IUtilCallback : IUtilResponseCallback<bool> { };

    public interface IUtilCallback<A> : IUtilResponseCallback<bool, A> { };

    public interface IUtilCallback<A, B> : IUtilResponseCallback<bool, A, B> { };

    public interface IUtilCallback<A, B, C> : IUtilResponseCallback<bool, A, B, C> { };

}