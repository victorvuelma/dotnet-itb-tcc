using System;
using System.Windows.Forms;
using System.Drawing;

namespace UIX
{

    public partial class hdrUIX : UserControl
    {

        public hdrUIX()
        {
            InitializeComponent();
        }

        public event EventHandler Close;
        public event EventHandler Min;

        public bool UIXButtonCloseEnabled { get => btnClo.Visible; set => btnClo.Visible = value; }
        public bool UIXButtonMinEnabled { get => btnMin.Visible; set => btnMin.Visible = value; }

        public Image UIXImage { get => pic.Image; set => pic.Image = value; }

        public String UIXTitle { get => lbl.Text; set => lbl.Text = value; }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (Min != null)
            {
                Min(this, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Close != null)
            {
                Close(this, e);
            }
        }

    }
}
