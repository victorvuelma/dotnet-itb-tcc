using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIX;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmGerenciador : Form
    {
        public frmGerenciador()
        {
            InitializeComponent();
            esconderConteudo();

            clnUtil.atualizarTabIndex(Controls);
        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            hdrUIX.Title = clnApp.AppName + " - Gerenciamento";
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
        }

        private void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
        }


        public static void listagemGerenciamento()
        {
            msgGerenciador msg = new msgGerenciador();
            msg.hdrUIX.Title = "Listagem";
            msg.lbl.Text = "Escolhe uma entre as três opções abaixo para ver lista completa.";
            msg.ShowDialog();
        }

        private static void adicionarGerenciamento()
        {
            msgGerenciador msg = new msgGerenciador();
            msg.hdrUIX.Title = "Adicionar";
            msg.lbl.Text = "Escolhe uma entre as três opções abaixo para adicionar.";
            msg.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            listagemGerenciamento();
        }

        uctGerenDGV apelido = new uctGerenDGV();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            apelido.Visible = true;

            adicionarGerenciamento();
            alterarConteudo(new uctGerenDGV(), "Testando");
        }
        
        private void esconderConteudo()
        {
            pnlConteudo.Visible = false;
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void hdrUIX_Min(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
