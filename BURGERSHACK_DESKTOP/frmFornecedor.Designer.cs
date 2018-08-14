namespace BurgerShack.Desktop
{
    partial class frmFornecedor
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
            this.btnCancelar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnSalvar = new vitorrdgs.UiX.Component.UIXButton();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.txtEmail = new vitorrdgs.UiX.Component.UIXTextBox();
            this.mtbTel =new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.mtbCNPJ =new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.txtRazaoSocial = new vitorrdgs.UiX.Component.UIXTextBox();
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtEndComplemento = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtEndCidade = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtEndBairro = new vitorrdgs.UiX.Component.UIXTextBox();
            this.mtbEndCEP =new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.cboEndUF = new vitorrdgs.UiX.Component.UIXComboBox();
            this.txtEndLogradouro = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtEndNr = new vitorrdgs.UiX.Component.UIXTextBox();
            this.pnlMenu.SuspendLayout();
            this.grbInformacoes.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnCancelar);
            this.pnlMenu.Controls.Add(this.btnSalvar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 300);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Description = "Cancelar";
            this.btnCancelar.HoverColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = global::BurgerShack.Desktop.Properties.Resources.voltar;
            this.btnCancelar.ImageLocation = null;
            this.btnCancelar.Location = new System.Drawing.Point(5, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 90);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BurgerShack.Desktop.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.ImageLocation = null;
            this.btnSalvar.Location = new System.Drawing.Point(5, 205);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 90);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.txtEmail);
            this.grbInformacoes.Controls.Add(this.mtbTel);
            this.grbInformacoes.Controls.Add(this.mtbCNPJ);
            this.grbInformacoes.Controls.Add(this.txtRazaoSocial);
            this.grbInformacoes.Location = new System.Drawing.Point(105, 55);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(390, 140);
            this.grbInformacoes.TabIndex = 6;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "INFORMAÇÕES DO FORNECEDOR";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = "E-mail";
            this.txtEmail.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEmail.Campo = "E-mail*";
            this.txtEmail.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEmail.Location = new System.Drawing.Point(5, 78);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.Size = new System.Drawing.Size(380, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // mtbTel
            // 
            this.mtbTel.AccessibleName = "Tel. Cel.*";
            this.mtbTel.Campo = "Telefone*";
            this.mtbTel.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbTel.Location = new System.Drawing.Point(5, 110);
            this.mtbTel.Mask = "";
            this.mtbTel.MaxLength = 32767;
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(378, 20);
            this.mtbTel.TabIndex = 11;
            this.mtbTel.ValidatingType = null;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.AccessibleName = "CPF*";
            this.mtbCNPJ.Campo = "CNPJ*";
            this.mtbCNPJ.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbCNPJ.Location = new System.Drawing.Point(5, 50);
            this.mtbCNPJ.Mask = "";
            this.mtbCNPJ.MaxLength = 32767;
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(380, 20);
            this.mtbCNPJ.TabIndex = 9;
            this.mtbCNPJ.ValidatingType = null;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.AccessibleName = "Nome*";
            this.txtRazaoSocial.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtRazaoSocial.Campo = "Razão Social*";
            this.txtRazaoSocial.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtRazaoSocial.Location = new System.Drawing.Point(5, 20);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRazaoSocial.MaxLength = 32767;
            this.txtRazaoSocial.Multiline = false;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRazaoSocial.Size = new System.Drawing.Size(380, 20);
            this.txtRazaoSocial.TabIndex = 7;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.fornecedor;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(500, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Fornecedor";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.txtEndComplemento);
            this.grpEndereco.Controls.Add(this.txtEndCidade);
            this.grpEndereco.Controls.Add(this.txtEndBairro);
            this.grpEndereco.Controls.Add(this.mtbEndCEP);
            this.grpEndereco.Controls.Add(this.cboEndUF);
            this.grpEndereco.Controls.Add(this.txtEndLogradouro);
            this.grpEndereco.Controls.Add(this.txtEndNr);
            this.grpEndereco.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEndereco.Location = new System.Drawing.Point(105, 205);
            this.grpEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEndereco.Size = new System.Drawing.Size(390, 140);
            this.grpEndereco.TabIndex = 7;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "ENDEREÇO";
            // 
            // txtEndComplemento
            // 
            this.txtEndComplemento.AccessibleName = "Complemento";
            this.txtEndComplemento.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEndComplemento.Campo = "Complemento";
            this.txtEndComplemento.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndComplemento.Location = new System.Drawing.Point(135, 80);
            this.txtEndComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndComplemento.MaxLength = 100;
            this.txtEndComplemento.Multiline = false;
            this.txtEndComplemento.Name = "txtEndComplemento";
            this.txtEndComplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndComplemento.Size = new System.Drawing.Size(250, 21);
            this.txtEndComplemento.TabIndex = 3;
            // 
            // txtEndCidade
            // 
            this.txtEndCidade.AccessibleName = "Cidade*";
            this.txtEndCidade.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEndCidade.Campo = "Cidade*";
            this.txtEndCidade.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndCidade.Location = new System.Drawing.Point(150, 110);
            this.txtEndCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndCidade.MaxLength = 100;
            this.txtEndCidade.Multiline = false;
            this.txtEndCidade.Name = "txtEndCidade";
            this.txtEndCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndCidade.Size = new System.Drawing.Size(150, 21);
            this.txtEndCidade.TabIndex = 6;
            // 
            // txtEndBairro
            // 
            this.txtEndBairro.AccessibleName = "Bairro*";
            this.txtEndBairro.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEndBairro.Campo = "Bairro*";
            this.txtEndBairro.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndBairro.Location = new System.Drawing.Point(5, 110);
            this.txtEndBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndBairro.MaxLength = 100;
            this.txtEndBairro.Multiline = false;
            this.txtEndBairro.Name = "txtEndBairro";
            this.txtEndBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndBairro.Size = new System.Drawing.Size(140, 21);
            this.txtEndBairro.TabIndex = 5;
            // 
            // mtbEndCEP
            // 
            this.mtbEndCEP.AccessibleName = "CEP*";
            this.mtbEndCEP.Campo = "CEP*";
            this.mtbEndCEP.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbEndCEP.Location = new System.Drawing.Point(5, 20);
            this.mtbEndCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbEndCEP.Mask = "";
            this.mtbEndCEP.MaxLength = 32767;
            this.mtbEndCEP.Name = "mtbEndCEP";
            this.mtbEndCEP.Size = new System.Drawing.Size(95, 20);
            this.mtbEndCEP.TabIndex = 4;
            this.mtbEndCEP.ValidatingType = null;
            // 
            // cboEndUF
            // 
            this.cboEndUF.AccessibleName = "Estado*";
            this.cboEndUF.Campo = "UF*";
            this.cboEndUF.FormattingEnabled = true;
            this.cboEndUF.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.cboEndUF.Location = new System.Drawing.Point(305, 110);
            this.cboEndUF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEndUF.Name = "cboEndUF";
            this.cboEndUF.Size = new System.Drawing.Size(80, 25);
            this.cboEndUF.TabIndex = 7;
            // 
            // txtEndLogradouro
            // 
            this.txtEndLogradouro.AccessibleName = "Logradouro*";
            this.txtEndLogradouro.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEndLogradouro.Campo = "Logradouro*";
            this.txtEndLogradouro.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndLogradouro.Location = new System.Drawing.Point(5, 50);
            this.txtEndLogradouro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndLogradouro.MaxLength = 100;
            this.txtEndLogradouro.Multiline = false;
            this.txtEndLogradouro.Name = "txtEndLogradouro";
            this.txtEndLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndLogradouro.Size = new System.Drawing.Size(380, 21);
            this.txtEndLogradouro.TabIndex = 1;
            // 
            // txtEndNr
            // 
            this.txtEndNr.AccessibleName = "Número*";
            this.txtEndNr.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.INT;
            this.txtEndNr.Campo = "Número*";
            this.txtEndNr.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndNr.Location = new System.Drawing.Point(5, 80);
            this.txtEndNr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndNr.MaxLength = 100;
            this.txtEndNr.Multiline = false;
            this.txtEndNr.Name = "txtEndNr";
            this.txtEndNr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndNr.Size = new System.Drawing.Size(120, 21);
            this.txtEndNr.TabIndex = 2;
            // 
            // frmFornecedor
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbInformacoes.ResumeLayout(false);
            this.grpEndereco.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnCancelar;
        private vitorrdgs.UiX.Component.UIXButton btnSalvar;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private vitorrdgs.UiX.Component.UIXTextBox txtRazaoSocial;
        private vitorrdgs.UiX.Component.UIXTextBox txtEmail;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbTel;
        public vitorrdgs.UiX.Component.UIXMaskedTextBox mtbCNPJ;
        public System.Windows.Forms.GroupBox grpEndereco;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndComplemento;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndCidade;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndBairro;
        public vitorrdgs.UiX.Component.UIXMaskedTextBox mtbEndCEP;
        public vitorrdgs.UiX.Component.UIXComboBox cboEndUF;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndLogradouro;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndNr;
    }
}