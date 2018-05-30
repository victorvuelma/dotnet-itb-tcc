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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new UIX.btnUIX();
            this.grbDetalhes = new System.Windows.Forms.GroupBox();
            this.txtEmail = new UIX.txtUIX();
            this.mtbTelCel = new UIX.mtbUIX();
            this.cboGenero = new UIX.cboUIX();
            this.btnSalvar = new UIX.btnUIX();
            this.mtbCPF = new UIX.mtbUIX();
            this.mtbDataNasc = new UIX.mtbUIX();
            this.txtNome = new UIX.txtUIX();
            this.hdrUIX = new UIX.hdrUIX();
            this.pnlMenu.SuspendLayout();
            this.grbDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 250);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Description = "Cancelar";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(5, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 90);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // grbDetalhes
            // 
            this.grbDetalhes.Controls.Add(this.txtEmail);
            this.grbDetalhes.Controls.Add(this.mtbTelCel);
            this.grbDetalhes.Controls.Add(this.cboGenero);
            this.grbDetalhes.Controls.Add(this.mtbCPF);
            this.grbDetalhes.Controls.Add(this.mtbDataNasc);
            this.grbDetalhes.Controls.Add(this.txtNome);
            this.grbDetalhes.Location = new System.Drawing.Point(105, 55);
            this.grbDetalhes.Name = "grbDetalhes";
            this.grbDetalhes.Size = new System.Drawing.Size(490, 149);
            this.grbDetalhes.TabIndex = 6;
            this.grbDetalhes.TabStop = false;
            this.grbDetalhes.Text = "INFORMACÕES DO CLIENTE";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = "E-mail";
            this.txtEmail.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtEmail.Campo = "E-mail";
            this.txtEmail.Location = new System.Drawing.Point(197, 87);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // mtbTelCel
            // 
            this.mtbTelCel.AccessibleName = "Celular*";
            this.mtbTelCel.Campo = "Celular*";
            this.mtbTelCel.Location = new System.Drawing.Point(130, 50);
            this.mtbTelCel.Mask = "";
            this.mtbTelCel.MaxLength = 32767;
            this.mtbTelCel.Name = "mtbTelCel";
            this.mtbTelCel.Size = new System.Drawing.Size(135, 20);
            this.mtbTelCel.TabIndex = 11;
            this.mtbTelCel.ValidatingType = null;
            // 
            // cboGenero
            // 
            this.cboGenero.AccessibleName = "Genero";
            this.cboGenero.Campo = "Genero";
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(400, 50);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(85, 20);
            this.cboGenero.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(486, 198);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 90);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mtbCPF
            // 
            this.mtbCPF.AccessibleName = "CPF*";
            this.mtbCPF.Campo = "CPF*";
            this.mtbCPF.Location = new System.Drawing.Point(5, 50);
            this.mtbCPF.Mask = "";
            this.mtbCPF.MaxLength = 32767;
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(115, 20);
            this.mtbCPF.TabIndex = 9;
            this.mtbCPF.ValidatingType = null;
            // 
            // mtbDataNasc
            // 
            this.mtbDataNasc.AccessibleName = "Data de Nascimento";
            this.mtbDataNasc.Campo = "Data de Nascimento";
            this.mtbDataNasc.Location = new System.Drawing.Point(6, 87);
            this.mtbDataNasc.Mask = "";
            this.mtbDataNasc.MaxLength = 32767;
            this.mtbDataNasc.Name = "mtbDataNasc";
            this.mtbDataNasc.Size = new System.Drawing.Size(185, 20);
            this.mtbDataNasc.TabIndex = 8;
            this.mtbDataNasc.ValidatingType = null;
            // 
            // txtNome
            // 
            this.txtNome.AccessibleName = "Nome*";
            this.txtNome.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtNome.Campo = "Nome*";
            this.txtNome.Location = new System.Drawing.Point(5, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(480, 20);
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
            this.hdrUIX.Size = new System.Drawing.Size(600, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Cliente";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.grbDetalhes);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbDetalhes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnVoltar;
        private UIX.btnUIX btnSalvar;
        private System.Windows.Forms.GroupBox grbDetalhes;
        private UIX.txtUIX txtNome;
        private UIX.mtbUIX mtbDataNasc;
        private UIX.mtbUIX mtbCPF;
        private UIX.cboUIX cboGenero;
        private UIX.txtUIX txtEmail;
        private UIX.mtbUIX mtbTelCel;
    }
}