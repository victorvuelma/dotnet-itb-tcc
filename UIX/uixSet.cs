using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace UIX
{
    public class uixSet
    {

        private Color _contentColor;
        private Color _darkColor;
        private Color _lightColor;

        private uixSet(Color darkColor, Color lightColor, Color contentColor)
        {
            _contentColor = contentColor;
            _darkColor = darkColor;
            _lightColor = lightColor;
        }

        public Color ContentColor { get => _contentColor; }
        public Color DarkColor { get => _darkColor; }
        public Color LightColor { get => _lightColor; }

        public static uixSet AQUA = new uixSet(uixColor.AQUA_DARK, uixColor.AQUA_LIGHT, uixColor.WHITE);
        public static uixSet BLUE = new uixSet(uixColor.BLUE_DARK, uixColor.BLUE_LIGHT, uixColor.WHITE);
        public static uixSet GRAY = new uixSet(uixColor.GRAY_DARK, uixColor.GRAY_LIGHT, uixColor.INDIGO_LIGHT);
        public static uixSet GREEN = new uixSet(uixColor.GREEN_DARK, uixColor.GREEN_LIGHT, uixColor.WHITE);
        public static uixSet INDIGO = new uixSet(uixColor.INDIGO_DARK, uixColor.INDIGO_LIGHT, uixColor.WHITE);
        public static uixSet PURPLE = new uixSet(uixColor.PURPLE_DARK, uixColor.PURPLE_LIGHT, uixColor.WHITE);
        public static uixSet RED = new uixSet(uixColor.RED_DARK, uixColor.RED_LIGHT, uixColor.WHITE);
        public static uixSet WHITE = new uixSet(uixColor.SILVER, uixColor.WHITE, uixColor.INDIGO_LIGHT);

    }

}
