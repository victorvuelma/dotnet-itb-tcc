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
    public partial class frmGerenciador : Form
    {
        public frmGerenciador()
        {
            InitializeComponent();
        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            uctUIX.UIXTitle = tplBurguerShack.AppName + " - Gerenciamento";
            tplBurguerShack.CommonTemplate.frmApply(this, uctUIX);
        }
    }
}
