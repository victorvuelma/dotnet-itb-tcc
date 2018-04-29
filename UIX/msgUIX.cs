using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIX
{
    public partial class msgUIX : Form
    {
        public msgUIX()
        {
            InitializeComponent();
        }

        public static msgUIX messageBox(String titulo, Image image, uixTemplate template)
        {
            msgUIX msg = new msgUIX();

            msg.uctUIX.UIXTitle = titulo;
            msg.Text = titulo;

            msg.uctUIX.UIXImage = image;

            template.frmApply(msg, msg.uctUIX);


            return msg;
        }
    }
}
