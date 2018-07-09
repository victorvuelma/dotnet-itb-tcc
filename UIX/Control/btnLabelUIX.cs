using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIX
{
    public partial class btnLabelUIX : btnUIX
    { 

        public btnLabelUIX()
        {
            InitializeComponent();

            lbl.TextAlign = ContentAlignment.MiddleCenter;
            pic.Location = new Point(10, 5);

            HoverColor = Color.Transparent;
        }

        private new void update()
        {
            pic.Size = new Size(Width - 20, Width - 20);

            lbl.Size = new Size(Width, Height - Width + 10);
            lbl.Location = new Point(0, Width - 10);
        }

        private void btnLabelUIX_Resize(object sender, EventArgs e)
        {
            update();
        }

        private void btnLabelUIX_FontChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
