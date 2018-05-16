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
    public partial class msgGerenciador : Form
    {
        public msgGerenciador()
        {
            InitializeComponent();
        }

        private int gerentType = -1;

        public int GerentType { get => gerentType; set => gerentType = value; }

        private void msgGerenciador_Load(object sender, EventArgs e)
        {
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            GerentType = 1;
            Close();
        }

        private void btnTerceirizada_Click(object sender, EventArgs e)
        {
            GerentType = 2;
            Close();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            GerentType = 3;
            Close();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
