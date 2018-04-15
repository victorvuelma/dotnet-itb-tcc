namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoAlterar
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
            this.grbPedidoAlterar = new System.Windows.Forms.GroupBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvClienteProdutos = new System.Windows.Forms.DataGridView();
            this.lblNomeProduto2 = new System.Windows.Forms.Label();
            this.txtPesquisa2 = new System.Windows.Forms.TextBox();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.pnlPreco = new System.Windows.Forms.Panel();
            this.grbPedidoAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPedidoAlterar
            // 
            this.grbPedidoAlterar.Controls.Add(this.ltbProdutos);
            this.grbPedidoAlterar.Controls.Add(this.pnlPreco);
            this.grbPedidoAlterar.Controls.Add(this.dgvClienteProdutos);
            this.grbPedidoAlterar.Controls.Add(this.lblNomeProduto2);
            this.grbPedidoAlterar.Controls.Add(this.txtPesquisa2);
            this.grbPedidoAlterar.Controls.Add(this.btnPedido);
            this.grbPedidoAlterar.Controls.Add(this.dgvProdutos);
            this.grbPedidoAlterar.Controls.Add(this.lblNomeProduto);
            this.grbPedidoAlterar.Controls.Add(this.txtPesquisa);
            this.grbPedidoAlterar.Location = new System.Drawing.Point(5, 5);
            this.grbPedidoAlterar.Name = "grbPedidoAlterar";
            this.grbPedidoAlterar.Size = new System.Drawing.Size(423, 597);
            this.grbPedidoAlterar.TabIndex = 6;
            this.grbPedidoAlterar.TabStop = false;
            this.grbPedidoAlterar.Text = "NOVO PEDIDO";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(271, 550);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(144, 38);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = "Alterar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 50);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(409, 164);
            this.dgvProdutos.TabIndex = 2;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(6, 23);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(118, 13);
            this.lblNomeProduto.TabIndex = 1;
            this.lblNomeProduto.Text = "NOME DO PRODUTO:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(144, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(270, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // dgvClienteProdutos
            // 
            this.dgvClienteProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvClienteProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteProdutos.Location = new System.Drawing.Point(6, 287);
            this.dgvClienteProdutos.Name = "dgvClienteProdutos";
            this.dgvClienteProdutos.Size = new System.Drawing.Size(408, 164);
            this.dgvClienteProdutos.TabIndex = 12;
            // 
            // lblNomeProduto2
            // 
            this.lblNomeProduto2.AutoSize = true;
            this.lblNomeProduto2.Location = new System.Drawing.Point(6, 261);
            this.lblNomeProduto2.Name = "lblNomeProduto2";
            this.lblNomeProduto2.Size = new System.Drawing.Size(118, 13);
            this.lblNomeProduto2.TabIndex = 11;
            this.lblNomeProduto2.Text = "NOME DO PRODUTO:";
            // 
            // txtPesquisa2
            // 
            this.txtPesquisa2.Location = new System.Drawing.Point(144, 261);
            this.txtPesquisa2.Name = "txtPesquisa2";
            this.txtPesquisa2.Size = new System.Drawing.Size(270, 20);
            this.txtPesquisa2.TabIndex = 10;
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.FormattingEnabled = true;
            this.ltbProdutos.Location = new System.Drawing.Point(9, 467);
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.Size = new System.Drawing.Size(260, 121);
            this.ltbProdutos.TabIndex = 14;
            // 
            // pnlPreco
            // 
            this.pnlPreco.BackColor = System.Drawing.Color.White;
            this.pnlPreco.Location = new System.Drawing.Point(275, 468);
            this.pnlPreco.Name = "pnlPreco";
            this.pnlPreco.Size = new System.Drawing.Size(140, 75);
            this.pnlPreco.TabIndex = 13;
            // 
            // uctPedidoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPedidoAlterar);
            this.Name = "uctPedidoAlterar";
            this.Size = new System.Drawing.Size(433, 606);
            this.grbPedidoAlterar.ResumeLayout(false);
            this.grbPedidoAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPedidoAlterar;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvClienteProdutos;
        private System.Windows.Forms.Label lblNomeProduto2;
        private System.Windows.Forms.TextBox txtPesquisa2;
        private System.Windows.Forms.ListBox ltbProdutos;
        private System.Windows.Forms.Panel pnlPreco;
    }
}
