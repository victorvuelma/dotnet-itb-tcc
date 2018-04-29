namespace BURGUER_SHACK_DESKTOP
{
    partial class uctProdutoRemover
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPesquisa = new UIX.txtUIX();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pnlPreco = new System.Windows.Forms.Panel();
            this.grbRemoverProduto = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbRemoverProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Campo = "NOME DO PRODUTO";
            this.txtPesquisa.Location = new System.Drawing.Point(10, 20);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(400, 20);
            this.txtPesquisa.TabIndex = 18;
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.FormattingEnabled = true;
            this.ltbProdutos.Location = new System.Drawing.Point(10, 455);
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.Size = new System.Drawing.Size(250, 134);
            this.ltbProdutos.TabIndex = 10;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(270, 550);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(140, 40);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = "Atualizar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(10, 50);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(400, 390);
            this.dgvProdutos.TabIndex = 2;
            // 
            // pnlPreco
            // 
            this.pnlPreco.BackColor = System.Drawing.Color.White;
            this.pnlPreco.Location = new System.Drawing.Point(270, 455);
            this.pnlPreco.Name = "pnlPreco";
            this.pnlPreco.Size = new System.Drawing.Size(140, 90);
            this.pnlPreco.TabIndex = 8;
            // 
            // grbRemoverProduto
            // 
            this.grbRemoverProduto.Controls.Add(this.txtPesquisa);
            this.grbRemoverProduto.Controls.Add(this.ltbProdutos);
            this.grbRemoverProduto.Controls.Add(this.btnPedido);
            this.grbRemoverProduto.Controls.Add(this.dgvProdutos);
            this.grbRemoverProduto.Controls.Add(this.pnlPreco);
            this.grbRemoverProduto.Location = new System.Drawing.Point(5, 5);
            this.grbRemoverProduto.Name = "grbRemoverProduto";
            this.grbRemoverProduto.Size = new System.Drawing.Size(420, 600);
            this.grbRemoverProduto.TabIndex = 6;
            this.grbRemoverProduto.TabStop = false;
            this.grbRemoverProduto.Text = "REMOVER PRODUTO";
            // 
            // uctProdutoRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbRemoverProduto);
            this.Name = "uctProdutoRemover";
            this.Size = new System.Drawing.Size(430, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbRemoverProduto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.txtUIX txtPesquisa;
        private System.Windows.Forms.ListBox ltbProdutos;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Panel pnlPreco;
        private System.Windows.Forms.GroupBox grbRemoverProduto;
    }
}
