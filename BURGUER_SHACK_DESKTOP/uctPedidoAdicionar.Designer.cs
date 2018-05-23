namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoAdicionar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAdicionarProduto = new System.Windows.Forms.GroupBox();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.btnIngredienteAdd = new System.Windows.Forms.Button();
            this.txtAdicional = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new UIX.txtUIX();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.grbDetalhes = new System.Windows.Forms.GroupBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.btnSobremesa = new UIX.btnUIX();
            this.btnBebida = new UIX.btnUIX();
            this.btnAcompanhamento = new UIX.btnUIX();
            this.btnLanche = new UIX.btnUIX();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbAdicionarProduto.SuspendLayout();
            this.grbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.grbDetalhes.SuspendLayout();
            this.grbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdicionarProduto
            // 
            this.grbAdicionarProduto.Controls.Add(this.grbProduto);
            this.grbAdicionarProduto.Controls.Add(this.grbDetalhes);
            this.grbAdicionarProduto.Controls.Add(this.grbTipo);
            this.grbAdicionarProduto.Location = new System.Drawing.Point(5, 5);
            this.grbAdicionarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbAdicionarProduto.Name = "grbAdicionarProduto";
            this.grbAdicionarProduto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbAdicionarProduto.Size = new System.Drawing.Size(440, 535);
            this.grbAdicionarProduto.TabIndex = 5;
            this.grbAdicionarProduto.TabStop = false;
            this.grbAdicionarProduto.Text = "ADICIONAR PRODUTO";
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.btnIngredienteAdd);
            this.grbProduto.Controls.Add(this.txtAdicional);
            this.grbProduto.Controls.Add(this.txtQuantidade);
            this.grbProduto.Controls.Add(this.btnIngredientes);
            this.grbProduto.Controls.Add(this.btnAlterar);
            this.grbProduto.Controls.Add(this.lblProdutoNome);
            this.grbProduto.Controls.Add(this.picProduto);
            this.grbProduto.Location = new System.Drawing.Point(5, 140);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(430, 190);
            this.grbProduto.TabIndex = 4;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "PRODUTO";
            // 
            // btnIngredienteAdd
            // 
            this.btnIngredienteAdd.Location = new System.Drawing.Point(260, 145);
            this.btnIngredienteAdd.Name = "btnIngredienteAdd";
            this.btnIngredienteAdd.Size = new System.Drawing.Size(40, 40);
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
            this.txtQuantidade.Size = new System.Drawing.Size(124, 37);
            this.txtQuantidade.TabIndex = 3;
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Location = new System.Drawing.Point(305, 145);
            this.btnIngredientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(120, 40);
            this.btnIngredientes.TabIndex = 11;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(5, 145);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 40);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            // grbDetalhes
            // 
            this.grbDetalhes.Controls.Add(this.lblDetalhes);
            this.grbDetalhes.Location = new System.Drawing.Point(4, 335);
            this.grbDetalhes.Name = "grbDetalhes";
            this.grbDetalhes.Size = new System.Drawing.Size(430, 195);
            this.grbDetalhes.TabIndex = 5;
            this.grbDetalhes.TabStop = false;
            this.grbDetalhes.Text = "DETALHES";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.Location = new System.Drawing.Point(5, 20);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(420, 170);
            this.lblDetalhes.TabIndex = 0;
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.btnSobremesa);
            this.grbTipo.Controls.Add(this.btnBebida);
            this.grbTipo.Controls.Add(this.btnAcompanhamento);
            this.grbTipo.Controls.Add(this.btnLanche);
            this.grbTipo.Location = new System.Drawing.Point(5, 15);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(430, 120);
            this.grbTipo.TabIndex = 0;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "TIPO DO PRODUTO";
            // 
            // btnSobremesa
            // 
            this.btnSobremesa.Description = "Sobremesa";
            this.btnSobremesa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobremesa.HoverColor = System.Drawing.Color.Transparent;
            this.btnSobremesa.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sobremesa;
            this.btnSobremesa.Location = new System.Drawing.Point(335, 20);
            this.btnSobremesa.Name = "btnSobremesa";
            this.btnSobremesa.Size = new System.Drawing.Size(90, 90);
            this.btnSobremesa.TabIndex = 3;
            this.btnSobremesa.Text = "btnUIX3";
            this.btnSobremesa.UseVisualStyleBackColor = true;
            this.btnSobremesa.Click += new System.EventHandler(this.btnSobremesa_Click);
            // 
            // btnBebida
            // 
            this.btnBebida.Description = "Bebida";
            this.btnBebida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebida.HoverColor = System.Drawing.Color.Transparent;
            this.btnBebida.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.bebida;
            this.btnBebida.Location = new System.Drawing.Point(225, 20);
            this.btnBebida.Name = "btnBebida";
            this.btnBebida.Size = new System.Drawing.Size(90, 90);
            this.btnBebida.TabIndex = 2;
            this.btnBebida.Text = "btnUIX2";
            this.btnBebida.UseVisualStyleBackColor = true;
            this.btnBebida.Click += new System.EventHandler(this.btnBebida_Click);
            // 
            // btnAcompanhamento
            // 
            this.btnAcompanhamento.Description = "Guarnição";
            this.btnAcompanhamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcompanhamento.HoverColor = System.Drawing.Color.Transparent;
            this.btnAcompanhamento.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.batatas;
            this.btnAcompanhamento.Location = new System.Drawing.Point(115, 20);
            this.btnAcompanhamento.Name = "btnAcompanhamento";
            this.btnAcompanhamento.Size = new System.Drawing.Size(90, 90);
            this.btnAcompanhamento.TabIndex = 1;
            this.btnAcompanhamento.Text = "btnUIX1";
            this.btnAcompanhamento.UseVisualStyleBackColor = true;
            this.btnAcompanhamento.Click += new System.EventHandler(this.btnAcompanhamento_Click);
            // 
            // btnLanche
            // 
            this.btnLanche.Description = "Lanche";
            this.btnLanche.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanche.HoverColor = System.Drawing.Color.Transparent;
            this.btnLanche.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.hamburger;
            this.btnLanche.Location = new System.Drawing.Point(5, 20);
            this.btnLanche.Name = "btnLanche";
            this.btnLanche.Size = new System.Drawing.Size(90, 90);
            this.btnLanche.TabIndex = 0;
            this.btnLanche.Text = "btnUIX1";
            this.btnLanche.UseVisualStyleBackColor = true;
            this.btnLanche.Click += new System.EventHandler(this.btnLanche_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(245, 546);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(200, 50);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar Produto";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // uctPedidoAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.grbAdicionarProduto);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedidoAdicionar";
            this.Size = new System.Drawing.Size(450, 600);
            this.Load += new System.EventHandler(this.uctPedidoAdicionar_Load);
            this.grbAdicionarProduto.ResumeLayout(false);
            this.grbProduto.ResumeLayout(false);
            this.grbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.grbDetalhes.ResumeLayout(false);
            this.grbTipo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdicionarProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grbTipo;
        private UIX.btnUIX btnLanche;
        private UIX.btnUIX btnSobremesa;
        private UIX.btnUIX btnBebida;
        private UIX.btnUIX btnAcompanhamento;
        private System.Windows.Forms.GroupBox grbDetalhes;
        private System.Windows.Forms.Label lblDetalhes;
        private UIX.txtUIX txtQuantidade;
        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.TextBox txtAdicional;
        public System.Windows.Forms.Button btnIngredienteAdd;
    }
}
