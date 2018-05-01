using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace BURGUER_SHACK_DESKTOP
{
    class clnApp
    {

        private static String appName = "Burguer Shack";
                
        private static UIX.uixTemplate commonTemplate = new UIX.uixTemplate(UIX.uixStyle.BLUE);

        private static int restMesas = 30;

        public static string AppName { get => appName; }

        public static UIX.uixTemplate CommonTemplate { get => commonTemplate; }

        public static int RestMesas { get => restMesas; set => restMesas = value; }
    }
}
