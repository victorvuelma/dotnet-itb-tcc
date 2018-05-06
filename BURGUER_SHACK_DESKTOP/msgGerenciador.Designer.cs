namespace BURGUER_SHACK_DESKTOP
{
    partial class msgGerenciador
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
            this.hdrUIX = new UIX.hdrUIX();
            this.btnProduto = new UIX.btnUIX();
            this.btnTerceirizada = new UIX.btnUIX();
            this.btnFuncionário = new UIX.btnUIX();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.gerenciador;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(429, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "T";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // btnProduto
            // 
            this.btnProduto.Description = "Produto";
            this.btnProduto.HoverColor = System.Drawing.Color.Transparent;
            this.btnProduto.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.produto;
            this.btnProduto.Location = new System.Drawing.Point(336, 105);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(80, 80);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnTerceirizada
            // 
            this.btnTerceirizada.Description = "Terceirizada";
            this.btnTerceirizada.HoverColor = System.Drawing.Color.Transparent;
            this.btnTerceirizada.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.terceirizada;
            this.btnTerceirizada.Location = new System.Drawing.Point(248, 105);
            this.btnTerceirizada.Name = "btnTerceirizada";
            this.btnTerceirizada.Size = new System.Drawing.Size(82, 80);
            this.btnTerceirizada.TabIndex = 3;
            this.btnTerceirizada.UseVisualStyleBackColor = true;
            this.btnTerceirizada.Click += new System.EventHandler(this.btnTerceirizada_Click);
            // 
            // btnFuncionário
            // 
            this.btnFuncionário.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionário.Description = "Funcionário";
            this.btnFuncionário.HoverColor = System.Drawing.Color.Transparent;
            this.btnFuncionário.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.funcionario;
            this.btnFuncionário.Location = new System.Drawing.Point(162, 105);
            this.btnFuncionário.Name = "btnFuncionário";
            this.btnFuncionário.Size = new System.Drawing.Size(80, 80);
            this.btnFuncionário.TabIndex = 4;
            this.btnFuncionário.UseVisualStyleBackColor = true;
            this.btnFuncionário.Click += new System.EventHandler(this.btnFuncionário_Click);
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(12, 53);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(404, 49);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "C";
            // 
            // msgGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 197);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnFuncionário);
            this.Controls.Add(this.btnTerceirizada);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msgGerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msgGerenciador";
            this.Load += new System.EventHandler(this.msgGerenciador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl;
        public UIX.hdrUIX hdrUIX;
        public UIX.btnUIX btnProduto;
        public UIX.btnUIX btnTerceirizada;
        public UIX.btnUIX btnFuncionário;
    }
}