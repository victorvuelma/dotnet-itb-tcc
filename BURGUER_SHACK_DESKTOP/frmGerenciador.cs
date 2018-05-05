﻿using System;
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
            hdrUIX.Text = clnApp.AppName + " - Gerenciamento";
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

        private void btnLista_Click(object sender, EventArgs e)
        {

            //pnlConteudo.lblId.Visible = true;
            //pnlConteudo.txtPesquisa.Visible = true;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnTercerizada_Click(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {

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
