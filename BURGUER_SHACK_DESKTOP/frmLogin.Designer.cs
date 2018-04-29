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
            this.txtNome = new UIX.txtUIX();
            this.txtSenha = new UIX.txtUIX();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.uctUIX = new UIX.uctUIX();
            this.picVer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AccessibleName = "Nome";
            this.txtNome.Campo = "Nome";
            this.txtNome.Location = new System.Drawing.Point(17, 88);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(271, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleName = "Senha";
            this.txtSenha.Campo = "Senha";
            this.txtSenha.Location = new System.Drawing.Point(13, 114);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(275, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(192, 156);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(96, 31);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(319, 43);
            this.uctUIX.TabIndex = 11;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = false;
            this.uctUIX.UIXImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.usuarios;
            this.uctUIX.UIXTitle = "BurgerShack :: Entrar";
            this.uctUIX.Close += new System.EventHandler(this.uctUIX_Close);
            // 
            // picVer
            // 
            this.picVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVer.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.eye;
            this.picVer.Location = new System.Drawing.Point(294, 107);
            this.picVer.Name = "picVer";
            this.picVer.Size = new System.Drawing.Size(27, 25);
            this.picVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVer.TabIndex = 12;
            this.picVer.TabStop = false;
            this.picVer.MouseEnter += new System.EventHandler(this.picVer_MouseEnter);
            this.picVer.MouseLeave += new System.EventHandler(this.picVer_MouseLeave);
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 200);
            this.Controls.Add(this.picVer);
            this.Controls.Add(this.uctUIX);
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
            this.ResumeLayout(false);

        }

        #endregion
        private UIX.txtUIX txtNome;
        private UIX.txtUIX txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private UIX.uctUIX uctUIX;
        private System.Windows.Forms.PictureBox picVer;
    }
}

