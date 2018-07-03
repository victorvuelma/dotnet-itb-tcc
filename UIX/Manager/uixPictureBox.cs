using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIX
{
    class uixPictureBox
    {
        
        public static void picApply(PictureBox pic, uixSet colorSet, Image errorImage)
        {
            uixControl.ctlApply(pic, colorSet);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.ErrorImage = errorImage;
        }

    }
}
