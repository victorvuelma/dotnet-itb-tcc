namespace BURGUERSHACK_DESKTOP
{
    partial class frmReserva
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
            this.btnAtendimento = new UIX.btnUIX();
            this.btnVoltar = new UIX.btnUIX();
            this.btnSalvar = new UIX.btnUIX();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCliEncontrar = new UIX.btnUIX();
            this.mtbCliCPF = new UIX.mtbUIX();
            this.grbReserva = new System.Windows.Forms.GroupBox();
            this.mtbHora = new UIX.mtbUIX();
            this.txtPessoas = new UIX.txtUIX();
            this.mtbData = new UIX.mtbUIX();
            this.grbMesas = new System.Windows.Forms.GroupBox();
            this.btnMesaVer = new UIX.btnUIX();
            this.btnMesaAdd = new UIX.btnUIX();
            this.hdrUIX = new UIX.hdrUIX();
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new UIX.btnUIX();
            this.btnConfirmar = new UIX.btnUIX();
            this.pnlMenu.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.grbReserva.SuspendLayout();
            this.grbMesas.SuspendLayout();
            this.grbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnAtendimento);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnSalvar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 300);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnAtendimento
            // 
            this.btnAtendimento.Description = "Atendimento";
            this.btnAtendimento.HoverColor = System.Drawing.Color.Transparent;
            this.btnAtendimento.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.atendimento;
            this.btnAtendimento.ImageLocation = null;
            this.btnAtendimento.Location = new System.Drawing.Point(5, 105);
            this.btnAtendimento.Name = "btnAtendimento";
            this.btnAtendimento.Size = new System.Drawing.Size(90, 90);
            this.btnAtendimento.TabIndex = 7;
            this.btnAtendimento.UseVisualStyleBackColor = true;
            this.btnAtendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
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
            this.btnSalvar.Location = new System.Drawing.Point(5, 205);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 90);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.lblCliente);
            this.grbCliente.Controls.Add(this.btnCliEncontrar);
            this.grbCliente.Controls.Add(this.mtbCliCPF);
            this.grbCliente.Location = new System.Drawing.Point(105, 55);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(340, 100);
            this.grbCliente.TabIndex = 6;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "CLIENTE";
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(5, 45);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(245, 50);
            this.lblCliente.TabIndex = 8;
            // 
            // btnCliEncontrar
            // 
            this.btnCliEncontrar.Description = "Encontrar";
            this.btnCliEncontrar.HoverColor = System.Drawing.Color.Transparent;
            this.btnCliEncontrar.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.cliente;
            this.btnCliEncontrar.ImageLocation = null;
            this.btnCliEncontrar.Location = new System.Drawing.Point(255, 15);
            this.btnCliEncontrar.Name = "btnCliEncontrar";
            this.btnCliEncontrar.Size = new System.Drawing.Size(80, 80);
            this.btnCliEncontrar.TabIndex = 7;
            this.btnCliEncontrar.UseVisualStyleBackColor = true;
            this.btnCliEncontrar.Click += new System.EventHandler(this.btnCliEncontrar_Click);
            // 
            // mtbCliCPF
            // 
            this.mtbCliCPF.AcceptButton = this.btnCliEncontrar;
            this.mtbCliCPF.AccessibleName = "CPF";
            this.mtbCliCPF.Campo = "CPF";
            this.mtbCliCPF.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.mtbCliCPF.Location = new System.Drawing.Point(5, 20);
            this.mtbCliCPF.Mask = "";
            this.mtbCliCPF.MaxLength = 32767;
            this.mtbCliCPF.Name = "mtbCliCPF";
            this.mtbCliCPF.Size = new System.Drawing.Size(245, 20);
            this.mtbCliCPF.TabIndex = 0;
            this.mtbCliCPF.ValidatingType = null;
            // 
            // grbReserva
            // 
            this.grbReserva.Controls.Add(this.mtbHora);
            this.grbReserva.Controls.Add(this.txtPessoas);
            this.grbReserva.Controls.Add(this.mtbData);
            this.grbReserva.Location = new System.Drawing.Point(105, 155);
            this.grbReserva.Name = "grbReserva";
            this.grbReserva.Size = new System.Drawing.Size(340, 55);
            this.grbReserva.TabIndex = 9;
            this.grbReserva.TabStop = false;
            this.grbReserva.Text = "RESERVA";
            // 
            // mtbHora
            // 
            this.mtbHora.AcceptButton = null;
            this.mtbHora.AccessibleName = "Hora";
            this.mtbHora.Campo = "Hora";
            this.mtbHora.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.mtbHora.Location = new System.Drawing.Point(127, 20);
            this.mtbHora.Mask = "";
            this.mtbHora.MaxLength = 32767;
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(97, 20);
            this.mtbHora.TabIndex = 9;
            this.mtbHora.ValidatingType = null;
            // 
            // txtPessoas
            // 
            this.txtPessoas.AcceptButton = null;
            this.txtPessoas.AccessibleName = "Pessoas";
            this.txtPessoas.Mode = UIX.uixEnum.uixTextBoxMode.INT;
            this.txtPessoas.Campo = "Pessoas";
            this.txtPessoas.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtPessoas.Location = new System.Drawing.Point(230, 20);
            this.txtPessoas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPessoas.MaxLength = 32767;
            this.txtPessoas.Multiline = false;
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPessoas.Size = new System.Drawing.Size(104, 20);
            this.txtPessoas.TabIndex = 10;
            // 
            // mtbData
            // 
            this.mtbData.AcceptButton = null;
            this.mtbData.AccessibleName = "Dia";
            this.mtbData.Campo = "Dia";
            this.mtbData.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.mtbData.Location = new System.Drawing.Point(5, 20);
            this.mtbData.Mask = "";
            this.mtbData.MaxLength = 32767;
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(116, 20);
            this.mtbData.TabIndex = 8;
            this.mtbData.ValidatingType = null;
            this.mtbData.Validated += new System.EventHandler(this.mtbData_Validated);
            // 
            // grbMesas
            // 
            this.grbMesas.Controls.Add(this.btnMesaVer);
            this.grbMesas.Controls.Add(this.btnMesaAdd);
            this.grbMesas.Location = new System.Drawing.Point(105, 250);
            this.grbMesas.Name = "grbMesas";
            this.grbMesas.Size = new System.Drawing.Size(165, 90);
            this.grbMesas.TabIndex = 12;
            this.grbMesas.TabStop = false;
            this.grbMesas.Text = "MESAS";
            // 
            // btnMesaVer
            // 
            this.btnMesaVer.Description = "Visualizar";
            this.btnMesaVer.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesaVer.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.lista;
            this.btnMesaVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesaVer.ImageLocation = null;
            this.btnMesaVer.Location = new System.Drawing.Point(85, 15);
            this.btnMesaVer.Name = "btnMesaVer";
            this.btnMesaVer.Size = new System.Drawing.Size(70, 70);
            this.btnMesaVer.TabIndex = 11;
            this.btnMesaVer.UseVisualStyleBackColor = true;
            this.btnMesaVer.Click += new System.EventHandler(this.btnMesaVer_Click);
            // 
            // btnMesaAdd
            // 
            this.btnMesaAdd.Description = "Adicionar";
            this.btnMesaAdd.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesaAdd.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnMesaAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesaAdd.ImageLocation = null;
            this.btnMesaAdd.Location = new System.Drawing.Point(10, 15);
            this.btnMesaAdd.Name = "btnMesaAdd";
            this.btnMesaAdd.Size = new System.Drawing.Size(70, 70);
            this.btnMesaAdd.TabIndex = 10;
            this.btnMesaAdd.UseVisualStyleBackColor = true;
            this.btnMesaAdd.Click += new System.EventHandler(this.btnMesaAdd_Click);
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.reserva;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(450, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Reserva";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.btnCancelar);
            this.grbSituacao.Controls.Add(this.btnConfirmar);
            this.grbSituacao.Location = new System.Drawing.Point(280, 250);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Size = new System.Drawing.Size(165, 90);
            this.grbSituacao.TabIndex = 13;
            this.grbSituacao.TabStop = false;
            this.grbSituacao.Text = "SITUAÇÃO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Description = "Cancelar";
            this.btnCancelar.HoverColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.excluir;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageLocation = null;
            this.btnCancelar.Location = new System.Drawing.Point(85, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 70);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Description = "Confirmar";
            this.btnConfirmar.HoverColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.ImageLocation = null;
            this.btnConfirmar.Location = new System.Drawing.Point(10, 15);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(70, 70);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmReserva
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.grbSituacao);
            this.Controls.Add(this.grbMesas);
            this.Controls.Add(this.grbReserva);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbCliente.ResumeLayout(false);
            this.grbReserva.ResumeLayout(false);
            this.grbMesas.ResumeLayout(false);
            this.grbSituacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        private UIX.btnUIX btnSalvar;
        private UIX.btnUIX btnVoltar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.GroupBox grbCliente;
        private UIX.mtbUIX mtbCliCPF;
        private UIX.btnUIX btnCliEncontrar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox grbReserva;
        private UIX.mtbUIX mtbData;
        private UIX.mtbUIX mtbHora;
        private UIX.txtUIX txtPessoas;
        private UIX.btnUIX btnMesaAdd;
        private UIX.btnUIX btnMesaVer;
        private System.Windows.Forms.GroupBox grbMesas;
        private UIX.btnUIX btnAtendimento;
        private System.Windows.Forms.GroupBox grbSituacao;
        private UIX.btnUIX btnCancelar;
        private UIX.btnUIX btnConfirmar;
    }
}