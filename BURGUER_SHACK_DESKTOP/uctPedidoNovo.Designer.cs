namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoNovo
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
            this.grbPedidoNovo = new System.Windows.Forms.GroupBox();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pnlPreco = new System.Windows.Forms.Panel();
            this.txtPesquisa = new UIX.txtUIX();
            this.grbPedidoNovo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPedidoNovo
            // 
            this.grbPedidoNovo.Controls.Add(this.txtPesquisa);
            this.grbPedidoNovo.Controls.Add(this.ltbProdutos);
            this.grbPedidoNovo.Controls.Add(this.btnPedido);
            this.grbPedidoNovo.Controls.Add(this.dgvProdutos);
            this.grbPedidoNovo.Controls.Add(this.pnlPreco);
            this.grbPedidoNovo.Location = new System.Drawing.Point(5, 5);
            this.grbPedidoNovo.Name = "grbPedidoNovo";
            this.grbPedidoNovo.Size = new System.Drawing.Size(420, 600);
            this.grbPedidoNovo.TabIndex = 5;
            this.grbPedidoNovo.TabStop = false;
            this.grbPedidoNovo.Text = "NOVO PEDIDO";
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.FormattingEnabled = true;
            this.ltbProdutos.Location = new System.Drawing.Point(5, 455);
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.Size = new System.Drawing.Size(260, 134);
            this.ltbProdutos.TabIndex = 10;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(271, 550);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(144, 38);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = "Confirmar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(5, 50);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(410, 387);
            this.dgvProdutos.TabIndex = 2;
            // 
            // pnlPreco
            // 
            this.pnlPreco.BackColor = System.Drawing.Color.White;
            this.pnlPreco.Location = new System.Drawing.Point(271, 455);
            this.pnlPreco.Name = "pnlPreco";
            this.pnlPreco.Size = new System.Drawing.Size(144, 90);
            this.pnlPreco.TabIndex = 8;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Campo = "NOME DO PRODUTO:";
            this.txtPesquisa.Location = new System.Drawing.Point(5, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(410, 20);
            this.txtPesquisa.TabIndex = 18;
            // 
            // uctPedidoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grbPedidoNovo);
            this.Name = "uctPedidoNovo";
            this.Size = new System.Drawing.Size(430, 610);
            this.grbPedidoNovo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPedidoNovo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.ListBox ltbProdutos;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Panel pnlPreco;
        private UIX.txtUIX txtPesquisa;
    }
}
