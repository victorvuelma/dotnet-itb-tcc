using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{
    public class uixButton
    {

        public static void btnApply(Button btn, uixSet colorSet)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = colorSet.LightColor;
            btn.FlatAppearance.BorderColor = colorSet.DarkColor;
            btn.FlatAppearance.MouseDownBackColor = colorSet.DarkColor;
            btn.FlatAppearance.MouseOverBackColor = colorSet.DarkColor;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = colorSet.ContentColor;
            btn.Cursor = Cursors.Hand;
        }

        public static void btnApply(Button btn, uixSet colorSet, Font font)
        {
            uixButton.btnApply(btn, colorSet);
            btn.Font = font;
        }

        public static void btnSquare(Button btn, int size)
        {
            uixButton.btnSize(btn, size, size);
        }

        public static void btnSize(Button btn, int x, int y)
        {
            btn.Height = y;
            btn.Width = x;
        }

        public static void btnStyleClose(Button btn, int size, uixSet colorSet)
        {
            uixButton.btnApply(btn, colorSet, uixFont.fontSize(uixFont.SANS_SERIF, 12F));
            btn.Text = "X";
            btn.TabIndex = int.MaxValue;
            uixButton.btnSquare(btn, size);
        }

        public static void btnStyleMinimize(Button btn, int size, uixSet colorSet)
        {
            uixButton.btnApply(btn, colorSet, uixFont.fontSize(uixFont.SANS_SERIF, 12F));
            btn.Text = "_";
            btn.TabIndex = int.MaxValue;
            uixButton.btnSquare(btn, size);
        }

    }

}
