namespace BurgerShack.Desktop
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
            this.picVer = new System.Windows.Forms.PictureBox();
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.txtSenha = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtUsuario = new vitorrdgs.UiX.Component.UIXTextBox();
            this.btnSalvar = new vitorrdgs.UiX.Component.UIXButton();
            this.grbAcesso = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).BeginInit();
            this.grbAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // picVer
            // 
            this.picVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVer.Image = global::BurgerShack.Desktop.Properties.Resources.eye;
            this.picVer.Location = new System.Drawing.Point(314, 50);
            this.picVer.Name = "picVer";
            this.picVer.Size = new System.Drawing.Size(20, 20);
            this.picVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVer.TabIndex = 12;
            this.picVer.TabStop = false;
            this.picVer.MouseEnter += new System.EventHandler(this.picVer_MouseEnter);
            this.picVer.MouseLeave += new System.EventHandler(this.picVer_MouseLeave);
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.acesso;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(350, 50);
            this.hdrUIX.TabIndex = 11;
            this.hdrUIX.Title = "Acesso";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // txtSenha
            // 
            this.txtSenha.AcceptButton = null;
            this.txtSenha.AccessibleName = "Senha";
            this.txtSenha.Campo = "Senha*";
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtSenha.Location = new System.Drawing.Point(5, 50);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.Size = new System.Drawing.Size(300, 21);
            this.txtSenha.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptButton = this.btnSalvar;
            this.txtUsuario.AccessibleName = "Usuário";
            this.txtUsuario.Campo = "Usuário*";
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtUsuario.Location = new System.Drawing.Point(5, 20);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.Size = new System.Drawing.Size(300, 21);
            this.txtUsuario.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Description = "SALVAR";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BurgerShack.Desktop.Properties.Resources.salvar;
            this.btnSalvar.ImageLocation = null;
            this.btnSalvar.Location = new System.Drawing.Point(255, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 90);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // grbAcesso
            // 
            this.grbAcesso.Controls.Add(this.txtUsuario);
            this.grbAcesso.Controls.Add(this.txtSenha);
            this.grbAcesso.Controls.Add(this.picVer);
            this.grbAcesso.Location = new System.Drawing.Point(5, 55);
            this.grbAcesso.Name = "grbAcesso";
            this.grbAcesso.Size = new System.Drawing.Size(340, 90);
            this.grbAcesso.TabIndex = 16;
            this.grbAcesso.TabStop = false;
            this.grbAcesso.Text = "INFORMAÇÕES DE ACESSO";
            // 
            // frmAcesso
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.grbAcesso);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).EndInit();
            this.grbAcesso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private vitorrdgs.UiX.Component.UIXTextBox txtUsuario;
        private vitorrdgs.UiX.Component.UIXTextBox txtSenha;
        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.PictureBox picVer;
        private vitorrdgs.UiX.Component.UIXButton btnSalvar;
        private System.Windows.Forms.GroupBox grbAcesso;
    }
}

