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
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
        }

        private void fechar()
        {
            if(clnMensagem.mostrarSimNao("Sistema", "Deseja realmente encerrar o sistema?", clnMensagem.MensagemIcone.INFO))
            {
                Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnSair, clnApp.AppVisualStyle.WarningButtonColor);

            abrirMesas();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            abrirMesas();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

    }
}
