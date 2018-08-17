using BurgerShack.Common;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;

namespace BurgerShack.Desktop
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
        }

        private void abrirMesas()
        {
            uctPrincipalMesas uctMesas = new uctPrincipalMesas{};

            alterarConteudo(uctMesas, "Mesas");
        }

        private void abrirReservas()
        {
            uctPrincipalReservas uctMesas = new uctPrincipalReservas{};

            alterarConteudo(uctMesas, "Reservas");
        }

        private void abrirGerenciamento()
        {
            frmGerenciamento frmGerenciamento = new frmGerenciamento{};
            frmGerenciamento.ShowDialog();
        }

        private void sair()
        {
            if (clnUtilMensagem.mostrarSimNao(App.Name, "Deseja realmente encerrar o sistema?", clnUtilMensagem.MensagemIcone.INFO))
            {
                Close();
            }
        }

        private void atualizarBotoes()
        {
            switch (AppDesktop.FuncionarioAtual.CodCargo)
            {
                case 1:
                    btnReservas.Hide();
                    btnGerenciamento.Hide();
                    break;
                case 2:
                    btnMesas.Hide();
                    btnGerenciamento.Hide();
                    break;
                case 3:
                    btnGerenciamento.Hide();
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnSair, AppDesktop.VisualStyle.ButtonWarningColor);

            abrirMesas();
            atualizarBotoes();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            abrirMesas();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            sair();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            abrirReservas();
        }

        private void btnGerenciamento_Click(object sender, EventArgs e)
        {
            abrirGerenciamento();
        }
    }
}
