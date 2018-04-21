using System;
using System.Windows.Forms;

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

        public string UIXTitle { get => lblTitulo.Text; set => lblTitulo.Text = value; }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Min(this, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(this, e);
        }
    }
}
