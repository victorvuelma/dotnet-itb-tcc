﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    internal interface clnUtilCallback<X, Y>
    {

        bool call(X x, Y y);

    }

    internal interface clnUtilCallback<X>
    {

        bool call(X x);

    }

    internal interface clnUtilCallback
    {

        bool call();

    }
}
