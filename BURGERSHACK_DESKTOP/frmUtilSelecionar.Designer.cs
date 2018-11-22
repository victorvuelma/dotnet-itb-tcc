namespace BurgerShack.Desktop
{
    partial class frmUtilSelecionar
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
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.lstOpcoes = new vitorrdgs.UiX.Component.UIXItemsList();
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblPesquisaRes = new System.Windows.Forms.Label();
            this.txtPesquisar = new vitorrdgs.UiX.Component.UIXTextBox();
            this.btnPesquisar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnConfirmar = new vitorrdgs.UiX.Component.UIXButton();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new vitorrdgs.UiX.Component.UIXTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.grbDetalhes = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbOpcoes.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.grbDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.lstOpcoes);
            this.grbOpcoes.Location = new System.Drawing.Point(5, 170);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(540, 370);
            this.grbOpcoes.TabIndex = 5;
            this.grbOpcoes.TabStop = false;
            // 
            // lstOpcoes
            // 
            this.lstOpcoes.AutoRender = true;
            this.lstOpcoes.AutoScroll = true;
            this.lstOpcoes.ItemsSize = 100;
            this.lstOpcoes.ItemsSpace = 10;
            this.lstOpcoes.Location = new System.Drawing.Point(5, 15);
            this.lstOpcoes.MaximumSize = new System.Drawing.Size(530, 10000);
            this.lstOpcoes.Name = "lstOpcoes";
            this.lstOpcoes.PosIndex = 0;
            this.lstOpcoes.Size = new System.Drawing.Size(530, 350);
            this.lstOpcoes.TabIndex = 0;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.alterar;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(750, 50);
            this.hdrUIX.TabIndex = 4;
            this.hdrUIX.Title = "Selecione";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.lblPesquisaRes);
            this.grbPesquisa.Controls.Add(this.txtPesquisar);
            this.grbPesquisa.Controls.Add(this.btnPesquisar);
            this.grbPesquisa.Location = new System.Drawing.Point(5, 55);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(540, 105);
            this.grbPesquisa.TabIndex = 4;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "ENCONTRAR";
            // 
            // lblPesquisaRes
            // 
            this.lblPesquisaRes.Location = new System.Drawing.Point(5, 75);
            this.lblPesquisaRes.Name = "lblPesquisaRes";
            this.lblPesquisaRes.Size = new System.Drawing.Size(440, 20);
            this.lblPesquisaRes.TabIndex = 4;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AcceptButton = this.btnPesquisar;
            this.txtPesquisar.Campo = "Pesquisar por";
            this.txtPesquisar.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.UP;
            this.txtPesquisar.Location = new System.Drawing.Point(5, 30);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtPesquisar.Multiline = false;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisar.Size = new System.Drawing.Size(440, 40);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.TextChange += new System.EventHandler(this.txtPesquisar_TextChange);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Description = "PESQUISAR";
            this.btnPesquisar.HoverColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Image = global::BurgerShack.Desktop.Properties.Resources.pesquisar;
            this.btnPesquisar.ImageLocation = null;
            this.btnPesquisar.Location = new System.Drawing.Point(450, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 80);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "btnUIX1";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Description = "CONFIRMAR";
            this.btnConfirmar.HoverColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Image = global::BurgerShack.Desktop.Properties.Resources.confirmar;
            this.btnConfirmar.ImageLocation = null;
            this.btnConfirmar.Location = new System.Drawing.Point(555, 400);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 140);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "btnUIX1";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(10, 20);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(120, 120);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AcceptButton = null;
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtQuantidade.Location = new System.Drawing.Point(6, 394);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantidade.Size = new System.Drawing.Size(152, 26);
            this.txtQuantidade.TabIndex = 2;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(5, 205);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(130, 120);
            this.lblDesc.TabIndex = 3;
            // 
            // grbDetalhes
            // 
            this.grbDetalhes.Controls.Add(this.lblDesc);
            this.grbDetalhes.Controls.Add(this.txtQuantidade);
            this.grbDetalhes.Controls.Add(this.lblNome);
            this.grbDetalhes.Controls.Add(this.picImagem);
            this.grbDetalhes.Location = new System.Drawing.Point(555, 55);
            this.grbDetalhes.Name = "grbDetalhes";
            this.grbDetalhes.Size = new System.Drawing.Size(140, 335);
            this.grbDetalhes.TabIndex = 6;
            this.grbDetalhes.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(5, 150);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(130, 50);
            this.lblNome.TabIndex = 1;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmUtilSelecionar
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.grbDetalhes);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUtilSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecione";
            this.Load += new System.EventHandler(this.frmSelecionar_Load);
            this.grbOpcoes.ResumeLayout(false);
            this.grbPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.grbDetalhes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbOpcoes;
        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private vitorrdgs.UiX.Component.UIXItemsList lstOpcoes;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Label lblPesquisaRes;
        private vitorrdgs.UiX.Component.UIXTextBox txtPesquisar;
        private vitorrdgs.UiX.Component.UIXButton btnPesquisar;
        private vitorrdgs.UiX.Component.UIXButton btnConfirmar;
        private System.Windows.Forms.PictureBox picImagem;
        public vitorrdgs.UiX.Component.UIXTextBox txtQuantidade;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.GroupBox grbDetalhes;
        private System.Windows.Forms.Label lblNome;
    }
}