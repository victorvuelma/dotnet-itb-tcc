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
    public partial class frmMesa : Form
    {
        public frmMesa()
        {
            InitializeComponent();
        }

        private void frmMesa_Load(object sender, EventArgs e)
        {
            clnTemplate.CommonTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnSair, clnTemplate.CommonTemplate.Style.WarningButtonColor);

            abrirMesas();
        }

        public void abrirMesas()
        {
            alterarConteudo(new uctMesaListar(), "Mesas");
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            abrirMesas();
        }

    }
}
