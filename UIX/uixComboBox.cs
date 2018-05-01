using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace UIX
{

    public class uixComboBox
    {

        public static void cboApply(ComboBox cbo, uixSet colorSet, Font font)
        {
            cbo.Font = uixFont.fontSize(font, cbo.Font.Size);
            uixComboBox.cboApply(cbo, colorSet);
        }

        public static void cboApply(ComboBox cbo, uixSet colorSet)
        {
            cbo.FlatStyle = FlatStyle.Popup;
            cbo.BackColor = colorSet.LightColor;
            cbo.ForeColor = colorSet.ContentColor;
            cbo.Margin = new Padding(0);
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

}
