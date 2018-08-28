namespace BurgerShack.Desktop
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
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnSalvar = new vitorrdgs.UiX.Component.UIXButton();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCliEncontrar = new vitorrdgs.UiX.Component.UIXButton();
            this.mtbCliCPF = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.grbValorTotal = new System.Windows.Forms.GroupBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.grbValorPagar = new System.Windows.Forms.GroupBox();
            this.txtValor = new vitorrdgs.UiX.Component.UIXTextBox();
            this.grbMeio = new System.Windows.Forms.GroupBox();
            this.cboBandeira = new vitorrdgs.UiX.Component.UIXComboBox();
            this.cboMetodo = new vitorrdgs.UiX.Component.UIXComboBox();
            this.grbDinheiro = new System.Windows.Forms.GroupBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtDinheiro = new vitorrdgs.UiX.Component.UIXTextBox();
            this.pnlMenu.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.grbValorTotal.SuspendLayout();
            this.grbValorPagar.SuspendLayout();
            this.grbMeio.SuspendLayout();
            this.grbDinheiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.pagamento;
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
            this.btnSalvar.Description = "SALVAR";
            this.btnSalvar.HoverColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::BurgerShack.Desktop.Properties.Resources.salvar;
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
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.lblCliente);
            this.grbCliente.Controls.Add(this.btnCliEncontrar);
            this.grbCliente.Controls.Add(this.mtbCliCPF);
            this.grbCliente.Location = new System.Drawing.Point(105, 55);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(340, 100);
            this.grbCliente.TabIndex = 30;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "CLIENTE";
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(5, 45);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(245, 50);
            this.lblCliente.TabIndex = 8;
            // 
            // btnCliEncontrar
            // 
            this.btnCliEncontrar.Description = "ENCONTRAR";
            this.btnCliEncontrar.HoverColor = System.Drawing.Color.Transparent;
            this.btnCliEncontrar.Image = global::BurgerShack.Desktop.Properties.Resources.cliente;
            this.btnCliEncontrar.ImageLocation = null;
            this.btnCliEncontrar.Location = new System.Drawing.Point(255, 15);
            this.btnCliEncontrar.Name = "btnCliEncontrar";
            this.btnCliEncontrar.Size = new System.Drawing.Size(80, 80);
            this.btnCliEncontrar.TabIndex = 7;
            this.btnCliEncontrar.Text = "Encontrar";
            this.btnCliEncontrar.UseVisualStyleBackColor = true;
            this.btnCliEncontrar.Click += new System.EventHandler(this.btnCliEncontrar_Click);
            // 
            // mtbCliCPF
            // 
            this.mtbCliCPF.AcceptButton = this.btnCliEncontrar;
            this.mtbCliCPF.AccessibleName = "CPF";
            this.mtbCliCPF.Campo = "CPF";
            this.mtbCliCPF.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbCliCPF.Location = new System.Drawing.Point(5, 20);
            this.mtbCliCPF.Mask = "";
            this.mtbCliCPF.MaxLength = 32767;
            this.mtbCliCPF.Name = "mtbCliCPF";
            this.mtbCliCPF.Size = new System.Drawing.Size(245, 20);
            this.mtbCliCPF.TabIndex = 0;
            this.mtbCliCPF.ValidatingType = null;
            // 
            // grbValorTotal
            // 
            this.grbValorTotal.Controls.Add(this.lblValorTotal);
            this.grbValorTotal.Location = new System.Drawing.Point(105, 160);
            this.grbValorTotal.Name = "grbValorTotal";
            this.grbValorTotal.Size = new System.Drawing.Size(175, 60);
            this.grbValorTotal.TabIndex = 31;
            this.grbValorTotal.TabStop = false;
            this.grbValorTotal.Text = "VALOR A PAGAR";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(6, 17);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(165, 35);
            this.lblValorTotal.TabIndex = 32;
            this.lblValorTotal.Text = "0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbValorPagar
            // 
            this.grbValorPagar.Controls.Add(this.txtValor);
            this.grbValorPagar.Location = new System.Drawing.Point(285, 160);
            this.grbValorPagar.Name = "grbValorPagar";
            this.grbValorPagar.Size = new System.Drawing.Size(160, 60);
            this.grbValorPagar.TabIndex = 33;
            this.grbValorPagar.TabStop = false;
            this.grbValorPagar.Text = "VALOR";
            // 
            // txtValor
            // 
            this.txtValor.AcceptButton = null;
            this.txtValor.AccessibleName = "Nome:*";
            this.txtValor.Campo = "Valor Pago (R$)*";
            this.txtValor.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.UP;
            this.txtValor.Location = new System.Drawing.Point(5, 15);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.MONEY;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.Size = new System.Drawing.Size(150, 40);
            this.txtValor.TabIndex = 5;
            // 
            // grbMeio
            // 
            this.grbMeio.Controls.Add(this.cboBandeira);
            this.grbMeio.Controls.Add(this.cboMetodo);
            this.grbMeio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMeio.Location = new System.Drawing.Point(105, 225);
            this.grbMeio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMeio.Name = "grbMeio";
            this.grbMeio.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMeio.Size = new System.Drawing.Size(340, 50);
            this.grbMeio.TabIndex = 7;
            this.grbMeio.TabStop = false;
            this.grbMeio.Text = "MEIO DE PAGAMENTO";
            // 
            // cboBandeira
            // 
            this.cboBandeira.AcceptButton = null;
            this.cboBandeira.Campo = "Bandeira*";
            this.cboBandeira.FormattingEnabled = true;
            this.cboBandeira.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.cboBandeira.Location = new System.Drawing.Point(170, 20);
            this.cboBandeira.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboBandeira.Name = "cboBandeira";
            this.cboBandeira.SelectedItem = null;
            this.cboBandeira.Size = new System.Drawing.Size(164, 25);
            this.cboBandeira.TabIndex = 1;
            this.cboBandeira.Visible = false;
            // 
            // cboMetodo
            // 
            this.cboMetodo.AcceptButton = null;
            this.cboMetodo.Campo = "Método*";
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.cboMetodo.Location = new System.Drawing.Point(5, 20);
            this.cboMetodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.SelectedItem = null;
            this.cboMetodo.Size = new System.Drawing.Size(155, 25);
            this.cboMetodo.TabIndex = 0;
            this.cboMetodo.Leave += new System.EventHandler(this.cboMetodo_Leave);
            // 
            // grbDinheiro
            // 
            this.grbDinheiro.Controls.Add(this.lblTroco);
            this.grbDinheiro.Controls.Add(this.txtDinheiro);
            this.grbDinheiro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDinheiro.Location = new System.Drawing.Point(105, 280);
            this.grbDinheiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDinheiro.Name = "grbDinheiro";
            this.grbDinheiro.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDinheiro.Size = new System.Drawing.Size(340, 60);
            this.grbDinheiro.TabIndex = 8;
            this.grbDinheiro.TabStop = false;
            this.grbDinheiro.Text = "DINHEIRO";
            // 
            // lblTroco
            // 
            this.lblTroco.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(160, 15);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(175, 40);
            this.lblTroco.TabIndex = 34;
            this.lblTroco.Text = "Troco: 0,00";
            this.lblTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.AcceptButton = null;
            this.txtDinheiro.Campo = "Dinheiro*";
            this.txtDinheiro.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtDinheiro.Location = new System.Drawing.Point(5, 25);
            this.txtDinheiro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDinheiro.MaxLength = 32767;
            this.txtDinheiro.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.MONEY;
            this.txtDinheiro.Multiline = false;
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDinheiro.Size = new System.Drawing.Size(150, 21);
            this.txtDinheiro.TabIndex = 0;
            // 
            // frmPagamento
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.grbDinheiro);
            this.Controls.Add(this.grbValorPagar);
            this.Controls.Add(this.grbValorTotal);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbMeio);
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
            this.grbCliente.ResumeLayout(false);
            this.grbValorTotal.ResumeLayout(false);
            this.grbValorPagar.ResumeLayout(false);
            this.grbMeio.ResumeLayout(false);
            this.grbDinheiro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnVoltar;
        private vitorrdgs.UiX.Component.UIXButton btnSalvar;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.Label lblCliente;
        private vitorrdgs.UiX.Component.UIXButton btnCliEncontrar;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbCliCPF;
        private System.Windows.Forms.GroupBox grbValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.GroupBox grbValorPagar;
        private vitorrdgs.UiX.Component.UIXTextBox txtValor;
        public System.Windows.Forms.GroupBox grbMeio;
        private vitorrdgs.UiX.Component.UIXComboBox cboMetodo;
        private vitorrdgs.UiX.Component.UIXComboBox cboBandeira;
        public System.Windows.Forms.GroupBox grbDinheiro;
        private vitorrdgs.UiX.Component.UIXTextBox txtDinheiro;
        private System.Windows.Forms.Label lblTroco;
    }
}