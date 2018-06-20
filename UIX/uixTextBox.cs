using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{
    public class uixTextBox
    {

        public static void txtApply(TextBoxBase txt, uixSet colorSet, Font font)
        {
            txt.Font = uixFont.fontSize(font, txt.Font.Size);
            uixTextBox.txtApply(txt, colorSet);
        }

        public static void txtApply(TextBoxBase txt, uixSet colorSet)
        {
            txt.BackColor = colorSet.LightColor;
            txt.ForeColor = colorSet.ContentColor;
            txt.BorderStyle = BorderStyle.None;
            if (txt.Multiline && txt is TextBox box)
            {
                box.ScrollBars = ScrollBars.Vertical;
            }
        }
    }
}
