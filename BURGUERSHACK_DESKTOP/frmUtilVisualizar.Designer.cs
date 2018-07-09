namespace BURGUERSHACK_DESKTOP
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
            this.uctOpcoes = new BURGUERSHACK_DESKTOP.uctUtilListar();
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
            this.grbOpcoes.Controls.Add(this.uctOpcoes);
            this.grbOpcoes.Location = new System.Drawing.Point(5, 190);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(590, 405);
            this.grbOpcoes.TabIndex = 5;
            this.grbOpcoes.TabStop = false;
            // 
            // uctOpcoes
            // 
            this.uctOpcoes.AutoScroll = true;
            this.uctOpcoes.Espacamento = 10;
            this.uctOpcoes.Location = new System.Drawing.Point(5, 15);
            this.uctOpcoes.MaximumSize = new System.Drawing.Size(580, 10000);
            this.uctOpcoes.Name = "uctOpcoes";
            this.uctOpcoes.PosIndex = 0;
            this.uctOpcoes.Size = new System.Drawing.Size(580, 380);
            this.uctOpcoes.TabIndex = 0;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.lista;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(600, 50);
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
            this.grbPesquisa.Size = new System.Drawing.Size(590, 120);
            this.grbPesquisa.TabIndex = 3;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "ENCONTRAR";
            // 
            // lblPesquisaRes
            // 
            this.lblPesquisaRes.Location = new System.Drawing.Point(5, 80);
            this.lblPesquisaRes.Name = "lblPesquisaRes";
            this.lblPesquisaRes.Size = new System.Drawing.Size(475, 30);
            this.lblPesquisaRes.TabIndex = 4;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AcceptButton = this.btnPesquisar;
            this.txtPesquisar.Campo = "Pesquisar por";
            this.txtPesquisar.LabelPosition = UIX.uixEnum.uixLabelPosition.UP;
            this.txtPesquisar.Location = new System.Drawing.Point(5, 20);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
            this.txtPesquisar.Multiline = false;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisar.Size = new System.Drawing.Size(475, 40);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.TextChange += new System.EventHandler(this.txtPesquisar_TextChange);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Description = "Pesquisar";
            this.btnPesquisar.HoverColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.pesquisar;
            this.btnPesquisar.ImageLocation = null;
            this.btnPesquisar.Location = new System.Drawing.Point(485, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 100);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "btnUIX1";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmUtilVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
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
        private BURGUERSHACK_DESKTOP.uctUtilListar uctOpcoes;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Label lblPesquisaRes;
        private UIX.txtUIX txtPesquisar;
        private UIX.btnUIX btnPesquisar;
    }
}