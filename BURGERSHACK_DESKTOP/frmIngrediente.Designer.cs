namespace BurgerShack.Desktop
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
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExcluir = new vitorrdgs.UiX.Component.UIXButton();
            this.btnVoltar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAlterar = new vitorrdgs.UiX.Component.UIXButton();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.btnTipo = new System.Windows.Forms.Button();
            this.txtValor = new vitorrdgs.UiX.Component.UIXTextBox();
            this.cboTipo = new vitorrdgs.UiX.Component.UIXComboBox();
            this.txtNome = new vitorrdgs.UiX.Component.UIXTextBox();
            this.cboSituacao = new vitorrdgs.UiX.Component.UIXComboBox();
            this.btnImgRemover = new vitorrdgs.UiX.Component.UIXButton();
            this.btnImgAdicionar = new vitorrdgs.UiX.Component.UIXButton();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.grbImagem = new System.Windows.Forms.GroupBox();
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.grbMercadoria = new System.Windows.Forms.GroupBox();
            this.lblMercadoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMercadoria = new vitorrdgs.UiX.Component.UIXButton();
            this.pnlMenu.SuspendLayout();
            this.grbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.grbImagem.SuspendLayout();
            this.grbSituacao.SuspendLayout();
            this.grbMercadoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.ingrediente;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(650, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Ingrediente";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnExcluir);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 300);
            this.pnlMenu.TabIndex = 6;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Description = "EXCLUIR";
            this.btnExcluir.HoverColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Image = null;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.ImageLocation = null;
            this.btnExcluir.Location = new System.Drawing.Point(5, 105);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 90);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Description = "CANCELAR";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BurgerShack.Desktop.Properties.Resources.voltar;
            this.btnVoltar.ImageLocation = null;
            this.btnVoltar.Location = new System.Drawing.Point(5, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 90);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Description = "SALVAR";
            this.btnAlterar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Image = global::BurgerShack.Desktop.Properties.Resources.salvar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.ImageLocation = null;
            this.btnAlterar.Location = new System.Drawing.Point(5, 205);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 90);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Salvar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.btnTipo);
            this.grbDados.Controls.Add(this.txtValor);
            this.grbDados.Controls.Add(this.cboTipo);
            this.grbDados.Controls.Add(this.txtNome);
            this.grbDados.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(105, 55);
            this.grbDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDados.Name = "grbDados";
            this.grbDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDados.Size = new System.Drawing.Size(340, 90);
            this.grbDados.TabIndex = 7;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "DADOS";
            // 
            // btnTipo
            // 
            this.btnTipo.BackgroundImage = global::BurgerShack.Desktop.Properties.Resources.alterar;
            this.btnTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTipo.Image = global::BurgerShack.Desktop.Properties.Resources.alterar;
            this.btnTipo.Location = new System.Drawing.Point(310, 50);
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
            this.txtValor.Campo = "Valor (R$)*";
            this.txtValor.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtValor.Location = new System.Drawing.Point(5, 50);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.MONEY;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.Size = new System.Drawing.Size(150, 26);
            this.txtValor.TabIndex = 19;
            // 
            // cboTipo
            // 
            this.cboTipo.AcceptButton = this.btnTipo;
            this.cboTipo.AccessibleName = "Tipo:*";
            this.cboTipo.Campo = "Tipo*";
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.cboTipo.Location = new System.Drawing.Point(165, 50);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.SelectedItem = null;
            this.cboTipo.Size = new System.Drawing.Size(140, 25);
            this.cboTipo.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.AcceptButton = null;
            this.txtNome.AccessibleName = "Nome:*";
            this.txtNome.Campo = "Nome*";
            this.txtNome.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtNome.Location = new System.Drawing.Point(5, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.Size = new System.Drawing.Size(330, 21);
            this.txtNome.TabIndex = 2;
            // 
            // cboSituacao
            // 
            this.cboSituacao.AcceptButton = null;
            this.cboSituacao.AccessibleName = "Tipo:*";
            this.cboSituacao.Campo = "Situação*";
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.cboSituacao.Location = new System.Drawing.Point(5, 20);
            this.cboSituacao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.SelectedItem = null;
            this.cboSituacao.Size = new System.Drawing.Size(170, 25);
            this.cboSituacao.TabIndex = 20;
            // 
            // btnImgRemover
            // 
            this.btnImgRemover.Description = "REMOVER";
            this.btnImgRemover.HoverColor = System.Drawing.Color.Transparent;
            this.btnImgRemover.Image = global::BurgerShack.Desktop.Properties.Resources.remover;
            this.btnImgRemover.ImageLocation = null;
            this.btnImgRemover.Location = new System.Drawing.Point(5, 20);
            this.btnImgRemover.Name = "btnImgRemover";
            this.btnImgRemover.Size = new System.Drawing.Size(80, 80);
            this.btnImgRemover.TabIndex = 28;
            this.btnImgRemover.Text = "Remover";
            this.btnImgRemover.UseVisualStyleBackColor = true;
            this.btnImgRemover.Click += new System.EventHandler(this.btnImgRemover_Click);
            // 
            // btnImgAdicionar
            // 
            this.btnImgAdicionar.Description = "ADICIONAR";
            this.btnImgAdicionar.HoverColor = System.Drawing.Color.Transparent;
            this.btnImgAdicionar.Image = global::BurgerShack.Desktop.Properties.Resources.adicionar;
            this.btnImgAdicionar.ImageLocation = null;
            this.btnImgAdicionar.Location = new System.Drawing.Point(90, 20);
            this.btnImgAdicionar.Name = "btnImgAdicionar";
            this.btnImgAdicionar.Size = new System.Drawing.Size(80, 80);
            this.btnImgAdicionar.TabIndex = 26;
            this.btnImgAdicionar.Text = "Adicionar";
            this.btnImgAdicionar.UseVisualStyleBackColor = true;
            this.btnImgAdicionar.Click += new System.EventHandler(this.btnImgAdicionar_Click);
            // 
            // picImagem
            // 
            this.picImagem.Image = global::BurgerShack.Desktop.Properties.Resources.imagem;
            this.picImagem.Location = new System.Drawing.Point(460, 55);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(180, 180);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 27;
            this.picImagem.TabStop = false;
            // 
            // grbImagem
            // 
            this.grbImagem.Controls.Add(this.btnImgAdicionar);
            this.grbImagem.Controls.Add(this.btnImgRemover);
            this.grbImagem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbImagem.Location = new System.Drawing.Point(460, 240);
            this.grbImagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbImagem.Name = "grbImagem";
            this.grbImagem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbImagem.Size = new System.Drawing.Size(180, 105);
            this.grbImagem.TabIndex = 20;
            this.grbImagem.TabStop = false;
            this.grbImagem.Text = "IMAGEM";
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.lblEstoque);
            this.grbSituacao.Controls.Add(this.cboSituacao);
            this.grbSituacao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSituacao.Location = new System.Drawing.Point(105, 155);
            this.grbSituacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbSituacao.Size = new System.Drawing.Size(340, 60);
            this.grbSituacao.TabIndex = 30;
            this.grbSituacao.TabStop = false;
            this.grbSituacao.Text = "SITUAÇÃO";
            // 
            // lblEstoque
            // 
            this.lblEstoque.Location = new System.Drawing.Point(180, 20);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(150, 25);
            this.lblEstoque.TabIndex = 21;
            // 
            // grbMercadoria
            // 
            this.grbMercadoria.Controls.Add(this.lblMercadoria);
            this.grbMercadoria.Controls.Add(this.label1);
            this.grbMercadoria.Controls.Add(this.btnMercadoria);
            this.grbMercadoria.Location = new System.Drawing.Point(105, 225);
            this.grbMercadoria.Name = "grbMercadoria";
            this.grbMercadoria.Size = new System.Drawing.Size(340, 100);
            this.grbMercadoria.TabIndex = 32;
            this.grbMercadoria.TabStop = false;
            this.grbMercadoria.Text = "MERCADORIA";
            // 
            // lblMercadoria
            // 
            this.lblMercadoria.Location = new System.Drawing.Point(5, 20);
            this.lblMercadoria.Name = "lblMercadoria";
            this.lblMercadoria.Size = new System.Drawing.Size(245, 75);
            this.lblMercadoria.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 75);
            this.label1.TabIndex = 8;
            // 
            // btnMercadoria
            // 
            this.btnMercadoria.Description = "SELECIONAR";
            this.btnMercadoria.HoverColor = System.Drawing.Color.Transparent;
            this.btnMercadoria.Image = global::BurgerShack.Desktop.Properties.Resources.mercadoria;
            this.btnMercadoria.ImageLocation = null;
            this.btnMercadoria.Location = new System.Drawing.Point(255, 15);
            this.btnMercadoria.Name = "btnMercadoria";
            this.btnMercadoria.Size = new System.Drawing.Size(80, 80);
            this.btnMercadoria.TabIndex = 7;
            this.btnMercadoria.Text = "Selecionar";
            this.btnMercadoria.UseVisualStyleBackColor = true;
            this.btnMercadoria.Click += new System.EventHandler(this.btnMercadoria_Click);
            // 
            // frmIngrediente
            // 
            this.AcceptButton = this.btnAlterar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.grbMercadoria);
            this.Controls.Add(this.grbSituacao);
            this.Controls.Add(this.grbImagem);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.grbDados);
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
            this.grbDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.grbImagem.ResumeLayout(false);
            this.grbSituacao.ResumeLayout(false);
            this.grbMercadoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnVoltar;
        private vitorrdgs.UiX.Component.UIXButton btnAlterar;
        public System.Windows.Forms.GroupBox grbDados;
        private vitorrdgs.UiX.Component.UIXTextBox txtValor;
        private vitorrdgs.UiX.Component.UIXComboBox cboTipo;
        private vitorrdgs.UiX.Component.UIXTextBox txtNome;
        private vitorrdgs.UiX.Component.UIXButton btnImgRemover;
        private vitorrdgs.UiX.Component.UIXButton btnImgAdicionar;
        private System.Windows.Forms.PictureBox picImagem;
        public System.Windows.Forms.GroupBox grbImagem;
        private vitorrdgs.UiX.Component.UIXComboBox cboSituacao;
        private System.Windows.Forms.Button btnTipo;
        public System.Windows.Forms.GroupBox grbSituacao;
        private System.Windows.Forms.Label lblEstoque;
        private vitorrdgs.UiX.Component.UIXButton btnExcluir;
        private System.Windows.Forms.GroupBox grbMercadoria;
        private System.Windows.Forms.Label lblMercadoria;
        private System.Windows.Forms.Label label1;
        private vitorrdgs.UiX.Component.UIXButton btnMercadoria;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}