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
        public uctGerenDGV()
        {
            InitializeComponent();
        }

        private void uctGerenDGV_Load(object sender, EventArgs e)
        {
            uctGerenDGV uctGerenDGV = new uctGerenDGV();
            switch (msgGerenciador.clicouEm)
            {
                case 1:
                    dgvFuncionario.Size = new Size(812, 532);
                    dgvFuncionario.Location = new Point(3, 3);
                    dgvFuncionario.Visible = true;
                    dgvProduto.Visible = false;
                    dgvTercerizada.Visible = false;
                    break;
                case 2:
                    dgvTercerizada.Size = new Size(812, 532);
                    dgvTercerizada.Location = new Point(3, 3);
                    dgvTercerizada.Visible = true;
                    dgvFuncionario.Visible = false;
                    dgvProduto.Visible = false;
                    break;
                case 3:
                    dgvProduto.Size = new Size(812, 532);
                    dgvProduto.Location = new Point(3, 3);
                    dgvProduto.Visible = true;
                    dgvFuncionario.Visible = false;
                    dgvTercerizada.Visible = false;
                    break;
            }
        }
    }
}
