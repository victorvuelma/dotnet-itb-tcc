namespace BURGUER_SHACK_DESKTOP
{
    partial class uctAtendimentoConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctAtendimentoConta));
            this.grbPedidoConta = new System.Windows.Forms.GroupBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.cboImpressora = new System.Windows.Forms.ComboBox();
            this.grpInformacoesConta = new System.Windows.Forms.GroupBox();
            this.txtValor = new UIX.txtUIX();
            this.grpConta = new System.Windows.Forms.GroupBox();
            this.txtValorDinheiro = new UIX.txtUIX();
            this.txtDesconto = new UIX.txtUIX();
            this.rboCartao = new System.Windows.Forms.RadioButton();
            this.rboDinheiro = new System.Windows.Forms.RadioButton();
            this.grpInformacoes = new System.Windows.Forms.GroupBox();
            this.txtClienteNome = new UIX.txtUIX();
            this.mtbClienteCPF = new UIX.mtbUIX();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlTroco = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
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
            this.grbPedidoConta.Controls.Add(this.txtNota);
            this.grbPedidoConta.Controls.Add(this.cboImpressora);
            this.grbPedidoConta.Controls.Add(this.grpInformacoesConta);
            this.grbPedidoConta.Controls.Add(this.grpInformacoes);
            this.grbPedidoConta.Controls.Add(this.pnlTotal);
            this.grbPedidoConta.Controls.Add(this.pnlTroco);
            this.grbPedidoConta.Location = new System.Drawing.Point(5, 5);
            this.grbPedidoConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPedidoConta.Name = "grbPedidoConta";
            this.grbPedidoConta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPedidoConta.Size = new System.Drawing.Size(490, 690);
            this.grbPedidoConta.TabIndex = 1;
            this.grbPedidoConta.TabStop = false;
            this.grbPedidoConta.Text = "CONTA DA MESA";
            this.grbPedidoConta.Enter += new System.EventHandler(this.grbPedidoConta_Enter);
            // 
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtNota.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(5, 20);
            this.txtNota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ReadOnly = true;
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNota.Size = new System.Drawing.Size(480, 280);
            this.txtNota.TabIndex = 7;
            this.txtNota.Text = resources.GetString("txtNota.Text");
            // 
            // cboImpressora
            // 
            this.cboImpressora.FormattingEnabled = true;
            this.cboImpressora.Location = new System.Drawing.Point(337, 17);
            this.cboImpressora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboImpressora.Name = "cboImpressora";
            this.cboImpressora.Size = new System.Drawing.Size(140, 24);
            this.cboImpressora.TabIndex = 51;
            this.cboImpressora.Visible = false;
            // 
            // grpInformacoesConta
            // 
            this.grpInformacoesConta.Controls.Add(this.txtValor);
            this.grpInformacoesConta.Controls.Add(this.grpConta);
            this.grpInformacoesConta.Controls.Add(this.rboCartao);
            this.grpInformacoesConta.Controls.Add(this.rboDinheiro);
            this.grpInformacoesConta.Location = new System.Drawing.Point(5, 310);
            this.grpInformacoesConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInformacoesConta.Name = "grpInformacoesConta";
            this.grpInformacoesConta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInformacoesConta.Size = new System.Drawing.Size(480, 150);
            this.grpInformacoesConta.TabIndex = 2;
            this.grpInformacoesConta.TabStop = false;
            // 
            // txtValor
            // 
            this.txtValor.AccessibleName = "Valor da Compra (R$)";
            this.txtValor.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
            this.txtValor.Campo = "Valor da Compra (R$)";
            this.txtValor.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtValor.Location = new System.Drawing.Point(7, 23);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.Size = new System.Drawing.Size(178, 25);
            this.txtValor.TabIndex = 2;
            // 
            // grpConta
            // 
            this.grpConta.Controls.Add(this.txtValorDinheiro);
            this.grpConta.Controls.Add(this.txtDesconto);
            this.grpConta.Location = new System.Drawing.Point(7, 84);
            this.grpConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpConta.Name = "grpConta";
            this.grpConta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpConta.Size = new System.Drawing.Size(457, 58);
            this.grpConta.TabIndex = 6;
            this.grpConta.TabStop = false;
            // 
            // txtValorDinheiro
            // 
            this.txtValorDinheiro.AccessibleName = "Valor em Dinheiro (R$)";
            this.txtValorDinheiro.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
            this.txtValorDinheiro.Campo = "Valor em Dinheiro (R$)";
            this.txtValorDinheiro.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtValorDinheiro.Location = new System.Drawing.Point(262, 23);
            this.txtValorDinheiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorDinheiro.MaxLength = 32767;
            this.txtValorDinheiro.Multiline = false;
            this.txtValorDinheiro.Name = "txtValorDinheiro";
            this.txtValorDinheiro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorDinheiro.Size = new System.Drawing.Size(187, 25);
            this.txtValorDinheiro.TabIndex = 7;
            this.txtValorDinheiro.Leave += new System.EventHandler(this.txtValorDinheiro_Leave);
            // 
            // txtDesconto
            // 
            this.txtDesconto.AccessibleName = "Desconto (R$)";
            this.txtDesconto.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
            this.txtDesconto.Campo = "Desconto (R$)";
            this.txtDesconto.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtDesconto.Location = new System.Drawing.Point(7, 23);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesconto.MaxLength = 32767;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesconto.Size = new System.Drawing.Size(157, 25);
            this.txtDesconto.TabIndex = 6;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // rboCartao
            // 
            this.rboCartao.AutoSize = true;
            this.rboCartao.Location = new System.Drawing.Point(353, 27);
            this.rboCartao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rboCartao.Name = "rboCartao";
            this.rboCartao.Size = new System.Drawing.Size(65, 20);
            this.rboCartao.TabIndex = 5;
            this.rboCartao.Text = "Cartão";
            this.rboCartao.UseVisualStyleBackColor = true;
            this.rboCartao.CheckedChanged += new System.EventHandler(this.rboCartao_CheckedChanged);
            // 
            // rboDinheiro
            // 
            this.rboDinheiro.AutoSize = true;
            this.rboDinheiro.Checked = true;
            this.rboDinheiro.Location = new System.Drawing.Point(238, 27);
            this.rboDinheiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rboDinheiro.Name = "rboDinheiro";
            this.rboDinheiro.Size = new System.Drawing.Size(69, 20);
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
            this.grpInformacoes.Controls.Add(this.btnFinalizar);
            this.grpInformacoes.Location = new System.Drawing.Point(5, 580);
            this.grpInformacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInformacoes.Name = "grpInformacoes";
            this.grpInformacoes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInformacoes.Size = new System.Drawing.Size(480, 50);
            this.grpInformacoes.TabIndex = 7;
            this.grpInformacoes.TabStop = false;
            this.grpInformacoes.Text = "INFORMAÇÕES DO CLIENTE";
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.AccessibleName = "Nome";
            this.txtClienteNome.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
            this.txtClienteNome.Campo = "Nome";
            this.txtClienteNome.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.txtClienteNome.Location = new System.Drawing.Point(7, 23);
            this.txtClienteNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClienteNome.MaxLength = 32767;
            this.txtClienteNome.Multiline = false;
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteNome.Size = new System.Drawing.Size(294, 25);
            this.txtClienteNome.TabIndex = 8;
            // 
            // mtbClienteCPF
            // 
            this.mtbClienteCPF.AccessibleName = "CPF";
            this.mtbClienteCPF.Campo = "CPF";
            this.mtbClienteCPF.LabelPosition = UIX.uixEnum.uixLabelPosition.SIDE;
            this.mtbClienteCPF.Location = new System.Drawing.Point(308, 23);
            this.mtbClienteCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbClienteCPF.Mask = "";
            this.mtbClienteCPF.MaxLength = 32767;
            this.mtbClienteCPF.Name = "mtbClienteCPF";
            this.mtbClienteCPF.Size = new System.Drawing.Size(156, 25);
            this.mtbClienteCPF.TabIndex = 9;
            this.mtbClienteCPF.ValidatingType = null;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.label4);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Location = new System.Drawing.Point(250, 470);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(230, 100);
            this.pnlTotal.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "VALOR TOTAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 60);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(230, 30);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "R$ 00.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTroco
            // 
            this.pnlTroco.Controls.Add(this.label3);
            this.pnlTroco.Controls.Add(this.lblTroco);
            this.pnlTroco.Location = new System.Drawing.Point(5, 470);
            this.pnlTroco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTroco.Name = "pnlTroco";
            this.pnlTroco.Size = new System.Drawing.Size(230, 100);
            this.pnlTroco.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "TROCO DO CLIENTE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTroco
            // 
            this.lblTroco.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(0, 60);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(230, 30);
            this.lblTroco.TabIndex = 3;
            this.lblTroco.Text = "R$ 00.00";
            this.lblTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(316, 12);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(163, 49);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Fechar Mesa";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // uctAtendimentoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPedidoConta);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctAtendimentoConta";
            this.Size = new System.Drawing.Size(500, 650);
            this.Load += new System.EventHandler(this.uctPedidoConta_Load);
            this.grbPedidoConta.ResumeLayout(false);
            this.grbPedidoConta.PerformLayout();
            this.grpInformacoesConta.ResumeLayout(false);
            this.grpInformacoesConta.PerformLayout();
            this.grpConta.ResumeLayout(false);
            this.grpInformacoes.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlTroco.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPedidoConta;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlTroco;
        private System.Windows.Forms.GroupBox grpInformacoes;
        private UIX.mtbUIX mtbClienteCPF;
        private UIX.txtUIX txtClienteNome;
        private System.Windows.Forms.GroupBox grpInformacoesConta;
        private UIX.txtUIX txtDesconto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton rboCartao;
        private System.Windows.Forms.RadioButton rboDinheiro;
        private System.Windows.Forms.GroupBox grpConta;
        private UIX.txtUIX txtValorDinheiro;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private UIX.txtUIX txtValor;
        private System.Windows.Forms.ComboBox cboImpressora;
        private System.Windows.Forms.TextBox txtNota;
    }
}
