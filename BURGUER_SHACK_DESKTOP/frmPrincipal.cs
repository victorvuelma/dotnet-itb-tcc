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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            App.VisualTemplate.frmApply(this, hdrUIX);
            UIX.uixButton.btnApply(btnSair, App.VisualStyle.ButtonWarningColor);

            clnUtil.atualizarForm(this);   

            abrirMesas();
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
