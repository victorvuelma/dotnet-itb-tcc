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

        private static Image commonLogo = global::BURGUER_SHACK_DESKTOP.Properties.Resources.menu;

        private static UIX.uixImageTemplate commonTemplateImage = new UIX.uixImageTemplate(CommonLogo, null);
        private static UIX.uixTemplate commonTemplate = new UIX.uixTemplate(UIX.uixStyle.BLUE, CommonImageTemplate);

        public static Image CommonLogo { get => commonLogo; }
        public static string AppName { get => appName; }
        public static UIX.uixImageTemplate CommonImageTemplate { get => commonTemplateImage; }
        public static UIX.uixTemplate CommonTemplate { get => commonTemplate; }
    }
}
