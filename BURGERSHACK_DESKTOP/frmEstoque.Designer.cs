namespace BurgerShack.Desktop
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
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAlterar = new vitorrdgs.UiX.Component.UIXButton();
            this.grbEntrada = new System.Windows.Forms.GroupBox();
            this.mtbValidade = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.txtValor = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtQuantidade = new vitorrdgs.UiX.Component.UIXTextBox();
            this.grbFornecedor = new System.Windows.Forms.GroupBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnFornEncontrar = new vitorrdgs.UiX.Component.UIXButton();
            this.mtbFornCNPJ = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.grbMercadoria = new System.Windows.Forms.GroupBox();
            this.lblMercadoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMercadoria = new vitorrdgs.UiX.Component.UIXButton();
            this.pnlMenu.SuspendLayout();
            this.grbEntrada.SuspendLayout();
            this.grbFornecedor.SuspendLayout();
            this.grbMercadoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.estoque;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(450, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Estoque";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 300);
            this.pnlMenu.TabIndex = 6;
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
            // btnSalvar
            // 
            this.btnAlterar.Description = "SALVAR";
            this.btnAlterar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Image = global::BurgerShack.Desktop.Properties.Resources.salvar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.ImageLocation = null;
            this.btnAlterar.Location = new System.Drawing.Point(5, 205);
            this.btnAlterar.Name = "btnSalvar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 90);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Salvar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbEntrada
            // 
            this.grbEntrada.Controls.Add(this.mtbValidade);
            this.grbEntrada.Controls.Add(this.txtValor);
            this.grbEntrada.Controls.Add(this.txtQuantidade);
            this.grbEntrada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEntrada.Location = new System.Drawing.Point(105, 265);
            this.grbEntrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbEntrada.Name = "grbEntrada";
            this.grbEntrada.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbEntrada.Size = new System.Drawing.Size(340, 80);
            this.grbEntrada.TabIndex = 7;
            this.grbEntrada.TabStop = false;
            this.grbEntrada.Text = "ENTRADA";
            // 
            // mtbValidade
            // 
            this.mtbValidade.AcceptButton = null;
            this.mtbValidade.AccessibleName = "CPF";
            this.mtbValidade.Campo = "Validade*";
            this.mtbValidade.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbValidade.Location = new System.Drawing.Point(160, 20);
            this.mtbValidade.Mask = "";
            this.mtbValidade.MaxLength = 32767;
            this.mtbValidade.Name = "mtbValidade";
            this.mtbValidade.Size = new System.Drawing.Size(175, 21);
            this.mtbValidade.TabIndex = 4;
            this.mtbValidade.ValidatingType = null;
            // 
            // txtValor
            // 
            this.txtValor.AcceptButton = null;
            this.txtValor.AccessibleName = "Nome:*";
            this.txtValor.Campo = "Valor*";
            this.txtValor.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtValor.Location = new System.Drawing.Point(5, 50);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.MONEY;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.Size = new System.Drawing.Size(330, 21);
            this.txtValor.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AcceptButton = null;
            this.txtQuantidade.AccessibleName = "Nome:*";
            this.txtQuantidade.Campo = "Quantidade*";
            this.txtQuantidade.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtQuantidade.Location = new System.Drawing.Point(5, 20);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.INT;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantidade.Size = new System.Drawing.Size(145, 21);
            this.txtQuantidade.TabIndex = 2;
            // 
            // grbFornecedor
            // 
            this.grbFornecedor.Controls.Add(this.lblFornecedor);
            this.grbFornecedor.Controls.Add(this.btnFornEncontrar);
            this.grbFornecedor.Controls.Add(this.mtbFornCNPJ);
            this.grbFornecedor.Location = new System.Drawing.Point(105, 55);
            this.grbFornecedor.Name = "grbFornecedor";
            this.grbFornecedor.Size = new System.Drawing.Size(340, 100);
            this.grbFornecedor.TabIndex = 30;
            this.grbFornecedor.TabStop = false;
            this.grbFornecedor.Text = "FORNECEDOR";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Location = new System.Drawing.Point(5, 45);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(245, 50);
            this.lblFornecedor.TabIndex = 8;
            // 
            // btnFornEncontrar
            // 
            this.btnFornEncontrar.Description = "ENCONTRAR";
            this.btnFornEncontrar.HoverColor = System.Drawing.Color.Transparent;
            this.btnFornEncontrar.Image = global::BurgerShack.Desktop.Properties.Resources.fornecedor;
            this.btnFornEncontrar.ImageLocation = null;
            this.btnFornEncontrar.Location = new System.Drawing.Point(255, 15);
            this.btnFornEncontrar.Name = "btnFornEncontrar";
            this.btnFornEncontrar.Size = new System.Drawing.Size(80, 80);
            this.btnFornEncontrar.TabIndex = 7;
            this.btnFornEncontrar.Text = "Encontrar";
            this.btnFornEncontrar.UseVisualStyleBackColor = true;
            this.btnFornEncontrar.Click += new System.EventHandler(this.btnFornEncontrar_Click);
            // 
            // mtbFornCNPJ
            // 
            this.mtbFornCNPJ.AcceptButton = this.btnFornEncontrar;
            this.mtbFornCNPJ.AccessibleName = "CPF";
            this.mtbFornCNPJ.Campo = "CNPJ";
            this.mtbFornCNPJ.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbFornCNPJ.Location = new System.Drawing.Point(5, 20);
            this.mtbFornCNPJ.Mask = "";
            this.mtbFornCNPJ.MaxLength = 32767;
            this.mtbFornCNPJ.Name = "mtbFornCNPJ";
            this.mtbFornCNPJ.Size = new System.Drawing.Size(245, 20);
            this.mtbFornCNPJ.TabIndex = 0;
            this.mtbFornCNPJ.ValidatingType = null;
            // 
            // grbMercadoria
            // 
            this.grbMercadoria.Controls.Add(this.lblMercadoria);
            this.grbMercadoria.Controls.Add(this.label1);
            this.grbMercadoria.Controls.Add(this.btnMercadoria);
            this.grbMercadoria.Location = new System.Drawing.Point(105, 160);
            this.grbMercadoria.Name = "grbMercadoria";
            this.grbMercadoria.Size = new System.Drawing.Size(340, 100);
            this.grbMercadoria.TabIndex = 31;
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
            this.btnMercadoria.Click += new System.EventHandler(this.btnIngSelecionar_Click);
            // 
            // frmEstoque
            // 
            this.AcceptButton = this.btnAlterar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.grbMercadoria);
            this.Controls.Add(this.grbFornecedor);
            this.Controls.Add(this.grbEntrada);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmIngrediente_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbEntrada.ResumeLayout(false);
            this.grbFornecedor.ResumeLayout(false);
            this.grbMercadoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnVoltar;
        private vitorrdgs.UiX.Component.UIXButton btnAlterar;
        public System.Windows.Forms.GroupBox grbEntrada;
        private vitorrdgs.UiX.Component.UIXTextBox txtQuantidade;
        private System.Windows.Forms.GroupBox grbFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private vitorrdgs.UiX.Component.UIXButton btnFornEncontrar;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbFornCNPJ;
        private System.Windows.Forms.GroupBox grbMercadoria;
        private System.Windows.Forms.Label label1;
        private vitorrdgs.UiX.Component.UIXButton btnMercadoria;
        private vitorrdgs.UiX.Component.UIXTextBox txtValor;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbValidade;
        private System.Windows.Forms.Label lblMercadoria;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}