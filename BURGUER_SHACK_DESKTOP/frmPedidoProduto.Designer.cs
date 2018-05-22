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
            this.hdrUIX = new UIX.hdrUIX();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.btnIngredienteAdd = new System.Windows.Forms.Button();
            this.txtAdicional = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new UIX.txtUIX();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.grbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.SuspendLayout();
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
            this.hdrUIX.Size = new System.Drawing.Size(450, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Produto";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(245, 247);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(200, 50);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.btnIngredienteAdd);
            this.grbProduto.Controls.Add(this.txtAdicional);
            this.grbProduto.Controls.Add(this.txtQuantidade);
            this.grbProduto.Controls.Add(this.btnIngredientes);
            this.grbProduto.Controls.Add(this.btnRemover);
            this.grbProduto.Controls.Add(this.lblProdutoNome);
            this.grbProduto.Controls.Add(this.picProduto);
            this.grbProduto.Location = new System.Drawing.Point(10, 60);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(430, 185);
            this.grbProduto.TabIndex = 11;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "PRODUTO";
            // 
            // btnIngredienteAdd
            // 
            this.btnIngredienteAdd.Location = new System.Drawing.Point(270, 145);
            this.btnIngredienteAdd.Name = "btnIngredienteAdd";
            this.btnIngredienteAdd.Size = new System.Drawing.Size(30, 30);
            this.btnIngredienteAdd.TabIndex = 13;
            this.btnIngredienteAdd.Text = "+";
            this.btnIngredienteAdd.UseVisualStyleBackColor = true;
            this.btnIngredienteAdd.Click += new System.EventHandler(this.btnIngredienteAdd_Click);
            // 
            // txtAdicional
            // 
            this.txtAdicional.Location = new System.Drawing.Point(130, 50);
            this.txtAdicional.Multiline = true;
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.Size = new System.Drawing.Size(295, 90);
            this.txtAdicional.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.AllowedChars = UIX.uixAllowedChars.INT;
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.Location = new System.Drawing.Point(130, 145);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(135, 25);
            this.txtQuantidade.TabIndex = 3;
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Location = new System.Drawing.Point(305, 145);
            this.btnIngredientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(120, 30);
            this.btnIngredientes.TabIndex = 11;
            this.btnIngredientes.Text = "&Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(5, 145);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 30);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoNome.Location = new System.Drawing.Point(130, 20);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(295, 25);
            this.lblProdutoNome.TabIndex = 1;
            this.lblProdutoNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(5, 20);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(120, 120);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduto.TabIndex = 0;
            this.picProduto.TabStop = false;
            // 
            // frmPedidoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.grbProduto);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPedidoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmPedidoProduto_Load);
            this.grbProduto.ResumeLayout(false);
            this.grbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox grbProduto;
        public System.Windows.Forms.Button btnIngredienteAdd;
        private System.Windows.Forms.TextBox txtAdicional;
        private UIX.txtUIX txtQuantidade;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.PictureBox picProduto;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}