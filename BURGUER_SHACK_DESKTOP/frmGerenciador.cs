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

        public static void listagemGerenciamento()
        {
            msgGerenciador msg = new msgGerenciador();
            msg.hdrUIX.Title = "Listagem";
            msg.lbl.Text = "Escolhe uma entre as três opções abaixo para ver lista completa.";
            msg.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            uctGerenDGV.hdrUIX.Title = "batata";
            alterarConteudo(null, "aaaaaaaaaa");
            listagemGerenciamento();

            switch (msgGerenciador.clicouEm)
            {
                case 1:
                    alterarConteudo(new uctGerenDGV(), "Lista de Funcionários");
                    break;
                case 2:
                    alterarConteudo(new uctGerenDGV(), "Lista de Tercerizadas");
                    break;
                case 3:
                    alterarConteudo(new uctGerenDGV(), "Lista de Produtos");
                    break;
            }
        }

        private static void adicionarGerenciamento()
        {
            msgGerenciador msg = new msgGerenciador();
            msg.hdrUIX.Title = "Adicionar";
            msg.lbl.Text = "Escolhe uma entre as três opções abaixo para adicionar.";
            msg.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            uctGerenDGV uctGerenDGV = new uctGerenDGV();
            uctGerenDGV.hdrUIX.Title = "arroz";
            pnlConteudo.Visible = false;
            uctGerenDGV.Visible = false;
            adicionarGerenciamento();

            switch (msgGerenciador.adicionar)
            {
                case 1:
                    alterarConteudo(uctGerenDGV, "Testes");
                    break;
                case 2:
                    alterarConteudo(uctGerenDGV, "Adicionar kk");
                    break;
                case 3:
                    alterarConteudo(uctGerenDGV, "Adicionar Produto");
                    break;
            }
        }


        private void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
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
