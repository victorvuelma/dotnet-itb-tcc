using BurgerShack.Common;
using BurgerShack.Common.UTIL;
using BurgerShack.Desktop.UTIL;
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
using vitorrdgs.UiX;

namespace BurgerShack.Desktop
{
    public partial class frmEntrar : Form
    {

        private clnUtilFormValidar _validar;

        public frmEntrar()
        {
            AppDesktop.startup();

            InitializeComponent();

            txtSenha.txt.PasswordChar = '*';
            hdrUIX.Title = App.Name + " - Acesso ao Sistema";

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtUsuario, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtSenha, clnUtilFormValidar.Validacao.OBRIGATORIO);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            List<clnFuncionario> objFuncionarios = new clnFuncionario { }.obterTodos();
            if (objFuncionarios.Count == 0)
            {
                frmFuncionario frmFuncionario = new frmFuncionario();
                frmFuncionario.Primeiro = true;
                frmFuncionario.ShowDialog();

                Hide();
                Close();
                return;
            }
            List<clnAcesso> objAcessos = new clnAcesso { }.obterTodos();
            if (objAcessos.Count == 0)
            {
                frmAcesso frmAcesso = new frmAcesso();
                frmAcesso.ObjAcesso = new clnAcesso
                {
                    CodFuncionario = objFuncionarios.First().Cod,
                    Senha = "",
                    Usuario = ""
                };
                frmAcesso.ShowDialog();
                
                Hide();
                Close();
                return;
            }

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
            if (_validar.validar(this))
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
                    clnUtilMensagem.mostrarOk("Falha ao acessar", "Não foi possível acessar o sistema pois as credenciais informadas são inválidas.");
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
            }
            txtUsuario.Focus();
        }

    }

}

