namespace BURGUER_SHACK_DESKTOP
{
    partial class uctGerenDGV
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
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.PIC = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvTercerizada = new System.Windows.Forms.DataGridView();
            this.razaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.hdrUIX = new UIX.hdrUIX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTercerizada)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.Cargo,
            this.Salario});
            this.dgvFuncionario.Location = new System.Drawing.Point(664, 395);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.Size = new System.Drawing.Size(100, 100);
            this.dgvFuncionario.TabIndex = 3;
            this.dgvFuncionario.Visible = false;
            // 
            // Código
            // 
            this.Código.HeaderText = "COD";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "CARGO";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "SALÁRIO";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIC});
            this.dgvProduto.Location = new System.Drawing.Point(508, 324);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(100, 100);
            this.dgvProduto.TabIndex = 5;
            this.dgvProduto.Visible = false;
            // 
            // PIC
            // 
            this.PIC.HeaderText = "IMAGEM";
            this.PIC.Name = "PIC";
            // 
            // dgvTercerizada
            // 
            this.dgvTercerizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTercerizada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.razaoSocial});
            this.dgvTercerizada.Location = new System.Drawing.Point(628, 172);
            this.dgvTercerizada.Name = "dgvTercerizada";
            this.dgvTercerizada.Size = new System.Drawing.Size(100, 100);
            this.dgvTercerizada.TabIndex = 4;
            this.dgvTercerizada.Visible = false;
            // 
            // razaoSocial
            // 
            this.razaoSocial.HeaderText = "RAZÃO SOCIAL";
            this.razaoSocial.Name = "razaoSocial";
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.dgvProduto);
            this.pnlConteudo.Controls.Add(this.dgvFuncionario);
            this.pnlConteudo.Controls.Add(this.hdrUIX);
            this.pnlConteudo.Controls.Add(this.dgvTercerizada);
            this.pnlConteudo.Location = new System.Drawing.Point(3, 3);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(812, 532);
            this.pnlConteudo.TabIndex = 6;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = true;
            this.hdrUIX.Image = null;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(250, 50);
            this.hdrUIX.TabIndex = 6;
            this.hdrUIX.Title = "Título";
            this.hdrUIX.Visible = false;
            // 
            // uctGerenDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConteudo);
            this.Name = "uctGerenDGV";
            this.Size = new System.Drawing.Size(907, 538);
            this.Load += new System.EventHandler(this.uctGerenDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTercerizada)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        public System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridViewImageColumn PIC;
        public System.Windows.Forms.DataGridView dgvTercerizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocial;
        private System.Windows.Forms.Panel pnlConteudo;
        private UIX.hdrUIX hdrUIX;
    }
}
