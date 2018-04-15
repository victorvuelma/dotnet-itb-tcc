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
            uctPedido1.Visible = true;
            uctPedido1.Location = new Point(0, 49);

            tplBurguerShack.CommonTemplate.frmApply(this, uctUIX);
        }
    }
}
