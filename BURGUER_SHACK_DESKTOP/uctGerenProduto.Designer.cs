namespace BURGUER_SHACK_DESKTOP
{
    partial class uctGerenProduto
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
            this.grbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtPrecoVenda = new UIX.txtUIX();
            this.txtPrecoCusto = new UIX.txtUIX();
            this.txtDataCadastro = new UIX.txtUIX();
            this.txtCodMarca = new System.Windows.Forms.TextBox();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.txtUnidadeEstoque = new UIX.txtUIX();
            this.txtFornecedor = new UIX.txtUIX();
            this.txtMarca = new UIX.txtUIX();
            this.cboTipo = new UIX.cboUIX();
            this.txtPeso = new UIX.txtUIX();
            this.txtDescricao = new UIX.txtUIX();
            this.txtNome = new UIX.txtUIX();
            this.ckbProdutoInativo = new System.Windows.Forms.CheckBox();
            this.picFotoProduto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new UIX.btnUIX();
            this.btnRemover = new UIX.btnUIX();
            this.btnAdicionar = new UIX.btnUIX();
            this.btnUIX1 = new UIX.btnUIX();
            this.txtPesquisa = new UIX.txtUIX();
            this.grbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDadosPessoais
            // 
            this.grbDadosPessoais.Controls.Add(this.txtPrecoVenda);
            this.grbDadosPessoais.Controls.Add(this.txtPrecoCusto);
            this.grbDadosPessoais.Controls.Add(this.txtDataCadastro);
            this.grbDadosPessoais.Controls.Add(this.txtCodMarca);
            this.grbDadosPessoais.Controls.Add(this.txtCodFornecedor);
            this.grbDadosPessoais.Controls.Add(this.txtUnidadeEstoque);
            this.grbDadosPessoais.Controls.Add(this.txtFornecedor);
            this.grbDadosPessoais.Controls.Add(this.txtMarca);
            this.grbDadosPessoais.Controls.Add(this.cboTipo);
            this.grbDadosPessoais.Controls.Add(this.txtPeso);
            this.grbDadosPessoais.Controls.Add(this.txtDescricao);
            this.grbDadosPessoais.Controls.Add(this.txtNome);
            this.grbDadosPessoais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPessoais.Location = new System.Drawing.Point(3, 20);
            this.grbDadosPessoais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Name = "grbDadosPessoais";
            this.grbDadosPessoais.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Size = new System.Drawing.Size(510, 218);
            this.grbDadosPessoais.TabIndex = 5;
            this.grbDadosPessoais.TabStop = false;
            this.grbDadosPessoais.Text = "DADOS DO PRODUTO";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.AccessibleName = "Preço de Venda: (R$)*";
            this.txtPrecoVenda.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtPrecoVenda.Campo = "Preço de Venda: (R$)*";
            this.txtPrecoVenda.Location = new System.Drawing.Point(282, 143);
            this.txtPrecoVenda.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtPrecoVenda.MaxLength = 32767;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(203, 26);
            this.txtPrecoVenda.TabIndex = 19;
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.AccessibleName = "Preço de Custo: (R$)*";
            this.txtPrecoCusto.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtPrecoCusto.Campo = "Preço de Custo: (R$)*";
            this.txtPrecoCusto.Location = new System.Drawing.Point(6, 143);
            this.txtPrecoCusto.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtPrecoCusto.MaxLength = 32767;
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(200, 21);
            this.txtPrecoCusto.TabIndex = 5;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.AccessibleName = "Data de Cadastro: *";
            this.txtDataCadastro.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtDataCadastro.Campo = "Data de Cadastro: *";
            this.txtDataCadastro.Location = new System.Drawing.Point(115, 82);
            this.txtDataCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataCadastro.MaxLength = 32767;
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(210, 20);
            this.txtDataCadastro.TabIndex = 22;
            this.txtDataCadastro.Load += new System.EventHandler(this.txtDataCadastro_Load);
            // 
            // txtCodMarca
            // 
            this.txtCodMarca.Location = new System.Drawing.Point(442, 112);
            this.txtCodMarca.Name = "txtCodMarca";
            this.txtCodMarca.Size = new System.Drawing.Size(40, 21);
            this.txtCodMarca.TabIndex = 18;
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(210, 112);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(59, 21);
            this.txtCodFornecedor.TabIndex = 15;
            // 
            // txtUnidadeEstoque
            // 
            this.txtUnidadeEstoque.AccessibleName = "Unidade em Estoque";
            this.txtUnidadeEstoque.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtUnidadeEstoque.Campo = "Unidade em Estoque";
            this.txtUnidadeEstoque.Location = new System.Drawing.Point(6, 176);
            this.txtUnidadeEstoque.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtUnidadeEstoque.MaxLength = 32767;
            this.txtUnidadeEstoque.Name = "txtUnidadeEstoque";
            this.txtUnidadeEstoque.Size = new System.Drawing.Size(190, 26);
            this.txtUnidadeEstoque.TabIndex = 6;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.AccessibleName = "Fornecedor";
            this.txtFornecedor.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtFornecedor.Campo = "Fornecedor";
            this.txtFornecedor.Location = new System.Drawing.Point(6, 112);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFornecedor.MaxLength = 32767;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(206, 23);
            this.txtFornecedor.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.AccessibleName = "Marca";
            this.txtMarca.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtMarca.Campo = "Marca";
            this.txtMarca.Location = new System.Drawing.Point(275, 112);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(173, 21);
            this.txtMarca.TabIndex = 8;
            // 
            // cboTipo
            // 
            this.cboTipo.AccessibleName = "Tipo:*";
            this.cboTipo.Campo = "Tipo:*";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(6, 22);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(157, 25);
            this.cboTipo.TabIndex = 9;
            // 
            // txtPeso
            // 
            this.txtPeso.AccessibleName = "Peso:* (g)";
            this.txtPeso.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtPeso.Campo = "Peso:* (g)";
            this.txtPeso.Location = new System.Drawing.Point(6, 82);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtPeso.MaxLength = 32767;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(103, 26);
            this.txtPeso.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AccessibleName = "Descrição:*";
            this.txtDescricao.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtDescricao.Campo = "Descrição:*";
            this.txtDescricao.Location = new System.Drawing.Point(6, 52);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(479, 23);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.AccessibleName = "Nome:*";
            this.txtNome.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtNome.Campo = "Nome:*";
            this.txtNome.Location = new System.Drawing.Point(171, 21);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(316, 21);
            this.txtNome.TabIndex = 2;
            // 
            // ckbProdutoInativo
            // 
            this.ckbProdutoInativo.AutoSize = true;
            this.ckbProdutoInativo.Location = new System.Drawing.Point(315, -2);
            this.ckbProdutoInativo.Name = "ckbProdutoInativo";
            this.ckbProdutoInativo.Size = new System.Drawing.Size(112, 20);
            this.ckbProdutoInativo.TabIndex = 13;
            this.ckbProdutoInativo.Text = "Produto Inativo";
            this.ckbProdutoInativo.UseVisualStyleBackColor = true;
            // 
            // picFotoProduto
            // 
            this.picFotoProduto.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.padrao;
            this.picFotoProduto.Location = new System.Drawing.Point(515, 39);
            this.picFotoProduto.Name = "picFotoProduto";
            this.picFotoProduto.Size = new System.Drawing.Size(201, 198);
            this.picFotoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoProduto.TabIndex = 12;
            this.picFotoProduto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(549, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "IMAGEM DO PRODUTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 224);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADICIONAIS";
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Location = new System.Drawing.Point(519, 222);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(0, 16);
            this.lblDirectorio.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.confirmar;
            this.btnSalvar.Location = new System.Drawing.Point(720, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 80);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Description = "Remover";
            this.btnRemover.HoverColor = System.Drawing.Color.Transparent;
            this.btnRemover.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover_menos;
            this.btnRemover.Location = new System.Drawing.Point(727, 158);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(80, 80);
            this.btnRemover.TabIndex = 25;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Description = "Adicionar";
            this.btnAdicionar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnAdicionar.Location = new System.Drawing.Point(727, 40);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 80);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnUIX1
            // 
            this.btnUIX1.Description = "ADICIONAR";
            this.btnUIX1.HoverColor = System.Drawing.Color.Transparent;
            this.btnUIX1.Image = null;
            this.btnUIX1.Location = new System.Drawing.Point(871, 241);
            this.btnUIX1.Name = "btnUIX1";
            this.btnUIX1.Size = new System.Drawing.Size(80, 80);
            this.btnUIX1.TabIndex = 23;
            this.btnUIX1.Text = "btnUIX1";
            this.btnUIX1.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AccessibleName = "Número de Identificação";
            this.txtPesquisa.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtPesquisa.Campo = "Número de Identificação";
            this.txtPesquisa.Location = new System.Drawing.Point(0, 1);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(265, 17);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.Visible = false;
            // 
            // uctGerenProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDirectorio);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnUIX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFotoProduto);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.grbDadosPessoais);
            this.Controls.Add(this.ckbProdutoInativo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctGerenProduto";
            this.Size = new System.Drawing.Size(810, 470);
            this.grbDadosPessoais.ResumeLayout(false);
            this.grbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIX.txtUIX txtPesquisa;
        public System.Windows.Forms.GroupBox grbDadosPessoais;
        private UIX.txtUIX txtFornecedor;
        private UIX.txtUIX txtNome;
        private UIX.txtUIX txtDescricao;
        private UIX.txtUIX txtPrecoCusto;
        private UIX.txtUIX txtUnidadeEstoque;
        private UIX.txtUIX txtMarca;
        private UIX.txtUIX txtPeso;
        private UIX.cboUIX cboTipo;
        private System.Windows.Forms.CheckBox ckbProdutoInativo;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private UIX.txtUIX txtPrecoVenda;
        private System.Windows.Forms.TextBox txtCodMarca;
        private System.Windows.Forms.PictureBox picFotoProduto;
        private System.Windows.Forms.Label label1;
        private UIX.btnUIX btnUIX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private UIX.txtUIX txtDataCadastro;
        private UIX.btnUIX btnAdicionar;
        private UIX.btnUIX btnRemover;
        private UIX.btnUIX btnSalvar;
        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
