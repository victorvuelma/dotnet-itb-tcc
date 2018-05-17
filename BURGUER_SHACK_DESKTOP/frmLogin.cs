using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIX;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmLogin : Form
    {

        private clnUtilValidar _validar;

        public frmLogin()
        {
            InitializeComponent();

            txtSenha.txt.PasswordChar = '*';
            hdrUIX.Title = App.AppName + " :: Acesso ao Sistema";

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtUsuario, clnUtilValidar.ValidarTipo.VAZIO);
            _validar.addValidacao(txtSenha, clnUtilValidar.ValidarTipo.VAZIO);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            txtUsuario.txt.Focus();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            if (clnUtilMensagem.mostrarSimNao("Sistema", "Deseja realmente encerrar o sistema?", clnUtilMensagem.MensagemIcone.ERRO))
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void picVer_MouseEnter(object sender, EventArgs e)
        {
            txtSenha.txt.PasswordChar = '\0';
        }

        private void picVer_MouseLeave(object sender, EventArgs e)
        {
            txtSenha.txt.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (_validar.valido())
            {
                //clnFuncionario objFuncionario = new clnFuncionario()
                //{
                //    Login = txtUsuario.Text
                //}.obterPorLogin();

                Hide();

                if (txtUsuario.Text.ToLower().Equals("gerente"))
                {
                    new frmGerenciador().ShowDialog();
                }
                else
                {
                    new frmPrincipal().ShowDialog();
                }

            }

            System.Windows.Forms.Application.Restart();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            switch (txtUIX.confirmar)
            {
                case 1:
                    btnEntrar.PerformClick();
                    break;
            }
         }
    }

}

