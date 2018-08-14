namespace BurgerShack.Desktop
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
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnReservas = new vitorrdgs.UiX.Component.UIXButton();
            this.btnSair = new vitorrdgs.UiX.Component.UIXButton();
            this.btnGerenciamento = new vitorrdgs.UiX.Component.UIXButton();
            this.btnMesas = new vitorrdgs.UiX.Component.UIXButton();
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlMenu.Controls.Add(this.btnGerenciamento);
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
            this.btnReservas.Image = global::BurgerShack.Desktop.Properties.Resources.reserva;
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservas.ImageLocation = null;
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
            this.btnSair.Image = global::BurgerShack.Desktop.Properties.Resources.sair;
            this.btnSair.ImageLocation = null;
            this.btnSair.Location = new System.Drawing.Point(5, 555);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 90);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerenciamento
            // 
            this.btnGerenciamento.Description = "Gerenciar";
            this.btnGerenciamento.HoverColor = System.Drawing.Color.Transparent;
            this.btnGerenciamento.Image = global::BurgerShack.Desktop.Properties.Resources.gerenciador;
            this.btnGerenciamento.ImageLocation = null;
            this.btnGerenciamento.Location = new System.Drawing.Point(5, 455);
            this.btnGerenciamento.Name = "btnGerenciamento";
            this.btnGerenciamento.Size = new System.Drawing.Size(90, 90);
            this.btnGerenciamento.TabIndex = 2;
            this.btnGerenciamento.UseVisualStyleBackColor = true;
            this.btnGerenciamento.Click += new System.EventHandler(this.btnGerenciamento_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.Description = "Mesas";
            this.btnMesas.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesas.Image = global::BurgerShack.Desktop.Properties.Resources.mesa;
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesas.ImageLocation = null;
            this.btnMesas.Location = new System.Drawing.Point(5, 5);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(90, 90);
            this.btnMesas.TabIndex = 0;
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.garcom;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(1000, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Principal";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        public System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnSair;
        private vitorrdgs.UiX.Component.UIXButton btnGerenciamento;
        private vitorrdgs.UiX.Component.UIXButton btnMesas;
        private vitorrdgs.UiX.Component.UIXButton btnReservas;
    }
}