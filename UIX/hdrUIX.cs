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

        public bool ButtonCloseEnabled { get => btnClo.Visible; set => btnClo.Visible = value; }
        public bool ButtonMinEnabled { get => btnMin.Visible; set => btnMin.Visible = value; }

        public Image Image { get => pic.Image; set => pic.Image = value; }

        public new String Text { get => lbl.Text; set => lbl.Text = value; }

        public new Size Size
        {
            get => base.Size;
            set
            {
                base.Size = value;
                lbl.Size = new Size(value.Width, value.Height);
                btnClo.Location = new Point(value.Width - 50, 10);
                btnMin.Location = new Point(value.Width - 100, 10);
            }
        }

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
