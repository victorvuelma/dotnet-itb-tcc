using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using vitorrdgs.UiX.Property;

namespace vitorrdgs.UiX.Manager
{

    public class uixComboBox
    {

        public static void cboApply(ComboBox cbo, uixSet colorSet, Font font)
        {
            uixControl.ctlApply(cbo, colorSet, font);
            uixComboBox.cboApply(cbo, colorSet);
        }

        public static void cboApply(ComboBox cbo, uixSet colorSet)
        {
            uixControl.ctlApply(cbo, colorSet);
            cbo.FlatStyle = FlatStyle.Popup;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
    }

}
