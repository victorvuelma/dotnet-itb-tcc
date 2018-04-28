namespace BURGUER_SHACK_DESKTOP
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new UIX.txtUIX();
            this.txtSenha = new UIX.txtUIX();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ctlUIX1 = new UIX.uctUIX();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Campo = "NOME:";
            this.txtNome.Location = new System.Drawing.Point(12, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Campo = "SENHA:";
            this.txtSenha.Location = new System.Drawing.Point(12, 114);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(276, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(192, 156);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 31);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "ENTRAR";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // ctlUIX1
            // 
            this.ctlUIX1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctlUIX1.Location = new System.Drawing.Point(0, 0);
            this.ctlUIX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctlUIX1.Name = "ctlUIX1";
            this.ctlUIX1.Size = new System.Drawing.Size(301, 43);
            this.ctlUIX1.TabIndex = 11;
            this.ctlUIX1.UIXButtonCloseEnabled = true;
            this.ctlUIX1.UIXButtonMinEnabled = false;
            this.ctlUIX1.UIXImage = null;
            this.ctlUIX1.UIXTitle = "BurgerShack :: Entrar";
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.ctlUIX1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UIX.txtUIX txtNome;
        private UIX.txtUIX txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private UIX.uctUIX ctlUIX1;
    }
}

