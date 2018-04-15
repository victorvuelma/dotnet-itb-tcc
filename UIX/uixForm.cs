using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace UIX
{

    public class uixForm
    {

        public static void frmApply(Form frm, uctUIX ctl, uixStyle style)
        {
            frm.FormBorderStyle = FormBorderStyle.None;

            uixHeader.hdrApply(frm, ctl, style);

            uixHeader.hdrMove(frm, new Control[] { ctl, ctl.lblTitulo, ctl.picFormIcon });
        }
    }
}
