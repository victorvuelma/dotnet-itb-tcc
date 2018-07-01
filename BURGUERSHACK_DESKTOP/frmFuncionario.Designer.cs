namespace BURGUERSHACK_DESKTOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAcesso = new UIX.btnUIX();
            this.btnVoltar = new UIX.btnUIX();
            this.btnSalvar = new UIX.btnUIX();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.mtbTelRes = new UIX.mtbUIX();
            this.txtRG = new UIX.txtUIX();
            this.txtEmail = new UIX.txtUIX();
            this.mtbTelCel = new UIX.mtbUIX();
            this.cboGenero = new UIX.cboUIX();
            this.mtbCPF = new UIX.mtbUIX();
            this.mtbDataNasc = new UIX.mtbUIX();
            this.txtNome = new UIX.txtUIX();
            this.hdrUIX = new UIX.hdrUIX();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtEndComplemento = new UIX.txtUIX();
            this.txtEndCidade = new UIX.txtUIX();
            this.txtEndBairro = new UIX.txtUIX();
            this.mtbEndCEP = new UIX.mtbUIX();
            this.cboEndUF = new UIX.cboUIX();
            this.txtEndLogradouro = new UIX.txtUIX();
            this.txtEndNr = new UIX.txtUIX();
            this.grbImagem = new System.Windows.Forms.GroupBox();
            this.btnImgAdicionar = new UIX.btnUIX();
            this.btnImgRemover = new UIX.btnUIX();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.grbContrato = new System.Windows.Forms.GroupBox();
            this.cboCargo = new UIX.cboUIX();
            this.cboSituacao = new UIX.cboUIX();
            this.txtSalario = new UIX.txtUIX();
            this.pnlMenu.SuspendLayout();
            this.grbInformacoes.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.grbImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.grbContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnAcesso);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnSalvar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 400);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnAcesso
            // 
            this.btnAcesso.Description = "Acesso";
            this.btnAcesso.HoverColor = System.Drawing.Color.Transparent;
            this.btnAcesso.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.entrar;
            this.btnAcesso.ImageLocation = null;
            this.btnAcesso.Location = new System.Drawing.Point(5, 205);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(90, 90);
            this.btnAcesso.TabIndex = 7;
            this.btnAcesso.Text = "Acesso";
            this.btnAcesso.UseVisualStyleBackColor = true;
            this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Description = "Cancelar";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.voltar;
            this.btnVoltar.ImageLocation = null;
            this.btnVoltar.Location = new System.Drawing.Point(5, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 90);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.ImageLocation = null;
            this.btnSalvar.Location = new System.Drawing.Point(5, 305);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 90);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.mtbTelRes.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.mtbTelRes.Location = new System.Drawing.Point(190, 140);
            this.mtbTelRes.Mask = "";
            this.mtbTelRes.MaxLength = 32767;
            this.mtbTelRes.Name = "mtbTelRes";
            this.mtbTelRes.Size = new System.Drawing.Size(195, 20);
            this.mtbTelRes.TabIndex = 14;
            this.mtbTelRes.ValidatingType = null;
            // 
            // txtRG
            // 
            this.txtRG.AcceptButton = null;
            this.txtRG.AccessibleName = "CPF*";
            this.txtRG.Campo = "RG*";
            this.txtRG.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtRG.Location = new System.Drawing.Point(180, 50);
            this.txtRG.MaxLength = 32767;
            this.txtRG.Mode = UIX.uixEnum.uixTextBoxMode.INT;
            this.txtRG.Multiline = false;
            this.txtRG.Name = "txtRG";
            this.txtRG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRG.Size = new System.Drawing.Size(205, 20);
            this.txtRG.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptButton = null;
            this.txtEmail.AccessibleName = "E-mail";
            this.txtEmail.Campo = "E-mail*";
            this.txtEmail.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtEmail.Location = new System.Drawing.Point(5, 110);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
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
            this.mtbTelCel.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.mtbTelCel.Location = new System.Drawing.Point(5, 140);
            this.mtbTelCel.Mask = "";
            this.mtbTelCel.MaxLength = 32767;
            this.mtbTelCel.Name = "mtbTelCel";
            this.mtbTelCel.Size = new System.Drawing.Size(180, 20);
            this.mtbTelCel.TabIndex = 11;
            this.mtbTelCel.ValidatingType = null;
            // 
            // cboGenero
            // 
            this.cboGenero.AcceptButton = null;
            this.cboGenero.AccessibleName = "Genero*";
            this.cboGenero.Campo = "Gênero*";
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.cboGenero.Location = new System.Drawing.Point(280, 80);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(105, 20);
            this.cboGenero.TabIndex = 10;
            // 
            // mtbCPF
            // 
            this.mtbCPF.AcceptButton = null;
            this.mtbCPF.AccessibleName = "CPF*";
            this.mtbCPF.Campo = "CPF*";
            this.mtbCPF.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.mtbCPF.Location = new System.Drawing.Point(5, 50);
            this.mtbCPF.Mask = "";
            this.mtbCPF.MaxLength = 32767;
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(170, 20);
            this.mtbCPF.TabIndex = 9;
            this.mtbCPF.ValidatingType = null;
            // 
            // mtbDataNasc
            // 
            this.mtbDataNasc.AcceptButton = null;
            this.mtbDataNasc.AccessibleName = "Data de Nascimento*";
            this.mtbDataNasc.Campo = "Data de Nascimento";
            this.mtbDataNasc.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.mtbDataNasc.Location = new System.Drawing.Point(5, 80);
            this.mtbDataNasc.Mask = "";
            this.mtbDataNasc.MaxLength = 32767;
            this.mtbDataNasc.Name = "mtbDataNasc";
            this.mtbDataNasc.Size = new System.Drawing.Size(270, 20);
            this.mtbDataNasc.TabIndex = 8;
            this.mtbDataNasc.ValidatingType = null;
            // 
            // txtNome
            // 
            this.txtNome.AcceptButton = null;
            this.txtNome.AccessibleName = "Nome*";
            this.txtNome.Campo = "Nome*";
            this.txtNome.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtNome.Location = new System.Drawing.Point(5, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.Size = new System.Drawing.Size(380, 20);
            this.txtNome.TabIndex = 7;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.funcionario;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(700, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Funcionário";
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
            this.grpEndereco.Location = new System.Drawing.Point(105, 305);
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
            this.txtEndComplemento.AcceptButton = null;
            this.txtEndComplemento.AccessibleName = "Complemento";
            this.txtEndComplemento.Campo = "Complemento";
            this.txtEndComplemento.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtEndComplemento.Location = new System.Drawing.Point(135, 80);
            this.txtEndComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndComplemento.MaxLength = 100;
            this.txtEndComplemento.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
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
            this.txtEndCidade.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtEndCidade.Location = new System.Drawing.Point(150, 110);
            this.txtEndCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndCidade.MaxLength = 100;
            this.txtEndCidade.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
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
            this.txtEndBairro.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtEndBairro.Location = new System.Drawing.Point(5, 110);
            this.txtEndBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndBairro.MaxLength = 100;
            this.txtEndBairro.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
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
            this.mtbEndCEP.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
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
            this.cboEndUF.AcceptButton = null;
            this.cboEndUF.AccessibleName = "Estado*";
            this.cboEndUF.Campo = "UF*";
            this.cboEndUF.FormattingEnabled = true;
            this.cboEndUF.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.cboEndUF.Location = new System.Drawing.Point(305, 110);
            this.cboEndUF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEndUF.Name = "cboEndUF";
            this.cboEndUF.Size = new System.Drawing.Size(80, 25);
            this.cboEndUF.TabIndex = 7;
            // 
            // txtEndLogradouro
            // 
            this.txtEndLogradouro.AcceptButton = null;
            this.txtEndLogradouro.AccessibleName = "Logradouro*";
            this.txtEndLogradouro.Campo = "Logradouro*";
            this.txtEndLogradouro.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtEndLogradouro.Location = new System.Drawing.Point(5, 50);
            this.txtEndLogradouro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndLogradouro.MaxLength = 100;
            this.txtEndLogradouro.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
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
            this.txtEndNr.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtEndNr.Location = new System.Drawing.Point(5, 80);
            this.txtEndNr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndNr.MaxLength = 100;
            this.txtEndNr.Mode = UIX.uixEnum.uixTextBoxMode.INT;
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
            this.btnImgAdicionar.Description = "Adicionar";
            this.btnImgAdicionar.HoverColor = System.Drawing.Color.Transparent;
            this.btnImgAdicionar.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.adicionar;
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
            this.btnImgRemover.Description = "Remover";
            this.btnImgRemover.HoverColor = System.Drawing.Color.Transparent;
            this.btnImgRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnImgRemover.Image")));
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
            this.picImagem.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.imagem;
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
            this.cboCargo.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.cboCargo.Location = new System.Drawing.Point(5, 45);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(380, 25);
            this.cboCargo.TabIndex = 2;
            // 
            // cboSituacao
            // 
            this.cboSituacao.AcceptButton = null;
            this.cboSituacao.Campo = "Situação";
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.cboSituacao.Location = new System.Drawing.Point(195, 15);
            this.cboSituacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(190, 20);
            this.cboSituacao.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.AcceptButton = null;
            this.txtSalario.Campo = "Salário*";
            this.txtSalario.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtSalario.Location = new System.Drawing.Point(5, 15);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalario.MaxLength = 32767;
            this.txtSalario.Mode = UIX.uixEnum.uixTextBoxMode.MONEY;
            this.txtSalario.Multiline = false;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalario.Size = new System.Drawing.Size(180, 20);
            this.txtSalario.TabIndex = 0;
            // 
            // frmFuncionario
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.grbContrato);
            this.Controls.Add(this.grbImagem);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.grpEndereco);
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
            this.grpEndereco.ResumeLayout(false);
            this.grbImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.grbContrato.ResumeLayout(false);
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
        public UIX.txtUIX txtRG;
        private UIX.mtbUIX mtbTelRes;
        public System.Windows.Forms.GroupBox grpEndereco;
        public UIX.txtUIX txtEndComplemento;
        public UIX.txtUIX txtEndCidade;
        public UIX.txtUIX txtEndBairro;
        public UIX.mtbUIX mtbEndCEP;
        public UIX.cboUIX cboEndUF;
        public UIX.txtUIX txtEndLogradouro;
        public UIX.txtUIX txtEndNr;
        public System.Windows.Forms.GroupBox grbImagem;
        private UIX.btnUIX btnImgAdicionar;
        private UIX.btnUIX btnImgRemover;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.GroupBox grbContrato;
        private UIX.txtUIX txtSalario;
        private UIX.cboUIX cboSituacao;
        private UIX.cboUIX cboCargo;
        private UIX.btnUIX btnAcesso;
    }
}