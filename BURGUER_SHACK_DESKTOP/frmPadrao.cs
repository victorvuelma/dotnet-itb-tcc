using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmPadrao : Form
    {
        public frmPadrao()
        {
            InitializeComponent();
        }

        private void frmPadrao_Load(object sender, EventArgs e)
        {
            UIX.UIXTemplate _frmTemplate = new UIX.UIXTemplate(UIX.UIXStyle.BLUE, new UIX.UIXImageTemplate(tplBurguerShack.CommonLogo, null));

            _frmTemplate.frmApply(this, uctUIX);
        }
    }
}
