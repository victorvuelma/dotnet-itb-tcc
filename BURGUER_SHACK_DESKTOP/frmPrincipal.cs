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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void abrirMesas()
        {
            alterarConteudo(new uctPrincipalMesas(), "Mesas");
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clnTemplate.CommonTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnSair, clnTemplate.CommonTemplate.Style.WarningButtonColor);

            abrirMesas();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            abrirMesas();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
