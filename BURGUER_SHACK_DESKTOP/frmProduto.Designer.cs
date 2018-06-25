namespace BURGUER_SHACK_DESKTOP
{
    partial class frmProduto
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExcluir = new UIX.btnUIX();
            this.btnVoltar = new UIX.btnUIX();
            this.btnSalvar = new UIX.btnUIX();
            this.grbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.cboSituacao = new UIX.cboUIX();
            this.txtDesc = new UIX.txtUIX();
            this.txtValor = new UIX.txtUIX();
            this.cboTipo = new UIX.cboUIX();
            this.txtNome = new UIX.txtUIX();
            this.btnImgRemover = new UIX.btnUIX();
            this.btnImgAdicionar = new UIX.btnUIX();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.grbImagem = new System.Windows.Forms.GroupBox();
            this.grbIngredientes = new System.Windows.Forms.GroupBox();
            this.btnIngredienteAdd = new UIX.btnUIX();
            this.btnIngredientes = new UIX.btnUIX();
            this.pnlMenu.SuspendLayout();
            this.grbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.grbImagem.SuspendLayout();
            this.grbIngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.produto;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(700, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Produto";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnExcluir);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnSalvar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 300);
            this.pnlMenu.TabIndex = 6;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Description = "Excluir";
            this.btnExcluir.HoverColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.ImageLocation = null;
            this.btnExcluir.Location = new System.Drawing.Point(5, 105);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 90);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Description = "Cancelar";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.voltar;
            this.btnVoltar.ImageLocation = null;
            this.btnVoltar.Location = new System.Drawing.Point(5, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 90);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Description = "Salvar";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.ImageLocation = null;
            this.btnSalvar.Location = new System.Drawing.Point(5, 205);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 90);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbDadosPessoais
            // 
            this.grbDadosPessoais.Controls.Add(this.cboSituacao);
            this.grbDadosPessoais.Controls.Add(this.txtDesc);
            this.grbDadosPessoais.Controls.Add(this.txtValor);
            this.grbDadosPessoais.Controls.Add(this.cboTipo);
            this.grbDadosPessoais.Controls.Add(this.txtNome);
            this.grbDadosPessoais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPessoais.Location = new System.Drawing.Point(105, 55);
            this.grbDadosPessoais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Name = "grbDadosPessoais";
            this.grbDadosPessoais.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Size = new System.Drawing.Size(390, 185);
            this.grbDadosPessoais.TabIndex = 7;
            this.grbDadosPessoais.TabStop = false;
            this.grbDadosPessoais.Text = "DADOS";
            // 
            // cboSituacao
            // 
            this.cboSituacao.AcceptButton = null;
            this.cboSituacao.AccessibleName = "Tipo:*";
            this.cboSituacao.Campo = "Situação*";
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.cboSituacao.Location = new System.Drawing.Point(170, 40);
            this.cboSituacao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(215, 25);
            this.cboSituacao.TabIndex = 20;
            // 
            // txtDesc
            // 
            this.txtDesc.AcceptButton = null;
            this.txtDesc.AccessibleName = "Preço de Venda: (R$)*";
            this.txtDesc.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtDesc.Campo = "Descrição";
            this.txtDesc.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtDesc.Location = new System.Drawing.Point(5, 70);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.Size = new System.Drawing.Size(380, 75);
            this.txtDesc.TabIndex = 30;
            // 
            // txtValor
            // 
            this.txtValor.AcceptButton = null;
            this.txtValor.AccessibleName = "Preço de Venda: (R$)*";
            this.txtValor.AllowedChars = UIX.uixEnum.uixAllowedChars.DOUBLE;
            this.txtValor.Campo = "Valor (R$)*";
            this.txtValor.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtValor.Location = new System.Drawing.Point(5, 39);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.Size = new System.Drawing.Size(160, 26);
            this.txtValor.TabIndex = 19;
            // 
            // cboTipo
            // 
            this.cboTipo.AcceptButton = null;
            this.cboTipo.AccessibleName = "Tipo:*";
            this.cboTipo.Campo = "Tipo*";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.cboTipo.Location = new System.Drawing.Point(5, 150);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(380, 25);
            this.cboTipo.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.AcceptButton = null;
            this.txtNome.AccessibleName = "Nome:*";
            this.txtNome.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtNome.Campo = "Nome:*";
            this.txtNome.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtNome.Location = new System.Drawing.Point(5, 15);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.Size = new System.Drawing.Size(380, 21);
            this.txtNome.TabIndex = 2;
            // 
            // btnImgRemover
            // 
            this.btnImgRemover.Description = "Remover";
            this.btnImgRemover.HoverColor = System.Drawing.Color.Transparent;
            this.btnImgRemover.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover;
            this.btnImgRemover.ImageLocation = null;
            this.btnImgRemover.Location = new System.Drawing.Point(10, 15);
            this.btnImgRemover.Name = "btnImgRemover";
            this.btnImgRemover.Size = new System.Drawing.Size(80, 80);
            this.btnImgRemover.TabIndex = 28;
            this.btnImgRemover.UseVisualStyleBackColor = true;
            this.btnImgRemover.Click += new System.EventHandler(this.btnImgRemover_Click);
            // 
            // btnImgAdicionar
            // 
            this.btnImgAdicionar.Description = "Adicionar";
            this.btnImgAdicionar.HoverColor = System.Drawing.Color.Transparent;
            this.btnImgAdicionar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnImgAdicionar.ImageLocation = null;
            this.btnImgAdicionar.Location = new System.Drawing.Point(100, 15);
            this.btnImgAdicionar.Name = "btnImgAdicionar";
            this.btnImgAdicionar.Size = new System.Drawing.Size(80, 80);
            this.btnImgAdicionar.TabIndex = 26;
            this.btnImgAdicionar.UseVisualStyleBackColor = true;
            this.btnImgAdicionar.Click += new System.EventHandler(this.btnImgAdicionar_Click);
            // 
            // picImagem
            // 
            this.picImagem.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.padrao;
            this.picImagem.Location = new System.Drawing.Point(505, 55);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(190, 190);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 27;
            this.picImagem.TabStop = false;
            // 
            // grbImagem
            // 
            this.grbImagem.Controls.Add(this.btnImgAdicionar);
            this.grbImagem.Controls.Add(this.btnImgRemover);
            this.grbImagem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbImagem.Location = new System.Drawing.Point(505, 245);
            this.grbImagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbImagem.Name = "grbImagem";
            this.grbImagem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbImagem.Size = new System.Drawing.Size(190, 100);
            this.grbImagem.TabIndex = 20;
            this.grbImagem.TabStop = false;
            this.grbImagem.Text = "IMAGEM";
            // 
            // grbIngredientes
            // 
            this.grbIngredientes.Controls.Add(this.btnIngredienteAdd);
            this.grbIngredientes.Controls.Add(this.btnIngredientes);
            this.grbIngredientes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbIngredientes.Location = new System.Drawing.Point(105, 245);
            this.grbIngredientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngredientes.Name = "grbIngredientes";
            this.grbIngredientes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngredientes.Size = new System.Drawing.Size(190, 100);
            this.grbIngredientes.TabIndex = 29;
            this.grbIngredientes.TabStop = false;
            this.grbIngredientes.Text = "INGREDIENTES";
            // 
            // btnIngredienteAdd
            // 
            this.btnIngredienteAdd.Description = "Adicionar";
            this.btnIngredienteAdd.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngredienteAdd.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnIngredienteAdd.ImageLocation = null;
            this.btnIngredienteAdd.Location = new System.Drawing.Point(100, 15);
            this.btnIngredienteAdd.Name = "btnIngredienteAdd";
            this.btnIngredienteAdd.Size = new System.Drawing.Size(80, 80);
            this.btnIngredienteAdd.TabIndex = 26;
            this.btnIngredienteAdd.UseVisualStyleBackColor = true;
            this.btnIngredienteAdd.Click += new System.EventHandler(this.btnIngredienteAdd_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Description = "Visualizar";
            this.btnIngredientes.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngredientes.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.btnIngredientes.ImageLocation = null;
            this.btnIngredientes.Location = new System.Drawing.Point(10, 15);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(80, 80);
            this.btnIngredientes.TabIndex = 28;
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredienteRemover_Click);
            // 
            // frmProduto
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.grbIngredientes);
            this.Controls.Add(this.grbImagem);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.grbDadosPessoais);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmIngrediente_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbDadosPessoais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.grbImagem.ResumeLayout(false);
            this.grbIngredientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnVoltar;
        private UIX.btnUIX btnSalvar;
        public System.Windows.Forms.GroupBox grbDadosPessoais;
        private UIX.txtUIX txtValor;
        private UIX.cboUIX cboTipo;
        private UIX.txtUIX txtNome;
        private UIX.btnUIX btnImgRemover;
        private UIX.btnUIX btnImgAdicionar;
        private System.Windows.Forms.PictureBox picImagem;
        public System.Windows.Forms.GroupBox grbImagem;
        private UIX.cboUIX cboSituacao;
        private UIX.btnUIX btnExcluir;
        private UIX.txtUIX txtDesc;
        public System.Windows.Forms.GroupBox grbIngredientes;
        private UIX.btnUIX btnIngredienteAdd;
        private UIX.btnUIX btnIngredientes;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}