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
                    dgvFuncionario.Size = pnlConteudo.Size;
                    dgvFuncionario.Location = pnlConteudo.Location;
                    dgvFuncionario.Visible = true;
                    dgvProduto.Visible = false;
                    dgvTercerizada.Visible = false;
                    break;
                case 2:
                    dgvTercerizada.Size = pnlConteudo.Size;
                    dgvTercerizada.Location = pnlConteudo.Location;
                    dgvTercerizada.Visible = true;
                    dgvFuncionario.Visible = false;
                    dgvProduto.Visible = false;
                    break;
                case 3:
                    dgvProduto.Size = pnlConteudo.Size;
                    dgvProduto.Location = pnlConteudo.Location;
                    dgvProduto.Visible = true;
                    dgvFuncionario.Visible = false;
                    dgvTercerizada.Visible = false;
                    break;
            }
        }
    }
}
