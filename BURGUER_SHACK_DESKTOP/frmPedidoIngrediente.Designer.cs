namespace BURGUER_SHACK_DESKTOP
{
    partial class frmPedidoIngrediente
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
            this.grbIngrediente = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new UIX.txtUIX();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.picIngrediente = new System.Windows.Forms.PictureBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.hdrUIX = new UIX.hdrUIX();
            this.grbIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIngrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // grbIngrediente
            // 
            this.grbIngrediente.Controls.Add(this.txtQuantidade);
            this.grbIngrediente.Controls.Add(this.btnAlterar);
            this.grbIngrediente.Controls.Add(this.lblNome);
            this.grbIngrediente.Controls.Add(this.picIngrediente);
            this.grbIngrediente.Location = new System.Drawing.Point(5, 55);
            this.grbIngrediente.Name = "grbIngrediente";
            this.grbIngrediente.Size = new System.Drawing.Size(440, 155);
            this.grbIngrediente.TabIndex = 4;
            this.grbIngrediente.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.AllowedChars = UIX.uixAllowedChars.INT;
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.Location = new System.Drawing.Point(145, 125);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(130, 25);
            this.txtQuantidade.TabIndex = 4;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(300, 115);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 35);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(145, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(290, 30);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "N";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picIngrediente
            // 
            this.picIngrediente.Location = new System.Drawing.Point(10, 20);
            this.picIngrediente.Name = "picIngrediente";
            this.picIngrediente.Size = new System.Drawing.Size(130, 130);
            this.picIngrediente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIngrediente.TabIndex = 0;
            this.picIngrediente.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(5, 215);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 40);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(325, 215);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 40);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(450, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Pedido Ingrediente";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // frmPedidoIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 260);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.grbIngrediente);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedidoIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedido Ingrediente";
            this.Load += new System.EventHandler(this.frmAlteraIngrediente_Load);
            this.grbIngrediente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIngrediente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.GroupBox grbIngrediente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox picIngrediente;
        private UIX.txtUIX txtQuantidade;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnRemover;
    }
}