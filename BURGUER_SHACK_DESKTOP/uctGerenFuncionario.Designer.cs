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
            this.txtDadosNome = new UIX.txtUIX();
            this.mtbDadosDtNasc = new UIX.mtbUIX();
            this.mtbDadosRG = new UIX.mtbUIX();
            this.mtbDadosCPF = new UIX.mtbUIX();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.grpContatos = new System.Windows.Forms.GroupBox();
            this.txtContatoNextel = new UIX.txtUIX();
            this.mtbContatoTelCel2 = new UIX.mtbUIX();
            this.mtbContatoTelCel = new UIX.mtbUIX();
            this.mtbContatoTelRes = new UIX.mtbUIX();
            this.txtContatoEmail = new UIX.txtUIX();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtEndComplemento = new UIX.txtUIX();
            this.txtEndCidade = new UIX.txtUIX();
            this.txtEndBairro = new UIX.txtUIX();
            this.mtbEndCEP = new UIX.mtbUIX();
            this.cboEndUF = new UIX.cboUIX();
            this.txtEndNr = new UIX.txtUIX();
            this.txtEndLogradouro = new UIX.txtUIX();
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
            this.grbDados.SuspendLayout();
            this.grpContatos.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.grpBeneficios.SuspendLayout();
            this.grpFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AccessibleName = "Número de Identificação";
            this.txtPesquisa.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtPesquisa.Campo = "Número de Identificação";
            this.txtPesquisa.Location = new System.Drawing.Point(0, 1);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.MaxLength = 5;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(227, 21);
            this.txtPesquisa.TabIndex = 1;
            // 
            // txtDadosNome
            // 
            this.txtDadosNome.AccessibleName = "Nome";
            this.txtDadosNome.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtDadosNome.Campo = "Nome";
            this.txtDadosNome.Location = new System.Drawing.Point(10, 20);
            this.txtDadosNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDadosNome.MaxLength = 40;
            this.txtDadosNome.Name = "txtDadosNome";
            this.txtDadosNome.Size = new System.Drawing.Size(487, 21);
            this.txtDadosNome.TabIndex = 1;
            // 
            // mtbDadosDtNasc
            // 
            this.mtbDadosDtNasc.AccessibleName = "Data de Nascimento";
            this.mtbDadosDtNasc.Campo = "Data de Nascimento";
            this.mtbDadosDtNasc.Location = new System.Drawing.Point(10, 50);
            this.mtbDadosDtNasc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbDadosDtNasc.Mask = "";
            this.mtbDadosDtNasc.MaxLength = 32767;
            this.mtbDadosDtNasc.Name = "mtbDadosDtNasc";
            this.mtbDadosDtNasc.Size = new System.Drawing.Size(185, 21);
            this.mtbDadosDtNasc.TabIndex = 2;
            this.mtbDadosDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDadosRG
            // 
            this.mtbDadosRG.AccessibleName = "Registro Geral (RG)";
            this.mtbDadosRG.Campo = "Registro Geral (RG)";
            this.mtbDadosRG.Location = new System.Drawing.Point(201, 50);
            this.mtbDadosRG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbDadosRG.Mask = "";
            this.mtbDadosRG.MaxLength = 32767;
            this.mtbDadosRG.Name = "mtbDadosRG";
            this.mtbDadosRG.Size = new System.Drawing.Size(178, 21);
            this.mtbDadosRG.TabIndex = 3;
            this.mtbDadosRG.ValidatingType = null;
            // 
            // mtbDadosCPF
            // 
            this.mtbDadosCPF.AccessibleName = "CPF";
            this.mtbDadosCPF.Campo = "CPF";
            this.mtbDadosCPF.Location = new System.Drawing.Point(386, 50);
            this.mtbDadosCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbDadosCPF.Mask = "";
            this.mtbDadosCPF.MaxLength = 32767;
            this.mtbDadosCPF.Name = "mtbDadosCPF";
            this.mtbDadosCPF.Size = new System.Drawing.Size(111, 21);
            this.mtbDadosCPF.TabIndex = 5;
            this.mtbDadosCPF.ValidatingType = null;
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.mtbDadosCPF);
            this.grbDados.Controls.Add(this.txtDadosNome);
            this.grbDados.Controls.Add(this.mtbDadosRG);
            this.grbDados.Controls.Add(this.mtbDadosDtNasc);
            this.grbDados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(5, 20);
            this.grbDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDados.Name = "grbDados";
            this.grbDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDados.Size = new System.Drawing.Size(790, 80);
            this.grbDados.TabIndex = 1;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "DADOS PESSOAIS *";
            // 
            // grpContatos
            // 
            this.grpContatos.Controls.Add(this.txtContatoNextel);
            this.grpContatos.Controls.Add(this.mtbContatoTelCel2);
            this.grpContatos.Controls.Add(this.mtbContatoTelCel);
            this.grpContatos.Controls.Add(this.mtbContatoTelRes);
            this.grpContatos.Controls.Add(this.txtContatoEmail);
            this.grpContatos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContatos.Location = new System.Drawing.Point(5, 110);
            this.grpContatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpContatos.Name = "grpContatos";
            this.grpContatos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpContatos.Size = new System.Drawing.Size(790, 80);
            this.grpContatos.TabIndex = 2;
            this.grpContatos.TabStop = false;
            this.grpContatos.Text = "MEIOS DE CONTATO";
            // 
            // txtContatoNextel
            // 
            this.txtContatoNextel.AccessibleName = "ID Nextel";
            this.txtContatoNextel.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtContatoNextel.Campo = "ID Nextel";
            this.txtContatoNextel.Location = new System.Drawing.Point(405, 50);
            this.txtContatoNextel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContatoNextel.MaxLength = 9;
            this.txtContatoNextel.Name = "txtContatoNextel";
            this.txtContatoNextel.Size = new System.Drawing.Size(129, 21);
            this.txtContatoNextel.TabIndex = 10;
            // 
            // mtbContatoTelCel2
            // 
            this.mtbContatoTelCel2.AccessibleName = "Telefone Celular 2";
            this.mtbContatoTelCel2.Campo = "Telefone Celular 2";
            this.mtbContatoTelCel2.Location = new System.Drawing.Point(212, 50);
            this.mtbContatoTelCel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbContatoTelCel2.Mask = "";
            this.mtbContatoTelCel2.MaxLength = 32767;
            this.mtbContatoTelCel2.Name = "mtbContatoTelCel2";
            this.mtbContatoTelCel2.Size = new System.Drawing.Size(187, 21);
            this.mtbContatoTelCel2.TabIndex = 9;
            this.mtbContatoTelCel2.ValidatingType = null;
            // 
            // mtbContatoTelCel
            // 
            this.mtbContatoTelCel.AccessibleName = "Telefone Celular*";
            this.mtbContatoTelCel.Campo = "Telefone Celular*";
            this.mtbContatoTelCel.Location = new System.Drawing.Point(10, 50);
            this.mtbContatoTelCel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbContatoTelCel.Mask = "";
            this.mtbContatoTelCel.MaxLength = 32767;
            this.mtbContatoTelCel.Name = "mtbContatoTelCel";
            this.mtbContatoTelCel.Size = new System.Drawing.Size(185, 21);
            this.mtbContatoTelCel.TabIndex = 8;
            this.mtbContatoTelCel.ValidatingType = null;
            // 
            // mtbContatoTelRes
            // 
            this.mtbContatoTelRes.AccessibleName = "Telefone Residencial*";
            this.mtbContatoTelRes.Campo = "Telefone Residencial*";
            this.mtbContatoTelRes.Location = new System.Drawing.Point(386, 20);
            this.mtbContatoTelRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbContatoTelRes.Mask = "";
            this.mtbContatoTelRes.MaxLength = 32767;
            this.mtbContatoTelRes.Name = "mtbContatoTelRes";
            this.mtbContatoTelRes.Size = new System.Drawing.Size(205, 21);
            this.mtbContatoTelRes.TabIndex = 7;
            this.mtbContatoTelRes.ValidatingType = null;
            // 
            // txtContatoEmail
            // 
            this.txtContatoEmail.AccessibleName = "E-mail*";
            this.txtContatoEmail.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtContatoEmail.Campo = "E-mail*";
            this.txtContatoEmail.Location = new System.Drawing.Point(10, 20);
            this.txtContatoEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContatoEmail.MaxLength = 40;
            this.txtContatoEmail.Name = "txtContatoEmail";
            this.txtContatoEmail.Size = new System.Drawing.Size(369, 21);
            this.txtContatoEmail.TabIndex = 6;
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
            this.grpEndereco.Location = new System.Drawing.Point(5, 200);
            this.grpEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEndereco.Size = new System.Drawing.Size(790, 80);
            this.grpEndereco.TabIndex = 3;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "ENDEREÇO";
            // 
            // txtEndComplemento
            // 
            this.txtEndComplemento.AccessibleName = "Complemento";
            this.txtEndComplemento.AllowedChars = UIX.uixAllowedChars.ALL;
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
            this.txtEndCidade.AllowedChars = UIX.uixAllowedChars.ALL;
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
            this.txtEndBairro.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtEndBairro.Campo = "Bairro*";
            this.txtEndBairro.Location = new System.Drawing.Point(111, 50);
            this.txtEndBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndBairro.MaxLength = 100;
            this.txtEndBairro.Name = "txtEndBairro";
            this.txtEndBairro.Size = new System.Drawing.Size(298, 21);
            this.txtEndBairro.TabIndex = 5;
            // 
            // mtbEndCEP
            // 
            this.mtbEndCEP.AccessibleName = "CEP*";
            this.mtbEndCEP.Campo = "CEP*";
            this.mtbEndCEP.Location = new System.Drawing.Point(10, 50);
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
            this.txtEndNr.AllowedChars = UIX.uixAllowedChars.ALL;
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
            this.txtEndLogradouro.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtEndLogradouro.Campo = "Logradouro*";
            this.txtEndLogradouro.Location = new System.Drawing.Point(10, 20);
            this.txtEndLogradouro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndLogradouro.MaxLength = 100;
            this.txtEndLogradouro.Name = "txtEndLogradouro";
            this.txtEndLogradouro.Size = new System.Drawing.Size(416, 21);
            this.txtEndLogradouro.TabIndex = 1;
            // 
            // grpBeneficios
            // 
            this.grpBeneficios.Controls.Add(this.cboValeTransporte);
            this.grpBeneficios.Controls.Add(this.cboTiqueteRefeicao);
            this.grpBeneficios.Controls.Add(this.cboAuxCreche);
            this.grpBeneficios.Controls.Add(this.cboAssOdontologica);
            this.grpBeneficios.Controls.Add(this.cboAssMedica);
            this.grpBeneficios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBeneficios.Location = new System.Drawing.Point(5, 350);
            this.grpBeneficios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBeneficios.Name = "grpBeneficios";
            this.grpBeneficios.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBeneficios.Size = new System.Drawing.Size(700, 80);
            this.grpBeneficios.TabIndex = 5;
            this.grpBeneficios.TabStop = false;
            this.grpBeneficios.Text = "BENEFÍCIOS";
            // 
            // cboValeTransporte
            // 
            this.cboValeTransporte.AccessibleName = "Vale-transporte";
            this.cboValeTransporte.Campo = "Vale-transporte";
            this.cboValeTransporte.FormattingEnabled = true;
            this.cboValeTransporte.Location = new System.Drawing.Point(12, 50);
            this.cboValeTransporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboValeTransporte.Name = "cboValeTransporte";
            this.cboValeTransporte.Size = new System.Drawing.Size(150, 25);
            this.cboValeTransporte.TabIndex = 25;
            // 
            // cboTiqueteRefeicao
            // 
            this.cboTiqueteRefeicao.AccessibleName = "Tíquete-refeição";
            this.cboTiqueteRefeicao.Campo = "Tíquete-refeição";
            this.cboTiqueteRefeicao.FormattingEnabled = true;
            this.cboTiqueteRefeicao.Location = new System.Drawing.Point(189, 50);
            this.cboTiqueteRefeicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTiqueteRefeicao.Name = "cboTiqueteRefeicao";
            this.cboTiqueteRefeicao.Size = new System.Drawing.Size(164, 25);
            this.cboTiqueteRefeicao.TabIndex = 24;
            // 
            // cboAuxCreche
            // 
            this.cboAuxCreche.AccessibleName = "Auxílio Creche";
            this.cboAuxCreche.Campo = "Auxílio Creche";
            this.cboAuxCreche.FormattingEnabled = true;
            this.cboAuxCreche.Location = new System.Drawing.Point(405, 20);
            this.cboAuxCreche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAuxCreche.Name = "cboAuxCreche";
            this.cboAuxCreche.Size = new System.Drawing.Size(150, 25);
            this.cboAuxCreche.TabIndex = 23;
            // 
            // cboAssOdontologica
            // 
            this.cboAssOdontologica.AccessibleName = "Assistência Odontológica";
            this.cboAssOdontologica.Campo = "Assistência Odontológica";
            this.cboAssOdontologica.FormattingEnabled = true;
            this.cboAssOdontologica.Location = new System.Drawing.Point(189, 20);
            this.cboAssOdontologica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAssOdontologica.Name = "cboAssOdontologica";
            this.cboAssOdontologica.Size = new System.Drawing.Size(210, 25);
            this.cboAssOdontologica.TabIndex = 22;
            // 
            // cboAssMedica
            // 
            this.cboAssMedica.AccessibleName = "Assistência Médica";
            this.cboAssMedica.Campo = "Assistência Médica";
            this.cboAssMedica.FormattingEnabled = true;
            this.cboAssMedica.Location = new System.Drawing.Point(12, 20);
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
            this.grpFuncionario.Location = new System.Drawing.Point(5, 290);
            this.grpFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFuncionario.Name = "grpFuncionario";
            this.grpFuncionario.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFuncionario.Size = new System.Drawing.Size(790, 50);
            this.grpFuncionario.TabIndex = 4;
            this.grpFuncionario.TabStop = false;
            this.grpFuncionario.Text = "FUNCIONÁRIO *";
            // 
            // txtSalario
            // 
            this.txtSalario.AccessibleName = "Salário";
            this.txtSalario.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtSalario.Campo = "Salário";
            this.txtSalario.Location = new System.Drawing.Point(373, 20);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalario.MaxLength = 100;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(134, 21);
            this.txtSalario.TabIndex = 20;
            // 
            // cboCargaHoraria
            // 
            this.cboCargaHoraria.AccessibleName = "Carga Horária";
            this.cboCargaHoraria.Campo = "Carga Horária";
            this.cboCargaHoraria.FormattingEnabled = true;
            this.cboCargaHoraria.Location = new System.Drawing.Point(218, 20);
            this.cboCargaHoraria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCargaHoraria.Name = "cboCargaHoraria";
            this.cboCargaHoraria.Size = new System.Drawing.Size(149, 25);
            this.cboCargaHoraria.TabIndex = 19;
            // 
            // txtCargo
            // 
            this.txtCargo.AccessibleName = "Cargo";
            this.txtCargo.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtCargo.Campo = "Cargo";
            this.txtCargo.Location = new System.Drawing.Point(10, 20);
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
            this.btnSalvar.Location = new System.Drawing.Point(711, 350);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 80);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            //this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.Controls.Add(this.grbDados);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctGerenFuncionario";
            this.Size = new System.Drawing.Size(800, 440);
            this.grbDados.ResumeLayout(false);
            this.grpContatos.ResumeLayout(false);
            this.grpEndereco.ResumeLayout(false);
            this.grpBeneficios.ResumeLayout(false);
            this.grpFuncionario.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        
        #endregion
        public UIX.txtUIX txtPesquisa;
        public UIX.txtUIX txtDadosNome;
        public UIX.mtbUIX mtbDadosDtNasc;
        public UIX.mtbUIX mtbDadosRG;
        public UIX.mtbUIX mtbDadosCPF;
        public System.Windows.Forms.GroupBox grbDados;
        public System.Windows.Forms.GroupBox grpContatos;
        public UIX.txtUIX txtContatoEmail;
        public UIX.mtbUIX mtbContatoTelRes;
        public UIX.mtbUIX mtbContatoTelCel;
        public UIX.mtbUIX mtbContatoTelCel2;
        public UIX.txtUIX txtContatoNextel;
        public System.Windows.Forms.GroupBox grpEndereco;
        public UIX.txtUIX txtEndLogradouro;
        public UIX.txtUIX txtEndNr;
        public UIX.mtbUIX mtbEndCEP;
        public UIX.cboUIX cboEndUF;
        public UIX.txtUIX txtEndBairro;
        public UIX.txtUIX txtEndCidade;
        public UIX.txtUIX txtEndComplemento;
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
