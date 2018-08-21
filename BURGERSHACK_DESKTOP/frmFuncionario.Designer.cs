namespace BurgerShack.Desktop
{
    partial class frmFuncionario
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
            this.btnExcluir = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAcesso = new vitorrdgs.UiX.Component.UIXButton();
            this.btnVoltar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAlterar = new vitorrdgs.UiX.Component.UIXButton();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.mtbTelRes = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.txtRG = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtEmail = new vitorrdgs.UiX.Component.UIXTextBox();
            this.mtbTelCel = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.cboGenero = new vitorrdgs.UiX.Component.UIXComboBox();
            this.mtbCPF = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.mtbDataNasc = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.txtNome = new vitorrdgs.UiX.Component.UIXTextBox();
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.grbEndereco = new System.Windows.Forms.GroupBox();
            this.txtEndComplemento = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtEndCidade = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtEndBairro = new vitorrdgs.UiX.Component.UIXTextBox();
            this.mtbEndCEP = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.cboEndUF = new vitorrdgs.UiX.Component.UIXComboBox();
            this.txtEndLogradouro = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtEndNr = new vitorrdgs.UiX.Component.UIXTextBox();
            this.grbImagem = new System.Windows.Forms.GroupBox();
            this.btnImgAdicionar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnImgRemover = new vitorrdgs.UiX.Component.UIXButton();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.grbContrato = new System.Windows.Forms.GroupBox();
            this.cboCargo = new vitorrdgs.UiX.Component.UIXComboBox();
            this.cboSituacao = new vitorrdgs.UiX.Component.UIXComboBox();
            this.txtSalario = new vitorrdgs.UiX.Component.UIXTextBox();
            this.pnlMenu.SuspendLayout();
            this.grbInformacoes.SuspendLayout();
            this.grbEndereco.SuspendLayout();
            this.grbImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.grbContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnExcluir);
            this.pnlMenu.Controls.Add(this.btnAcesso);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 400);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Description = "EXCLUIR";
            this.btnExcluir.HoverColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Image = global::BurgerShack.Desktop.Properties.Resources.excluir;
            this.btnExcluir.ImageLocation = null;
            this.btnExcluir.Location = new System.Drawing.Point(5, 205);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 90);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAcesso
            // 
            this.btnAcesso.Description = "ACESSO";
            this.btnAcesso.HoverColor = System.Drawing.Color.Transparent;
            this.btnAcesso.Image = global::BurgerShack.Desktop.Properties.Resources.entrar;
            this.btnAcesso.ImageLocation = null;
            this.btnAcesso.Location = new System.Drawing.Point(5, 105);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(90, 90);
            this.btnAcesso.TabIndex = 7;
            this.btnAcesso.Text = "Acesso";
            this.btnAcesso.UseVisualStyleBackColor = true;
            this.btnAcesso.Visible = false;
            this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Description = "CANCELAR";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BurgerShack.Desktop.Properties.Resources.voltar;
            this.btnVoltar.ImageLocation = null;
            this.btnVoltar.Location = new System.Drawing.Point(5, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 90);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Description = "SALVAR";
            this.btnAlterar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Image = global::BurgerShack.Desktop.Properties.Resources.salvar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.ImageLocation = null;
            this.btnAlterar.Location = new System.Drawing.Point(5, 305);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 90);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Salvar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.mtbTelRes);
            this.grbInformacoes.Controls.Add(this.txtRG);
            this.grbInformacoes.Controls.Add(this.txtEmail);
            this.grbInformacoes.Controls.Add(this.mtbTelCel);
            this.grbInformacoes.Controls.Add(this.cboGenero);
            this.grbInformacoes.Controls.Add(this.mtbCPF);
            this.grbInformacoes.Controls.Add(this.mtbDataNasc);
            this.grbInformacoes.Controls.Add(this.txtNome);
            this.grbInformacoes.Location = new System.Drawing.Point(105, 55);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(390, 170);
            this.grbInformacoes.TabIndex = 6;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "INFORMAÇÕES DO FUNCIONÁRIO";
            // 
            // mtbTelRes
            // 
            this.mtbTelRes.AcceptButton = null;
            this.mtbTelRes.AccessibleName = "Tel. Cel.*";
            this.mtbTelRes.Campo = "Tel. Res.*";
            this.mtbTelRes.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbTelRes.Location = new System.Drawing.Point(190, 140);
            this.mtbTelRes.Mask = "";
            this.mtbTelRes.MaxLength = 32767;
            this.mtbTelRes.Name = "mtbTelRes";
            this.mtbTelRes.Size = new System.Drawing.Size(195, 21);
            this.mtbTelRes.TabIndex = 14;
            this.mtbTelRes.ValidatingType = null;
            // 
            // txtRG
            // 
            this.txtRG.AcceptButton = null;
            this.txtRG.AccessibleName = "CPF*";
            this.txtRG.Campo = "RG*";
            this.txtRG.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtRG.Location = new System.Drawing.Point(180, 50);
            this.txtRG.MaxLength = 32767;
            this.txtRG.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.INT;
            this.txtRG.Multiline = false;
            this.txtRG.Name = "txtRG";
            this.txtRG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRG.Size = new System.Drawing.Size(205, 21);
            this.txtRG.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptButton = null;
            this.txtEmail.AccessibleName = "E-mail";
            this.txtEmail.Campo = "E-mail*";
            this.txtEmail.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEmail.Location = new System.Drawing.Point(5, 110);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.Size = new System.Drawing.Size(380, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // mtbTelCel
            // 
            this.mtbTelCel.AcceptButton = null;
            this.mtbTelCel.AccessibleName = "Tel. Cel.*";
            this.mtbTelCel.Campo = "Tel. Cel.*";
            this.mtbTelCel.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbTelCel.Location = new System.Drawing.Point(5, 140);
            this.mtbTelCel.Mask = "";
            this.mtbTelCel.MaxLength = 32767;
            this.mtbTelCel.Name = "mtbTelCel";
            this.mtbTelCel.Size = new System.Drawing.Size(180, 21);
            this.mtbTelCel.TabIndex = 11;
            this.mtbTelCel.ValidatingType = null;
            // 
            // cboGenero
            // 
            this.cboGenero.AcceptButton = null;
            this.cboGenero.AccessibleName = "Genero*";
            this.cboGenero.Campo = "Gênero*";
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.cboGenero.Location = new System.Drawing.Point(280, 80);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.SelectedItem = null;
            this.cboGenero.Size = new System.Drawing.Size(105, 25);
            this.cboGenero.TabIndex = 10;
            // 
            // mtbCPF
            // 
            this.mtbCPF.AcceptButton = null;
            this.mtbCPF.AccessibleName = "CPF*";
            this.mtbCPF.Campo = "CPF*";
            this.mtbCPF.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbCPF.Location = new System.Drawing.Point(5, 50);
            this.mtbCPF.Mask = "";
            this.mtbCPF.MaxLength = 32767;
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(170, 21);
            this.mtbCPF.TabIndex = 9;
            this.mtbCPF.ValidatingType = null;
            // 
            // mtbDataNasc
            // 
            this.mtbDataNasc.AcceptButton = null;
            this.mtbDataNasc.AccessibleName = "Data de Nascimento*";
            this.mtbDataNasc.Campo = "Data de Nascimento*";
            this.mtbDataNasc.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbDataNasc.Location = new System.Drawing.Point(5, 80);
            this.mtbDataNasc.Mask = "";
            this.mtbDataNasc.MaxLength = 32767;
            this.mtbDataNasc.Name = "mtbDataNasc";
            this.mtbDataNasc.Size = new System.Drawing.Size(270, 21);
            this.mtbDataNasc.TabIndex = 8;
            this.mtbDataNasc.ValidatingType = null;
            // 
            // txtNome
            // 
            this.txtNome.AcceptButton = null;
            this.txtNome.AccessibleName = "Nome*";
            this.txtNome.Campo = "Nome*";
            this.txtNome.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtNome.Location = new System.Drawing.Point(5, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.Size = new System.Drawing.Size(380, 21);
            this.txtNome.TabIndex = 7;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.funcionario;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(700, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Funcionário";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // grbEndereco
            // 
            this.grbEndereco.Controls.Add(this.txtEndComplemento);
            this.grbEndereco.Controls.Add(this.txtEndCidade);
            this.grbEndereco.Controls.Add(this.txtEndBairro);
            this.grbEndereco.Controls.Add(this.mtbEndCEP);
            this.grbEndereco.Controls.Add(this.cboEndUF);
            this.grbEndereco.Controls.Add(this.txtEndLogradouro);
            this.grbEndereco.Controls.Add(this.txtEndNr);
            this.grbEndereco.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEndereco.Location = new System.Drawing.Point(105, 305);
            this.grbEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbEndereco.Name = "grbEndereco";
            this.grbEndereco.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbEndereco.Size = new System.Drawing.Size(390, 140);
            this.grbEndereco.TabIndex = 7;
            this.grbEndereco.TabStop = false;
            this.grbEndereco.Text = "ENDEREÇO";
            // 
            // txtEndComplemento
            // 
            this.txtEndComplemento.AcceptButton = null;
            this.txtEndComplemento.AccessibleName = "Complemento";
            this.txtEndComplemento.Campo = "Complemento";
            this.txtEndComplemento.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndComplemento.Location = new System.Drawing.Point(135, 80);
            this.txtEndComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndComplemento.MaxLength = 100;
            this.txtEndComplemento.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEndComplemento.Multiline = false;
            this.txtEndComplemento.Name = "txtEndComplemento";
            this.txtEndComplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndComplemento.Size = new System.Drawing.Size(250, 21);
            this.txtEndComplemento.TabIndex = 3;
            // 
            // txtEndCidade
            // 
            this.txtEndCidade.AcceptButton = null;
            this.txtEndCidade.AccessibleName = "Cidade*";
            this.txtEndCidade.Campo = "Cidade*";
            this.txtEndCidade.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndCidade.Location = new System.Drawing.Point(150, 110);
            this.txtEndCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndCidade.MaxLength = 100;
            this.txtEndCidade.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEndCidade.Multiline = false;
            this.txtEndCidade.Name = "txtEndCidade";
            this.txtEndCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndCidade.Size = new System.Drawing.Size(150, 21);
            this.txtEndCidade.TabIndex = 6;
            // 
            // txtEndBairro
            // 
            this.txtEndBairro.AcceptButton = null;
            this.txtEndBairro.AccessibleName = "Bairro*";
            this.txtEndBairro.Campo = "Bairro*";
            this.txtEndBairro.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndBairro.Location = new System.Drawing.Point(5, 110);
            this.txtEndBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndBairro.MaxLength = 100;
            this.txtEndBairro.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEndBairro.Multiline = false;
            this.txtEndBairro.Name = "txtEndBairro";
            this.txtEndBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndBairro.Size = new System.Drawing.Size(140, 21);
            this.txtEndBairro.TabIndex = 5;
            // 
            // mtbEndCEP
            // 
            this.mtbEndCEP.AcceptButton = null;
            this.mtbEndCEP.AccessibleName = "CEP*";
            this.mtbEndCEP.Campo = "CEP*";
            this.mtbEndCEP.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbEndCEP.Location = new System.Drawing.Point(5, 20);
            this.mtbEndCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbEndCEP.Mask = "";
            this.mtbEndCEP.MaxLength = 32767;
            this.mtbEndCEP.Name = "mtbEndCEP";
            this.mtbEndCEP.Size = new System.Drawing.Size(95, 21);
            this.mtbEndCEP.TabIndex = 4;
            this.mtbEndCEP.ValidatingType = null;
            // 
            // cboEndUF
            // 
            this.cboEndUF.AcceptButton = null;
            this.cboEndUF.AccessibleName = "Estado*";
            this.cboEndUF.Campo = "UF*";
            this.cboEndUF.FormattingEnabled = true;
            this.cboEndUF.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.cboEndUF.Location = new System.Drawing.Point(305, 110);
            this.cboEndUF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEndUF.Name = "cboEndUF";
            this.cboEndUF.SelectedItem = null;
            this.cboEndUF.Size = new System.Drawing.Size(80, 25);
            this.cboEndUF.TabIndex = 7;
            // 
            // txtEndLogradouro
            // 
            this.txtEndLogradouro.AcceptButton = null;
            this.txtEndLogradouro.AccessibleName = "Logradouro*";
            this.txtEndLogradouro.Campo = "Logradouro*";
            this.txtEndLogradouro.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndLogradouro.Location = new System.Drawing.Point(5, 50);
            this.txtEndLogradouro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndLogradouro.MaxLength = 100;
            this.txtEndLogradouro.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtEndLogradouro.Multiline = false;
            this.txtEndLogradouro.Name = "txtEndLogradouro";
            this.txtEndLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndLogradouro.Size = new System.Drawing.Size(380, 21);
            this.txtEndLogradouro.TabIndex = 1;
            // 
            // txtEndNr
            // 
            this.txtEndNr.AcceptButton = null;
            this.txtEndNr.AccessibleName = "Número*";
            this.txtEndNr.Campo = "Número*";
            this.txtEndNr.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtEndNr.Location = new System.Drawing.Point(5, 80);
            this.txtEndNr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndNr.MaxLength = 100;
            this.txtEndNr.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.INT;
            this.txtEndNr.Multiline = false;
            this.txtEndNr.Name = "txtEndNr";
            this.txtEndNr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndNr.Size = new System.Drawing.Size(120, 21);
            this.txtEndNr.TabIndex = 2;
            // 
            // grbImagem
            // 
            this.grbImagem.Controls.Add(this.btnImgAdicionar);
            this.grbImagem.Controls.Add(this.btnImgRemover);
            this.grbImagem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbImagem.Location = new System.Drawing.Point(505, 245);
            this.grbImagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbImagem.Name = "grbImagem";
            this.grbImagem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbImagem.Size = new System.Drawing.Size(190, 100);
            this.grbImagem.TabIndex = 28;
            this.grbImagem.TabStop = false;
            this.grbImagem.Text = "IMAGEM";
            // 
            // btnImgAdicionar
            // 
            this.btnImgAdicionar.Description = "ADICIONAR";
            this.btnImgAdicionar.HoverColor = System.Drawing.Color.Transparent;
            this.btnImgAdicionar.Image = global::BurgerShack.Desktop.Properties.Resources.adicionar;
            this.btnImgAdicionar.ImageLocation = null;
            this.btnImgAdicionar.Location = new System.Drawing.Point(100, 15);
            this.btnImgAdicionar.Name = "btnImgAdicionar";
            this.btnImgAdicionar.Size = new System.Drawing.Size(80, 80);
            this.btnImgAdicionar.TabIndex = 26;
            this.btnImgAdicionar.Text = "Adicionar";
            this.btnImgAdicionar.UseVisualStyleBackColor = true;
            this.btnImgAdicionar.Click += new System.EventHandler(this.btnImgAdicionar_Click);
            // 
            // btnImgRemover
            // 
            this.btnImgRemover.Description = "REMOVER";
            this.btnImgRemover.HoverColor = System.Drawing.Color.Transparent;
            this.btnImgRemover.Image = global::BurgerShack.Desktop.Properties.Resources.remover;
            this.btnImgRemover.ImageLocation = null;
            this.btnImgRemover.Location = new System.Drawing.Point(10, 15);
            this.btnImgRemover.Name = "btnImgRemover";
            this.btnImgRemover.Size = new System.Drawing.Size(80, 80);
            this.btnImgRemover.TabIndex = 28;
            this.btnImgRemover.Text = "Remover";
            this.btnImgRemover.UseVisualStyleBackColor = true;
            this.btnImgRemover.Click += new System.EventHandler(this.btnImgRemover_Click);
            // 
            // picImagem
            // 
            this.picImagem.Image = global::BurgerShack.Desktop.Properties.Resources.imagem;
            this.picImagem.Location = new System.Drawing.Point(505, 55);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(190, 190);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 29;
            this.picImagem.TabStop = false;
            // 
            // grbContrato
            // 
            this.grbContrato.Controls.Add(this.cboCargo);
            this.grbContrato.Controls.Add(this.cboSituacao);
            this.grbContrato.Controls.Add(this.txtSalario);
            this.grbContrato.Location = new System.Drawing.Point(105, 225);
            this.grbContrato.Name = "grbContrato";
            this.grbContrato.Size = new System.Drawing.Size(390, 75);
            this.grbContrato.TabIndex = 15;
            this.grbContrato.TabStop = false;
            this.grbContrato.Text = "CONTRATO";
            // 
            // cboCargo
            // 
            this.cboCargo.AcceptButton = null;
            this.cboCargo.Campo = "Cargo*";
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.cboCargo.Location = new System.Drawing.Point(5, 46);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.SelectedItem = null;
            this.cboCargo.Size = new System.Drawing.Size(380, 25);
            this.cboCargo.TabIndex = 2;
            // 
            // cboSituacao
            // 
            this.cboSituacao.AcceptButton = null;
            this.cboSituacao.Campo = "Situação";
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.cboSituacao.Location = new System.Drawing.Point(195, 15);
            this.cboSituacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.SelectedItem = null;
            this.cboSituacao.Size = new System.Drawing.Size(190, 25);
            this.cboSituacao.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.AcceptButton = null;
            this.txtSalario.Campo = "Salário*";
            this.txtSalario.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtSalario.Location = new System.Drawing.Point(5, 15);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalario.MaxLength = 32767;
            this.txtSalario.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.MONEY;
            this.txtSalario.Multiline = false;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalario.Size = new System.Drawing.Size(180, 26);
            this.txtSalario.TabIndex = 0;
            // 
            // frmFuncionario
            // 
            this.AcceptButton = this.btnAlterar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.grbContrato);
            this.Controls.Add(this.grbImagem);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.grbEndereco);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbInformacoes.ResumeLayout(false);
            this.grbEndereco.ResumeLayout(false);
            this.grbImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.grbContrato.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnVoltar;
        private vitorrdgs.UiX.Component.UIXButton btnAlterar;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private vitorrdgs.UiX.Component.UIXTextBox txtNome;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbDataNasc;
        private vitorrdgs.UiX.Component.UIXComboBox cboGenero;
        private vitorrdgs.UiX.Component.UIXTextBox txtEmail;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbTelCel;
        public vitorrdgs.UiX.Component.UIXMaskedTextBox mtbCPF;
        public vitorrdgs.UiX.Component.UIXTextBox txtRG;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbTelRes;
        public System.Windows.Forms.GroupBox grbEndereco;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndComplemento;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndCidade;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndBairro;
        public vitorrdgs.UiX.Component.UIXMaskedTextBox mtbEndCEP;
        public vitorrdgs.UiX.Component.UIXComboBox cboEndUF;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndLogradouro;
        public vitorrdgs.UiX.Component.UIXTextBox txtEndNr;
        public System.Windows.Forms.GroupBox grbImagem;
        private vitorrdgs.UiX.Component.UIXButton btnImgAdicionar;
        private vitorrdgs.UiX.Component.UIXButton btnImgRemover;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.GroupBox grbContrato;
        private vitorrdgs.UiX.Component.UIXTextBox txtSalario;
        private vitorrdgs.UiX.Component.UIXComboBox cboSituacao;
        private vitorrdgs.UiX.Component.UIXComboBox cboCargo;
        private vitorrdgs.UiX.Component.UIXButton btnAcesso;
        private vitorrdgs.UiX.Component.UIXButton btnExcluir;
    }
}