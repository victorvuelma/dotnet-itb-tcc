namespace BurgerShack.Desktop
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
            this.lblValor = new System.Windows.Forms.Label();
            this.grbIngredientes = new System.Windows.Forms.GroupBox();
            this.btnIngredienteAdd = new vitorrdgs.UiX.Component.UIXButton();
            this.btnIngredientes = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAlterar = new vitorrdgs.UiX.Component.UIXButton();
            this.txtAdicional = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtQuantidade = new vitorrdgs.UiX.Component.UIXTextBox();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.btnSobremesa = new vitorrdgs.UiX.Component.UIXButton();
            this.btnBebida = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAcompanhamento = new vitorrdgs.UiX.Component.UIXButton();
            this.btnLanche = new vitorrdgs.UiX.Component.UIXButton();
            this.grbDetalhes = new System.Windows.Forms.GroupBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.btnConfirmar = new vitorrdgs.UiX.Component.UIXButton();
            this.grbAdicionarProduto.SuspendLayout();
            this.grbProduto.SuspendLayout();
            this.grbIngredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.grbTipo.SuspendLayout();
            this.grbDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdicionarProduto
            // 
            this.grbAdicionarProduto.Controls.Add(this.grbProduto);
            this.grbAdicionarProduto.Controls.Add(this.grbTipo);
            this.grbAdicionarProduto.Location = new System.Drawing.Point(5, 5);
            this.grbAdicionarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbAdicionarProduto.Name = "grbAdicionarProduto";
            this.grbAdicionarProduto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbAdicionarProduto.Size = new System.Drawing.Size(440, 390);
            this.grbAdicionarProduto.TabIndex = 5;
            this.grbAdicionarProduto.TabStop = false;
            this.grbAdicionarProduto.Text = "ADICIONAR PRODUTO";
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.lblValor);
            this.grbProduto.Controls.Add(this.grbIngredientes);
            this.grbProduto.Controls.Add(this.btnAlterar);
            this.grbProduto.Controls.Add(this.txtAdicional);
            this.grbProduto.Controls.Add(this.txtQuantidade);
            this.grbProduto.Controls.Add(this.lblProdutoNome);
            this.grbProduto.Controls.Add(this.picProduto);
            this.grbProduto.Location = new System.Drawing.Point(5, 150);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(430, 235);
            this.grbProduto.TabIndex = 4;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "PRODUTO";
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(110, 195);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(210, 25);
            this.lblValor.TabIndex = 31;
            this.lblValor.Text = "Valor:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbIngredientes
            // 
            this.grbIngredientes.Controls.Add(this.btnIngredienteAdd);
            this.grbIngredientes.Controls.Add(this.btnIngredientes);
            this.grbIngredientes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbIngredientes.Location = new System.Drawing.Point(325, 20);
            this.grbIngredientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngredientes.Name = "grbIngredientes";
            this.grbIngredientes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngredientes.Size = new System.Drawing.Size(100, 205);
            this.grbIngredientes.TabIndex = 30;
            this.grbIngredientes.TabStop = false;
            this.grbIngredientes.Text = "INGREDIENTES";
            // 
            // btnIngredienteAdd
            // 
            this.btnIngredienteAdd.Description = "Adicionar";
            this.btnIngredienteAdd.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngredienteAdd.Image = global::BurgerShack.Desktop.Properties.Resources.adicionar;
            this.btnIngredienteAdd.ImageLocation = null;
            this.btnIngredienteAdd.Location = new System.Drawing.Point(5, 110);
            this.btnIngredienteAdd.Name = "btnIngredienteAdd";
            this.btnIngredienteAdd.Size = new System.Drawing.Size(90, 90);
            this.btnIngredienteAdd.TabIndex = 26;
            this.btnIngredienteAdd.Text = "Adicionar";
            this.btnIngredienteAdd.UseVisualStyleBackColor = true;
            this.btnIngredienteAdd.Click += new System.EventHandler(this.btnIngredienteAdd_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Description = "Visualizar";
            this.btnIngredientes.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngredientes.Image = global::BurgerShack.Desktop.Properties.Resources.lista;
            this.btnIngredientes.ImageLocation = null;
            this.btnIngredientes.Location = new System.Drawing.Point(5, 15);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(90, 90);
            this.btnIngredientes.TabIndex = 28;
            this.btnIngredientes.Text = "Visualizar";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Description = "Alterar";
            this.btnAlterar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Image = global::BurgerShack.Desktop.Properties.Resources.alterar;
            this.btnAlterar.ImageLocation = null;
            this.btnAlterar.Location = new System.Drawing.Point(5, 125);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 100);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtAdicional
            // 
            this.txtAdicional.AcceptButton = null;
            this.txtAdicional.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtAdicional.Campo = "Informações Adicionais";
            this.txtAdicional.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.UP;
            this.txtAdicional.Location = new System.Drawing.Point(110, 100);
            this.txtAdicional.MaxLength = 32767;
            this.txtAdicional.Multiline = true;
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdicional.Size = new System.Drawing.Size(210, 85);
            this.txtAdicional.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AcceptButton = null;
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.INT;
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtQuantidade.Location = new System.Drawing.Point(110, 70);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantidade.Size = new System.Drawing.Size(210, 21);
            this.txtQuantidade.TabIndex = 3;
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoNome.Location = new System.Drawing.Point(110, 20);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(210, 40);
            this.lblProdutoNome.TabIndex = 1;
            this.lblProdutoNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(5, 20);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(100, 100);
            this.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduto.TabIndex = 0;
            this.picProduto.TabStop = false;
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.btnSobremesa);
            this.grbTipo.Controls.Add(this.btnBebida);
            this.grbTipo.Controls.Add(this.btnAcompanhamento);
            this.grbTipo.Controls.Add(this.btnLanche);
            this.grbTipo.Location = new System.Drawing.Point(5, 20);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(430, 120);
            this.grbTipo.TabIndex = 0;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "TIPO DO PRODUTO";
            // 
            // btnSobremesa
            // 
            this.btnSobremesa.Description = "Sobremesa";
            this.btnSobremesa.HoverColor = System.Drawing.Color.Transparent;
            this.btnSobremesa.Image = global::BurgerShack.Desktop.Properties.Resources.sobremesa;
            this.btnSobremesa.ImageLocation = null;
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
            this.btnBebida.HoverColor = System.Drawing.Color.Transparent;
            this.btnBebida.Image = global::BurgerShack.Desktop.Properties.Resources.bebida;
            this.btnBebida.ImageLocation = null;
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
            this.btnAcompanhamento.HoverColor = System.Drawing.Color.Transparent;
            this.btnAcompanhamento.Image = global::BurgerShack.Desktop.Properties.Resources.batatas;
            this.btnAcompanhamento.ImageLocation = null;
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
            this.btnLanche.HoverColor = System.Drawing.Color.Transparent;
            this.btnLanche.Image = global::BurgerShack.Desktop.Properties.Resources.hamburger;
            this.btnLanche.ImageLocation = null;
            this.btnLanche.Location = new System.Drawing.Point(5, 20);
            this.btnLanche.Name = "btnLanche";
            this.btnLanche.Size = new System.Drawing.Size(90, 90);
            this.btnLanche.TabIndex = 0;
            this.btnLanche.Text = "btnUIX1";
            this.btnLanche.UseVisualStyleBackColor = true;
            this.btnLanche.Click += new System.EventHandler(this.btnLanche_Click);
            // 
            // grbDetalhes
            // 
            this.grbDetalhes.Controls.Add(this.lblDetalhes);
            this.grbDetalhes.Location = new System.Drawing.Point(5, 405);
            this.grbDetalhes.Name = "grbDetalhes";
            this.grbDetalhes.Size = new System.Drawing.Size(335, 190);
            this.grbDetalhes.TabIndex = 5;
            this.grbDetalhes.TabStop = false;
            this.grbDetalhes.Text = "DETALHES";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.Location = new System.Drawing.Point(5, 20);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(325, 165);
            this.lblDetalhes.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Description = "Confirmar";
            this.btnConfirmar.HoverColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Image = global::BurgerShack.Desktop.Properties.Resources.confirmar;
            this.btnConfirmar.ImageLocation = null;
            this.btnConfirmar.Location = new System.Drawing.Point(345, 495);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 100);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar Pedido";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // uctPedidoAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grbDetalhes);
            this.Controls.Add(this.grbAdicionarProduto);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedidoAdicionar";
            this.Size = new System.Drawing.Size(450, 600);
            this.Load += new System.EventHandler(this.uctPedidoAdicionar_Load);
            this.grbAdicionarProduto.ResumeLayout(false);
            this.grbProduto.ResumeLayout(false);
            this.grbIngredientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.grbTipo.ResumeLayout(false);
            this.grbDetalhes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdicionarProduto;
        private System.Windows.Forms.GroupBox grbTipo;
        private vitorrdgs.UiX.Component.UIXButton btnLanche;
        private vitorrdgs.UiX.Component.UIXButton btnSobremesa;
        private vitorrdgs.UiX.Component.UIXButton btnBebida;
        private vitorrdgs.UiX.Component.UIXButton btnAcompanhamento;
        private System.Windows.Forms.GroupBox grbDetalhes;
        private System.Windows.Forms.Label lblDetalhes;
        private vitorrdgs.UiX.Component.UIXTextBox txtQuantidade;
        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.Label lblProdutoNome;
        private vitorrdgs.UiX.Component.UIXTextBox txtAdicional;
        private vitorrdgs.UiX.Component.UIXButton btnConfirmar;
        public vitorrdgs.UiX.Component.UIXButton btnAlterar;
        public System.Windows.Forms.GroupBox grbIngredientes;
        private vitorrdgs.UiX.Component.UIXButton btnIngredienteAdd;
        private vitorrdgs.UiX.Component.UIXButton btnIngredientes;
        private System.Windows.Forms.Label lblValor;
    }
}
