using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{
    class uixMaskedTextBox
    {

        public static void mtbApply(MaskedTextBox mtb, uixSet colorSet, Font font)
        {
            mtb.Font = uixFont.fontSize(font, mtb.Font.Size);
            uixMaskedTextBox.mtbApply(mtb, colorSet);
        }

        public static void mtbApply(MaskedTextBox mtb, uixSet colorSet)
        {
            mtb.BackColor = colorSet.LightColor;
            mtb.ForeColor = colorSet.ContentColor;
            mtb.BorderStyle = BorderStyle.None;
            mtb.Margin = new Padding(5);
        }


    }
}
