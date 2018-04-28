namespace BURGUER_SHACK_DESKTOP
{
    partial class uctFuncionario
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtPesquisa = new UIX.txtUIX();
            this.txtNome = new UIX.txtUIX();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.grpContatos = new System.Windows.Forms.GroupBox();
            this.txtIDNextel = new UIX.txtUIX();
            this.mtbTelCel2 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbTelCel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbTelRes = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new UIX.txtUIX();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new UIX.txtUIX();
            this.txtCidade = new UIX.txtUIX();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBairro = new UIX.txtUIX();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumero = new UIX.txtUIX();
            this.txtEndereco = new UIX.txtUIX();
            this.label14 = new System.Windows.Forms.Label();
            this.grpBeneficios = new System.Windows.Forms.GroupBox();
            this.cboValeTransporte = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboTiqueteRefeicao = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboAuxCreche = new System.Windows.Forms.ComboBox();
            this.cboAssOdontologica = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboAssMedica = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.grpFuncionario = new System.Windows.Forms.GroupBox();
            this.txtSalario = new UIX.txtUIX();
            this.cboCargaHoraria = new System.Windows.Forms.ComboBox();
            this.txtCargo = new UIX.txtUIX();
            this.label24 = new System.Windows.Forms.Label();
            this.grbDadosPessoais.SuspendLayout();
            this.grpContatos.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.grpBeneficios.SuspendLayout();
            this.grpFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(147, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Número de Identificação:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Campo = "Campo:";
            this.txtPesquisa.Location = new System.Drawing.Point(154, 1);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.MaxLength = 5;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(41, 21);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Nascimento:";
            // 
            // mtbDtNasc
            // 
            this.mtbDtNasc.Location = new System.Drawing.Point(519, 23);
            this.mtbDtNasc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbDtNasc.Mask = "00/00/0000";
            this.mtbDtNasc.Name = "mtbDtNasc";
            this.mtbDtNasc.Size = new System.Drawing.Size(76, 21);
            this.mtbDtNasc.TabIndex = 3;
            this.mtbDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(720, 23);
            this.mtbRG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbRG.Mask = "00,000,000-0";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(84, 21);
            this.mtbRG.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registro Geral (RG):";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(47, 51);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(97, 21);
            this.mtbCPF.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF:";
            // 
            // grbDadosPessoais
            // 
            this.grbDadosPessoais.Controls.Add(this.mtbCPF);
            this.grbDadosPessoais.Controls.Add(this.txtNome);
            this.grbDadosPessoais.Controls.Add(this.label4);
            this.grbDadosPessoais.Controls.Add(this.mtbRG);
            this.grbDadosPessoais.Controls.Add(this.label2);
            this.grbDadosPessoais.Controls.Add(this.label3);
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
            this.grpContatos.Controls.Add(this.label8);
            this.grpContatos.Controls.Add(this.mtbTelCel);
            this.grpContatos.Controls.Add(this.label7);
            this.grpContatos.Controls.Add(this.mtbTelRes);
            this.grpContatos.Controls.Add(this.label5);
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
            this.mtbTelCel2.Location = new System.Drawing.Point(111, 55);
            this.mtbTelCel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbTelCel2.Mask = "(00) 00000-0000";
            this.mtbTelCel2.Name = "mtbTelCel2";
            this.mtbTelCel2.Size = new System.Drawing.Size(101, 21);
            this.mtbTelCel2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Telefone Celular:";
            // 
            // mtbTelCel
            // 
            this.mtbTelCel.Location = new System.Drawing.Point(716, 23);
            this.mtbTelCel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbTelCel.Mask = "(00) 00000-0000";
            this.mtbTelCel.Name = "mtbTelCel";
            this.mtbTelCel.Size = new System.Drawing.Size(88, 21);
            this.mtbTelCel.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone Celular:";
            // 
            // mtbTelRes
            // 
            this.mtbTelRes.Location = new System.Drawing.Point(512, 23);
            this.mtbTelRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbTelRes.Mask = "(00) 0000-0000";
            this.mtbTelRes.Name = "mtbTelRes";
            this.mtbTelRes.Size = new System.Drawing.Size(95, 21);
            this.mtbTelRes.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone Residencial:";
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
            this.grpEndereco.Controls.Add(this.label15);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.cboUF);
            this.grpEndereco.Controls.Add(this.label12);
            this.grpEndereco.Controls.Add(this.mtbCEP);
            this.grpEndereco.Controls.Add(this.label11);
            this.grpEndereco.Controls.Add(this.txtNumero);
            this.grpEndereco.Controls.Add(this.txtEndereco);
            this.grpEndereco.Controls.Add(this.label14);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 22;
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
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(667, 23);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(57, 24);
            this.cboUF.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(613, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Estado:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(543, 23);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(64, 21);
            this.mtbCEP.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "CEP:";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 2;
            // 
            // grpBeneficios
            // 
            this.grpBeneficios.Controls.Add(this.cboValeTransporte);
            this.grpBeneficios.Controls.Add(this.label20);
            this.grpBeneficios.Controls.Add(this.cboTiqueteRefeicao);
            this.grpBeneficios.Controls.Add(this.label19);
            this.grpBeneficios.Controls.Add(this.cboAuxCreche);
            this.grpBeneficios.Controls.Add(this.cboAssOdontologica);
            this.grpBeneficios.Controls.Add(this.label18);
            this.grpBeneficios.Controls.Add(this.label17);
            this.grpBeneficios.Controls.Add(this.cboAssMedica);
            this.grpBeneficios.Controls.Add(this.label23);
            this.grpBeneficios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBeneficios.Location = new System.Drawing.Point(3, 362);
            this.grpBeneficios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBeneficios.Name = "grpBeneficios";
            this.grpBeneficios.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBeneficios.Size = new System.Drawing.Size(810, 84);
            this.grpBeneficios.TabIndex = 5;
            this.grpBeneficios.TabStop = false;
            this.grpBeneficios.Text = "BENEFÍCIOS";
            // 
            // cboValeTransporte
            // 
            this.cboValeTransporte.FormattingEnabled = true;
            this.cboValeTransporte.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboValeTransporte.Location = new System.Drawing.Point(106, 51);
            this.cboValeTransporte.Name = "cboValeTransporte";
            this.cboValeTransporte.Size = new System.Drawing.Size(57, 24);
            this.cboValeTransporte.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "Vale-transporte";
            // 
            // cboTiqueteRefeicao
            // 
            this.cboTiqueteRefeicao.FormattingEnabled = true;
            this.cboTiqueteRefeicao.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboTiqueteRefeicao.Location = new System.Drawing.Point(669, 21);
            this.cboTiqueteRefeicao.Name = "cboTiqueteRefeicao";
            this.cboTiqueteRefeicao.Size = new System.Drawing.Size(57, 24);
            this.cboTiqueteRefeicao.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(564, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "Tíquete-refeição:";
            // 
            // cboAuxCreche
            // 
            this.cboAuxCreche.FormattingEnabled = true;
            this.cboAuxCreche.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboAuxCreche.Location = new System.Drawing.Point(498, 21);
            this.cboAuxCreche.Name = "cboAuxCreche";
            this.cboAuxCreche.Size = new System.Drawing.Size(57, 24);
            this.cboAuxCreche.TabIndex = 23;
            // 
            // cboAssOdontologica
            // 
            this.cboAssOdontologica.FormattingEnabled = true;
            this.cboAssOdontologica.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboAssOdontologica.Location = new System.Drawing.Point(342, 21);
            this.cboAssOdontologica.Name = "cboAssOdontologica";
            this.cboAssOdontologica.Size = new System.Drawing.Size(57, 24);
            this.cboAssOdontologica.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(405, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 16);
            this.label18.TabIndex = 29;
            this.label18.Text = "Auxílio Creche:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(190, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "Assistência Odontológica:";
            // 
            // cboAssMedica
            // 
            this.cboAssMedica.FormattingEnabled = true;
            this.cboAssMedica.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboAssMedica.Location = new System.Drawing.Point(127, 21);
            this.cboAssMedica.Name = "cboAssMedica";
            this.cboAssMedica.Size = new System.Drawing.Size(57, 24);
            this.cboAssMedica.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "Assistência Médica:";
            // 
            // grpFuncionario
            // 
            this.grpFuncionario.Controls.Add(this.txtSalario);
            this.grpFuncionario.Controls.Add(this.cboCargaHoraria);
            this.grpFuncionario.Controls.Add(this.txtCargo);
            this.grpFuncionario.Controls.Add(this.label24);
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
            this.cboCargaHoraria.FormattingEnabled = true;
            this.cboCargaHoraria.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboCargaHoraria.Location = new System.Drawing.Point(310, 23);
            this.cboCargaHoraria.Name = "cboCargaHoraria";
            this.cboCargaHoraria.Size = new System.Drawing.Size(57, 24);
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
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(218, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 16);
            this.label24.TabIndex = 4;
            this.label24.Text = "Carga Horária:";
            // 
            // uctFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpFuncionario);
            this.Controls.Add(this.grpBeneficios);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.grpContatos);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.grbDadosPessoais);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctFuncionario";
            this.Size = new System.Drawing.Size(818, 488);
            this.grbDadosPessoais.ResumeLayout(false);
            this.grbDadosPessoais.PerformLayout();
            this.grpContatos.ResumeLayout(false);
            this.grpContatos.PerformLayout();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.grpBeneficios.ResumeLayout(false);
            this.grpBeneficios.PerformLayout();
            this.grpFuncionario.ResumeLayout(false);
            this.grpFuncionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblId;
        public UIX.txtUIX txtPesquisa;
        public UIX.txtUIX txtNome;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox mtbDtNasc;
        public System.Windows.Forms.MaskedTextBox mtbRG;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox mtbCPF;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox grbDadosPessoais;
        public System.Windows.Forms.GroupBox grpContatos;
        public UIX.txtUIX txtEmail;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox mtbTelRes;
        public System.Windows.Forms.MaskedTextBox mtbTelCel;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox mtbTelCel2;
        public System.Windows.Forms.Label label8;
        public UIX.txtUIX txtIDNextel;
        public System.Windows.Forms.GroupBox grpEndereco;
        public UIX.txtUIX txtEndereco;
        public System.Windows.Forms.Label label14;
        public UIX.txtUIX txtNumero;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox mtbCEP;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cboUF;
        public UIX.txtUIX txtBairro;
        public UIX.txtUIX txtCidade;
        public System.Windows.Forms.Label label15;
        public UIX.txtUIX txtComplemento;
        public System.Windows.Forms.GroupBox grpBeneficios;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.ComboBox cboAssMedica;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox cboAssOdontologica;
        public System.Windows.Forms.ComboBox cboAuxCreche;
        public System.Windows.Forms.ComboBox cboTiqueteRefeicao;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.ComboBox cboValeTransporte;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.GroupBox grpFuncionario;
        public UIX.txtUIX txtCargo;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.ComboBox cboCargaHoraria;
        public UIX.txtUIX txtSalario;
    }
}
