using BURGUERSHACK_COMMON.UTIL;
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

namespace BURGUERSHACK_DESKTOP
{
    public partial class frmEntrar : Form
    {

        private clnUtilFormValidar _validar;

        public frmEntrar()
        {
            InitializeComponent();

            txtSenha.txt.PasswordChar = '*';
            hdrUIX.Title = App.Name + " - Acesso ao Sistema";

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtUsuario, clnUtilFormValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(txtSenha, clnUtilFormValidar.ValidarTipo.OBRIGATORIO);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);

            Focus();
            txtUsuario.Focus();
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
                clnAcesso objAcesso = new clnAcesso
                {
                    Usuario = txtUsuario.Text,
                    Senha = txtSenha.Text
                };

                int? codFuncionario = objAcesso.acessar();

                if (codFuncionario != null)
                {
                    Hide();

                    frmPrincipal frmPrincipal = new frmPrincipal
                    {
                        CodFuncionario = (int)codFuncionario
                    };
                    frmPrincipal.ShowDialog();

                    Application.Restart();
                    return;
                }
                else
                {
                    clnUtilMensagem.mostrarOk("Falha ao acessar", "Não foi possível acessar o sistema pois as credenciais informadas são inválidas.", clnUtilMensagem.MensagemIcone.ERRO);
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
            }
            txtUsuario.Focus();
        }

    }

}

