namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoListar
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
            this.grbProdutoRemover = new System.Windows.Forms.GroupBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.txtUIX2 = new UIX.txtUIX();
            this.grbProdutoRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProdutoRemover
            // 
            this.grbProdutoRemover.Controls.Add(this.txtUIX2);
            this.grbProdutoRemover.Controls.Add(this.dgvPedidos);
            this.grbProdutoRemover.Location = new System.Drawing.Point(5, 5);
            this.grbProdutoRemover.Name = "grbProdutoRemover";
            this.grbProdutoRemover.Size = new System.Drawing.Size(420, 600);
            this.grbProdutoRemover.TabIndex = 8;
            this.grbProdutoRemover.TabStop = false;
            this.grbProdutoRemover.Text = "PEDIDOS";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(10, 50);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(400, 540);
            this.dgvPedidos.TabIndex = 4;
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
            // uctPedidoListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbProdutoRemover);
            this.Name = "uctPedidoListar";
            this.Size = new System.Drawing.Size(430, 610);
            this.grbProdutoRemover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbProdutoRemover;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private UIX.txtUIX txtUIX2;
    }
}
