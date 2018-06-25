namespace BURGUER_SHACK_DESKTOP
{
    partial class frmCliente
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new UIX.btnUIX();
            this.btnSalvar = new UIX.btnUIX();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.txtEmail = new UIX.txtUIX();
            this.mtbTelCel = new UIX.mtbUIX();
            this.cboGenero = new UIX.cboUIX();
            this.mtbCPF = new UIX.mtbUIX();
            this.mtbDataNasc = new UIX.mtbUIX();
            this.txtNome = new UIX.txtUIX();
            this.hdrUIX = new UIX.hdrUIX();
            this.pnlMenu.SuspendLayout();
            this.grbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnSalvar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 200);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Description = "Cancelar";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.voltar;
            this.btnVoltar.ImageLocation = null;
            this.btnVoltar.Location = new System.Drawing.Point(5, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 90);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.ImageLocation = null;
            this.btnSalvar.Location = new System.Drawing.Point(5, 105);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 90);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.txtEmail);
            this.grbInformacoes.Controls.Add(this.mtbTelCel);
            this.grbInformacoes.Controls.Add(this.cboGenero);
            this.grbInformacoes.Controls.Add(this.mtbCPF);
            this.grbInformacoes.Controls.Add(this.mtbDataNasc);
            this.grbInformacoes.Controls.Add(this.txtNome);
            this.grbInformacoes.Location = new System.Drawing.Point(105, 55);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(390, 150);
            this.grbInformacoes.TabIndex = 6;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "INFORMAÇÕES DO CLIENTE";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = "E-mail";
            this.txtEmail.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
            this.txtEmail.Campo = "E-mail";
            this.txtEmail.Location = new System.Drawing.Point(5, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // mtbTelCel
            // 
            this.mtbTelCel.AccessibleName = "Tel. Cel.*";
            this.mtbTelCel.Campo = "Tel. Celular*";
            this.mtbTelCel.Location = new System.Drawing.Point(185, 60);
            this.mtbTelCel.Mask = "";
            this.mtbTelCel.MaxLength = 32767;
            this.mtbTelCel.Name = "mtbTelCel";
            this.mtbTelCel.Size = new System.Drawing.Size(200, 20);
            this.mtbTelCel.TabIndex = 11;
            this.mtbTelCel.ValidatingType = null;
            // 
            // cboGenero
            // 
            this.cboGenero.AccessibleName = "Gênero*";
            this.cboGenero.Campo = "Genero*";
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(283, 90);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(102, 20);
            this.cboGenero.TabIndex = 10;
            // 
            // mtbCPF
            // 
            this.mtbCPF.AccessibleName = "CPF*";
            this.mtbCPF.Campo = "CPF*";
            this.mtbCPF.Location = new System.Drawing.Point(5, 60);
            this.mtbCPF.Mask = "";
            this.mtbCPF.MaxLength = 32767;
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(170, 20);
            this.mtbCPF.TabIndex = 9;
            this.mtbCPF.ValidatingType = null;
            // 
            // mtbDataNasc
            // 
            this.mtbDataNasc.AccessibleName = "Data de Nascimento";
            this.mtbDataNasc.Campo = "Data de Nascimento";
            this.mtbDataNasc.Location = new System.Drawing.Point(5, 90);
            this.mtbDataNasc.Mask = "";
            this.mtbDataNasc.MaxLength = 32767;
            this.mtbDataNasc.Name = "mtbDataNasc";
            this.mtbDataNasc.Size = new System.Drawing.Size(270, 20);
            this.mtbDataNasc.TabIndex = 8;
            this.mtbDataNasc.ValidatingType = null;
            // 
            // txtNome
            // 
            this.txtNome.AccessibleName = "Nome*";
            this.txtNome.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
            this.txtNome.Campo = "Nome*";
            this.txtNome.Location = new System.Drawing.Point(5, 25);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(380, 20);
            this.txtNome.TabIndex = 7;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.cliente;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(500, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Cliente";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // frmCliente
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbInformacoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnVoltar;
        private UIX.btnUIX btnSalvar;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private UIX.txtUIX txtNome;
        private UIX.mtbUIX mtbDataNasc;
        private UIX.cboUIX cboGenero;
        private UIX.txtUIX txtEmail;
        private UIX.mtbUIX mtbTelCel;
        public UIX.mtbUIX mtbCPF;
    }
}