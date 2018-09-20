using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace vitorrdgs.UiX.Property
{
    public class uixColor
    {
        public static Color AQUA_LIGHT = fromRGB(26, 188, 156);
        public static Color AQUA_DARK = fromRGB(22, 160, 133);

        public static Color BLUE_LIGHT = fromRGB(52, 152, 219);
        public static Color BLUE_DARK = fromRGB(41, 128, 185);

        public static Color GREEN_LIGHT = fromRGB(46, 204, 113);
        public static Color GREEN_DARK = fromRGB(39, 174, 96);

        public static Color GRAY_LIGHT = fromRGB(149, 165, 166);
        public static Color GRAY_DARK = fromRGB(127, 140, 141);

        public static Color INDIGO_LIGHT = fromRGB(52, 73, 94);
        public static Color INDIGO_DARK = fromRGB(44, 62, 80);

        public static Color PURPLE_LIGHT = fromRGB(155, 89, 182);
        public static Color PURPLE_DARK = fromRGB(142, 68, 173);

        public static Color RED_LIGHT = fromRGB(231, 76, 60);
        public static Color RED_DARK = fromRGB(192, 57, 43);

        public static Color SILVER = fromRGB(189, 195, 199);
        public static Color WHITE = fromRGB(236, 240, 241);

        public static Color YELLOW_LIGHT = fromRGB(241, 196, 15);
        public static Color YELLOW_DARK = fromRGB(243, 156, 18);

        public static Color fromRGB(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }

    }

}
