using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using UIX;

namespace BURGUER_SHACK_DESKTOP
{
    class clnApp
    {

        private static String appName = "Burguer Shack";

        private static UIX.uixStyle appVisualStyle = UIX.uixStyle.BLUE;
        private static UIX.uixTemplate appVisualTemplate = new UIX.uixTemplate(AppVisualStyle);

        private static int restMesas = 30;

        public static String AppName { get => appName; }

        public static UIX.uixTemplate AppVisualTemplate { get => appVisualTemplate; }

        public static int RestMesas { get => restMesas; set => restMesas = value; }
        public static uixStyle AppVisualStyle { get => appVisualStyle; set => appVisualStyle = value; }
    }
}
