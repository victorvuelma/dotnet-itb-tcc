namespace BURGUER_SHACK_DESKTOP
{
    partial class frmSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionar));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grbDetalhes = new System.Windows.Forms.GroupBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlOpcoes = new System.Windows.Forms.Panel();
            this.txtQuantidade = new UIX.txtUIX();
            this.txtPesquisa = new UIX.txtUIX();
            this.hdrUIX = new UIX.hdrUIX();
            this.grbDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.grbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(560, 495);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(185, 50);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // grbDetalhes
            // 
            this.grbDetalhes.Controls.Add(this.lblDesc);
            this.grbDetalhes.Controls.Add(this.txtQuantidade);
            this.grbDetalhes.Controls.Add(this.lblNome);
            this.grbDetalhes.Controls.Add(this.picImagem);
            this.grbDetalhes.Location = new System.Drawing.Point(560, 55);
            this.grbDetalhes.Name = "grbDetalhes";
            this.grbDetalhes.Size = new System.Drawing.Size(185, 435);
            this.grbDetalhes.TabIndex = 6;
            this.grbDetalhes.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(10, 235);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(165, 150);
            this.lblDesc.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(10, 190);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(165, 40);
            this.lblNome.TabIndex = 1;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(10, 15);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(165, 165);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnPesquisar);
            this.grbOpcoes.Controls.Add(this.txtPesquisa);
            this.grbOpcoes.Controls.Add(this.pnlOpcoes);
            this.grbOpcoes.Location = new System.Drawing.Point(5, 55);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(550, 485);
            this.grbOpcoes.TabIndex = 5;
            this.grbOpcoes.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(450, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(95, 25);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // pnlOpcoes
            // 
            this.pnlOpcoes.AutoScroll = true;
            this.pnlOpcoes.Location = new System.Drawing.Point(5, 50);
            this.pnlOpcoes.MaximumSize = new System.Drawing.Size(540, 1000);
            this.pnlOpcoes.Name = "pnlOpcoes";
            this.pnlOpcoes.Size = new System.Drawing.Size(540, 425);
            this.pnlOpcoes.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.Location = new System.Drawing.Point(10, 400);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(165, 20);
            this.txtQuantidade.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AccessibleName = "Pesquisar";
            this.txtPesquisa.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtPesquisa.Campo = "Pesquisar";
            this.txtPesquisa.Location = new System.Drawing.Point(5, 15);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(440, 25);
            this.txtPesquisa.TabIndex = 1;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(750, 50);
            this.hdrUIX.TabIndex = 4;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = null;
            this.hdrUIX.Text = "Selecione";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // frmSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grbDetalhes);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecione";
            this.Load += new System.EventHandler(this.frmSelecionar_Load);
            this.grbDetalhes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.grbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox grbDetalhes;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel pnlOpcoes;
        private UIX.txtUIX txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox picImagem;
        private UIX.txtUIX txtQuantidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDesc;
    }
}