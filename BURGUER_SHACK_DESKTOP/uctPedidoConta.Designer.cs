namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoConta
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
            this.grbPedidoConta = new System.Windows.Forms.GroupBox();
            this.grpInformacoesConta = new System.Windows.Forms.GroupBox();
            this.grpConta = new System.Windows.Forms.GroupBox();
            this.rboCartao = new System.Windows.Forms.RadioButton();
            this.rboDinheiro = new System.Windows.Forms.RadioButton();
            this.grpInformacoes = new System.Windows.Forms.GroupBox();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlTroco = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.txtValor = new UIX.txtUIX();
            this.txtValorDinheiro = new UIX.txtUIX();
            this.cboTributos = new UIX.cboUIX();
            this.txtDesconto = new UIX.txtUIX();
            this.txtClienteNome = new UIX.txtUIX();
            this.mtbClienteCPF = new UIX.mtbUIX();
            this.txtCodPedido = new UIX.txtUIX();
            this.grbPedidoConta.SuspendLayout();
            this.grpInformacoesConta.SuspendLayout();
            this.grpConta.SuspendLayout();
            this.grpInformacoes.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlTroco.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPedidoConta
            // 
            this.grbPedidoConta.Controls.Add(this.grpInformacoesConta);
            this.grbPedidoConta.Controls.Add(this.grpInformacoes);
            this.grbPedidoConta.Controls.Add(this.pnlTotal);
            this.grbPedidoConta.Controls.Add(this.pnlTroco);
            this.grbPedidoConta.Controls.Add(this.ltbProdutos);
            this.grbPedidoConta.Controls.Add(this.btnPedido);
            this.grbPedidoConta.Controls.Add(this.txtCodPedido);
            this.grbPedidoConta.Location = new System.Drawing.Point(5, 5);
            this.grbPedidoConta.Name = "grbPedidoConta";
            this.grbPedidoConta.Size = new System.Drawing.Size(417, 600);
            this.grbPedidoConta.TabIndex = 1;
            this.grbPedidoConta.TabStop = false;
            this.grbPedidoConta.Text = "CONTA DO PEDIDO";
            // 
            // grpInformacoesConta
            // 
            this.grpInformacoesConta.Controls.Add(this.txtValor);
            this.grpInformacoesConta.Controls.Add(this.grpConta);
            this.grpInformacoesConta.Controls.Add(this.rboCartao);
            this.grpInformacoesConta.Controls.Add(this.rboDinheiro);
            this.grpInformacoesConta.Controls.Add(this.cboTributos);
            this.grpInformacoesConta.Location = new System.Drawing.Point(6, 268);
            this.grpInformacoesConta.Name = "grpInformacoesConta";
            this.grpInformacoesConta.Size = new System.Drawing.Size(404, 121);
            this.grpInformacoesConta.TabIndex = 2;
            this.grpInformacoesConta.TabStop = false;
            this.grpInformacoesConta.Text = "INFORMAÇÕES DA CONTA";
            // 
            // grpConta
            // 
            this.grpConta.Controls.Add(this.txtValorDinheiro);
            this.grpConta.Controls.Add(this.txtDesconto);
            this.grpConta.Location = new System.Drawing.Point(6, 68);
            this.grpConta.Name = "grpConta";
            this.grpConta.Size = new System.Drawing.Size(392, 47);
            this.grpConta.TabIndex = 6;
            this.grpConta.TabStop = false;
            this.grpConta.Text = "EXTRAS";
            // 
            // rboCartao
            // 
            this.rboCartao.AutoSize = true;
            this.rboCartao.Location = new System.Drawing.Point(231, 45);
            this.rboCartao.Name = "rboCartao";
            this.rboCartao.Size = new System.Drawing.Size(56, 17);
            this.rboCartao.TabIndex = 5;
            this.rboCartao.Text = "Cartão";
            this.rboCartao.UseVisualStyleBackColor = true;
            this.rboCartao.CheckedChanged += new System.EventHandler(this.rboCartao_CheckedChanged);
            // 
            // rboDinheiro
            // 
            this.rboDinheiro.AutoSize = true;
            this.rboDinheiro.Checked = true;
            this.rboDinheiro.Location = new System.Drawing.Point(133, 45);
            this.rboDinheiro.Name = "rboDinheiro";
            this.rboDinheiro.Size = new System.Drawing.Size(64, 17);
            this.rboDinheiro.TabIndex = 4;
            this.rboDinheiro.TabStop = true;
            this.rboDinheiro.Text = "Dinheiro";
            this.rboDinheiro.UseVisualStyleBackColor = true;
            this.rboDinheiro.CheckedChanged += new System.EventHandler(this.rboDinheiro_CheckedChanged);
            // 
            // grpInformacoes
            // 
            this.grpInformacoes.Controls.Add(this.txtClienteNome);
            this.grpInformacoes.Controls.Add(this.mtbClienteCPF);
            this.grpInformacoes.Location = new System.Drawing.Point(6, 503);
            this.grpInformacoes.Name = "grpInformacoes";
            this.grpInformacoes.Size = new System.Drawing.Size(404, 47);
            this.grpInformacoes.TabIndex = 7;
            this.grpInformacoes.TabStop = false;
            this.grpInformacoes.Text = "INFORMAÇÕES DO CLIENTE";
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.label4);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Location = new System.Drawing.Point(210, 395);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(201, 102);
            this.pnlTotal.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(107, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 33);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "00.00";
            // 
            // pnlTroco
            // 
            this.pnlTroco.Controls.Add(this.label3);
            this.pnlTroco.Controls.Add(this.lblTroco);
            this.pnlTroco.Location = new System.Drawing.Point(6, 395);
            this.pnlTroco.Name = "pnlTroco";
            this.pnlTroco.Size = new System.Drawing.Size(197, 102);
            this.pnlTroco.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "TROCO DO CLIENTE";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(62, 50);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(132, 33);
            this.lblTroco.TabIndex = 3;
            this.lblTroco.Text = "R$ 00.00";
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ltbProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltbProdutos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbProdutos.FormattingEnabled = true;
            this.ltbProdutos.ItemHeight = 14;
            this.ltbProdutos.Items.AddRange(new object[] {
            "----------------------------------------------------------",
            "\t\t  Comercio Burguer Shack",
            "\t\tRua Tuiuva , 180 - Barueri",
            "\tCNPJ: 67.237.358/0001-03 IE: 008.244.210.461",
            "----------------------------------------------------------",
            "DATE\tHOUR\t\tCOO:",
            "----------------------------------------------------------",
            "\t\t\tCUPOM FISCAL",
            "ITEM \tCODIGO \t\tDESCRICAO",
            "\tQUANT. UNITARIO\t\t\t\tVALOR",
            "----------------------------------------------------------"});
            this.ltbProdutos.Location = new System.Drawing.Point(6, 38);
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.Size = new System.Drawing.Size(405, 224);
            this.ltbProdutos.TabIndex = 50;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(270, 554);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(140, 40);
            this.btnPedido.TabIndex = 10;
            this.btnPedido.Text = "Confirmar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.AccessibleName = "Valor da Compra: (R$)";
            this.txtValor.Campo = "Valor da Compra: (R$)";
            this.txtValor.Location = new System.Drawing.Point(6, 19);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(153, 20);
            this.txtValor.TabIndex = 2;
            // 
            // txtValorDinheiro
            // 
            this.txtValorDinheiro.AccessibleName = "Valor em Dinheiro: (R$)";
            this.txtValorDinheiro.Campo = "Valor em Dinheiro: (R$)";
            this.txtValorDinheiro.Location = new System.Drawing.Point(225, 19);
            this.txtValorDinheiro.MaxLength = 32767;
            this.txtValorDinheiro.Name = "txtValorDinheiro";
            this.txtValorDinheiro.Size = new System.Drawing.Size(160, 20);
            this.txtValorDinheiro.TabIndex = 7;
            this.txtValorDinheiro.Leave += new System.EventHandler(this.txtValorDinheiro_Leave);
            // 
            // cboTributos
            // 
            this.cboTributos.AccessibleName = "Tributos";
            this.cboTributos.Campo = "Tributos";
            this.cboTributos.FormattingEnabled = true;
            this.cboTributos.Location = new System.Drawing.Point(248, 19);
            this.cboTributos.Name = "cboTributos";
            this.cboTributos.Size = new System.Drawing.Size(150, 20);
            this.cboTributos.TabIndex = 3;
            // 
            // txtDesconto
            // 
            this.txtDesconto.AccessibleName = "Desconto";
            this.txtDesconto.Campo = "Desconto";
            this.txtDesconto.Location = new System.Drawing.Point(6, 19);
            this.txtDesconto.MaxLength = 32767;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(130, 20);
            this.txtDesconto.TabIndex = 6;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.AccessibleName = "Nome";
            this.txtClienteNome.Campo = "Nome";
            this.txtClienteNome.Location = new System.Drawing.Point(6, 19);
            this.txtClienteNome.MaxLength = 32767;
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(252, 20);
            this.txtClienteNome.TabIndex = 8;
            // 
            // mtbClienteCPF
            // 
            this.mtbClienteCPF.AccessibleName = "CPF";
            this.mtbClienteCPF.Campo = "CPF";
            this.mtbClienteCPF.Location = new System.Drawing.Point(264, 19);
            this.mtbClienteCPF.Mask = "";
            this.mtbClienteCPF.MaxLength = 32767;
            this.mtbClienteCPF.Name = "mtbClienteCPF";
            this.mtbClienteCPF.Size = new System.Drawing.Size(134, 20);
            this.mtbClienteCPF.TabIndex = 9;
            this.mtbClienteCPF.ValidatingType = null;
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.AccessibleName = "CÓDIGO DO PEDIDO:";
            this.txtCodPedido.Campo = "CÓDIGO DO PEDIDO:";
            this.txtCodPedido.Location = new System.Drawing.Point(10, 13);
            this.txtCodPedido.MaxLength = 32767;
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.Size = new System.Drawing.Size(164, 19);
            this.txtCodPedido.TabIndex = 1;
            // 
            // uctPedidoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPedidoConta);
            this.Name = "uctPedidoConta";
            this.Size = new System.Drawing.Size(430, 610);
            this.grbPedidoConta.ResumeLayout(false);
            this.grpInformacoesConta.ResumeLayout(false);
            this.grpInformacoesConta.PerformLayout();
            this.grpConta.ResumeLayout(false);
            this.grpInformacoes.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlTroco.ResumeLayout(false);
            this.pnlTroco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPedidoConta;
        private System.Windows.Forms.Button btnPedido;
        private UIX.txtUIX txtCodPedido;
        private System.Windows.Forms.ListBox ltbProdutos;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlTroco;
        private System.Windows.Forms.GroupBox grpInformacoes;
        private UIX.mtbUIX mtbClienteCPF;
        private UIX.txtUIX txtClienteNome;
        private System.Windows.Forms.GroupBox grpInformacoesConta;
        private UIX.txtUIX txtDesconto;
        private UIX.cboUIX cboTributos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton rboCartao;
        private System.Windows.Forms.RadioButton rboDinheiro;
        private System.Windows.Forms.GroupBox grpConta;
        private UIX.txtUIX txtValorDinheiro;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private UIX.txtUIX txtValor;
    }
}
