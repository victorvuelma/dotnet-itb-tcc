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
        public int clicouEm = 0;

        private void msgGerenciador_Load(object sender, EventArgs e)
        {
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);
        }

        private void btnFuncionário_Click(object sender, EventArgs e)
        {
            frmGerenciador frm = new frmGerenciador();
            frm.dgvFuncionario.Visible = true;
            frm.dgvTercerizada.Visible = false;
            frm.dgvProduto.Visible = false;
            clicouEm = 1;
        }

        private void btnTerceirizada_Click(object sender, EventArgs e)
        {
            frmGerenciador frm = new frmGerenciador();
            frm.dgvFuncionario.Visible = false;
            frm.dgvTercerizada.Visible = true;
            frm.dgvProduto.Visible = false;
            clicouEm = 2;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmGerenciador frm = new frmGerenciador();
            frm.dgvFuncionario.Visible = false;
            frm.dgvTercerizada.Visible = false;
            frm.dgvProduto.Visible = true;
            clicouEm = 3;
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
