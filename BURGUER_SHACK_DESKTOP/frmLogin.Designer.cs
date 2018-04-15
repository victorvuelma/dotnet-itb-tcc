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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblESenha = new System.Windows.Forms.Label();
            this.ctlUIX1 = new UIX.uctUIX();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(48, 92);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 16);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "NOME";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(48, 119);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 16);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "SENHA";
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(97, 93);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(246, 21);
            this.txtLogin.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(97, 119);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(246, 21);
            this.txtSenha.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(271, 139);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 26);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblESenha
            // 
            this.lblESenha.AutoSize = true;
            this.lblESenha.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblESenha.Location = new System.Drawing.Point(94, 144);
            this.lblESenha.Name = "lblESenha";
            this.lblESenha.Size = new System.Drawing.Size(122, 16);
            this.lblESenha.TabIndex = 10;
            this.lblESenha.Text = "Esqueci minha senha";
            // 
            // ctlUIX1
            // 
            this.ctlUIX1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctlUIX1.Location = new System.Drawing.Point(-2, 0);
            this.ctlUIX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctlUIX1.Name = "ctlUIX1";
            this.ctlUIX1.Size = new System.Drawing.Size(188, 43);
            this.ctlUIX1.TabIndex = 11;
            this.ctlUIX1.UIXButtonCloseEnabled = true;
            this.ctlUIX1.UIXButtonMinEnabled = false;
            this.ctlUIX1.UIXTitle = "BurgerShack :: Acesso";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.ctlUIX1);
            this.Controls.Add(this.lblESenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblESenha;
        private UIX.uctUIX ctlUIX1;
    }
}

