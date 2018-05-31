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
            this.pnlMenu.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(365, 188);
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
            this.hdrUIX.Size = new System.Drawing.Size(450, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Reserva";
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
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 250);
            this.pnlMenu.TabIndex = 5;
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
            this.lblCliente.Size = new System.Drawing.Size(240, 50);
            this.lblCliente.TabIndex = 8;
            // 
            // btnCliEncontrar
            // 
            this.btnCliEncontrar.Description = "Encontrar";
            this.btnCliEncontrar.HoverColor = System.Drawing.Color.Transparent;
            this.btnCliEncontrar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.cliente;
            this.btnCliEncontrar.Location = new System.Drawing.Point(255, 12);
            this.btnCliEncontrar.Name = "btnCliEncontrar";
            this.btnCliEncontrar.Size = new System.Drawing.Size(80, 80);
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
            this.mtbCliCPF.Size = new System.Drawing.Size(244, 20);
            this.mtbCliCPF.TabIndex = 0;
            this.mtbCliCPF.ValidatingType = null;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
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
    }
}