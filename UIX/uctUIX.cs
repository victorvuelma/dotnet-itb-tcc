using System;
using System.Windows.Forms;

namespace UIX
{

    public partial class uctUIX : UserControl
    {

        private bool _uixBtnCloseEnabled = true;
        private bool _uixBtnMinEnabled = true;

        public uctUIX()
        {
            InitializeComponent();
        }

        public bool UIXButtonCloseEnabled { get => _uixBtnCloseEnabled; set => _uixBtnCloseEnabled = value; }
        public bool UIXButtonMinEnabled { get => _uixBtnMinEnabled; set => _uixBtnMinEnabled = value; }

        public string UIXTitle { get => lblTitulo.Text; set => lblTitulo.Text = value; }

        private void uctUIX_Load(object sender, EventArgs e)
        {

            btnSair.Enabled = UIXButtonCloseEnabled;
            btnSair.Visible = UIXButtonCloseEnabled;

            btnMin.Enabled = UIXButtonMinEnabled;
            btnMin.Visible = UIXButtonMinEnabled;

        }
    }
}
