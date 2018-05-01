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
    public partial class frmCozinha : Form
    {
        public frmCozinha()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        private void frmCozinha_Load(object sender, EventArgs e)
        {
            UIX.uixTemplate _frmTemplate = new UIX.uixTemplate(UIX.uixStyle.SILVER);

            clnTemplate.CommonTemplate.frmApply(this, uctUIX1);
        }
    }
}
