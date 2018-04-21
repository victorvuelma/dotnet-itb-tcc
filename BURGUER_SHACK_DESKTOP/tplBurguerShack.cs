using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class tplBurguerShack
    {

        private static String appName = "Burguer Shack";
                
        private static UIX.uixTemplate commonTemplate = new UIX.uixTemplate(UIX.uixStyle.BLUE);

        public static string AppName { get => appName; }
        public static UIX.uixTemplate CommonTemplate { get => commonTemplate; }
    }
}
