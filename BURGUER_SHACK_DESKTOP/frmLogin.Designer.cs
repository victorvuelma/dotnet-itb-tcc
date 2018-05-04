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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.picVer = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.hdrUIX = new UIX.hdrUIX();
            this.txtSenha = new UIX.txtUIX();
            this.txtNome = new UIX.txtUIX();
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(364, 199);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(96, 31);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "ACESSAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // picVer
            // 
            this.picVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVer.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.eye;
            this.picVer.Location = new System.Drawing.Point(465, 140);
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
            this.lblProgram.Location = new System.Drawing.Point(0, 280);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(500, 20);
            this.lblProgram.TabIndex = 14;
            this.lblProgram.Text = "BurguerShack :: Versão 1.0 :: Copyright 2018";
            this.lblProgram.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(500, 40);
            this.hdrUIX.TabIndex = 11;
            this.hdrUIX.UIXButtonCloseEnabled = true;
            this.hdrUIX.UIXButtonMinEnabled = false;
            this.hdrUIX.UIXImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.usuarios;
            this.hdrUIX.UIXTitle = "BurgerShack :: Acessar o Sistema";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleName = "Senha";
            this.txtSenha.Campo = "Senha";
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(190, 145);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(270, 30);
            this.txtSenha.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.AccessibleName = "Nome";
            this.txtNome.Campo = "Nome";
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(190, 110);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(270, 30);
            this.txtNome.TabIndex = 7;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picVer);
            this.Controls.Add(this.hdrUIX);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UIX.txtUIX txtNome;
        private UIX.txtUIX txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.PictureBox picVer;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblProgram;
    }
}

