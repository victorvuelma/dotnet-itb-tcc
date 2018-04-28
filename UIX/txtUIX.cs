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
    public partial class txtUIX : UserControl
    {
        public txtUIX()
        {
            InitializeComponent();
        }

        public String Campo {
            get => lblCampo.Text;
            set {
                lblCampo.Text = value;
                int x = lblCampo.Size.Width;
                txtCampo.Location = new Point(x, txtCampo.Location.Y);
            }
        }

        public String Text { get => txtCampo.Text; set => txtCampo.Text = value; }

        public Size Size
        {
            get => base.Size;
            set
            {
                Size current = base.Size;
                txtCampo.Size = new Size(value.Width - lblCampo.Size.Width - 50, txtCampo.Size.Height);
                base.Size = value;
            }
        }

    }
}
