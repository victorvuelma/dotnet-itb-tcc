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

    public partial class frmEstoqueold : Form
    {

        public frmEstoqueold()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            hdrUIX.Title = App.Name + " - Estoque";
            clnUtil.atualizarForm(this);
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void hdrUIX_Min(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
