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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            //pnlConteudo.lblId.Visible = false;
            //pnlConteudo.txtPesquisa.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //pnlConteudo.lblId.Visible = true;
            //pnlConteudo.txtPesquisa.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            //pnlConteudo.lblId.Visible = true;
            //pnlConteudo.txtPesquisa.Visible = true;
        }

        public static void listagemGerenciamento()
        {
            msgGerenciador msg = new msgGerenciador();
            frmGerenciador frm = new frmGerenciador();
            msg.hdrUIX.Title = "Listagem";
            msg.lbl.Text = "Escolhe uma entre três opções abaixo para ver lista completa.";

            switch (msg.clicouEm)
            {
                case 1:
                    frm.dgvFuncionario.Visible = true;
                    frm.dgvProduto.Visible = false;
                    frm.dgvTercerizada.Visible = false;
                    break;
                case 2:
                    frm.dgvFuncionario.Visible = false;
                    frm.dgvTercerizada.Visible = true;
                    frm.dgvProduto.Visible = false;
                    break;
                case 3:
                    frm.dgvFuncionario.Visible = false;
                    frm.dgvTercerizada.Visible = false;
                    frm.dgvProduto.Visible = true;
                    break;
            }

            msg.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            msgGerenciador msg = new msgGerenciador();
            frmGerenciador frm = new frmGerenciador();
            listagemGerenciamento();
            switch (msg.clicouEm)
            {
                case 1:
                    frm.dgvFuncionario.Visible = true;
                    frm.dgvProduto.Visible = false;
                    frm.dgvTercerizada.Visible = false;
                    break;
                case 2:
                    frm.dgvFuncionario.Visible = false;
                    frm.dgvTercerizada.Visible = true;
                    frm.dgvProduto.Visible = false;
                    break;
                case 3:
                    frm.dgvFuncionario.Visible = false;
                    frm.dgvTercerizada.Visible = false;
                    frm.dgvProduto.Visible = true;
                    break;
            }
        }

        private void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            pnlConteudo.Visible = true;

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
