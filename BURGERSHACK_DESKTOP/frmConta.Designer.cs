﻿namespace BurgerShack.Desktop
{
    partial class frmConta
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
            this.btnImprimir = new vitorrdgs.UiX.Component.UIXButton();
            this.grbNota = new System.Windows.Forms.GroupBox();
            this.webConta = new System.Windows.Forms.WebBrowser();
            this.txtPessoas = new vitorrdgs.UiX.Component.UIXTextBox();
            this.btnAtualizar = new vitorrdgs.UiX.Component.UIXButton();
            this.grbValor = new System.Windows.Forms.GroupBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.grbAlterar = new System.Windows.Forms.GroupBox();
            this.chkServico = new System.Windows.Forms.CheckBox();
            this.txtDesconto = new vitorrdgs.UiX.Component.UIXTextBox();
            this.btnFinalizar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnPagamento = new vitorrdgs.UiX.Component.UIXButton();
            this.pnlMenu.SuspendLayout();
            this.grbNota.SuspendLayout();
            this.grbValor.SuspendLayout();
            this.grbAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.conta;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(750, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Conta";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnFinalizar);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnImprimir);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 500);
            this.pnlMenu.TabIndex = 6;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Description = "Cancelar";
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
            // btnImprimir
            // 
            this.btnImprimir.Description = "Imprimir";
            this.btnImprimir.HoverColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Image = global::BurgerShack.Desktop.Properties.Resources.salvar;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.ImageLocation = null;
            this.btnImprimir.Location = new System.Drawing.Point(5, 405);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 90);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // grbNota
            // 
            this.grbNota.Controls.Add(this.webConta);
            this.grbNota.Location = new System.Drawing.Point(105, 55);
            this.grbNota.Name = "grbNota";
            this.grbNota.Size = new System.Drawing.Size(640, 395);
            this.grbNota.TabIndex = 7;
            this.grbNota.TabStop = false;
            this.grbNota.Text = "NOTA";
            // 
            // webConta
            // 
            this.webConta.Location = new System.Drawing.Point(5, 15);
            this.webConta.MaximumSize = new System.Drawing.Size(630, 100000);
            this.webConta.MinimumSize = new System.Drawing.Size(630, 360);
            this.webConta.Name = "webConta";
            this.webConta.Size = new System.Drawing.Size(630, 370);
            this.webConta.TabIndex = 0;
            // 
            // txtPessoas
            // 
            this.txtPessoas.AcceptButton = this.btnAtualizar;
            this.txtPessoas.Campo = "Pessoas";
            this.txtPessoas.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtPessoas.Location = new System.Drawing.Point(5, 15);
            this.txtPessoas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPessoas.MaxLength = 2;
            this.txtPessoas.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.INT;
            this.txtPessoas.Multiline = false;
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPessoas.Size = new System.Drawing.Size(160, 20);
            this.txtPessoas.TabIndex = 8;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Description = "Atualizar";
            this.btnAtualizar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Image = global::BurgerShack.Desktop.Properties.Resources.salvar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.ImageLocation = null;
            this.btnAtualizar.Location = new System.Drawing.Point(170, 15);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(70, 70);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // grbValor
            // 
            this.grbValor.Controls.Add(this.lblValorPago);
            this.grbValor.Controls.Add(this.lblValorTotal);
            this.grbValor.Location = new System.Drawing.Point(500, 455);
            this.grbValor.Name = "grbValor";
            this.grbValor.Size = new System.Drawing.Size(245, 90);
            this.grbValor.TabIndex = 9;
            this.grbValor.TabStop = false;
            this.grbValor.Text = "VALOR";
            // 
            // label1
            // 
            this.lblValorPago.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(5, 20);
            this.lblValorPago.Name = "label1";
            this.lblValorPago.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValorPago.Size = new System.Drawing.Size(230, 30);
            this.lblValorPago.TabIndex = 1;
            this.lblValorPago.Text = "Valor Pago: R$00,00";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(5, 50);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValorTotal.Size = new System.Drawing.Size(230, 30);
            this.lblValorTotal.TabIndex = 0;
            this.lblValorTotal.Text = "Valor Total: R$00,00";
            // 
            // grbAlterar
            // 
            this.grbAlterar.Controls.Add(this.chkServico);
            this.grbAlterar.Controls.Add(this.btnAtualizar);
            this.grbAlterar.Controls.Add(this.txtDesconto);
            this.grbAlterar.Controls.Add(this.txtPessoas);
            this.grbAlterar.Location = new System.Drawing.Point(105, 455);
            this.grbAlterar.Name = "grbAlterar";
            this.grbAlterar.Size = new System.Drawing.Size(245, 90);
            this.grbAlterar.TabIndex = 10;
            this.grbAlterar.TabStop = false;
            this.grbAlterar.Text = "ALTERAR";
            // 
            // chkServico
            // 
            this.chkServico.Location = new System.Drawing.Point(5, 65);
            this.chkServico.Name = "chkServico";
            this.chkServico.Size = new System.Drawing.Size(160, 20);
            this.chkServico.TabIndex = 10;
            this.chkServico.Text = "Incluir Serviço";
            this.chkServico.UseVisualStyleBackColor = true;
            this.chkServico.CheckedChanged += new System.EventHandler(this.chkServico_CheckedChanged);
            // 
            // txtDesconto
            // 
            this.txtDesconto.AcceptButton = this.btnAtualizar;
            this.txtDesconto.Campo = "Desconto";
            this.txtDesconto.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtDesconto.Location = new System.Drawing.Point(5, 40);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDesconto.MaxLength = 5;
            this.txtDesconto.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.DOUBLE;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesconto.Size = new System.Drawing.Size(160, 20);
            this.txtDesconto.TabIndex = 9;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Description = "Finalizar";
            this.btnFinalizar.HoverColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.Image = global::BurgerShack.Desktop.Properties.Resources.confirmar;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizar.ImageLocation = null;
            this.btnFinalizar.Location = new System.Drawing.Point(5, 305);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(90, 90);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Description = "Pagamento";
            this.btnPagamento.HoverColor = System.Drawing.Color.Transparent;
            this.btnPagamento.Image = global::BurgerShack.Desktop.Properties.Resources.pagamento;
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagamento.ImageLocation = null;
            this.btnPagamento.Location = new System.Drawing.Point(380, 455);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(90, 90);
            this.btnPagamento.TabIndex = 8;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // frmConta
            // 
            this.AcceptButton = this.btnImprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.grbAlterar);
            this.Controls.Add(this.grbValor);
            this.Controls.Add(this.grbNota);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.frmConta_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbNota.ResumeLayout(false);
            this.grbValor.ResumeLayout(false);
            this.grbAlterar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnVoltar;
        private vitorrdgs.UiX.Component.UIXButton btnImprimir;
        private System.Windows.Forms.GroupBox grbNota;
        private System.Windows.Forms.WebBrowser webConta;
        private vitorrdgs.UiX.Component.UIXTextBox txtPessoas;
        private System.Windows.Forms.GroupBox grbValor;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.GroupBox grbAlterar;
        private vitorrdgs.UiX.Component.UIXTextBox txtDesconto;
        private vitorrdgs.UiX.Component.UIXButton btnAtualizar;
        private System.Windows.Forms.CheckBox chkServico;
        private vitorrdgs.UiX.Component.UIXButton btnFinalizar;
        private vitorrdgs.UiX.Component.UIXButton btnPagamento;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}