namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedido
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
            this.pnlFuncoes = new System.Windows.Forms.Panel();
            this.pnlPreco = new System.Windows.Forms.Panel();
            this.btnPedido = new System.Windows.Forms.Button();
            this.grbAdicionarItens = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbAlterarItens = new System.Windows.Forms.GroupBox();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvProdutos2 = new System.Windows.Forms.DataGridView();
            this.lblNomeProduto2 = new System.Windows.Forms.Label();
            this.txtPesquisar2 = new System.Windows.Forms.TextBox();
            this.grbRemoverProduto = new System.Windows.Forms.GroupBox();
            this.dgvCarrinho2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesquisar3 = new System.Windows.Forms.TextBox();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpListaPedidos = new System.Windows.Forms.GroupBox();
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.pnlFuncoes.SuspendLayout();
            this.grbAdicionarItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbAlterarItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos2)).BeginInit();
            this.grbRemoverProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho2)).BeginInit();
            this.grpListaPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFuncoes
            // 
            this.pnlFuncoes.Controls.Add(this.btnPedidos);
            this.pnlFuncoes.Controls.Add(this.btnLogout);
            this.pnlFuncoes.Controls.Add(this.btnMenu);
            this.pnlFuncoes.Controls.Add(this.btnRemover);
            this.pnlFuncoes.Controls.Add(this.btnAlterar);
            this.pnlFuncoes.Controls.Add(this.btnAdicionar);
            this.pnlFuncoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFuncoes.Location = new System.Drawing.Point(0, 0);
            this.pnlFuncoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFuncoes.Name = "pnlFuncoes";
            this.pnlFuncoes.Size = new System.Drawing.Size(64, 649);
            this.pnlFuncoes.TabIndex = 1;
            // 
            // pnlPreco
            // 
            this.pnlPreco.BackColor = System.Drawing.Color.White;
            this.pnlPreco.Location = new System.Drawing.Point(340, 526);
            this.pnlPreco.Name = "pnlPreco";
            this.pnlPreco.Size = new System.Drawing.Size(153, 75);
            this.pnlPreco.TabIndex = 2;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(340, 604);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(153, 38);
            this.btnPedido.TabIndex = 3;
            this.btnPedido.Text = "Confirmar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // grbAdicionarItens
            // 
            this.grbAdicionarItens.Controls.Add(this.dgvProdutos);
            this.grbAdicionarItens.Controls.Add(this.label1);
            this.grbAdicionarItens.Controls.Add(this.txtPesquisa);
            this.grbAdicionarItens.Location = new System.Drawing.Point(497, 146);
            this.grbAdicionarItens.Name = "grbAdicionarItens";
            this.grbAdicionarItens.Size = new System.Drawing.Size(423, 130);
            this.grbAdicionarItens.TabIndex = 4;
            this.grbAdicionarItens.TabStop = false;
            this.grbAdicionarItens.Text = "ADICIONAR ITENS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME DO PRODUTO:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(144, 23);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(273, 21);
            this.txtPesquisa.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 47);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(411, 457);
            this.dgvProdutos.TabIndex = 2;
            // 
            // grbAlterarItens
            // 
            this.grbAlterarItens.Controls.Add(this.dgvProdutos2);
            this.grbAlterarItens.Controls.Add(this.lblNomeProduto2);
            this.grbAlterarItens.Controls.Add(this.txtPesquisar2);
            this.grbAlterarItens.Controls.Add(this.dgvCarrinho);
            this.grbAlterarItens.Controls.Add(this.lblNomeProduto);
            this.grbAlterarItens.Controls.Add(this.txtPesquisar);
            this.grbAlterarItens.Location = new System.Drawing.Point(497, 282);
            this.grbAlterarItens.Name = "grbAlterarItens";
            this.grbAlterarItens.Size = new System.Drawing.Size(423, 130);
            this.grbAlterarItens.TabIndex = 5;
            this.grbAlterarItens.TabStop = false;
            this.grbAlterarItens.Text = "ALTERAR PEDIDO";
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Location = new System.Drawing.Point(6, 47);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.Size = new System.Drawing.Size(411, 199);
            this.dgvCarrinho.TabIndex = 2;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(6, 23);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(125, 16);
            this.lblNomeProduto.TabIndex = 1;
            this.lblNomeProduto.Text = "NOME DO PRODUTO:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(144, 23);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(273, 21);
            this.txtPesquisar.TabIndex = 0;
            // 
            // dgvProdutos2
            // 
            this.dgvProdutos2.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos2.Location = new System.Drawing.Point(6, 305);
            this.dgvProdutos2.Name = "dgvProdutos2";
            this.dgvProdutos2.Size = new System.Drawing.Size(411, 199);
            this.dgvProdutos2.TabIndex = 5;
            // 
            // lblNomeProduto2
            // 
            this.lblNomeProduto2.AutoSize = true;
            this.lblNomeProduto2.Location = new System.Drawing.Point(6, 281);
            this.lblNomeProduto2.Name = "lblNomeProduto2";
            this.lblNomeProduto2.Size = new System.Drawing.Size(125, 16);
            this.lblNomeProduto2.TabIndex = 4;
            this.lblNomeProduto2.Text = "NOME DO PRODUTO:";
            // 
            // txtPesquisar2
            // 
            this.txtPesquisar2.Location = new System.Drawing.Point(144, 281);
            this.txtPesquisar2.Name = "txtPesquisar2";
            this.txtPesquisar2.Size = new System.Drawing.Size(273, 21);
            this.txtPesquisar2.TabIndex = 3;
            // 
            // grbRemoverProduto
            // 
            this.grbRemoverProduto.Controls.Add(this.dgvCarrinho2);
            this.grbRemoverProduto.Controls.Add(this.label3);
            this.grbRemoverProduto.Controls.Add(this.txtPesquisar3);
            this.grbRemoverProduto.Location = new System.Drawing.Point(497, 10);
            this.grbRemoverProduto.Name = "grbRemoverProduto";
            this.grbRemoverProduto.Size = new System.Drawing.Size(423, 130);
            this.grbRemoverProduto.TabIndex = 6;
            this.grbRemoverProduto.TabStop = false;
            this.grbRemoverProduto.Text = "REMOVER PRODUTO";
            // 
            // dgvCarrinho2
            // 
            this.dgvCarrinho2.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrinho2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho2.Location = new System.Drawing.Point(6, 47);
            this.dgvCarrinho2.Name = "dgvCarrinho2";
            this.dgvCarrinho2.Size = new System.Drawing.Size(411, 457);
            this.dgvCarrinho2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOME DO PRODUTO:";
            // 
            // txtPesquisar3
            // 
            this.txtPesquisar3.Location = new System.Drawing.Point(144, 23);
            this.txtPesquisar3.Name = "txtPesquisar3";
            this.txtPesquisar3.Size = new System.Drawing.Size(273, 21);
            this.txtPesquisar3.TabIndex = 0;
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.FormattingEnabled = true;
            this.ltbProdutos.ItemHeight = 16;
            this.ltbProdutos.Location = new System.Drawing.Point(74, 526);
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.Size = new System.Drawing.Size(260, 116);
            this.ltbProdutos.TabIndex = 7;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pedidos;
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.Location = new System.Drawing.Point(2, 290);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(60, 60);
            this.btnPedidos.TabIndex = 7;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(2, 582);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Location = new System.Drawing.Point(2, 10);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemover.Location = new System.Drawing.Point(2, 220);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(60, 60);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(2, 150);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 60);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Location = new System.Drawing.Point(2, 80);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(60, 60);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.FillWeight = 200F;
            this.dataGridViewImageColumn1.HeaderText = "TESTE 1";
            this.dataGridViewImageColumn1.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.hamburger;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grpListaPedidos
            // 
            this.grpListaPedidos.Controls.Add(this.dgvListaPedidos);
            this.grpListaPedidos.Controls.Add(this.lblIdPedido);
            this.grpListaPedidos.Controls.Add(this.txtIdPedido);
            this.grpListaPedidos.Location = new System.Drawing.Point(70, 10);
            this.grpListaPedidos.Name = "grpListaPedidos";
            this.grpListaPedidos.Size = new System.Drawing.Size(423, 130);
            this.grpListaPedidos.TabIndex = 6;
            this.grpListaPedidos.TabStop = false;
            this.grpListaPedidos.Text = "LISTA DE PEDIDOS";
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidos.Location = new System.Drawing.Point(6, 47);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.Size = new System.Drawing.Size(411, 457);
            this.dgvListaPedidos.TabIndex = 2;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(6, 23);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(88, 16);
            this.lblIdPedido.TabIndex = 1;
            this.lblIdPedido.Text = "ID DO PEDIDO:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(105, 23);
            this.txtIdPedido.MaxLength = 4;
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(70, 21);
            this.txtIdPedido.TabIndex = 0;
            // 
            // uctPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpListaPedidos);
            this.Controls.Add(this.ltbProdutos);
            this.Controls.Add(this.grbAlterarItens);
            this.Controls.Add(this.grbRemoverProduto);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.grbAdicionarItens);
            this.Controls.Add(this.pnlPreco);
            this.Controls.Add(this.pnlFuncoes);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedido";
            this.Size = new System.Drawing.Size(731, 649);
            this.Load += new System.EventHandler(this.uctPedido_Load);
            this.pnlFuncoes.ResumeLayout(false);
            this.grbAdicionarItens.ResumeLayout(false);
            this.grbAdicionarItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbAlterarItens.ResumeLayout(false);
            this.grbAlterarItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos2)).EndInit();
            this.grbRemoverProduto.ResumeLayout(false);
            this.grbRemoverProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho2)).EndInit();
            this.grpListaPedidos.ResumeLayout(false);
            this.grpListaPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlFuncoes;
        private System.Windows.Forms.Panel pnlPreco;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.GroupBox grbAdicionarItens;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbAlterarItens;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvProdutos2;
        private System.Windows.Forms.Label lblNomeProduto2;
        private System.Windows.Forms.TextBox txtPesquisar2;
        private System.Windows.Forms.GroupBox grbRemoverProduto;
        private System.Windows.Forms.DataGridView dgvCarrinho2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesquisar3;
        private System.Windows.Forms.ListBox ltbProdutos;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.GroupBox grpListaPedidos;
        private System.Windows.Forms.DataGridView dgvListaPedidos;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.TextBox txtIdPedido;
    }
}
