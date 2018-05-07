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
        public static int clicouEm = 0;
        public static int adicionar = 0;

        private void msgGerenciador_Load(object sender, EventArgs e)
        {
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);
        }

        private void btnFuncionário_Click(object sender, EventArgs e)
        {
            if (hdrUIX.Title == "Adicionar")
            {
                adicionar = 1;
                Close();
            }
            else
            {
                clicouEm = 1;
                Close();
            }
        }

        private void btnTerceirizada_Click(object sender, EventArgs e)
        {

            if (hdrUIX.Title == "Adicionar")
            {
                adicionar = 2;
                Close();
            }
            else
            {
                clicouEm = 2;
                Close();
            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {

            if (hdrUIX.Title == "Adicionar")
            {
                adicionar = 3;
                Close();
            }
            else
            {
                clicouEm = 3;
                Close();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            clicouEm = -1;
            adicionar = -1;
            Close();
        }
    }
}
