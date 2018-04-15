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
            this.txtItens = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbNovoPedido = new System.Windows.Forms.GroupBox();
            this.grbAdicionarItens = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnlFuncoes.SuspendLayout();
            this.grbNovoPedido.SuspendLayout();
            this.grbAdicionarItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFuncoes
            // 
            this.pnlFuncoes.Controls.Add(this.btnLogout);
            this.pnlFuncoes.Controls.Add(this.btnMenu);
            this.pnlFuncoes.Controls.Add(this.btnAlterar);
            this.pnlFuncoes.Controls.Add(this.btnRemover);
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
            this.pnlPreco.Location = new System.Drawing.Point(276, 517);
            this.pnlPreco.Name = "pnlPreco";
            this.pnlPreco.Size = new System.Drawing.Size(153, 75);
            this.pnlPreco.TabIndex = 2;
            // 
            // txtItens
            // 
            this.txtItens.BackColor = System.Drawing.Color.White;
            this.txtItens.Location = new System.Drawing.Point(6, 517);
            this.txtItens.Multiline = true;
            this.txtItens.Name = "txtItens";
            this.txtItens.ReadOnly = true;
            this.txtItens.Size = new System.Drawing.Size(264, 119);
            this.txtItens.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grbNovoPedido
            // 
            this.grbNovoPedido.Controls.Add(this.grbAdicionarItens);
            this.grbNovoPedido.Controls.Add(this.txtItens);
            this.grbNovoPedido.Controls.Add(this.button1);
            this.grbNovoPedido.Controls.Add(this.pnlPreco);
            this.grbNovoPedido.Location = new System.Drawing.Point(70, 3);
            this.grbNovoPedido.Name = "grbNovoPedido";
            this.grbNovoPedido.Size = new System.Drawing.Size(435, 642);
            this.grbNovoPedido.TabIndex = 4;
            this.grbNovoPedido.TabStop = false;
            this.grbNovoPedido.Text = "NOVO PEDIDO";
            // 
            // grbAdicionarItens
            // 
            this.grbAdicionarItens.Controls.Add(this.label1);
            this.grbAdicionarItens.Controls.Add(this.txtPesquisa);
            this.grbAdicionarItens.Location = new System.Drawing.Point(6, 20);
            this.grbAdicionarItens.Name = "grbAdicionarItens";
            this.grbAdicionarItens.Size = new System.Drawing.Size(423, 491);
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
            this.txtPesquisa.Location = new System.Drawing.Point(137, 20);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(280, 21);
            this.txtPesquisa.TabIndex = 0;
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
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(2, 585);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.UseVisualStyleBackColor = true;
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
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(2, 220);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 60);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemover.Location = new System.Drawing.Point(2, 150);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(60, 60);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.UseVisualStyleBackColor = true;
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
            // 
            // uctPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbNovoPedido);
            this.Controls.Add(this.pnlFuncoes);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedido";
            this.Size = new System.Drawing.Size(508, 649);
            this.pnlFuncoes.ResumeLayout(false);
            this.grbNovoPedido.ResumeLayout(false);
            this.grbNovoPedido.PerformLayout();
            this.grbAdicionarItens.ResumeLayout(false);
            this.grbAdicionarItens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlFuncoes;
        private System.Windows.Forms.Panel pnlPreco;
        private System.Windows.Forms.TextBox txtItens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbNovoPedido;
        private System.Windows.Forms.GroupBox grbAdicionarItens;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
