namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoRemover
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbProdutoRemover = new System.Windows.Forms.GroupBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.txtUIX2 = new UIX.txtUIX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbProdutoRemover.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(10, 50);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(400, 495);
            this.dgvProdutos.TabIndex = 2;
            // 
            // grbProdutoRemover
            // 
            this.grbProdutoRemover.Controls.Add(this.txtUIX2);
            this.grbProdutoRemover.Controls.Add(this.btnPedido);
            this.grbProdutoRemover.Controls.Add(this.dgvProdutos);
            this.grbProdutoRemover.Location = new System.Drawing.Point(5, 5);
            this.grbProdutoRemover.Name = "grbProdutoRemover";
            this.grbProdutoRemover.Size = new System.Drawing.Size(420, 600);
            this.grbProdutoRemover.TabIndex = 7;
            this.grbProdutoRemover.TabStop = false;
            this.grbProdutoRemover.Text = "APAGAR PEDIDO";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(260, 555);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(150, 40);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = "Apagar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // txtUIX2
            // 
            this.txtUIX2.AccessibleName = "MESA";
            this.txtUIX2.Campo = "MESA";
            this.txtUIX2.Location = new System.Drawing.Point(10, 19);
            this.txtUIX2.MaxLength = 32767;
            this.txtUIX2.Name = "txtUIX2";
            this.txtUIX2.Size = new System.Drawing.Size(77, 19);
            this.txtUIX2.TabIndex = 22;
            // 
            // uctPedidoRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbProdutoRemover);
            this.Name = "uctPedidoRemover";
            this.Size = new System.Drawing.Size(430, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbProdutoRemover.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbProdutoRemover;
        private System.Windows.Forms.Button btnPedido;
        private UIX.txtUIX txtUIX2;
    }
}
