using System;
using System.Windows.Forms;

namespace UIX
{

    public partial class ctlUIX : UserControl
    {

        private String _uixTitle = "";

        private bool _uixBtnCloseEnabled = true;
        private bool _uixBtnMinEnabled = true;

        public ctlUIX()
        {
            InitializeComponent();
        }

        public bool UIXButtonCloseEnabled { get => _uixBtnCloseEnabled; set => _uixBtnCloseEnabled = value; }
        public bool UIXButtonMinEnabled { get => _uixBtnMinEnabled; set => _uixBtnMinEnabled = value; }

        public string UIXTitle { get => _uixTitle; set => _uixTitle = value; }

        private void ctlUIX_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = UIXTitle;

            btnSair.Enabled = UIXButtonCloseEnabled;
            btnSair.Visible = UIXButtonCloseEnabled;

            btnMin.Enabled = UIXButtonMinEnabled;
            btnMin.Visible = UIXButtonMinEnabled;

        }
    }
}
