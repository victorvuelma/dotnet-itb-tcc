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

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmLogin : Form
    {

        private clnValidar _validar;

        public frmLogin()
        {
            InitializeComponent();

            _validar = new clnValidar();
            txtSenha.txt.PasswordChar = '*';

            clnUtil.atualizarTabIndex(Controls);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UIX.uixTemplate _frmTemplate = new UIX.uixTemplate(UIX.uixStyle.SILVER);

            clnApp.CommonTemplate.frmApply(this, uctUIX);

            _validar.addValidacao(txtNome, clnValidar.VAZIO);
            _validar.addValidacao(txtSenha, clnValidar.VAZIO);
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            Application.Exit();
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
                Hide();

                new frmPrincipal().ShowDialog();

                //Application.Restart();
                Application.Exit();
            }

            //SqlConnection sql = new SqlConnection("Integrated Security=SSPI; Persist Security Info=False;Initial Catalog=Burguer_Shack;Data Source=DESKTOP-NNGLJE4");
            //SqlCommand command = new SqlCommand("select * from FUNCIONARIO where Nome=@Nome and Senha=@Senha", sql);
            //command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            //command.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;

            //try
            //{
            //    sql.Open();
            //    SqlDataReader drms = command.ExecuteReader();
            //    if (drms.HasRows == false)
            //    {
            //        throw new Exception("usuario ou senha errado porra");
            //    }
            //        drms.Read();
            //        frmPedido objfrmPedido = new frmPedido();
            //        objfrmPedido.Visible = true;
            //        this.Visible = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //finally
            //{
            //    sql.Close();
            //}


            //if (txtNome.Text == "garçom" && txtSenha.Text == "123")
            //{
            //    frmPedido objfrmPedido = new frmPedido();
            //    objfrmPedido.Visible = true;
            //    this.Visible = false;
            //}
            //else if (txtNome.Text == "cozinha" && txtSenha.Text == "123")
            //{
            //    frmCozinha objfrmCozinha = new frmCozinha();
            //    objfrmCozinha.Visible = true;
            //    this.Visible = false;
            //}
            //else if (txtNome.Text == "lider" && txtSenha.Text == "123")
            //{
            //    frmGerenciador objfrmGerenciador = new frmGerenciador();
            //    objfrmGerenciador.Visible = true;
            //    this.Visible = false;
            //}
        }

    }
}
