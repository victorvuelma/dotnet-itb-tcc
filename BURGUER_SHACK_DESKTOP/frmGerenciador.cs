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
            listagemGerenciamento();
            
            switch (msgGerenciador.clicouEm)
            {
                case 1:
                    dgvFuncionario.Visible = true;
                    dgvFuncionario.Location = pnlConteudo.Location;
                    dgvFuncionario.Size = pnlConteudo.Size;

                    dgvProduto.Visible = false;
                    dgvProduto.Location = new Point(930, 495);
                    dgvProduto.Size = new Size(100,100);

                    dgvTercerizada.Visible = false;
                    dgvTercerizada.Location = new Point(930, 495);
                    dgvTercerizada.Size = new Size(100, 100);

                    uctGerenFuncionario.Visible = false;
                    uctGerenProduto.Visible = false;
                    uctGerenTerceirizada.Visible = false;
                    break;
                case 2:
                    dgvFuncionario.Visible = false;
                    dgvFuncionario.Location = new Point(930, 495);
                    dgvFuncionario.Size = new Size(100, 100);

                    dgvTercerizada.Visible = true;
                    dgvTercerizada.Location = pnlConteudo.Location;
                    dgvTercerizada.Size = pnlConteudo.Size;

                    dgvProduto.Visible = false;
                    dgvProduto.Location = new Point(930, 495);
                    dgvProduto.Size = new Size(100, 100);

                    uctGerenFuncionario.Visible = false;
                    uctGerenProduto.Visible = false;
                    uctGerenTerceirizada.Visible = false;
                    break;
                case 3:
                    dgvFuncionario.Visible = false;
                    dgvFuncionario.Location = new Point(930, 495);
                    dgvFuncionario.Size = new Size(100, 100);

                    dgvTercerizada.Visible = false;
                    dgvTercerizada.Location = new Point(930, 495);
                    dgvTercerizada.Size = new Size(100, 100);

                    dgvProduto.Visible = true;
                    dgvProduto.Location = pnlConteudo.Location;
                    dgvProduto.Size = pnlConteudo.Size;

                    uctGerenFuncionario.Visible = false;
                    uctGerenProduto.Visible = false;
                    uctGerenTerceirizada.Visible = false;
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
            adicionarGerenciamento();

            switch (msgGerenciador.adicionar)
            {
                case 1:
                    uctGerenFuncionario.Visible = true;
                    uctGerenFuncionario.Location = pnlConteudo.Location;
                    uctGerenFuncionario.Size = pnlConteudo.Size;
                    uctGerenProduto.Visible = false;
                    uctGerenTerceirizada.Visible = false;

                    dgvFuncionario.Visible = false;
                    dgvTercerizada.Visible = false;
                    dgvProduto.Visible = false;
                    break;
                case 2:
                    uctGerenTerceirizada.Visible = true;
                    uctGerenTerceirizada.Location = pnlConteudo.Location;
                    uctGerenTerceirizada.Size = pnlConteudo.Size;
                    uctGerenFuncionario.Visible = false;
                    uctGerenProduto.Visible = false;

                    dgvFuncionario.Visible = false;
                    dgvTercerizada.Visible = false;
                    dgvProduto.Visible = false;
                    break;
                case 3:
                    uctGerenProduto.Visible = true;
                    uctGerenProduto.Location = pnlConteudo.Location;
                    uctGerenProduto.Size = pnlConteudo.Size;
                    uctGerenFuncionario.Visible = false;
                    uctGerenTerceirizada.Visible = false;

                    dgvFuncionario.Visible = false;
                    dgvTercerizada.Visible = false;
                    dgvProduto.Visible = false;
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
