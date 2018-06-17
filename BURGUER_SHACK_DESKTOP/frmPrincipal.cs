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

        private int _codFuncionario;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
        }

        public void abrirMesas()
        {
            uctPrincipalMesas uctMesas = new uctPrincipalMesas
            {
                CodFuncionario = CodFuncionario
            };

            alterarConteudo(uctMesas, "Mesas");
        }

        public void abrirReservas()
        {
            uctPrincipalReservas uctMesas = new uctPrincipalReservas
            {
                CodFuncionario = CodFuncionario
            };

            alterarConteudo(uctMesas, "Reservas");
        }

        private void fechar()
        {
            if (clnUtilMensagem.mostrarSimNao("Sistema", "Deseja realmente encerrar o sistema?", clnUtilMensagem.MensagemIcone.INFO))
            {
                Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnSair, App.AppVisualStyle.ButtonWarningColor);

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

        private void btnReservas_Click(object sender, EventArgs e)
        {
            abrirReservas();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            new frmCliente { }.Show();
        }
    }
}
