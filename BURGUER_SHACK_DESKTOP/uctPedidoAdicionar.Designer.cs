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
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.txtProdutoPesquisar = new UIX.txtUIX();
            this.btnProdutoPesquisar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnSobremesa = new UIX.btnUIX();
            this.btnBebida = new UIX.btnUIX();
            this.btnAcompanhamento = new UIX.btnUIX();
            this.btnLanche = new UIX.btnUIX();
            this.grbAdicionarProduto.SuspendLayout();
            this.grbTipo.SuspendLayout();
            this.grbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
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
            this.grbAdicionarProduto.Size = new System.Drawing.Size(490, 730);
            this.grbAdicionarProduto.TabIndex = 5;
            this.grbAdicionarProduto.TabStop = false;
            this.grbAdicionarProduto.Text = "ADICIONAR PRODUTO";
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.btnSobremesa);
            this.grbTipo.Controls.Add(this.btnBebida);
            this.grbTipo.Controls.Add(this.btnAcompanhamento);
            this.grbTipo.Controls.Add(this.btnLanche);
            this.grbTipo.Location = new System.Drawing.Point(5, 20);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(480, 130);
            this.grbTipo.TabIndex = 0;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "TIPO DO PRODUTO";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(345, 745);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(150, 50);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = "Confirmar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.dgvProdutos);
            this.grbProduto.Controls.Add(this.btnProdutoPesquisar);
            this.grbProduto.Controls.Add(this.txtProdutoPesquisar);
            this.grbProduto.Location = new System.Drawing.Point(5, 160);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(480, 270);
            this.grbProduto.TabIndex = 4;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "SELECIONE O PRODUTO";
            // 
            // txtProdutoPesquisar
            // 
            this.txtProdutoPesquisar.AccessibleName = "Produto";
            this.txtProdutoPesquisar.Campo = "Produto";
            this.txtProdutoPesquisar.Location = new System.Drawing.Point(10, 20);
            this.txtProdutoPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdutoPesquisar.MaxLength = 32767;
            this.txtProdutoPesquisar.Name = "txtProdutoPesquisar";
            this.txtProdutoPesquisar.Size = new System.Drawing.Size(350, 22);
            this.txtProdutoPesquisar.TabIndex = 0;
            // 
            // btnProdutoPesquisar
            // 
            this.btnProdutoPesquisar.Location = new System.Drawing.Point(370, 20);
            this.btnProdutoPesquisar.Name = "btnProdutoPesquisar";
            this.btnProdutoPesquisar.Size = new System.Drawing.Size(100, 22);
            this.btnProdutoPesquisar.TabIndex = 1;
            this.btnProdutoPesquisar.Text = "Pesquisar";
            this.btnProdutoPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(10, 50);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(460, 210);
            this.dgvProdutos.TabIndex = 2;
            // 
            // btnSobremesa
            // 
            this.btnSobremesa.Description = "Sobremesa";
            this.btnSobremesa.HoverColor = System.Drawing.Color.Transparent;
            this.btnSobremesa.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sobremesa;
            this.btnSobremesa.Location = new System.Drawing.Point(370, 20);
            this.btnSobremesa.Name = "btnSobremesa";
            this.btnSobremesa.Size = new System.Drawing.Size(100, 100);
            this.btnSobremesa.TabIndex = 3;
            this.btnSobremesa.Text = "btnUIX3";
            this.btnSobremesa.UseVisualStyleBackColor = true;
            // 
            // btnBebida
            // 
            this.btnBebida.Description = "Bebida";
            this.btnBebida.HoverColor = System.Drawing.Color.Transparent;
            this.btnBebida.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.bebida;
            this.btnBebida.Location = new System.Drawing.Point(250, 20);
            this.btnBebida.Name = "btnBebida";
            this.btnBebida.Size = new System.Drawing.Size(100, 100);
            this.btnBebida.TabIndex = 2;
            this.btnBebida.Text = "btnUIX2";
            this.btnBebida.UseVisualStyleBackColor = true;
            // 
            // btnAcompanhamento
            // 
            this.btnAcompanhamento.Description = "Acompanhamento";
            this.btnAcompanhamento.Font = new System.Drawing.Font("Century Gothic", 6.75F);
            this.btnAcompanhamento.HoverColor = System.Drawing.Color.Transparent;
            this.btnAcompanhamento.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.batatas;
            this.btnAcompanhamento.Location = new System.Drawing.Point(130, 20);
            this.btnAcompanhamento.Name = "btnAcompanhamento";
            this.btnAcompanhamento.Size = new System.Drawing.Size(100, 100);
            this.btnAcompanhamento.TabIndex = 1;
            this.btnAcompanhamento.Text = "btnUIX1";
            this.btnAcompanhamento.UseVisualStyleBackColor = true;
            // 
            // btnLanche
            // 
            this.btnLanche.Description = "Lanche";
            this.btnLanche.HoverColor = System.Drawing.Color.Transparent;
            this.btnLanche.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.hamburger;
            this.btnLanche.Location = new System.Drawing.Point(10, 20);
            this.btnLanche.Name = "btnLanche";
            this.btnLanche.Size = new System.Drawing.Size(100, 100);
            this.btnLanche.TabIndex = 0;
            this.btnLanche.Text = "btnUIX1";
            this.btnLanche.UseVisualStyleBackColor = true;
            // 
            // uctPedidoAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.grbAdicionarProduto);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedidoAdicionar";
            this.Size = new System.Drawing.Size(500, 800);
            this.grbAdicionarProduto.ResumeLayout(false);
            this.grbTipo.ResumeLayout(false);
            this.grbProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdicionarProduto;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.GroupBox grbTipo;
        private UIX.btnUIX btnLanche;
        private UIX.btnUIX btnSobremesa;
        private UIX.btnUIX btnBebida;
        private UIX.btnUIX btnAcompanhamento;
        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.Button btnProdutoPesquisar;
        private UIX.txtUIX txtProdutoPesquisar;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}
