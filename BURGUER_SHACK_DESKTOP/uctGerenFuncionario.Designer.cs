namespace BURGUER_SHACK_DESKTOP
{
    partial class uctGerenFuncionario
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
            this.txtPesquisa = new UIX.txtUIX();
            this.txtNome = new UIX.txtUIX();
            this.mtbDtNasc = new UIX.mtbUIX();
            this.mtbRG = new UIX.mtbUIX();
            this.mtbCPF = new UIX.mtbUIX();
            this.grbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.grpContatos = new System.Windows.Forms.GroupBox();
            this.txtIDNextel = new UIX.txtUIX();
            this.mtbTelCel2 = new UIX.mtbUIX();
            this.mtbTelCel = new UIX.mtbUIX();
            this.mtbTelRes = new UIX.mtbUIX();
            this.txtEmail = new UIX.txtUIX();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new UIX.txtUIX();
            this.txtCidade = new UIX.txtUIX();
            this.txtBairro = new UIX.txtUIX();
            this.cboUF = new UIX.cboUIX();
            this.mtbCEP = new UIX.mtbUIX();
            this.txtNumero = new UIX.txtUIX();
            this.txtEndereco = new UIX.txtUIX();
            this.grpBeneficios = new System.Windows.Forms.GroupBox();
            this.cboValeTransporte = new UIX.cboUIX();
            this.cboTiqueteRefeicao = new UIX.cboUIX();
            this.cboAuxCreche = new UIX.cboUIX();
            this.cboAssOdontologica = new UIX.cboUIX();
            this.cboAssMedica = new UIX.cboUIX();
            this.grpFuncionario = new System.Windows.Forms.GroupBox();
            this.txtSalario = new UIX.txtUIX();
            this.cboCargaHoraria = new UIX.cboUIX();
            this.txtCargo = new UIX.txtUIX();
            this.btnSalvar = new UIX.btnUIX();
            this.grbDadosPessoais.SuspendLayout();
            this.grpContatos.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.grpBeneficios.SuspendLayout();
            this.grpFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Campo = "Número de Identificação:";
            this.txtPesquisa.Location = new System.Drawing.Point(0, 1);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.MaxLength = 5;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(228, 21);
            this.txtPesquisa.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Campo = "Nome:";
            this.txtNome.Location = new System.Drawing.Point(12, 23);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(371, 21);
            this.txtNome.TabIndex = 2;
            // 
            // mtbDtNasc
            // 
            this.mtbDtNasc.Campo = "Data de Nascimento:";
            this.mtbDtNasc.Location = new System.Drawing.Point(388, 23);
            this.mtbDtNasc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbDtNasc.Mask = "00/00/0000";
            this.mtbDtNasc.MaxLength = 32767;
            this.mtbDtNasc.Name = "mtbDtNasc";
            this.mtbDtNasc.Size = new System.Drawing.Size(206, 21);
            this.mtbDtNasc.TabIndex = 3;
            this.mtbDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // mtbRG
            // 
            this.mtbRG.Campo = "Registro Geral (RG):";
            this.mtbRG.Location = new System.Drawing.Point(600, 23);
            this.mtbRG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbRG.Mask = "00,000,000-0";
            this.mtbRG.MaxLength = 32767;
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(204, 21);
            this.mtbRG.TabIndex = 4;
            this.mtbRG.ValidatingType = null;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Campo = "CPF:";
            this.mtbCPF.Location = new System.Drawing.Point(11, 50);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.MaxLength = 32767;
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(133, 21);
            this.mtbCPF.TabIndex = 5;
            this.mtbCPF.ValidatingType = null;
            // 
            // grbDadosPessoais
            // 
            this.grbDadosPessoais.Controls.Add(this.mtbCPF);
            this.grbDadosPessoais.Controls.Add(this.txtNome);
            this.grbDadosPessoais.Controls.Add(this.mtbRG);
            this.grbDadosPessoais.Controls.Add(this.mtbDtNasc);
            this.grbDadosPessoais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPessoais.Location = new System.Drawing.Point(3, 20);
            this.grbDadosPessoais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Name = "grbDadosPessoais";
            this.grbDadosPessoais.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Size = new System.Drawing.Size(810, 81);
            this.grbDadosPessoais.TabIndex = 1;
            this.grbDadosPessoais.TabStop = false;
            this.grbDadosPessoais.Text = "DADOS PESSOAIS *";
            // 
            // grpContatos
            // 
            this.grpContatos.Controls.Add(this.txtIDNextel);
            this.grpContatos.Controls.Add(this.mtbTelCel2);
            this.grpContatos.Controls.Add(this.mtbTelCel);
            this.grpContatos.Controls.Add(this.mtbTelRes);
            this.grpContatos.Controls.Add(this.txtEmail);
            this.grpContatos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContatos.Location = new System.Drawing.Point(3, 109);
            this.grpContatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpContatos.Name = "grpContatos";
            this.grpContatos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpContatos.Size = new System.Drawing.Size(810, 87);
            this.grpContatos.TabIndex = 2;
            this.grpContatos.TabStop = false;
            this.grpContatos.Text = "MEIOS DE CONTATO";
            // 
            // txtIDNextel
            // 
            this.txtIDNextel.Campo = "ID Nextel:";
            this.txtIDNextel.Location = new System.Drawing.Point(218, 55);
            this.txtIDNextel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDNextel.MaxLength = 9;
            this.txtIDNextel.Name = "txtIDNextel";
            this.txtIDNextel.Size = new System.Drawing.Size(130, 21);
            this.txtIDNextel.TabIndex = 10;
            // 
            // mtbTelCel2
            // 
            this.mtbTelCel2.Campo = "Telefone Celular:";
            this.mtbTelCel2.Location = new System.Drawing.Point(10, 55);
            this.mtbTelCel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbTelCel2.Mask = "(00) 00000-0000";
            this.mtbTelCel2.MaxLength = 32767;
            this.mtbTelCel2.Name = "mtbTelCel2";
            this.mtbTelCel2.Size = new System.Drawing.Size(202, 21);
            this.mtbTelCel2.TabIndex = 9;
            this.mtbTelCel2.ValidatingType = null;
            // 
            // mtbTelCel
            // 
            this.mtbTelCel.Campo = "Telefone Celular:";
            this.mtbTelCel.Location = new System.Drawing.Point(616, 23);
            this.mtbTelCel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbTelCel.Mask = "(00) 00000-0000";
            this.mtbTelCel.MaxLength = 32767;
            this.mtbTelCel.Name = "mtbTelCel";
            this.mtbTelCel.Size = new System.Drawing.Size(188, 21);
            this.mtbTelCel.TabIndex = 8;
            this.mtbTelCel.ValidatingType = null;
            // 
            // mtbTelRes
            // 
            this.mtbTelRes.Campo = "Telefone Residencial:";
            this.mtbTelRes.Location = new System.Drawing.Point(388, 23);
            this.mtbTelRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbTelRes.Mask = "(00) 0000-0000";
            this.mtbTelRes.MaxLength = 32767;
            this.mtbTelRes.Name = "mtbTelRes";
            this.mtbTelRes.Size = new System.Drawing.Size(219, 21);
            this.mtbTelRes.TabIndex = 7;
            this.mtbTelRes.ValidatingType = null;
            // 
            // txtEmail
            // 
            this.txtEmail.Campo = "E-mail:";
            this.txtEmail.Location = new System.Drawing.Point(10, 23);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(369, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.txtComplemento);
            this.grpEndereco.Controls.Add(this.txtCidade);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.cboUF);
            this.grpEndereco.Controls.Add(this.mtbCEP);
            this.grpEndereco.Controls.Add(this.txtNumero);
            this.grpEndereco.Controls.Add(this.txtEndereco);
            this.grpEndereco.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEndereco.Location = new System.Drawing.Point(3, 204);
            this.grpEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEndereco.Size = new System.Drawing.Size(810, 84);
            this.grpEndereco.TabIndex = 3;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "ENDEREÇO *";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Campo = "Complemento:";
            this.txtComplemento.Location = new System.Drawing.Point(477, 52);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(270, 21);
            this.txtComplemento.TabIndex = 17;
            // 
            // txtCidade
            // 
            this.txtCidade.Campo = "Cidade:";
            this.txtCidade.Location = new System.Drawing.Point(10, 52);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(234, 21);
            this.txtCidade.TabIndex = 15;
            // 
            // txtBairro
            // 
            this.txtBairro.Campo = "Bairro:";
            this.txtBairro.Location = new System.Drawing.Point(250, 52);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(221, 21);
            this.txtBairro.TabIndex = 16;
            // 
            // cboUF
            // 
            this.cboUF.Campo = "Estado:";
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(616, 23);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(108, 24);
            this.cboUF.TabIndex = 14;
            // 
            // mtbCEP
            // 
            this.mtbCEP.Campo = "CEP:";
            this.mtbCEP.Location = new System.Drawing.Point(504, 23);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.MaxLength = 32767;
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(103, 21);
            this.mtbCEP.TabIndex = 13;
            this.mtbCEP.ValidatingType = null;
            // 
            // txtNumero
            // 
            this.txtNumero.Campo = "Número:";
            this.txtNumero.Location = new System.Drawing.Point(386, 23);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumero.MaxLength = 100;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(112, 21);
            this.txtNumero.TabIndex = 12;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Campo = "Endereço:";
            this.txtEndereco.Location = new System.Drawing.Point(10, 23);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(370, 21);
            this.txtEndereco.TabIndex = 11;
            // 
            // grpBeneficios
            // 
            this.grpBeneficios.Controls.Add(this.cboValeTransporte);
            this.grpBeneficios.Controls.Add(this.cboTiqueteRefeicao);
            this.grpBeneficios.Controls.Add(this.cboAuxCreche);
            this.grpBeneficios.Controls.Add(this.cboAssOdontologica);
            this.grpBeneficios.Controls.Add(this.cboAssMedica);
            this.grpBeneficios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBeneficios.Location = new System.Drawing.Point(3, 362);
            this.grpBeneficios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBeneficios.Name = "grpBeneficios";
            this.grpBeneficios.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBeneficios.Size = new System.Drawing.Size(726, 88);
            this.grpBeneficios.TabIndex = 5;
            this.grpBeneficios.TabStop = false;
            this.grpBeneficios.Text = "BENEFÍCIOS";
            // 
            // cboValeTransporte
            // 
            this.cboValeTransporte.Campo = "Vale-transporte:";
            this.cboValeTransporte.FormattingEnabled = true;
            this.cboValeTransporte.Location = new System.Drawing.Point(12, 50);
            this.cboValeTransporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboValeTransporte.Name = "cboValeTransporte";
            this.cboValeTransporte.Size = new System.Drawing.Size(150, 25);
            this.cboValeTransporte.TabIndex = 25;
            // 
            // cboTiqueteRefeicao
            // 
            this.cboTiqueteRefeicao.Campo = "Tíquete-refeição:";
            this.cboTiqueteRefeicao.FormattingEnabled = true;
            this.cboTiqueteRefeicao.Location = new System.Drawing.Point(250, 53);
            this.cboTiqueteRefeicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTiqueteRefeicao.Name = "cboTiqueteRefeicao";
            this.cboTiqueteRefeicao.Size = new System.Drawing.Size(164, 25);
            this.cboTiqueteRefeicao.TabIndex = 24;
            // 
            // cboAuxCreche
            // 
            this.cboAuxCreche.Campo = "Auxílio Creche:";
            this.cboAuxCreche.FormattingEnabled = true;
            this.cboAuxCreche.Location = new System.Drawing.Point(405, 21);
            this.cboAuxCreche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAuxCreche.Name = "cboAuxCreche";
            this.cboAuxCreche.Size = new System.Drawing.Size(150, 25);
            this.cboAuxCreche.TabIndex = 23;
            // 
            // cboAssOdontologica
            // 
            this.cboAssOdontologica.Campo = "Assistência Odontológica:";
            this.cboAssOdontologica.FormattingEnabled = true;
            this.cboAssOdontologica.Location = new System.Drawing.Point(189, 21);
            this.cboAssOdontologica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAssOdontologica.Name = "cboAssOdontologica";
            this.cboAssOdontologica.Size = new System.Drawing.Size(210, 25);
            this.cboAssOdontologica.TabIndex = 22;
            // 
            // cboAssMedica
            // 
            this.cboAssMedica.Campo = "Assistência Médica:";
            this.cboAssMedica.FormattingEnabled = true;
            this.cboAssMedica.Location = new System.Drawing.Point(12, 21);
            this.cboAssMedica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAssMedica.Name = "cboAssMedica";
            this.cboAssMedica.Size = new System.Drawing.Size(171, 25);
            this.cboAssMedica.TabIndex = 21;
            // 
            // grpFuncionario
            // 
            this.grpFuncionario.Controls.Add(this.txtSalario);
            this.grpFuncionario.Controls.Add(this.cboCargaHoraria);
            this.grpFuncionario.Controls.Add(this.txtCargo);
            this.grpFuncionario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFuncionario.Location = new System.Drawing.Point(3, 296);
            this.grpFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFuncionario.Name = "grpFuncionario";
            this.grpFuncionario.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFuncionario.Size = new System.Drawing.Size(810, 58);
            this.grpFuncionario.TabIndex = 4;
            this.grpFuncionario.TabStop = false;
            this.grpFuncionario.Text = "FUNCIONÁRIO *";
            // 
            // txtSalario
            // 
            this.txtSalario.Campo = "Salário:";
            this.txtSalario.Location = new System.Drawing.Point(373, 23);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalario.MaxLength = 100;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(134, 21);
            this.txtSalario.TabIndex = 20;
            // 
            // cboCargaHoraria
            // 
            this.cboCargaHoraria.Campo = "Carga Horária:";
            this.cboCargaHoraria.FormattingEnabled = true;
            this.cboCargaHoraria.Location = new System.Drawing.Point(218, 23);
            this.cboCargaHoraria.Name = "cboCargaHoraria";
            this.cboCargaHoraria.Size = new System.Drawing.Size(149, 24);
            this.cboCargaHoraria.TabIndex = 19;
            // 
            // txtCargo
            // 
            this.txtCargo.Campo = "Cargo:";
            this.txtCargo.Location = new System.Drawing.Point(10, 23);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargo.MaxLength = 40;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(202, 21);
            this.txtCargo.TabIndex = 18;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.confirmar;
            this.btnSalvar.Location = new System.Drawing.Point(729, 369);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 80);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // uctGerenFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpFuncionario);
            this.Controls.Add(this.grpBeneficios);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.grpContatos);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.grbDadosPessoais);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctGerenFuncionario";
            this.Size = new System.Drawing.Size(818, 488);
            this.grbDadosPessoais.ResumeLayout(false);
            this.grpContatos.ResumeLayout(false);
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.grpBeneficios.ResumeLayout(false);
            this.grpFuncionario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public UIX.txtUIX txtPesquisa;
        public UIX.txtUIX txtNome;
        public UIX.mtbUIX mtbDtNasc;
        public UIX.mtbUIX mtbRG;
        public UIX.mtbUIX mtbCPF;
        public System.Windows.Forms.GroupBox grbDadosPessoais;
        public System.Windows.Forms.GroupBox grpContatos;
        public UIX.txtUIX txtEmail;
        public UIX.mtbUIX mtbTelRes;
        public UIX.mtbUIX mtbTelCel;
        public UIX.mtbUIX mtbTelCel2;
        public UIX.txtUIX txtIDNextel;
        public System.Windows.Forms.GroupBox grpEndereco;
        public UIX.txtUIX txtEndereco;
        public UIX.txtUIX txtNumero;
        public UIX.mtbUIX mtbCEP;
        public UIX.cboUIX cboUF;
        public UIX.txtUIX txtBairro;
        public UIX.txtUIX txtCidade;
        public UIX.txtUIX txtComplemento;
        public System.Windows.Forms.GroupBox grpBeneficios;
        public UIX.cboUIX cboAssMedica;
        public UIX.cboUIX cboAssOdontologica;
        public UIX.cboUIX cboAuxCreche;
        public UIX.cboUIX cboTiqueteRefeicao;
        public UIX.cboUIX cboValeTransporte;
        public System.Windows.Forms.GroupBox grpFuncionario;
        public UIX.txtUIX txtCargo;
        public UIX.cboUIX cboCargaHoraria;
        public UIX.txtUIX txtSalario;
        private UIX.btnUIX btnSalvar;
    }
}
