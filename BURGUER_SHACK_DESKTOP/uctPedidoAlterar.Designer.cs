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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbPedidoAlterar = new System.Windows.Forms.GroupBox();
            this.txtUIX1 = new UIX.txtUIX();
            this.txtPesquisa = new UIX.txtUIX();
            this.dgvClienteProduto = new System.Windows.Forms.DataGridView();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pnlPreco = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbPedidoAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPedidoAlterar
            // 
            this.grbPedidoAlterar.Controls.Add(this.txtUIX1);
            this.grbPedidoAlterar.Controls.Add(this.txtPesquisa);
            this.grbPedidoAlterar.Controls.Add(this.dgvClienteProduto);
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
            // txtUIX1
            // 
            this.txtUIX1.Campo = "NOME DO PRODUTO:";
            this.txtUIX1.Location = new System.Drawing.Point(10, 245);
            this.txtUIX1.MaxLength = 32767;
            this.txtUIX1.Name = "txtUIX1";
            this.txtUIX1.Size = new System.Drawing.Size(400, 20);
            this.txtUIX1.TabIndex = 18;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Campo = "NOME DO PRODUTO:";
            this.txtPesquisa.Location = new System.Drawing.Point(10, 20);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(400, 20);
            this.txtPesquisa.TabIndex = 17;
            // 
            // dgvClienteProduto
            // 
            this.dgvClienteProduto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClienteProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClienteProduto.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClienteProduto.Location = new System.Drawing.Point(10, 275);
            this.dgvClienteProduto.Name = "dgvClienteProduto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClienteProduto.Size = new System.Drawing.Size(400, 170);
            this.dgvClienteProduto.TabIndex = 16;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProdutos.Location = new System.Drawing.Point(10, 50);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(400, 180);
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
    }
}
