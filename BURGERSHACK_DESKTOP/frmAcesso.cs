using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;

namespace BurgerShack.Desktop
{
    public partial class frmAcesso : Form
    {

        private clnUtilFormValidar _validar;
        private clnAcesso _objAcesso;

        internal clnAcesso ObjAcesso { get => _objAcesso; set => _objAcesso = value; }

        public frmAcesso()
        {
            InitializeComponent();

            txtSenha.txt.PasswordChar = '*';

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtUsuario, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtSenha, clnUtilFormValidar.Validacao.OBRIGATORIO);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);

            txtUsuario.Text = ObjAcesso.Usuario;

            if(txtUsuario.Text == "")
            {
                hdrUIX.Title = App.Name + " - Novo Acesso";
                txtSenha.Campo = "Senha*";
                txtUsuario.Focus();
            } else
            {
                hdrUIX.Title = App.Name + " - Alterar Acesso";
                txtSenha.Focus();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            if (UtilMensagem.mostrarSimNao("Acesso", "Deseja cancelar esta operação?", UtilMensagem.MensagemIcone.ERRO))
            {
                Close();
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
                clnAcesso objAcessoUsuario = new clnAcesso
                {
                    Usuario = txtUsuario.Text
                }.obterPorUsuario();

                if (objAcessoUsuario == null || objAcessoUsuario.CodFuncionario == ObjAcesso.CodFuncionario)
                {
                    ObjAcesso.Usuario = txtUsuario.Text;
                    ObjAcesso.Senha = txtSenha.Text;
                    ObjAcesso.gravar();

                    UtilMensagem.mostrarOk("Acesso", "Acesso gravado com sucesso!");

                    Close();
                }
                else
                {
                    UtilMensagem.mostrarOk("Acesso", "Erro, o usuario informado já está em uso.");
                }
            }
        }

    }

}

