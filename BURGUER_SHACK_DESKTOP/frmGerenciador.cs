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
            uctFuncionario.Visible = false;
        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            uctUIX.UIXTitle = tplBurguerShack.AppName + " - Gerenciamento";
            tplBurguerShack.CommonTemplate.frmApply(this, uctUIX);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            EsconderControles();
            grpFuncao.Visible = true;
            grpFuncao.Text = "ADICIONAR";

            uctFuncionario.lblId.Visible = false;
            uctFuncionario.txtPesquisa.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EsconderControles();
            grpFuncao.Visible = true;
            grpFuncao.Text = "MODIFICAR";

            uctFuncionario.lblId.Visible = true;
            uctFuncionario.txtPesquisa.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            EsconderControles();
            grpFuncao.Visible = true;
            grpFuncao.Text = "REMOVER";

            uctFuncionario.lblId.Visible = true;
            uctFuncionario.txtPesquisa.Visible = true;
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            EsconderControles();
            grpFuncao.Visible = true;
            grpFuncao.Text = "LISTA";

            uctFuncionario.lblId.Visible = true;
            uctFuncionario.txtPesquisa.Visible = true;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            uctUIX.UIXTitle = tplBurguerShack.AppName + " - Funcionário";

            VerificaFuncao();
        }

        private void btnTransportadora_Click(object sender, EventArgs e)
        {
            uctUIX.UIXTitle = tplBurguerShack.AppName + " - Transportadora";

            VerificaFuncao();
        }

        private void btnTercerizada_Click(object sender, EventArgs e)
        {
            uctUIX.UIXTitle = tplBurguerShack.AppName + " - Tercerizada";

            VerificaFuncao();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            uctUIX.UIXTitle = tplBurguerShack.AppName + " - Produto";

            VerificaFuncao();
        }

        private void VerificaFuncao()
        {
            if (grpFuncao.Text == "ADICIONAR" && uctUIX.UIXTitle == "Burguer Shack - Funcionário")
            {
                uctFuncionario.Visible = true;
            }
            else if (grpFuncao.Text == "MODIFICAR" && uctUIX.UIXTitle == "Burguer Shack - Funcionário")
            {
                uctFuncionario.Visible = true;
            }
            else if (grpFuncao.Text == "REMOVER" && uctUIX.UIXTitle == "Burguer Shack - Funcionário")
            {
                uctFuncionario.Visible = true;
            }
            else if (grpFuncao.Text == "LISTA" && uctUIX.UIXTitle == "Burguer Shack - Funcionário")
            {
                uctFuncionario.Visible = true;
            }
        }

        private void EsconderControles()
        {
            uctFuncionario.Visible = false;
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void uctUIX_Min(object sender, EventArgs e)
        {
            MessageBox.Show("Não funciona =/");
        }
    }
}
