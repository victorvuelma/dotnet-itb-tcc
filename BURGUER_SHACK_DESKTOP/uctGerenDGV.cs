using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class uctGerenDGV : UserControl
    {
        private Control[] uctGeren;
        private DataGridView[] dgvGeren;
        public uctGerenDGV() 
        {
            InitializeComponent();
            uctGeren = new Control[] { uctGerenFuncionario, uctGerenTerceirizada, uctGerenProduto};
            dgvGeren = new DataGridView[] { dgvFuncionario, dgvTercerizada, dgvProduto };
        }

        private void uctGerenDGV_Load(object sender, EventArgs e)
        {
            atualizarConteudo();
        }
        public void atualizarConteudo()
        {
            uctGeren[0].Visible = false; uctGeren[1].Visible = false; uctGeren[2].Visible = false;
            dgvGeren[0].Visible = false; dgvGeren[1].Visible = false; dgvGeren[2].Visible = false;
        }

        private void uctGerenDGV_VisibleChanged(object sender, EventArgs e)
        {
            atualizarConteudo();
        }
    }
}
