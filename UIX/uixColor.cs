using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace UIX
{
    public class uixColor
    {
        public static Color AQUA_LIGHT = uixColor.fromRGB(26, 188, 156);
        public static Color AQUA_DARK = uixColor.fromRGB(22, 160, 133);

        public static Color BLUE_LIGHT = uixColor.fromRGB(52, 152, 219);
        public static Color BLUE_DARK = uixColor.fromRGB(41, 128, 185);

        public static Color GREEN_LIGHT = uixColor.fromRGB(46, 204, 113);
        public static Color GREEN_DARK = uixColor.fromRGB(39, 174, 96);

        public static Color GRAY_LIGHT = uixColor.fromRGB(149, 165, 166);
        public static Color GRAY_DARK = uixColor.fromRGB(127, 140, 141);

        public static Color INDIGO_LIGHT = uixColor.fromRGB(52, 73, 94);
        public static Color INDIGO_DARK = uixColor.fromRGB(44, 62, 80);

        public static Color PURPLE_LIGHT = uixColor.fromRGB(155, 89, 182);
        public static Color PURPLE_DARK = uixColor.fromRGB(142, 68, 173);

        public static Color RED_LIGHT = uixColor.fromRGB(231, 76, 60);
        public static Color RED_DARK = uixColor.fromRGB(192, 57, 43);

        public static Color SILVER = uixColor.fromRGB(189, 195, 199);
        public static Color WHITE = uixColor.fromRGB(236, 240, 241);

        public static Color YELLOW_LIGHT = uixColor.fromRGB(241, 196, 15);
        public static Color YELLOW_DARK = uixColor.fromRGB(243, 156, 18);

        public static Color fromRGB(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }

    }

}
