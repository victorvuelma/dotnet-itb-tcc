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

        public new Size Size
        {
            get => base.Size;
            set
            {
                base.Size = value;

                pic.Size = new Size(value.Width - 20, value.Width - 20);

                lbl.Size = new Size(value.Width, value.Height - value.Width + 10);
                lbl.Location = new Point(0, value.Width - 10);
            }
        }

    }
}
