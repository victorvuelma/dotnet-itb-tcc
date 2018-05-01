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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbPedidoAlterar = new System.Windows.Forms.GroupBox();
            this.grpCarrinho = new System.Windows.Forms.GroupBox();
            this.txtUIX1 = new UIX.txtUIX();
            this.dgvClienteProduto = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new UIX.txtUIX();
            this.txtUIX2 = new UIX.txtUIX();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pnlPreco = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbPedidoAlterar.SuspendLayout();
            this.grpCarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPedidoAlterar
            // 
            this.grbPedidoAlterar.Controls.Add(this.grpCarrinho);
            this.grbPedidoAlterar.Controls.Add(this.txtPesquisa);
            this.grbPedidoAlterar.Controls.Add(this.txtUIX2);
            this.grbPedidoAlterar.Controls.Add(this.ltbProdutos);
            this.grbPedidoAlterar.Controls.Add(this.btnAlterar);
            this.grbPedidoAlterar.Controls.Add(this.pnlPreco);
            this.grbPedidoAlterar.Controls.Add(this.dgvProdutos);
            this.grbPedidoAlterar.Location = new System.Drawing.Point(5, 5);
            this.grbPedidoAlterar.Name = "grbPedidoAlterar";
            this.grbPedidoAlterar.Size = new System.Drawing.Size(420, 600);
            this.grbPedidoAlterar.TabIndex = 6;
            this.grbPedidoAlterar.TabStop = false;
            this.grbPedidoAlterar.Text = "ALTERAR PEDIDO";
            // 
            // grpCarrinho
            // 
            this.grpCarrinho.Controls.Add(this.txtUIX1);
            this.grpCarrinho.Controls.Add(this.dgvClienteProduto);
            this.grpCarrinho.Location = new System.Drawing.Point(10, 256);
            this.grpCarrinho.Name = "grpCarrinho";
            this.grpCarrinho.Size = new System.Drawing.Size(400, 193);
            this.grpCarrinho.TabIndex = 22;
            this.grpCarrinho.TabStop = false;
            this.grpCarrinho.Text = "CARRINHO";
            // 
            // txtUIX1
            // 
            this.txtUIX1.AccessibleName = "NOME DO PRODUTO";
            this.txtUIX1.Campo = "NOME DO PRODUTO";
            this.txtUIX1.Location = new System.Drawing.Point(6, 19);
            this.txtUIX1.MaxLength = 32767;
            this.txtUIX1.Name = "txtUIX1";
            this.txtUIX1.Size = new System.Drawing.Size(396, 20);
            this.txtUIX1.TabIndex = 18;
            // 
            // dgvClienteProduto
            // 
            this.dgvClienteProduto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClienteProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClienteProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClienteProduto.Location = new System.Drawing.Point(6, 45);
            this.dgvClienteProduto.Name = "dgvClienteProduto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClienteProduto.Size = new System.Drawing.Size(391, 142);
            this.dgvClienteProduto.TabIndex = 16;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AccessibleName = "NOME DO PRODUTO";
            this.txtPesquisa.Campo = "NOME DO PRODUTO";
            this.txtPesquisa.Location = new System.Drawing.Point(10, 50);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(400, 20);
            this.txtPesquisa.TabIndex = 20;
            // 
            // txtUIX2
            // 
            this.txtUIX2.AccessibleName = "MESA";
            this.txtUIX2.Campo = "MESA";
            this.txtUIX2.Location = new System.Drawing.Point(10, 20);
            this.txtUIX2.MaxLength = 32767;
            this.txtUIX2.Name = "txtUIX2";
            this.txtUIX2.Size = new System.Drawing.Size(77, 19);
            this.txtUIX2.TabIndex = 21;
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.FormattingEnabled = true;
            this.ltbProdutos.Location = new System.Drawing.Point(10, 455);
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.Size = new System.Drawing.Size(250, 134);
            this.ltbProdutos.TabIndex = 13;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(265, 549);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(145, 40);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar Pedido";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // pnlPreco
            // 
            this.pnlPreco.BackColor = System.Drawing.Color.White;
            this.pnlPreco.Location = new System.Drawing.Point(265, 455);
            this.pnlPreco.Name = "pnlPreco";
            this.pnlPreco.Size = new System.Drawing.Size(145, 90);
            this.pnlPreco.TabIndex = 11;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProdutos.Location = new System.Drawing.Point(10, 80);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(400, 170);
            this.dgvProdutos.TabIndex = 2;
            // 
            // uctPedidoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPedidoAlterar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uctPedidoAlterar";
            this.Size = new System.Drawing.Size(430, 610);
            this.grbPedidoAlterar.ResumeLayout(false);
            this.grpCarrinho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPedidoAlterar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.ListBox ltbProdutos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel pnlPreco;
        private System.Windows.Forms.DataGridView dgvClienteProduto;
        private UIX.txtUIX txtUIX1;
        private UIX.txtUIX txtPesquisa;
        private UIX.txtUIX txtUIX2;
        private System.Windows.Forms.GroupBox grpCarrinho;
    }
}
