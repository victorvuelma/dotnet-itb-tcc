namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoProdutoDetalhes
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
            this.grbDetalhes = new System.Windows.Forms.GroupBox();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.columnIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtQuantidade = new UIX.txtUIX();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetalhes
            // 
            this.grbDetalhes.Controls.Add(this.dgvIngredientes);
            this.grbDetalhes.Location = new System.Drawing.Point(5, 30);
            this.grbDetalhes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDetalhes.Name = "grbDetalhes";
            this.grbDetalhes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDetalhes.Size = new System.Drawing.Size(390, 320);
            this.grbDetalhes.TabIndex = 5;
            this.grbDetalhes.TabStop = false;
            this.grbDetalhes.Text = "INGREDIENTES";
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToResizeColumns = false;
            this.dgvIngredientes.AllowUserToResizeRows = false;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIngrediente,
            this.columnQuantidade});
            this.dgvIngredientes.Location = new System.Drawing.Point(5, 30);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.Size = new System.Drawing.Size(380, 280);
            this.dgvIngredientes.TabIndex = 2;
            // 
            // columnIngrediente
            // 
            this.columnIngrediente.HeaderText = "INGREDIENTE";
            this.columnIngrediente.Name = "columnIngrediente";
            // 
            // columnQuantidade
            // 
            this.columnQuantidade.HeaderText = "QUANTIDADE";
            this.columnQuantidade.Name = "columnQuantidade";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(290, 360);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.AllowedChars = UIX.uixAllowedChars.INT;
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.Location = new System.Drawing.Point(5, 5);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(390, 25);
            this.txtQuantidade.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(10, 360);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 30);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // uctPedidoProdutoDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grbDetalhes);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedidoProdutoDetalhes";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.uctPedidoProdutoDetalhes_Load);
            this.grbDetalhes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetalhes;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.Button btnConfirmar;
        private UIX.txtUIX txtQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantidade;
    }
}
