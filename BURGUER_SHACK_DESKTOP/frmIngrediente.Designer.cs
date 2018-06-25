namespace BURGUER_SHACK_DESKTOP
{
    partial class frmIngrediente
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
            this.btnTipo = new System.Windows.Forms.Button();
            this.txtValor = new UIX.txtUIX();
            this.cboTipo = new UIX.cboUIX();
            this.txtNome = new UIX.txtUIX();
            this.cboSituacao = new UIX.cboUIX();
            this.btnImgRemover = new UIX.btnUIX();
            this.btnImgAdicionar = new UIX.btnUIX();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.grbImagem = new System.Windows.Forms.GroupBox();
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.grbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.grbImagem.SuspendLayout();
            this.grbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.ingrediente;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(500, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Ingrediente";
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
            this.grbDadosPessoais.Controls.Add(this.btnTipo);
            this.grbDadosPessoais.Controls.Add(this.txtValor);
            this.grbDadosPessoais.Controls.Add(this.cboTipo);
            this.grbDadosPessoais.Controls.Add(this.txtNome);
            this.grbDadosPessoais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPessoais.Location = new System.Drawing.Point(105, 55);
            this.grbDadosPessoais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Name = "grbDadosPessoais";
            this.grbDadosPessoais.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Size = new System.Drawing.Size(390, 90);
            this.grbDadosPessoais.TabIndex = 7;
            this.grbDadosPessoais.TabStop = false;
            this.grbDadosPessoais.Text = "DADOS";
            // 
            // btnTipo
            // 
            this.btnTipo.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTipo.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnTipo.Location = new System.Drawing.Point(360, 50);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(25, 25);
            this.btnTipo.TabIndex = 29;
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // txtValor
            // 
            this.txtValor.AcceptButton = null;
            this.txtValor.AccessibleName = "Preço de Venda: (R$)*";
            this.txtValor.AllowedChars = UIX.uixEnum.uixAllowedChars.DOUBLE;
            this.txtValor.Campo = "Valor (R$)*";
            this.txtValor.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtValor.Location = new System.Drawing.Point(5, 50);
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
            this.cboTipo.AcceptButton = this.btnTipo;
            this.cboTipo.AccessibleName = "Tipo:*";
            this.cboTipo.Campo = "Tipo*";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.cboTipo.Location = new System.Drawing.Point(170, 50);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(185, 25);
            this.cboTipo.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.AcceptButton = null;
            this.txtNome.AccessibleName = "Nome:*";
            this.txtNome.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtNome.Campo = "Nome:*";
            this.txtNome.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtNome.Location = new System.Drawing.Point(5, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.Size = new System.Drawing.Size(380, 21);
            this.txtNome.TabIndex = 2;
            // 
            // cboSituacao
            // 
            this.cboSituacao.AcceptButton = null;
            this.cboSituacao.AccessibleName = "Tipo:*";
            this.cboSituacao.Campo = "Situação*";
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.cboSituacao.Location = new System.Drawing.Point(5, 20);
            this.cboSituacao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(180, 30);
            this.cboSituacao.TabIndex = 20;
            // 
            // btnImgRemover
            // 
            this.btnImgRemover.Description = "Remover";
            this.btnImgRemover.HoverColor = System.Drawing.Color.Transparent;
            this.btnImgRemover.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover;
            this.btnImgRemover.ImageLocation = null;
            this.btnImgRemover.Location = new System.Drawing.Point(10, 20);
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
            this.btnImgAdicionar.Location = new System.Drawing.Point(100, 20);
            this.btnImgAdicionar.Name = "btnImgAdicionar";
            this.btnImgAdicionar.Size = new System.Drawing.Size(80, 80);
            this.btnImgAdicionar.TabIndex = 26;
            this.btnImgAdicionar.UseVisualStyleBackColor = true;
            this.btnImgAdicionar.Click += new System.EventHandler(this.btnImgAdicionar_Click);
            // 
            // picImagem
            // 
            this.picImagem.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.padrao;
            this.picImagem.Location = new System.Drawing.Point(305, 150);
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
            this.grbImagem.Location = new System.Drawing.Point(106, 235);
            this.grbImagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbImagem.Name = "grbImagem";
            this.grbImagem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbImagem.Size = new System.Drawing.Size(190, 105);
            this.grbImagem.TabIndex = 20;
            this.grbImagem.TabStop = false;
            this.grbImagem.Text = "IMAGEM";
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.lblEstoque);
            this.grbSituacao.Controls.Add(this.cboSituacao);
            this.grbSituacao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSituacao.Location = new System.Drawing.Point(105, 150);
            this.grbSituacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSituacao.Size = new System.Drawing.Size(190, 85);
            this.grbSituacao.TabIndex = 30;
            this.grbSituacao.TabStop = false;
            this.grbSituacao.Text = "SITUAÇÃO";
            // 
            // lblEstoque
            // 
            this.lblEstoque.Location = new System.Drawing.Point(5, 50);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(180, 25);
            this.lblEstoque.TabIndex = 21;
            // 
            // frmIngrediente
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.grbSituacao);
            this.Controls.Add(this.grbImagem);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.grbDadosPessoais);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingrediente";
            this.Load += new System.EventHandler(this.frmIngrediente_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbDadosPessoais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.grbImagem.ResumeLayout(false);
            this.grbSituacao.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnTipo;
        public System.Windows.Forms.GroupBox grbSituacao;
        private System.Windows.Forms.Label lblEstoque;
        private UIX.btnUIX btnExcluir;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}