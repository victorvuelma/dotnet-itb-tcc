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
            uixControl.ctlApply(txt, colorSet, font);
            uixTextBox.txtApply(txt, colorSet);
        }

        public static void txtApply(TextBoxBase txt, uixSet colorSet)
        {
            uixControl.ctlApply(txt, colorSet);
            txt.BorderStyle = BorderStyle.None;
            if (txt.Multiline && txt is TextBox box)
            {
                box.ScrollBars = ScrollBars.Vertical;
            }
            if (txt.ReadOnly)
            {
                txt.Cursor = Cursors.Default;
            }
        }
    }
}
