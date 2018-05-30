namespace BURGUER_SHACK_DESKTOP
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.hdrUIX = new UIX.hdrUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnReservas = new UIX.btnUIX();
            this.btnSair = new UIX.btnUIX();
            this.btnCardapio = new UIX.btnUIX();
            this.btnMesas = new UIX.btnUIX();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.garcom;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(1000, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Principal";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Location = new System.Drawing.Point(100, 50);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(900, 650);
            this.pnlConteudo.TabIndex = 6;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnReservas);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnCardapio);
            this.pnlMenu.Controls.Add(this.btnMesas);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 650);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnReservas
            // 
            this.btnReservas.Description = "Reservas";
            this.btnReservas.HoverColor = System.Drawing.Color.Transparent;
            this.btnReservas.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.reserva;
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservas.Location = new System.Drawing.Point(5, 105);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(90, 90);
            this.btnReservas.TabIndex = 7;
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnSair
            // 
            this.btnSair.Description = "Sair";
            this.btnSair.HoverColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(5, 555);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 90);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCardapio
            // 
            this.btnCardapio.Description = "Cardápio";
            this.btnCardapio.HoverColor = System.Drawing.Color.Transparent;
            this.btnCardapio.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pedido;
            this.btnCardapio.Location = new System.Drawing.Point(7, 216);
            this.btnCardapio.Name = "btnCardapio";
            this.btnCardapio.Size = new System.Drawing.Size(90, 90);
            this.btnCardapio.TabIndex = 2;
            this.btnCardapio.UseVisualStyleBackColor = true;
            this.btnCardapio.Click += new System.EventHandler(this.btnCardapio_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.Description = "Mesas";
            this.btnMesas.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesas.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesa;
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesas.Location = new System.Drawing.Point(5, 5);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(90, 90);
            this.btnMesas.TabIndex = 0;
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        public System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnSair;
        private UIX.btnUIX btnCardapio;
        private UIX.btnUIX btnMesas;
        private UIX.btnUIX btnReservas;
    }
}