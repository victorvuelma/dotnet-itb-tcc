using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public partial class frmConfirmar : Form
    {

        private bool _confirmado = false;

        public bool Confirmado { get => _confirmado; set => _confirmado = value; }

        public frmConfirmar()
        {
            InitializeComponent();

            txtSenha.txt.PasswordChar = '*';
            hdrUIX.Title = App.Name + " - Confirme sua operação";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);

            txtSenha.Focus();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            if (UtilMensagem.mostrarSimNao("Confirmação", "Deseja cancelar esta operação?", UtilMensagem.MensagemIcone.ERRO))
            {
                Close();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!UtilValidar.vazio(txtSenha.Text))
            {
                clnAcesso objAcesso = new clnAcesso
                {
                    CodFuncionario = AppDesktop.FuncionarioAtual.Cod,
                    Senha = txtSenha.Text
                };

                if (objAcesso.autenticarPorCodigo() != null)
                {
                    Confirmado = true;
                    Close();
                    return;
                }

            }
            UtilMensagem.mostrarOk("Confirmação", "Senha incorreta!");

            txtSenha.Text = "";
            txtSenha.Focus();
        }
    }

}

