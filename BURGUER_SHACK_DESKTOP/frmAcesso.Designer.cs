namespace BURGUER_SHACK_DESKTOP
{
    partial class frmAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcesso));
            this.picVer = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.hdrUIX = new UIX.hdrUIX();
            this.txtSenha = new UIX.txtUIX();
            this.txtUsuario = new UIX.txtUIX();
            this.btnEntrar = new UIX.btnUIX();
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // picVer
            // 
            this.picVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVer.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.eye;
            this.picVer.Location = new System.Drawing.Point(465, 120);
            this.picVer.Name = "picVer";
            this.picVer.Size = new System.Drawing.Size(20, 20);
            this.picVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVer.TabIndex = 12;
            this.picVer.TabStop = false;
            this.picVer.MouseEnter += new System.EventHandler(this.picVer_MouseEnter);
            this.picVer.MouseLeave += new System.EventHandler(this.picVer_MouseLeave);
            // 
            // picUser
            // 
            this.picUser.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.usuarios;
            this.picUser.Location = new System.Drawing.Point(30, 80);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(150, 150);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 13;
            this.picUser.TabStop = false;
            // 
            // lblProgram
            // 
            this.lblProgram.Location = new System.Drawing.Point(0, 245);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(500, 25);
            this.lblProgram.TabIndex = 14;
            this.lblProgram.Text = "BurguerShack :: Versão 1.0 :: Copyright 2018";
            this.lblProgram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.usuarios;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(500, 50);
            this.hdrUIX.TabIndex = 11;
            this.hdrUIX.Title = "Acesso ao Sistema";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleName = "Senha";
            this.txtSenha.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtSenha.Campo = "Senha";
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(190, 120);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(270, 30);
            this.txtSenha.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleName = "Usuário";
            this.txtUsuario.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtUsuario.Campo = "Usuário";
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(190, 80);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(270, 30);
            this.txtUsuario.TabIndex = 7;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.Description = "Acessar";
            this.btnEntrar.HoverColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.entrar;
            this.btnEntrar.ImageLocation = null;
            this.btnEntrar.Location = new System.Drawing.Point(380, 155);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(80, 80);
            this.btnEntrar.TabIndex = 15;
            this.btnEntrar.Text = "btnUIX1";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmAcesso
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picVer);
            this.Controls.Add(this.hdrUIX);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ao Sistema";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UIX.txtUIX txtUsuario;
        private UIX.txtUIX txtSenha;
        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.PictureBox picVer;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblProgram;
        private UIX.btnUIX btnEntrar;
    }
}

