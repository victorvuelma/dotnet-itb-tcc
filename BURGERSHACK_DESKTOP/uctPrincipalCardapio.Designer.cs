namespace BurgerShack.Desktop
{
    partial class uctPrincipalCardapio
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
            this.txtPesquisa = new vitorrdgs.UiX.Component.UIXTextBox();
            this.rdbLanches = new System.Windows.Forms.RadioButton();
            this.rdbBebidas = new System.Windows.Forms.RadioButton();
            this.grbProdutoRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProdutoRemover
            // 
            this.grbProdutoRemover.Controls.Add(this.rdbBebidas);
            this.grbProdutoRemover.Controls.Add(this.rdbLanches);
            this.grbProdutoRemover.Controls.Add(this.dgvPedidos);
            this.grbProdutoRemover.Controls.Add(this.txtPesquisa);
            this.grbProdutoRemover.Location = new System.Drawing.Point(5, 5);
            this.grbProdutoRemover.Name = "grbProdutoRemover";
            this.grbProdutoRemover.Size = new System.Drawing.Size(420, 600);
            this.grbProdutoRemover.TabIndex = 9;
            this.grbProdutoRemover.TabStop = false;
            this.grbProdutoRemover.Text = "CARDÁPIO";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(10, 66);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(400, 524);
            this.dgvPedidos.TabIndex = 4;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AccessibleName = "NOME DO PRODUTO";
            this.txtPesquisa.Campo = "NOME DO PRODUTO";
            this.txtPesquisa.Location = new System.Drawing.Point(10, 40);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(405, 20);
            this.txtPesquisa.TabIndex = 3;
            // 
            // rdbLanches
            // 
            this.rdbLanches.AutoSize = true;
            this.rdbLanches.Location = new System.Drawing.Point(10, 17);
            this.rdbLanches.Name = "rdbLanches";
            this.rdbLanches.Size = new System.Drawing.Size(75, 17);
            this.rdbLanches.TabIndex = 5;
            this.rdbLanches.TabStop = true;
            this.rdbLanches.Text = "LANCHES";
            this.rdbLanches.UseVisualStyleBackColor = true;
            // 
            // rdbBebidas
            // 
            this.rdbBebidas.AutoSize = true;
            this.rdbBebidas.Location = new System.Drawing.Point(101, 17);
            this.rdbBebidas.Name = "rdbBebidas";
            this.rdbBebidas.Size = new System.Drawing.Size(71, 17);
            this.rdbBebidas.TabIndex = 6;
            this.rdbBebidas.TabStop = true;
            this.rdbBebidas.Text = "BEBIDAS";
            this.rdbBebidas.UseVisualStyleBackColor = true;
            // 
            // uctPedidoCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbProdutoRemover);
            this.Name = "uctPedidoCardapio";
            this.Size = new System.Drawing.Size(430, 610);
            this.grbProdutoRemover.ResumeLayout(false);
            this.grbProdutoRemover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProdutoRemover;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.RadioButton rdbBebidas;
        private System.Windows.Forms.RadioButton rdbLanches;
        private vitorrdgs.UiX.Component.UIXTextBox txtPesquisa;
    }
}
