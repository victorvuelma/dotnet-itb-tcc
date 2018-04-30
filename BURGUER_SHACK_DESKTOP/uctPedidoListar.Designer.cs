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
            this.txtPesquisa = new UIX.txtUIX();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.grbProdutoRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProdutoRemover
            // 
            this.grbProdutoRemover.Controls.Add(this.dgvPedidos);
            this.grbProdutoRemover.Controls.Add(this.txtPesquisa);
            this.grbProdutoRemover.Location = new System.Drawing.Point(5, 5);
            this.grbProdutoRemover.Name = "grbProdutoRemover";
            this.grbProdutoRemover.Size = new System.Drawing.Size(420, 600);
            this.grbProdutoRemover.TabIndex = 8;
            this.grbProdutoRemover.TabStop = false;
            this.grbProdutoRemover.Text = "PEDIDOS";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AccessibleName = "ID DO PEDIDO";
            this.txtPesquisa.Campo = "ID DO PEDIDO";
            this.txtPesquisa.Location = new System.Drawing.Point(10, 20);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(400, 20);
            this.txtPesquisa.TabIndex = 3;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(10, 50);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(400, 540);
            this.dgvPedidos.TabIndex = 4;
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
        private UIX.txtUIX txtPesquisa;
        private System.Windows.Forms.DataGridView dgvPedidos;
    }
}
