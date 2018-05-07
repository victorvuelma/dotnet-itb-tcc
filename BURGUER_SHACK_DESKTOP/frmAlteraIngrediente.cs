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
    public partial class frmAlteraIngrediente : Form
    {
        public frmAlteraIngrediente()
        {
            InitializeComponent();
        }

        private void frmAlteraIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarTabIndex(Controls);
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);

            UIX.uixButton.btnApply(btnRemover, clnApp.AppVisualStyle.ButtonWarningColor);
        }
    }
}
