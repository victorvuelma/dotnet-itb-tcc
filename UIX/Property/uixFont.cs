using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace vitorrdgs.UiX.Property
{
    public class uixFont
    {

        public static Font CENTURY_REGULAR = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static Font CENTURY_BOLD = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static Font LATO_BLACK = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static Font SANS_SERIF = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);

        public static Font alterFont(Font font, Font oldFont, float size)
        {
            FontStyle fontStyle = oldFont.Style;
            if (oldFont.Style == FontStyle.Regular && font.Style != FontStyle.Regular)
            {
                fontStyle = font.Style;
            }
            return new Font(font.FontFamily, size, fontStyle);
        }

        public static Font alterFont(Font font, Font oldFont)
        {
            return alterFont(font, oldFont, oldFont.Size);
        }

        public static Font alterFont(Font font, float size)
        {
            return alterFont(font, font, size);
        }

    }

}
