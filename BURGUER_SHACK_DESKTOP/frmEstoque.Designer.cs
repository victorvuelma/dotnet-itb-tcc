namespace BURGUER_SHACK_DESKTOP
{
    partial class frmEstoque
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hdrUIX = new UIX.hdrUIX();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnUIX1 = new UIX.btnUIX();
            this.btnProduto = new UIX.btnUIX();
            this.btnSorvetes = new UIX.btnUIX();
            this.btnSobremesas = new UIX.btnUIX();
            this.btnBebidas = new UIX.btnUIX();
            this.btnIngredientes = new UIX.btnUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.ckbIndisponivel = new System.Windows.Forms.CheckBox();
            this.txtPesquisa = new UIX.txtUIX();
            this.columnProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButtons.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = true;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.estoque;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(932, 50);
            this.hdrUIX.TabIndex = 1;
            this.hdrUIX.Title = "Estoque";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            this.hdrUIX.Min += new System.EventHandler(this.hdrUIX_Min);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnUIX1);
            this.pnlButtons.Controls.Add(this.btnProduto);
            this.pnlButtons.Controls.Add(this.btnSorvetes);
            this.pnlButtons.Controls.Add(this.btnSobremesas);
            this.pnlButtons.Controls.Add(this.btnBebidas);
            this.pnlButtons.Controls.Add(this.btnIngredientes);
            this.pnlButtons.Location = new System.Drawing.Point(73, 51);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(518, 90);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnUIX1
            // 
            this.btnUIX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUIX1.Description = "Lanche";
            this.btnUIX1.HoverColor = System.Drawing.Color.Transparent;
            this.btnUIX1.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lanche;
            this.btnUIX1.Location = new System.Drawing.Point(5, 5);
            this.btnUIX1.Name = "btnUIX1";
            this.btnUIX1.Size = new System.Drawing.Size(80, 80);
            this.btnUIX1.TabIndex = 12;
            this.btnUIX1.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            this.btnProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduto.Description = "Produto";
            this.btnProduto.HoverColor = System.Drawing.Color.Transparent;
            this.btnProduto.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.produto;
            this.btnProduto.Location = new System.Drawing.Point(91, 5);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(80, 80);
            this.btnProduto.TabIndex = 11;
            this.btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnSorvetes
            // 
            this.btnSorvetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSorvetes.Description = "Sorvetes";
            this.btnSorvetes.HoverColor = System.Drawing.Color.Transparent;
            this.btnSorvetes.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sorvete;
            this.btnSorvetes.Location = new System.Drawing.Point(349, 5);
            this.btnSorvetes.Name = "btnSorvetes";
            this.btnSorvetes.Size = new System.Drawing.Size(80, 80);
            this.btnSorvetes.TabIndex = 10;
            this.btnSorvetes.UseVisualStyleBackColor = true;
            // 
            // btnSobremesas
            // 
            this.btnSobremesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSobremesas.Description = "Sobremesas";
            this.btnSobremesas.HoverColor = System.Drawing.Color.Transparent;
            this.btnSobremesas.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.batatas2;
            this.btnSobremesas.Location = new System.Drawing.Point(263, 5);
            this.btnSobremesas.Name = "btnSobremesas";
            this.btnSobremesas.Size = new System.Drawing.Size(80, 80);
            this.btnSobremesas.TabIndex = 9;
            this.btnSobremesas.UseVisualStyleBackColor = true;
            // 
            // btnBebidas
            // 
            this.btnBebidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBebidas.Description = "Bebidas";
            this.btnBebidas.HoverColor = System.Drawing.Color.Transparent;
            this.btnBebidas.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.bebida2;
            this.btnBebidas.Location = new System.Drawing.Point(177, 5);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(80, 80);
            this.btnBebidas.TabIndex = 8;
            this.btnBebidas.UseVisualStyleBackColor = true;
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngredientes.Description = "Ingredientes";
            this.btnIngredientes.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngredientes.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.ingrediente1;
            this.btnIngredientes.Location = new System.Drawing.Point(435, 5);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(80, 80);
            this.btnIngredientes.TabIndex = 7;
            this.btnIngredientes.UseVisualStyleBackColor = true;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.dgvProdutos);
            this.pnlConteudo.Location = new System.Drawing.Point(7, 143);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(918, 445);
            this.pnlConteudo.TabIndex = 3;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProduto,
            this.columnQuantidade,
            this.VALOR});
            this.dgvProdutos.Location = new System.Drawing.Point(3, 4);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(910, 437);
            this.dgvProdutos.TabIndex = 3;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.ckbIndisponivel);
            this.pnlFiltro.Controls.Add(this.txtPesquisa);
            this.pnlFiltro.Location = new System.Drawing.Point(597, 51);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(323, 90);
            this.pnlFiltro.TabIndex = 4;
            // 
            // ckbIndisponivel
            // 
            this.ckbIndisponivel.AutoSize = true;
            this.ckbIndisponivel.Location = new System.Drawing.Point(3, 31);
            this.ckbIndisponivel.Name = "ckbIndisponivel";
            this.ckbIndisponivel.Size = new System.Drawing.Size(63, 17);
            this.ckbIndisponivel.TabIndex = 0;
            this.ckbIndisponivel.Text = "Inativos";
            this.ckbIndisponivel.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AccessibleName = "Pesquisar";
            this.txtPesquisa.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtPesquisa.Campo = "Pesquisar";
            this.txtPesquisa.Location = new System.Drawing.Point(3, 5);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(182, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // columnProduto
            // 
            this.columnProduto.HeaderText = "PRODUTO";
            this.columnProduto.Name = "columnProduto";
            // 
            // columnQuantidade
            // 
            this.columnQuantidade.HeaderText = "QUANTIDADE";
            this.columnQuantidade.Name = "columnQuantidade";
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 600);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel pnlButtons;
        private UIX.btnUIX btnSorvetes;
        private UIX.btnUIX btnSobremesas;
        private UIX.btnUIX btnBebidas;
        private UIX.btnUIX btnIngredientes;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlFiltro;
        private UIX.txtUIX txtPesquisa;
        private System.Windows.Forms.CheckBox ckbIndisponivel;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private UIX.btnUIX btnProduto;
        private UIX.btnUIX btnUIX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
    }
}