namespace BURGUER_SHACK_DESKTOP
{
    partial class frmPedido
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
            this.lblUix = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picFormIcon = new System.Windows.Forms.PictureBox();
            this.pnlFuncoes = new System.Windows.Forms.Panel();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.uctUIX = new UIX.uctUIX();
            this.uctPedidoNovo1 = new BURGUER_SHACK_DESKTOP.uctPedidoNovo();
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
            this.pnlFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUix
            // 
            this.lblUix.AutoSize = true;
            this.lblUix.Location = new System.Drawing.Point(199, -1);
            this.lblUix.Name = "lblUix";
            this.lblUix.Size = new System.Drawing.Size(42, 13);
            this.lblUix.TabIndex = 14;
            this.lblUix.Text = "labeluix";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(49, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 13);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Burguer Shack - ???";
            // 
            // picFormIcon
            // 
            this.picFormIcon.Location = new System.Drawing.Point(-2, -12);
            this.picFormIcon.Name = "picFormIcon";
            this.picFormIcon.Size = new System.Drawing.Size(100, 50);
            this.picFormIcon.TabIndex = 15;
            this.picFormIcon.TabStop = false;
            // 
            // pnlFuncoes
            // 
            this.pnlFuncoes.Controls.Add(this.btnPedidos);
            this.pnlFuncoes.Controls.Add(this.btnLogout);
            this.pnlFuncoes.Controls.Add(this.btnMenu);
            this.pnlFuncoes.Controls.Add(this.btnRemover);
            this.pnlFuncoes.Controls.Add(this.btnAlterar);
            this.pnlFuncoes.Controls.Add(this.btnAdicionar);
            this.pnlFuncoes.Location = new System.Drawing.Point(0, 45);
            this.pnlFuncoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFuncoes.Name = "pnlFuncoes";
            this.pnlFuncoes.Size = new System.Drawing.Size(64, 649);
            this.pnlFuncoes.TabIndex = 16;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pedidos;
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.Location = new System.Drawing.Point(2, 290);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(60, 60);
            this.btnPedidos.TabIndex = 7;
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(2, 582);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Location = new System.Drawing.Point(2, 10);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemover.Location = new System.Drawing.Point(2, 220);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(60, 60);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(2, 150);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 60);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Location = new System.Drawing.Point(2, 80);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(60, 60);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(250, 39);
            this.uctUIX.TabIndex = 12;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = true;
            this.uctUIX.UIXTitle = "Burguer Shack - Pedidos";
            // 
            // uctPedidoNovo1
            // 
            this.uctPedidoNovo1.Location = new System.Drawing.Point(68, 44);
            this.uctPedidoNovo1.Margin = new System.Windows.Forms.Padding(0);
            this.uctPedidoNovo1.Name = "uctPedidoNovo1";
            this.uctPedidoNovo1.Size = new System.Drawing.Size(430, 630);
            this.uctPedidoNovo1.TabIndex = 17;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 761);
            this.Controls.Add(this.uctPedidoNovo1);
            this.Controls.Add(this.pnlFuncoes);
            this.Controls.Add(this.uctUIX);
            this.Controls.Add(this.lblUix);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picFormIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
            this.pnlFuncoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public UIX.uctUIX uctUIX;
        private System.Windows.Forms.Label lblUix;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picFormIcon;
        private System.Windows.Forms.Panel pnlFuncoes;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private uctPedidoNovo uctPedidoNovo1;
    }
}