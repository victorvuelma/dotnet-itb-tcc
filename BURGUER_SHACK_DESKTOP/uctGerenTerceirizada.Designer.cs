namespace BURGUER_SHACK_DESKTOP
{
    partial class uctGerenTerceirizada
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDadosEmpresa = new System.Windows.Forms.GroupBox();
            this.txtEmpSite = new UIX.txtUIX();
            this.mtbEmpCNPJ = new UIX.mtbUIX();
            this.txtEmpNomeFantasia = new UIX.txtUIX();
            this.txtEmpRazaoSocial = new UIX.txtUIX();
            this.mtbEmpIE = new UIX.mtbUIX();
            this.grpContato = new System.Windows.Forms.GroupBox();
            this.mtbCntFax = new UIX.mtbUIX();
            this.mtbCntRamal = new UIX.mtbUIX();
            this.mtbCntTelCel = new UIX.mtbUIX();
            this.mtbCntTelCom2 = new UIX.mtbUIX();
            this.mtbCntTelCom = new UIX.mtbUIX();
            this.txtCntEmail = new UIX.txtUIX();
            this.grpDadosResponsavel = new System.Windows.Forms.GroupBox();
            this.txtResEmail = new UIX.txtUIX();
            this.mtbResTelFixo = new UIX.mtbUIX();
            this.mtbResTelCom = new UIX.mtbUIX();
            this.mtbResRG = new UIX.mtbUIX();
            this.mtbResCPF = new UIX.mtbUIX();
            this.txtResNome = new UIX.txtUIX();
            this.txtCtrCargo = new UIX.txtUIX();
            this.grpContrato = new System.Windows.Forms.GroupBox();
            this.mtbCtrConvTermino = new UIX.mtbUIX();
            this.mtbCtrConvInicio = new UIX.mtbUIX();
            this.mtbCtrConvNr = new UIX.mtbUIX();
            this.txtCtrCoord = new UIX.txtUIX();
            this.txtPesquisa = new UIX.txtUIX();
            this.btnSalvar = new UIX.btnUIX();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtEndComplemento = new UIX.txtUIX();
            this.txtEndCidade = new UIX.txtUIX();
            this.txtEndBairro = new UIX.txtUIX();
            this.mtbEndCEP = new UIX.mtbUIX();
            this.cboEndUF = new UIX.cboUIX();
            this.txtEndNr = new UIX.txtUIX();
            this.txtEndLogradouro = new UIX.txtUIX();
            this.grbDadosEmpresa.SuspendLayout();
            this.grpContato.SuspendLayout();
            this.grpDadosResponsavel.SuspendLayout();
            this.grpContrato.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosEmpresa
            // 
            this.grbDadosEmpresa.Controls.Add(this.txtEmpSite);
            this.grbDadosEmpresa.Controls.Add(this.mtbEmpCNPJ);
            this.grbDadosEmpresa.Controls.Add(this.txtEmpNomeFantasia);
            this.grbDadosEmpresa.Controls.Add(this.txtEmpRazaoSocial);
            this.grbDadosEmpresa.Controls.Add(this.mtbEmpIE);
            this.grbDadosEmpresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosEmpresa.Location = new System.Drawing.Point(5, 20);
            this.grbDadosEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosEmpresa.Name = "grbDadosEmpresa";
            this.grbDadosEmpresa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosEmpresa.Size = new System.Drawing.Size(790, 80);
            this.grbDadosEmpresa.TabIndex = 4;
            this.grbDadosEmpresa.TabStop = false;
            this.grbDadosEmpresa.Text = "DADOS EMPRESARIAL";
            // 
            // txtEmpSite
            // 
            this.txtEmpSite.AccessibleName = "Site";
            this.txtEmpSite.Campo = "Site";
            this.txtEmpSite.Location = new System.Drawing.Point(352, 50);
            this.txtEmpSite.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtEmpSite.MaxLength = 32767;
            this.txtEmpSite.Name = "txtEmpSite";
            this.txtEmpSite.Size = new System.Drawing.Size(360, 21);
            this.txtEmpSite.TabIndex = 6;
            // 
            // mtbEmpCNPJ
            // 
            this.mtbEmpCNPJ.AccessibleName = "CNPJ";
            this.mtbEmpCNPJ.Campo = "CNPJ";
            this.mtbEmpCNPJ.Location = new System.Drawing.Point(5, 50);
            this.mtbEmpCNPJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbEmpCNPJ.Mask = "00,000,000/0000-00";
            this.mtbEmpCNPJ.MaxLength = 32767;
            this.mtbEmpCNPJ.Name = "mtbEmpCNPJ";
            this.mtbEmpCNPJ.Size = new System.Drawing.Size(143, 21);
            this.mtbEmpCNPJ.TabIndex = 4;
            this.mtbEmpCNPJ.ValidatingType = null;
            // 
            // txtEmpNomeFantasia
            // 
            this.txtEmpNomeFantasia.AccessibleName = "Nome Fantasia";
            this.txtEmpNomeFantasia.Campo = "Nome Fantasia";
            this.txtEmpNomeFantasia.Location = new System.Drawing.Point(386, 20);
            this.txtEmpNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmpNomeFantasia.MaxLength = 32767;
            this.txtEmpNomeFantasia.Name = "txtEmpNomeFantasia";
            this.txtEmpNomeFantasia.Size = new System.Drawing.Size(326, 26);
            this.txtEmpNomeFantasia.TabIndex = 3;
            // 
            // txtEmpRazaoSocial
            // 
            this.txtEmpRazaoSocial.AccessibleName = "Razão Social*";
            this.txtEmpRazaoSocial.Campo = "Razão Social*";
            this.txtEmpRazaoSocial.Location = new System.Drawing.Point(5, 20);
            this.txtEmpRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpRazaoSocial.MaxLength = 32767;
            this.txtEmpRazaoSocial.Name = "txtEmpRazaoSocial";
            this.txtEmpRazaoSocial.Size = new System.Drawing.Size(375, 21);
            this.txtEmpRazaoSocial.TabIndex = 2;
            // 
            // mtbEmpIE
            // 
            this.mtbEmpIE.AccessibleName = "Inscrição Estadual";
            this.mtbEmpIE.Campo = "Inscrição Estadual";
            this.mtbEmpIE.Location = new System.Drawing.Point(154, 50);
            this.mtbEmpIE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mtbEmpIE.Mask = "000,000,000,000";
            this.mtbEmpIE.MaxLength = 32767;
            this.mtbEmpIE.Name = "mtbEmpIE";
            this.mtbEmpIE.Size = new System.Drawing.Size(192, 21);
            this.mtbEmpIE.TabIndex = 5;
            this.mtbEmpIE.ValidatingType = null;
            // 
            // grpContato
            // 
            this.grpContato.Controls.Add(this.mtbCntFax);
            this.grpContato.Controls.Add(this.mtbCntRamal);
            this.grpContato.Controls.Add(this.mtbCntTelCel);
            this.grpContato.Controls.Add(this.mtbCntTelCom2);
            this.grpContato.Controls.Add(this.mtbCntTelCom);
            this.grpContato.Controls.Add(this.txtCntEmail);
            this.grpContato.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContato.Location = new System.Drawing.Point(5, 185);
            this.grpContato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpContato.Name = "grpContato";
            this.grpContato.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpContato.Size = new System.Drawing.Size(790, 80);
            this.grpContato.TabIndex = 6;
            this.grpContato.TabStop = false;
            this.grpContato.Text = "MEIOS DE CONTATO";
            // 
            // mtbCntFax
            // 
            this.mtbCntFax.AccessibleName = "FAX";
            this.mtbCntFax.Campo = "FAX";
            this.mtbCntFax.Location = new System.Drawing.Point(325, 50);
            this.mtbCntFax.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.mtbCntFax.Mask = "(00) 0000-0000";
            this.mtbCntFax.MaxLength = 32767;
            this.mtbCntFax.Name = "mtbCntFax";
            this.mtbCntFax.Size = new System.Drawing.Size(106, 22);
            this.mtbCntFax.TabIndex = 18;
            this.mtbCntFax.ValidatingType = null;
            // 
            // mtbCntRamal
            // 
            this.mtbCntRamal.AccessibleName = "Ramal";
            this.mtbCntRamal.Campo = "Ramal";
            this.mtbCntRamal.Location = new System.Drawing.Point(192, 50);
            this.mtbCntRamal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCntRamal.Mask = "";
            this.mtbCntRamal.MaxLength = 32767;
            this.mtbCntRamal.Name = "mtbCntRamal";
            this.mtbCntRamal.Size = new System.Drawing.Size(127, 22);
            this.mtbCntRamal.TabIndex = 17;
            this.mtbCntRamal.ValidatingType = null;
            // 
            // mtbCntTelCel
            // 
            this.mtbCntTelCel.AccessibleName = "Telefone Celular";
            this.mtbCntTelCel.Campo = "Telefone Celular";
            this.mtbCntTelCel.Location = new System.Drawing.Point(5, 50);
            this.mtbCntTelCel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.mtbCntTelCel.Mask = "(00) 00000-0000";
            this.mtbCntTelCel.MaxLength = 32767;
            this.mtbCntTelCel.Name = "mtbCntTelCel";
            this.mtbCntTelCel.Size = new System.Drawing.Size(181, 23);
            this.mtbCntTelCel.TabIndex = 16;
            this.mtbCntTelCel.ValidatingType = null;
            // 
            // mtbCntTelCom2
            // 
            this.mtbCntTelCom2.AccessibleName = "Telefone Comercial";
            this.mtbCntTelCom2.Campo = "Telefone Comercial";
            this.mtbCntTelCom2.Location = new System.Drawing.Point(568, 20);
            this.mtbCntTelCom2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.mtbCntTelCom2.Mask = "(00) 0000-0000";
            this.mtbCntTelCom2.MaxLength = 32767;
            this.mtbCntTelCom2.Name = "mtbCntTelCom2";
            this.mtbCntTelCom2.Size = new System.Drawing.Size(191, 24);
            this.mtbCntTelCom2.TabIndex = 15;
            this.mtbCntTelCom2.ValidatingType = null;
            // 
            // mtbCntTelCom
            // 
            this.mtbCntTelCom.AccessibleName = "Telefone Comercial:*";
            this.mtbCntTelCom.Campo = "Telefone Comercial:*";
            this.mtbCntTelCom.Location = new System.Drawing.Point(362, 20);
            this.mtbCntTelCom.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.mtbCntTelCom.Mask = "(00) 0000-0000";
            this.mtbCntTelCom.MaxLength = 32767;
            this.mtbCntTelCom.Name = "mtbCntTelCom";
            this.mtbCntTelCom.Size = new System.Drawing.Size(200, 23);
            this.mtbCntTelCom.TabIndex = 14;
            this.mtbCntTelCom.ValidatingType = null;
            // 
            // txtCntEmail
            // 
            this.txtCntEmail.AccessibleName = "Email:*";
            this.txtCntEmail.Campo = "Email:*";
            this.txtCntEmail.Location = new System.Drawing.Point(5, 20);
            this.txtCntEmail.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtCntEmail.MaxLength = 40;
            this.txtCntEmail.Name = "txtCntEmail";
            this.txtCntEmail.Size = new System.Drawing.Size(351, 28);
            this.txtCntEmail.TabIndex = 13;
            // 
            // grpDadosResponsavel
            // 
            this.grpDadosResponsavel.Controls.Add(this.txtResEmail);
            this.grpDadosResponsavel.Controls.Add(this.mtbResTelFixo);
            this.grpDadosResponsavel.Controls.Add(this.mtbResTelCom);
            this.grpDadosResponsavel.Controls.Add(this.mtbResRG);
            this.grpDadosResponsavel.Controls.Add(this.mtbResCPF);
            this.grpDadosResponsavel.Controls.Add(this.txtResNome);
            this.grpDadosResponsavel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosResponsavel.Location = new System.Drawing.Point(5, 100);
            this.grpDadosResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDadosResponsavel.Name = "grpDadosResponsavel";
            this.grpDadosResponsavel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDadosResponsavel.Size = new System.Drawing.Size(790, 80);
            this.grpDadosResponsavel.TabIndex = 12;
            this.grpDadosResponsavel.TabStop = false;
            this.grpDadosResponsavel.Text = "DADOS DO RESPONSÁVEL *";
            // 
            // txtResEmail
            // 
            this.txtResEmail.AccessibleName = "Email";
            this.txtResEmail.Campo = "Email";
            this.txtResEmail.Location = new System.Drawing.Point(365, 50);
            this.txtResEmail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtResEmail.MaxLength = 40;
            this.txtResEmail.Name = "txtResEmail";
            this.txtResEmail.Size = new System.Drawing.Size(347, 21);
            this.txtResEmail.TabIndex = 12;
            // 
            // mtbResTelFixo
            // 
            this.mtbResTelFixo.AccessibleName = "Telefone Fixo";
            this.mtbResTelFixo.Campo = "Telefone Fixo";
            this.mtbResTelFixo.Location = new System.Drawing.Point(6, 50);
            this.mtbResTelFixo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.mtbResTelFixo.Mask = "(00) 0000-0000";
            this.mtbResTelFixo.MaxLength = 32767;
            this.mtbResTelFixo.Name = "mtbResTelFixo";
            this.mtbResTelFixo.Size = new System.Drawing.Size(155, 23);
            this.mtbResTelFixo.TabIndex = 10;
            this.mtbResTelFixo.ValidatingType = null;
            // 
            // mtbResTelCom
            // 
            this.mtbResTelCom.AccessibleName = "Telefone Comercial";
            this.mtbResTelCom.Campo = "Telefone Comercial";
            this.mtbResTelCom.Location = new System.Drawing.Point(167, 50);
            this.mtbResTelCom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mtbResTelCom.Mask = "(00) 0000-0000";
            this.mtbResTelCom.MaxLength = 32767;
            this.mtbResTelCom.Name = "mtbResTelCom";
            this.mtbResTelCom.Size = new System.Drawing.Size(192, 21);
            this.mtbResTelCom.TabIndex = 11;
            this.mtbResTelCom.ValidatingType = null;
            // 
            // mtbResRG
            // 
            this.mtbResRG.AccessibleName = "Registro Geral";
            this.mtbResRG.Campo = "Registro Geral";
            this.mtbResRG.Location = new System.Drawing.Point(560, 20);
            this.mtbResRG.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.mtbResRG.Mask = "00,000,000-0";
            this.mtbResRG.MaxLength = 32767;
            this.mtbResRG.Name = "mtbResRG";
            this.mtbResRG.Size = new System.Drawing.Size(152, 24);
            this.mtbResRG.TabIndex = 9;
            this.mtbResRG.ValidatingType = null;
            // 
            // mtbResCPF
            // 
            this.mtbResCPF.AccessibleName = "CPF";
            this.mtbResCPF.Campo = "CPF";
            this.mtbResCPF.Location = new System.Drawing.Point(444, 20);
            this.mtbResCPF.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mtbResCPF.Mask = "000,000,000-00";
            this.mtbResCPF.MaxLength = 32767;
            this.mtbResCPF.Name = "mtbResCPF";
            this.mtbResCPF.Size = new System.Drawing.Size(110, 26);
            this.mtbResCPF.TabIndex = 8;
            this.mtbResCPF.ValidatingType = null;
            // 
            // txtResNome
            // 
            this.txtResNome.AccessibleName = "Nome";
            this.txtResNome.Campo = "Nome";
            this.txtResNome.Location = new System.Drawing.Point(5, 20);
            this.txtResNome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtResNome.MaxLength = 40;
            this.txtResNome.Name = "txtResNome";
            this.txtResNome.Size = new System.Drawing.Size(433, 26);
            this.txtResNome.TabIndex = 7;
            // 
            // txtCtrCargo
            // 
            this.txtCtrCargo.AccessibleName = "Cargo/Função";
            this.txtCtrCargo.Campo = "Cargo/Função";
            this.txtCtrCargo.Location = new System.Drawing.Point(365, 50);
            this.txtCtrCargo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCtrCargo.MaxLength = 32767;
            this.txtCtrCargo.Name = "txtCtrCargo";
            this.txtCtrCargo.Size = new System.Drawing.Size(335, 21);
            this.txtCtrCargo.TabIndex = 30;
            // 
            // grpContrato
            // 
            this.grpContrato.Controls.Add(this.mtbCtrConvTermino);
            this.grpContrato.Controls.Add(this.mtbCtrConvInicio);
            this.grpContrato.Controls.Add(this.mtbCtrConvNr);
            this.grpContrato.Controls.Add(this.txtCtrCoord);
            this.grpContrato.Controls.Add(this.txtCtrCargo);
            this.grpContrato.Location = new System.Drawing.Point(5, 350);
            this.grpContrato.Name = "grpContrato";
            this.grpContrato.Size = new System.Drawing.Size(700, 80);
            this.grpContrato.TabIndex = 13;
            this.grpContrato.TabStop = false;
            this.grpContrato.Text = "CONTRATO SOCIAL * ";
            // 
            // mtbCtrConvTermino
            // 
            this.mtbCtrConvTermino.AccessibleName = "Término do Convênio";
            this.mtbCtrConvTermino.Campo = "Término do Convênio";
            this.mtbCtrConvTermino.Location = new System.Drawing.Point(176, 50);
            this.mtbCtrConvTermino.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mtbCtrConvTermino.Mask = "00/00/0000";
            this.mtbCtrConvTermino.MaxLength = 32767;
            this.mtbCtrConvTermino.Name = "mtbCtrConvTermino";
            this.mtbCtrConvTermino.Size = new System.Drawing.Size(183, 25);
            this.mtbCtrConvTermino.TabIndex = 29;
            this.mtbCtrConvTermino.ValidatingType = null;
            // 
            // mtbCtrConvInicio
            // 
            this.mtbCtrConvInicio.AccessibleName = "Inicio do Convênio";
            this.mtbCtrConvInicio.Campo = "Inicio do Convênio";
            this.mtbCtrConvInicio.Location = new System.Drawing.Point(5, 50);
            this.mtbCtrConvInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCtrConvInicio.Mask = "00/00/0000";
            this.mtbCtrConvInicio.MaxLength = 32767;
            this.mtbCtrConvInicio.Name = "mtbCtrConvInicio";
            this.mtbCtrConvInicio.Size = new System.Drawing.Size(165, 21);
            this.mtbCtrConvInicio.TabIndex = 28;
            this.mtbCtrConvInicio.ValidatingType = null;
            // 
            // mtbCtrConvNr
            // 
            this.mtbCtrConvNr.AccessibleName = "Convênio nº";
            this.mtbCtrConvNr.Campo = "Convênio nº";
            this.mtbCtrConvNr.Location = new System.Drawing.Point(495, 20);
            this.mtbCtrConvNr.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.mtbCtrConvNr.Mask = "";
            this.mtbCtrConvNr.MaxLength = 32767;
            this.mtbCtrConvNr.Name = "mtbCtrConvNr";
            this.mtbCtrConvNr.Size = new System.Drawing.Size(199, 20);
            this.mtbCtrConvNr.TabIndex = 27;
            this.mtbCtrConvNr.ValidatingType = null;
            // 
            // txtCtrCoord
            // 
            this.txtCtrCoord.AccessibleName = "Coornedador do Convênio";
            this.txtCtrCoord.Campo = "Coornedador do Convênio";
            this.txtCtrCoord.Location = new System.Drawing.Point(5, 20);
            this.txtCtrCoord.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtCtrCoord.MaxLength = 40;
            this.txtCtrCoord.Name = "txtCtrCoord";
            this.txtCtrCoord.Size = new System.Drawing.Size(484, 23);
            this.txtCtrCoord.TabIndex = 26;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AccessibleName = "Número de Identificação";
            this.txtPesquisa.Campo = "Número de Identificação";
            this.txtPesquisa.Location = new System.Drawing.Point(0, 1);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(227, 21);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.confirmar;
            this.btnSalvar.Location = new System.Drawing.Point(715, 350);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 80);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.txtEndComplemento);
            this.grpEndereco.Controls.Add(this.txtEndCidade);
            this.grpEndereco.Controls.Add(this.txtEndBairro);
            this.grpEndereco.Controls.Add(this.mtbEndCEP);
            this.grpEndereco.Controls.Add(this.cboEndUF);
            this.grpEndereco.Controls.Add(this.txtEndNr);
            this.grpEndereco.Controls.Add(this.txtEndLogradouro);
            this.grpEndereco.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEndereco.Location = new System.Drawing.Point(5, 265);
            this.grpEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEndereco.Size = new System.Drawing.Size(790, 80);
            this.grpEndereco.TabIndex = 32;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "ENDEREÇO";
            // 
            // txtEndComplemento
            // 
            this.txtEndComplemento.AccessibleName = "Complemento";
            this.txtEndComplemento.Campo = "Complemento";
            this.txtEndComplemento.Location = new System.Drawing.Point(558, 20);
            this.txtEndComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndComplemento.MaxLength = 100;
            this.txtEndComplemento.Name = "txtEndComplemento";
            this.txtEndComplemento.Size = new System.Drawing.Size(226, 21);
            this.txtEndComplemento.TabIndex = 3;
            // 
            // txtEndCidade
            // 
            this.txtEndCidade.AccessibleName = "Cidade*";
            this.txtEndCidade.Campo = "Cidade*";
            this.txtEndCidade.Location = new System.Drawing.Point(415, 50);
            this.txtEndCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndCidade.MaxLength = 100;
            this.txtEndCidade.Name = "txtEndCidade";
            this.txtEndCidade.Size = new System.Drawing.Size(255, 21);
            this.txtEndCidade.TabIndex = 6;
            // 
            // txtEndBairro
            // 
            this.txtEndBairro.AccessibleName = "Bairro*";
            this.txtEndBairro.Campo = "Bairro*";
            this.txtEndBairro.Location = new System.Drawing.Point(107, 50);
            this.txtEndBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndBairro.MaxLength = 100;
            this.txtEndBairro.Name = "txtEndBairro";
            this.txtEndBairro.Size = new System.Drawing.Size(302, 21);
            this.txtEndBairro.TabIndex = 5;
            // 
            // mtbEndCEP
            // 
            this.mtbEndCEP.AccessibleName = "CEP*";
            this.mtbEndCEP.Campo = "CEP*";
            this.mtbEndCEP.Location = new System.Drawing.Point(10, 50);
            this.mtbEndCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbEndCEP.Mask = "00000-000";
            this.mtbEndCEP.MaxLength = 32767;
            this.mtbEndCEP.Name = "mtbEndCEP";
            this.mtbEndCEP.Size = new System.Drawing.Size(91, 21);
            this.mtbEndCEP.TabIndex = 4;
            this.mtbEndCEP.ValidatingType = null;
            // 
            // cboEndUF
            // 
            this.cboEndUF.AccessibleName = "Estado*";
            this.cboEndUF.Campo = "Estado*";
            this.cboEndUF.FormattingEnabled = true;
            this.cboEndUF.Location = new System.Drawing.Point(676, 50);
            this.cboEndUF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEndUF.Name = "cboEndUF";
            this.cboEndUF.Size = new System.Drawing.Size(108, 25);
            this.cboEndUF.TabIndex = 7;
            // 
            // txtEndNr
            // 
            this.txtEndNr.AccessibleName = "Número*";
            this.txtEndNr.Campo = "Número*";
            this.txtEndNr.Location = new System.Drawing.Point(432, 20);
            this.txtEndNr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndNr.MaxLength = 100;
            this.txtEndNr.Name = "txtEndNr";
            this.txtEndNr.Size = new System.Drawing.Size(121, 21);
            this.txtEndNr.TabIndex = 2;
            // 
            // txtEndLogradouro
            // 
            this.txtEndLogradouro.AccessibleName = "Logradouro*";
            this.txtEndLogradouro.Campo = "Logradouro*";
            this.txtEndLogradouro.Location = new System.Drawing.Point(10, 20);
            this.txtEndLogradouro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndLogradouro.MaxLength = 100;
            this.txtEndLogradouro.Name = "txtEndLogradouro";
            this.txtEndLogradouro.Size = new System.Drawing.Size(416, 21);
            this.txtEndLogradouro.TabIndex = 1;
            // 
            // uctGerenTerceirizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.grpContrato);
            this.Controls.Add(this.grpDadosResponsavel);
            this.Controls.Add(this.grpContato);
            this.Controls.Add(this.grbDadosEmpresa);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctGerenTerceirizada";
            this.Size = new System.Drawing.Size(800, 440);
            this.grbDadosEmpresa.ResumeLayout(false);
            this.grpContato.ResumeLayout(false);
            this.grpDadosResponsavel.ResumeLayout(false);
            this.grpContrato.ResumeLayout(false);
            this.grpEndereco.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox grbDadosEmpresa;
        public System.Windows.Forms.GroupBox grpContato;
        public System.Windows.Forms.GroupBox grpDadosResponsavel;
        private System.Windows.Forms.GroupBox grpContrato;
        private UIX.txtUIX txtPesquisa;
        private UIX.txtUIX txtEmpRazaoSocial;
        private UIX.txtUIX txtEmpNomeFantasia;
        private UIX.mtbUIX mtbEmpCNPJ;
        private UIX.mtbUIX mtbEmpIE;
        private UIX.txtUIX txtEmpSite;
        public UIX.txtUIX txtResNome;
        private UIX.txtUIX txtCtrCargo;
        private UIX.mtbUIX mtbResCPF;
        private UIX.mtbUIX mtbResRG;
        public UIX.mtbUIX mtbResTelCom;
        public UIX.mtbUIX mtbResTelFixo;
        public UIX.txtUIX txtResEmail;
        public UIX.txtUIX txtCntEmail;
        public UIX.mtbUIX mtbCntTelCom;
        public UIX.mtbUIX mtbCntTelCom2;
        public UIX.mtbUIX mtbCntTelCel;
        private UIX.mtbUIX mtbCntRamal;
        public UIX.mtbUIX mtbCntFax;
        public UIX.txtUIX txtCtrCoord;
        private UIX.mtbUIX mtbCtrConvNr;
        private UIX.mtbUIX mtbCtrConvInicio;
        private UIX.mtbUIX mtbCtrConvTermino;
        private UIX.btnUIX btnSalvar;
        public System.Windows.Forms.GroupBox grpEndereco;
        public UIX.txtUIX txtEndComplemento;
        public UIX.txtUIX txtEndCidade;
        public UIX.txtUIX txtEndBairro;
        public UIX.mtbUIX mtbEndCEP;
        public UIX.cboUIX cboEndUF;
        public UIX.txtUIX txtEndNr;
        public UIX.txtUIX txtEndLogradouro;
    }
}
