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
    public partial class frmGerenciador : Form
    {

        public frmGerenciador()
        {
            InitializeComponent();
            esconderConteudo();
        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            uctUIX.UIXTitle = clnTemplate.AppName + " - Gerenciamento";
            clnTemplate.CommonTemplate.frmApply(this, uctUIX);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            esconderConteudo();
            grpFuncao.Visible = true;
            grpFuncao.Text = "ADICIONAR";

            //pnlConteudo.lblId.Visible = false;
            //pnlConteudo.txtPesquisa.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            esconderConteudo();
            grpFuncao.Visible = true;
            grpFuncao.Text = "MODIFICAR";

            //pnlConteudo.lblId.Visible = true;
            //pnlConteudo.txtPesquisa.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            esconderConteudo();
            grpFuncao.Visible = true;
            grpFuncao.Text = "REMOVER";

            //pnlConteudo.lblId.Visible = true;
            //pnlConteudo.txtPesquisa.Visible = true;
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            esconderConteudo();
            grpFuncao.Visible = true;
            grpFuncao.Text = "LISTA";

            //pnlConteudo.lblId.Visible = true;
            //pnlConteudo.txtPesquisa.Visible = true;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctGerenFuncionario(), "Funcionário");
        }

        private void btnTransportadora_Click(object sender, EventArgs e)
        {
            uctUIX.UIXTitle = clnTemplate.AppName + " - Transportadora";
        }

        private void btnTercerizada_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctGerenTerceirizada(), "Terceirizada");
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            uctUIX.UIXTitle = clnTemplate.AppName + " - Produto";
        }

        private void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            pnlConteudo.Visible = true;

            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        private void esconderConteudo()
        {
            pnlConteudo.Visible = false;
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void uctUIX_Min(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
