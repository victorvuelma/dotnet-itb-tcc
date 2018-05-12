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
        uctGerenDGV apelido = new uctGerenDGV();


        public static void listagemGerenciamento()
        {
            msgGerenciador msg = new msgGerenciador();
            msg.hdrUIX.Title = "Listagem";
            msg.lbl.Text = "Escolhe uma entre as três opções abaixo para ver lista completa.";
            msg.ShowDialog();
        }

        private static void adicionarGerenciamento()
        {
        uctGerenDGV apelido = new uctGerenDGV();
            msgGerenciador msg = new msgGerenciador();
            msg.hdrUIX.Title = "Adicionar";
            msg.lbl.Text = "Escolhe uma entre as três opções abaixo para adicionar.";
            apelido.CreateControl();
            msg.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            listagemGerenciamento();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            apelido.Visible = true;

            adicionarGerenciamento();
            alterarConteudo(uctGerenDGV1, "Testando");
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
