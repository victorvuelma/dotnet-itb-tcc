namespace BURGUER_SHACK_DESKTOP
{
    partial class frmUtilVisualizar
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
            this.pnlOpcoes = new System.Windows.Forms.Panel();
            this.hdrUIX = new UIX.hdrUIX();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblPesquisaRes = new System.Windows.Forms.Label();
            this.txtPesquisar = new UIX.txtUIX();
            this.btnPesquisar = new UIX.btnUIX();
            this.grbOpcoes.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.pnlOpcoes);
            this.grbOpcoes.Location = new System.Drawing.Point(5, 165);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(540, 380);
            this.grbOpcoes.TabIndex = 5;
            this.grbOpcoes.TabStop = false;
            // 
            // pnlOpcoes
            // 
            this.pnlOpcoes.AutoScroll = true;
            this.pnlOpcoes.Location = new System.Drawing.Point(5, 15);
            this.pnlOpcoes.MaximumSize = new System.Drawing.Size(530, 1000);
            this.pnlOpcoes.Name = "pnlOpcoes";
            this.pnlOpcoes.Size = new System.Drawing.Size(530, 355);
            this.pnlOpcoes.TabIndex = 0;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(550, 50);
            this.hdrUIX.TabIndex = 4;
            this.hdrUIX.Title = "Visualizar";
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
            this.grbPesquisa.TabIndex = 3;
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
            this.txtPesquisar.AllowedChars = UIX.uixEnum.uixAllowedChars.ALL;
            this.txtPesquisar.Campo = "Pesquisar por";
            this.txtPesquisar.LabelPosition = UIX.uixEnum.uixLabelPosition.UP;
            this.txtPesquisar.Location = new System.Drawing.Point(5, 25);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.Multiline = false;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisar.Size = new System.Drawing.Size(440, 40);
            this.txtPesquisar.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Description = "Pesquisar";
            this.btnPesquisar.HoverColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pesquisar;
            this.btnPesquisar.ImageLocation = null;
            this.btnPesquisar.Location = new System.Drawing.Point(450, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 80);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "btnUIX1";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmUtilVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.grbOpcoes);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUtilVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "8";
            this.Load += new System.EventHandler(this.frmUtilVisualizar_Load);
            this.grbOpcoes.ResumeLayout(false);
            this.grbPesquisa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbOpcoes;
        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel pnlOpcoes;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Label lblPesquisaRes;
        private UIX.txtUIX txtPesquisar;
        private UIX.btnUIX btnPesquisar;
    }
}