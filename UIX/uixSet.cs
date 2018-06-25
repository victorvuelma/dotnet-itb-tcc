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
        private Color _backColor;

        public Color ContentColor { get => _contentColor; set => _contentColor = value; }
        public Color DarkColor { get => _darkColor; set => _darkColor = value; }
        public Color BackColor { get => _backColor; set => _backColor = value; }

        public static uixSet AQUA = new uixSet { DarkColor = uixColor.AQUA_DARK, BackColor = uixColor.AQUA_LIGHT, ContentColor = uixColor.WHITE };
        public static uixSet BLUE = new uixSet { DarkColor = uixColor.BLUE_DARK, BackColor = uixColor.BLUE_LIGHT, ContentColor = uixColor.WHITE };
        public static uixSet GRAY = new uixSet { DarkColor = uixColor.GRAY_DARK, BackColor = uixColor.GRAY_LIGHT, ContentColor = uixColor.INDIGO_LIGHT };
        public static uixSet GREEN = new uixSet { DarkColor = uixColor.GREEN_DARK, BackColor = uixColor.GREEN_LIGHT, ContentColor = uixColor.WHITE };
        public static uixSet INDIGO = new uixSet { DarkColor = uixColor.INDIGO_DARK, BackColor = uixColor.INDIGO_LIGHT, ContentColor = uixColor.WHITE };
        public static uixSet PURPLE = new uixSet { DarkColor = uixColor.PURPLE_DARK, BackColor = uixColor.PURPLE_LIGHT, ContentColor = uixColor.WHITE };
        public static uixSet RED = new uixSet { DarkColor = uixColor.RED_DARK, BackColor = uixColor.RED_LIGHT, ContentColor = uixColor.WHITE };
        public static uixSet WHITE = new uixSet { DarkColor = uixColor.SILVER, BackColor = uixColor.WHITE, ContentColor = uixColor.INDIGO_LIGHT };

    }

}
