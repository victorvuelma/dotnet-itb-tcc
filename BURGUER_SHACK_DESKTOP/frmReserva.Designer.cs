namespace BURGUER_SHACK_DESKTOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.btnSalvar = new UIX.btnUIX();
            this.hdrUIX = new UIX.hdrUIX();
            this.btnVoltar = new UIX.btnUIX();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCliEncontrar = new UIX.btnUIX();
            this.mtbCliCPF = new UIX.mtbUIX();
            this.grbReserva = new System.Windows.Forms.GroupBox();
            this.cboSituacao = new UIX.cboUIX();
            this.txtPessoas = new UIX.txtUIX();
            this.mtbHora = new UIX.mtbUIX();
            this.mtbDia = new UIX.mtbUIX();
            this.btnMesaAdd = new UIX.btnUIX();
            this.btnMesaVer = new UIX.btnUIX();
            this.grbMesas = new System.Windows.Forms.GroupBox();
            this.pnlMenu.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.grbReserva.SuspendLayout();
            this.grbMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(305, 300);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 90);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.reserva;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(400, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Reserva";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
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
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 350);
            this.pnlMenu.TabIndex = 5;
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.lblCliente);
            this.grbCliente.Controls.Add(this.btnCliEncontrar);
            this.grbCliente.Controls.Add(this.mtbCliCPF);
            this.grbCliente.Location = new System.Drawing.Point(105, 55);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(290, 120);
            this.grbCliente.TabIndex = 6;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "CLIENTE";
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(5, 45);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(180, 65);
            this.lblCliente.TabIndex = 8;
            // 
            // btnCliEncontrar
            // 
            this.btnCliEncontrar.Description = "Encontrar";
            this.btnCliEncontrar.HoverColor = System.Drawing.Color.Transparent;
            this.btnCliEncontrar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.cliente;
            this.btnCliEncontrar.Location = new System.Drawing.Point(190, 20);
            this.btnCliEncontrar.Name = "btnCliEncontrar";
            this.btnCliEncontrar.Size = new System.Drawing.Size(90, 90);
            this.btnCliEncontrar.TabIndex = 7;
            this.btnCliEncontrar.UseVisualStyleBackColor = true;
            this.btnCliEncontrar.Click += new System.EventHandler(this.btnCliEncontrar_Click);
            // 
            // mtbCliCPF
            // 
            this.mtbCliCPF.AccessibleName = "CPF";
            this.mtbCliCPF.Campo = "CPF";
            this.mtbCliCPF.Location = new System.Drawing.Point(5, 20);
            this.mtbCliCPF.Mask = "";
            this.mtbCliCPF.MaxLength = 32767;
            this.mtbCliCPF.Name = "mtbCliCPF";
            this.mtbCliCPF.Size = new System.Drawing.Size(180, 20);
            this.mtbCliCPF.TabIndex = 0;
            this.mtbCliCPF.ValidatingType = null;
            // 
            // grbReserva
            // 
            this.grbReserva.Controls.Add(this.cboSituacao);
            this.grbReserva.Controls.Add(this.txtPessoas);
            this.grbReserva.Controls.Add(this.mtbHora);
            this.grbReserva.Controls.Add(this.mtbDia);
            this.grbReserva.Location = new System.Drawing.Point(105, 180);
            this.grbReserva.Name = "grbReserva";
            this.grbReserva.Size = new System.Drawing.Size(290, 114);
            this.grbReserva.TabIndex = 9;
            this.grbReserva.TabStop = false;
            this.grbReserva.Text = "RESERVA";
            // 
            // cboSituacao
            // 
            this.cboSituacao.AccessibleName = "Situacao";
            this.cboSituacao.Campo = "Situacao";
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Location = new System.Drawing.Point(5, 80);
            this.cboSituacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(280, 20);
            this.cboSituacao.TabIndex = 11;
            // 
            // txtPessoas
            // 
            this.txtPessoas.AccessibleName = "Pessoas";
            this.txtPessoas.AllowedChars = UIX.uixAllowedChars.INT;
            this.txtPessoas.Campo = "Pessoas";
            this.txtPessoas.Location = new System.Drawing.Point(5, 50);
            this.txtPessoas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPessoas.MaxLength = 32767;
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.Size = new System.Drawing.Size(280, 20);
            this.txtPessoas.TabIndex = 10;
            // 
            // mtbHora
            // 
            this.mtbHora.AccessibleName = "Hora";
            this.mtbHora.Campo = "Hora";
            this.mtbHora.Location = new System.Drawing.Point(175, 20);
            this.mtbHora.Mask = "";
            this.mtbHora.MaxLength = 32767;
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(110, 20);
            this.mtbHora.TabIndex = 9;
            this.mtbHora.ValidatingType = null;
            // 
            // mtbDia
            // 
            this.mtbDia.AccessibleName = "Dia";
            this.mtbDia.Campo = "Dia";
            this.mtbDia.Location = new System.Drawing.Point(5, 20);
            this.mtbDia.Mask = "";
            this.mtbDia.MaxLength = 32767;
            this.mtbDia.Name = "mtbDia";
            this.mtbDia.Size = new System.Drawing.Size(160, 20);
            this.mtbDia.TabIndex = 8;
            this.mtbDia.ValidatingType = null;
            // 
            // btnMesaAdd
            // 
            this.btnMesaAdd.Description = "Adicionar";
            this.btnMesaAdd.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesaAdd.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnMesaAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesaAdd.Location = new System.Drawing.Point(5, 15);
            this.btnMesaAdd.Name = "btnMesaAdd";
            this.btnMesaAdd.Size = new System.Drawing.Size(70, 70);
            this.btnMesaAdd.TabIndex = 10;
            this.btnMesaAdd.UseVisualStyleBackColor = true;
            this.btnMesaAdd.Click += new System.EventHandler(this.btnMesaAdd_Click);
            // 
            // btnMesaVer
            // 
            this.btnMesaVer.Description = "Visualizar";
            this.btnMesaVer.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesaVer.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover_menos;
            this.btnMesaVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesaVer.Location = new System.Drawing.Point(80, 15);
            this.btnMesaVer.Name = "btnMesaVer";
            this.btnMesaVer.Size = new System.Drawing.Size(70, 70);
            this.btnMesaVer.TabIndex = 11;
            this.btnMesaVer.UseVisualStyleBackColor = true;
            this.btnMesaVer.Click += new System.EventHandler(this.btnMesaVer_Click);
            // 
            // grbMesas
            // 
            this.grbMesas.Controls.Add(this.btnMesaVer);
            this.grbMesas.Controls.Add(this.btnMesaAdd);
            this.grbMesas.Location = new System.Drawing.Point(105, 300);
            this.grbMesas.Name = "grbMesas";
            this.grbMesas.Size = new System.Drawing.Size(155, 90);
            this.grbMesas.TabIndex = 12;
            this.grbMesas.TabStop = false;
            this.grbMesas.Text = "MESAS";
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.grbMesas);
            this.Controls.Add(this.grbReserva);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbCliente.ResumeLayout(false);
            this.grbReserva.ResumeLayout(false);
            this.grbMesas.ResumeLayout(false);
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
        private UIX.mtbUIX mtbDia;
        private UIX.mtbUIX mtbHora;
        private UIX.txtUIX txtPessoas;
        private UIX.cboUIX cboSituacao;
        private UIX.btnUIX btnMesaAdd;
        private UIX.btnUIX btnMesaVer;
        private System.Windows.Forms.GroupBox grbMesas;
    }
}