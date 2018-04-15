using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIX;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UIX.UIXTemplate _frmTemplate = new UIX.UIXTemplate(UIX.UIXStyle.SILVER, new UIX.UIXImageTemplate(null, null));

            _frmTemplate.frmApply(this, ctlUIX1);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
