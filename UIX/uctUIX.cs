using System;
using System.Windows.Forms;
using System.Drawing;

namespace UIX
{

    public partial class uctUIX : UserControl
    {

        public uctUIX()
        {
            InitializeComponent();
        }

        public event EventHandler Close;
        public event EventHandler Min;

        public bool UIXButtonCloseEnabled { get => btnClose.Visible; set => btnClose.Visible = value; }
        public bool UIXButtonMinEnabled { get => btnMin.Visible; set => btnMin.Visible = value; }

        public Image UIXImage { get => picFormIcon.Image; set => picFormIcon.Image = value; }

        public String UIXTitle { get => lblTitulo.Text; set => lblTitulo.Text = value; }

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
