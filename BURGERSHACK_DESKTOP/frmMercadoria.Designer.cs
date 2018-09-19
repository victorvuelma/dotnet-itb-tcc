namespace BurgerShack.Desktop
{
    partial class frmMercadoria
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExcluir = new vitorrdgs.UiX.Component.UIXButton();
            this.btnVoltar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAlterar = new vitorrdgs.UiX.Component.UIXButton();
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtDescricao = new vitorrdgs.UiX.Component.UIXTextBox();
            this.chkBaixar = new System.Windows.Forms.CheckBox();
            this.pnlMenu.SuspendLayout();
            this.grbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnExcluir);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 300);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Description = "EXCLUIR";
            this.btnExcluir.HoverColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Image = global::BurgerShack.Desktop.Properties.Resources.excluir;
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
            this.btnVoltar.Text = "Voltar";
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
            this.btnAlterar.Text = "Editar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.mercadoria;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(400, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Mesa";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.chkBaixar);
            this.grbInformacoes.Controls.Add(this.lblSituacao);
            this.grbInformacoes.Controls.Add(this.txtCodigoBarras);
            this.grbInformacoes.Controls.Add(this.txtDescricao);
            this.grbInformacoes.Location = new System.Drawing.Point(105, 55);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(290, 180);
            this.grbInformacoes.TabIndex = 6;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "INFORMAÇÕES";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(5, 120);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(60, 16);
            this.lblSituacao.TabIndex = 2;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.AcceptButton = null;
            this.txtCodigoBarras.Campo = "Código de Barras*";
            this.txtCodigoBarras.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.UP;
            this.txtCodigoBarras.Location = new System.Drawing.Point(5, 70);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCodigoBarras.MaxLength = 32767;
            this.txtCodigoBarras.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.INT;
            this.txtCodigoBarras.Multiline = false;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoBarras.Size = new System.Drawing.Size(280, 40);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptButton = null;
            this.txtDescricao.Campo = "Descrição*";
            this.txtDescricao.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.UP;
            this.txtDescricao.Location = new System.Drawing.Point(5, 20);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.Size = new System.Drawing.Size(280, 40);
            this.txtDescricao.TabIndex = 0;
            // 
            // chkBaixar
            // 
            this.chkBaixar.AutoSize = true;
            this.chkBaixar.Checked = true;
            this.chkBaixar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBaixar.Location = new System.Drawing.Point(10, 150);
            this.chkBaixar.Name = "chkBaixar";
            this.chkBaixar.Size = new System.Drawing.Size(163, 20);
            this.chkBaixar.TabIndex = 3;
            this.chkBaixar.Text = "Baixar automaticamente";
            this.chkBaixar.UseVisualStyleBackColor = true;
            // 
            // frmMercadoria
            // 
            this.AcceptButton = this.btnAlterar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mesa";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnVoltar;
        private vitorrdgs.UiX.Component.UIXButton btnAlterar;
        private vitorrdgs.UiX.Component.UIXButton btnExcluir;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private vitorrdgs.UiX.Component.UIXTextBox txtDescricao;
        private vitorrdgs.UiX.Component.UIXTextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.CheckBox chkBaixar;
    }
}