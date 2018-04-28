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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.grbProdutoRemover = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new UIX.txtUIX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grbProdutoRemover.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(5, 45);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(410, 549);
            this.dgv.TabIndex = 2;
            // 
            // grbProdutoRemover
            // 
            this.grbProdutoRemover.Controls.Add(this.txtPesquisa);
            this.grbProdutoRemover.Controls.Add(this.dgv);
            this.grbProdutoRemover.Location = new System.Drawing.Point(5, 5);
            this.grbProdutoRemover.Name = "grbProdutoRemover";
            this.grbProdutoRemover.Size = new System.Drawing.Size(420, 600);
            this.grbProdutoRemover.TabIndex = 8;
            this.grbProdutoRemover.TabStop = false;
            this.grbProdutoRemover.Text = "PEDIDOS";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Campo = "ID DO PEDIDO:";
            this.txtPesquisa.Location = new System.Drawing.Point(7, 20);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(408, 24);
            this.txtPesquisa.TabIndex = 3;
            // 
            // uctPedidoListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbProdutoRemover);
            this.Name = "uctPedidoListar";
            this.Size = new System.Drawing.Size(430, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grbProdutoRemover.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox grbProdutoRemover;
        private UIX.txtUIX txtPesquisa;
    }
}
