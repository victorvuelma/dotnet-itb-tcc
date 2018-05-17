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
        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            hdrUIX.Title = App.AppName + " - Gerenciamento";

            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);
        }

        private void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo);
        }

        public void listagemGerenciamento()
        {
            msgGerenciador msg = new msgGerenciador();
            msg.hdrUIX.Title = "Listagem";
            msg.lbl.Text = "Escolhe uma entre as três opções abaixo para ver lista completa.";
            msg.ShowDialog();
        }

        private void adicionarGerenciamento()
        {
            msgGerenciador msg = new msgGerenciador();
            msg.hdrUIX.Title = "Adicionar";
            msg.lbl.Text = "Escolhe uma entre as três opções abaixo para adicionar.";
            msg.ShowDialog();
            if (msg.GerentType == 1)
            {
                alterarConteudo(new uctGerenFuncionario(), "");
            }
            else if (msg.GerentType == 2)
            {
                alterarConteudo(new uctGerenTerceirizada(), "");
            }
            else
            {
                alterarConteudo(new uctGerenProduto(), "");
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            listagemGerenciamento();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionarGerenciamento();
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

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new frmEstoque();
            frmEstoque.ShowDialog();
        }
    }
}
