using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
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
            uctPrincipalMesas uctMesas = new uctPrincipalMesas { };

            alterarConteudo(uctMesas, "Mesas");
        }

        private void abrirReservas()
        {
            uctPrincipalReservas uctMesas = new uctPrincipalReservas { };

            alterarConteudo(uctMesas, "Reservas");
        }

        private void abrirGerenciamento()
        {
            frmConfirmar frmConfirmar = new frmConfirmar();
            frmConfirmar.ShowDialog();
            if (frmConfirmar.Confirmado)
            {
                frmGerenciamento frmGerenciamento = new frmGerenciamento { };
                frmGerenciamento.ShowDialog();
            }
        }

        private void sair()
        {
            if (UtilMensagem.mostrarSimNao(App.Name, "Deseja realmente encerrar o sistema?", UtilMensagem.MensagemIcone.INFO))
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

        private void btnSenha_Click(object sender, EventArgs e)
        {
            frmConfirmar frmConfirmar = new frmConfirmar();
            frmConfirmar.ShowDialog();

            if (frmConfirmar.Confirmado)
            {
                clnAcesso objAcesso = new clnAcesso
                {
                    CodFuncionario = AppDesktop.FuncionarioAtual.Cod
                }.obterPorFuncionario();

                frmAcesso frmAlterarSenha = new frmAcesso();
                frmAlterarSenha.ObjAcesso = objAcesso;
                frmAlterarSenha.ShowDialog();
            }
        }
    }
}
