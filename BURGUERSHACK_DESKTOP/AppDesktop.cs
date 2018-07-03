using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using UIX;
using SQL_POWERUP;
using System.Windows.Forms;
using BURGUERSHACK_COMMON;

namespace BURGUERSHACK_DESKTOP
{
    class AppDesktop
    {

        private static UIX.uixStyle _visualStyle = UIX.uixStyle.BLUE;
        private static UIX.uixTemplate _visualTemplate = new UIX.uixTemplate
        {
            Style = VisualStyle,
            Icon = Properties.Resources.app_ico,
            ErrorImage = Properties.Resources.imagem_erro
        };

        public static UIX.uixTemplate VisualTemplate { get => _visualTemplate; }
        public static uixStyle VisualStyle { get => _visualStyle; }

        internal static void startup()
        {
            App.DatabaseSql.ExceptionCall = (Exception ex) =>
            {

            };
        }

    }
}
