namespace BURGUER_SHACK_DESKTOP
{
    partial class frmPagamento
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
            this.btnVoltar = new UIX.btnUIX();
            this.btnSalvar = new UIX.btnUIX();
            this.grbEntrada = new System.Windows.Forms.GroupBox();
            this.mtbValidade = new UIX.mtbUIX();
            this.txtValor = new UIX.txtUIX();
            this.txtQuantidade = new UIX.txtUIX();
            this.grbFornecedor = new System.Windows.Forms.GroupBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnFornEncontrar = new UIX.btnUIX();
            this.mtbFornCNPJ = new UIX.mtbUIX();
            this.grbIngrediente = new System.Windows.Forms.GroupBox();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngSelecionar = new UIX.btnUIX();
            this.pnlMenu.SuspendLayout();
            this.grbEntrada.SuspendLayout();
            this.grbFornecedor.SuspendLayout();
            this.grbIngrediente.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pagamento;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(450, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Pagamento";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnSalvar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 300);
            this.pnlMenu.TabIndex = 6;
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
            this.btnVoltar.Text = "Cancelar";
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
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.mtbValidade.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
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
            this.txtValor.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtValor.Location = new System.Drawing.Point(5, 50);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Mode = UIX.uixEnum.uixTextBoxMode.MONEY;
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
            this.txtQuantidade.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtQuantidade.Location = new System.Drawing.Point(5, 20);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Mode = UIX.uixEnum.uixTextBoxMode.INT;
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
            this.btnFornEncontrar.Description = "Encontrar";
            this.btnFornEncontrar.HoverColor = System.Drawing.Color.Transparent;
            this.btnFornEncontrar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.fornecedor;
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
            this.mtbFornCNPJ.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.mtbFornCNPJ.Location = new System.Drawing.Point(5, 20);
            this.mtbFornCNPJ.Mask = "";
            this.mtbFornCNPJ.MaxLength = 32767;
            this.mtbFornCNPJ.Name = "mtbFornCNPJ";
            this.mtbFornCNPJ.Size = new System.Drawing.Size(245, 20);
            this.mtbFornCNPJ.TabIndex = 0;
            this.mtbFornCNPJ.ValidatingType = null;
            // 
            // grbIngrediente
            // 
            this.grbIngrediente.Controls.Add(this.lblIngrediente);
            this.grbIngrediente.Controls.Add(this.label1);
            this.grbIngrediente.Controls.Add(this.btnIngSelecionar);
            this.grbIngrediente.Location = new System.Drawing.Point(105, 160);
            this.grbIngrediente.Name = "grbIngrediente";
            this.grbIngrediente.Size = new System.Drawing.Size(340, 100);
            this.grbIngrediente.TabIndex = 31;
            this.grbIngrediente.TabStop = false;
            this.grbIngrediente.Text = "INGREDIENTE";
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.Location = new System.Drawing.Point(5, 20);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(245, 75);
            this.lblIngrediente.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 75);
            this.label1.TabIndex = 8;
            // 
            // btnIngSelecionar
            // 
            this.btnIngSelecionar.Description = "Selecionar";
            this.btnIngSelecionar.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngSelecionar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.ingrediente;
            this.btnIngSelecionar.ImageLocation = null;
            this.btnIngSelecionar.Location = new System.Drawing.Point(255, 15);
            this.btnIngSelecionar.Name = "btnIngSelecionar";
            this.btnIngSelecionar.Size = new System.Drawing.Size(80, 80);
            this.btnIngSelecionar.TabIndex = 7;
            this.btnIngSelecionar.Text = "Selecionar";
            this.btnIngSelecionar.UseVisualStyleBackColor = true;
            this.btnIngSelecionar.Click += new System.EventHandler(this.btnIngSelecionar_Click);
            // 
            // frmPagamento
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.grbIngrediente);
            this.Controls.Add(this.grbFornecedor);
            this.Controls.Add(this.grbEntrada);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.frmIngrediente_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbEntrada.ResumeLayout(false);
            this.grbFornecedor.ResumeLayout(false);
            this.grbIngrediente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnVoltar;
        private UIX.btnUIX btnSalvar;
        public System.Windows.Forms.GroupBox grbEntrada;
        private UIX.txtUIX txtQuantidade;
        private System.Windows.Forms.GroupBox grbFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private UIX.btnUIX btnFornEncontrar;
        private UIX.mtbUIX mtbFornCNPJ;
        private System.Windows.Forms.GroupBox grbIngrediente;
        private System.Windows.Forms.Label label1;
        private UIX.btnUIX btnIngSelecionar;
        private UIX.txtUIX txtValor;
        private UIX.mtbUIX mtbValidade;
        private System.Windows.Forms.Label lblIngrediente;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}