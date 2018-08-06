using BURGERSHACK_COMMON;
using BURGERSHACK_COMMON.UTIL;
using BURGERSHACK_DESKTOP.UTIL;
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

namespace BURGERSHACK_DESKTOP
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
            hdrUIX.Title = App.Name + " - Gerenciar Acesso";

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtUsuario, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtSenha, clnUtilFormValidar.Validacao.OBRIGATORIO);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);

            txtUsuario.Text = ObjAcesso.Usuario;
            txtSenha.Text = ObjAcesso.Senha;
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            if (clnUtilMensagem.mostrarSimNao("Acesso", "Deseja cancelar esta operação?", clnUtilMensagem.MensagemIcone.ERRO))
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
                ObjAcesso.Usuario = txtUsuario.Text;
                ObjAcesso.gravar();

                clnUtilMensagem.mostrarOk("Acesso", "Acesso gravado com sucesso!");

                Close();
            }
        }

    }

}

