namespace BURGUER_SHACK_DESKTOP
{
    partial class frmItem
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
            this.btnConfirmar = new UIX.btnUIX();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.txtAdicional = new UIX.txtUIX();
            this.txtQuantidade = new UIX.txtUIX();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.btnRemover = new UIX.btnUIX();
            this.grbIngredientes = new System.Windows.Forms.GroupBox();
            this.btnIngredienteAdd = new UIX.btnUIX();
            this.btnIngredientes = new UIX.btnUIX();
            this.grbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.grbIngredientes.SuspendLayout();
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
            this.hdrUIX.Title = "Item";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Description = "Confirmar";
            this.btnConfirmar.HoverColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.confirmar;
            this.btnConfirmar.ImageLocation = null;
            this.btnConfirmar.Location = new System.Drawing.Point(345, 195);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 100);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.txtAdicional);
            this.grbProduto.Controls.Add(this.txtQuantidade);
            this.grbProduto.Controls.Add(this.lblProdutoNome);
            this.grbProduto.Controls.Add(this.picProduto);
            this.grbProduto.Location = new System.Drawing.Point(5, 55);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(440, 135);
            this.grbProduto.TabIndex = 11;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "PRODUTO";
            // 
            // txtAdicional
            // 
            this.txtAdicional.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtAdicional.Campo = "Informações Adicionais";
            this.txtAdicional.LabelPosition = UIX.uixEnum.uixLabelPosition.UP;
            this.txtAdicional.Location = new System.Drawing.Point(120, 70);
            this.txtAdicional.MaxLength = 32767;
            this.txtAdicional.Multiline = true;
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.Size = new System.Drawing.Size(315, 60);
            this.txtAdicional.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.AllowedChars = UIX.uixEnum.uixAllowedChars.INT;
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtQuantidade.Location = new System.Drawing.Point(120, 45);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(315, 21);
            this.txtQuantidade.TabIndex = 3;
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoNome.Location = new System.Drawing.Point(120, 20);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(315, 20);
            this.lblProdutoNome.TabIndex = 1;
            this.lblProdutoNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(5, 20);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(110, 110);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduto.TabIndex = 0;
            this.picProduto.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Description = "Remover";
            this.btnRemover.HoverColor = System.Drawing.Color.Transparent;
            this.btnRemover.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover;
            this.btnRemover.ImageLocation = null;
            this.btnRemover.Location = new System.Drawing.Point(5, 195);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 100);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // grbIngredientes
            // 
            this.grbIngredientes.Controls.Add(this.btnIngredienteAdd);
            this.grbIngredientes.Controls.Add(this.btnIngredientes);
            this.grbIngredientes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbIngredientes.Location = new System.Drawing.Point(160, 195);
            this.grbIngredientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngredientes.Name = "grbIngredientes";
            this.grbIngredientes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngredientes.Size = new System.Drawing.Size(175, 100);
            this.grbIngredientes.TabIndex = 30;
            this.grbIngredientes.TabStop = false;
            this.grbIngredientes.Text = "INGREDIENTES";
            // 
            // btnIngredienteAdd
            // 
            this.btnIngredienteAdd.Description = "Adicionar";
            this.btnIngredienteAdd.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngredienteAdd.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnIngredienteAdd.ImageLocation = null;
            this.btnIngredienteAdd.Location = new System.Drawing.Point(90, 15);
            this.btnIngredienteAdd.Name = "btnIngredienteAdd";
            this.btnIngredienteAdd.Size = new System.Drawing.Size(80, 80);
            this.btnIngredienteAdd.TabIndex = 26;
            this.btnIngredienteAdd.UseVisualStyleBackColor = true;
            this.btnIngredienteAdd.Click += new System.EventHandler(this.btnIngredienteAdd_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Description = "Visualizar";
            this.btnIngredientes.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngredientes.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.btnIngredientes.ImageLocation = null;
            this.btnIngredientes.Location = new System.Drawing.Point(5, 15);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(80, 80);
            this.btnIngredientes.TabIndex = 28;
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // frmItem
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.grbIngredientes);
            this.Controls.Add(this.grbProduto);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.hdrUIX);
            this.Controls.Add(this.btnRemover);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.frmPedidoProduto_Load);
            this.grbProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.grbIngredientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public UIX.hdrUIX hdrUIX;
        private UIX.btnUIX btnConfirmar;
        private System.Windows.Forms.GroupBox grbProduto;
        private UIX.txtUIX txtAdicional;
        private UIX.txtUIX txtQuantidade;
        private UIX.btnUIX btnRemover;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.PictureBox picProduto;
        private UIX.btnUIX btnIngredienteAdd;
        private UIX.btnUIX btnIngredientes;
        private System.Windows.Forms.GroupBox grbIngredientes;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}