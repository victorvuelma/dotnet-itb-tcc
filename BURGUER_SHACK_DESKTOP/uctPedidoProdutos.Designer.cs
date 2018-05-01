namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoProdutos
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
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.dgvAdicionarProdutos = new System.Windows.Forms.DataGridView();
            this.grbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.dgvAdicionarProdutos);
            this.grbProdutos.Location = new System.Drawing.Point(5, 5);
            this.grbProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProdutos.Size = new System.Drawing.Size(490, 730);
            this.grbProdutos.TabIndex = 5;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "PRODUTOS";
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
            // dgvAdicionarProdutos
            // 
            this.dgvAdicionarProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdicionarProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionarProdutos.Location = new System.Drawing.Point(5, 20);
            this.dgvAdicionarProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAdicionarProdutos.Name = "dgvAdicionarProdutos";
            this.dgvAdicionarProdutos.Size = new System.Drawing.Size(480, 700);
            this.dgvAdicionarProdutos.TabIndex = 2;
            // 
            // uctPedidoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.grbProdutos);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedidoNovo";
            this.Size = new System.Drawing.Size(500, 800);
            this.grbProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.DataGridView dgvAdicionarProdutos;
        private System.Windows.Forms.Button btnPedido;
    }
}
