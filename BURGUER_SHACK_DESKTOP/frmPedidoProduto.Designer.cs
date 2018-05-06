namespace BURGUER_SHACK_DESKTOP
{
    partial class frmPedidoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoProduto));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnRemover = new UIX.btnUIX();
            this.btnVer = new UIX.btnUIX();
            this.btnVoltar = new UIX.btnUIX();
            this.btnAlterar = new UIX.btnUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.hdrUIX = new UIX.hdrUIX();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnRemover);
            this.pnlMenu.Controls.Add(this.btnVer);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 450);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnRemover
            // 
            this.btnRemover.Description = "Remover";
            this.btnRemover.HoverColor = System.Drawing.Color.Transparent;
            this.btnRemover.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover_x;
            this.btnRemover.Location = new System.Drawing.Point(5, 205);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(90, 90);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnVer
            // 
            this.btnVer.Description = "Visualizar";
            this.btnVer.HoverColor = System.Drawing.Color.Transparent;
            this.btnVer.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVer.Location = new System.Drawing.Point(5, 5);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(90, 90);
            this.btnVer.TabIndex = 0;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Description = "Voltar";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(5, 355);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 90);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Description = "Alterar";
            this.btnAlterar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnAlterar.Location = new System.Drawing.Point(5, 105);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 90);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Location = new System.Drawing.Point(100, 50);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(550, 450);
            this.pnlConteudo.TabIndex = 3;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pedido;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(650, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Produto";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // frmPedidoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPedidoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmPedidoProduto_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnVer;
        private UIX.btnUIX btnAlterar;
        public UIX.hdrUIX hdrUIX;
        public System.Windows.Forms.Panel pnlConteudo;
        public UIX.btnUIX btnVoltar;
        public UIX.btnUIX btnRemover;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}