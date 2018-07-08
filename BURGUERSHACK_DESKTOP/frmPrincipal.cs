using BURGUERSHACK_COMMON.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUERSHACK_DESKTOP
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

        private void abrirMesas()
        {
            uctPrincipalMesas uctMesas = new uctPrincipalMesas
            {
                CodFuncionario = CodFuncionario
            };

            alterarConteudo(uctMesas, "Mesas");
        }

        private void abrirReservas()
        {
            uctPrincipalReservas uctMesas = new uctPrincipalReservas
            {
                CodFuncionario = CodFuncionario
            };

            alterarConteudo(uctMesas, "Reservas");
        }

        private void abrirGerenciamento()
        {
            frmGerenciamento frmGerenciamento = new frmGerenciamento
            {
                CodFuncionario = CodFuncionario
            };
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
            clnFuncionario objFuncionario = new clnFuncionario
            {
                Cod = CodFuncionario
            }.obterPorCod();

            switch (objFuncionario.CodCargo)
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
            UIX.uixButton.btnApply(btnSair, AppDesktop.VisualStyle.ButtonWarningColor);

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
