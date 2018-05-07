namespace BURGUER_SHACK_DESKTOP
{
    partial class frmAlteraIngrediente
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
            this.grbAntigo = new System.Windows.Forms.GroupBox();
            this.picAntigo = new System.Windows.Forms.PictureBox();
            this.lblAntigoNome = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnEscolher = new System.Windows.Forms.Button();
            this.grbNovo = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblNovoNome = new System.Windows.Forms.Label();
            this.picNovo = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new UIX.txtUIX();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grbAntigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAntigo)).BeginInit();
            this.grbNovo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNovo)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = true;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(325, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Alterar Ingrediente";
            // 
            // grbAntigo
            // 
            this.grbAntigo.Controls.Add(this.btnEscolher);
            this.grbAntigo.Controls.Add(this.lblQuantidade);
            this.grbAntigo.Controls.Add(this.lblAntigoNome);
            this.grbAntigo.Controls.Add(this.picAntigo);
            this.grbAntigo.Location = new System.Drawing.Point(5, 55);
            this.grbAntigo.Name = "grbAntigo";
            this.grbAntigo.Size = new System.Drawing.Size(150, 275);
            this.grbAntigo.TabIndex = 1;
            this.grbAntigo.TabStop = false;
            this.grbAntigo.Text = "Alterar:";
            // 
            // picAntigo
            // 
            this.picAntigo.Location = new System.Drawing.Point(10, 20);
            this.picAntigo.Name = "picAntigo";
            this.picAntigo.Size = new System.Drawing.Size(130, 130);
            this.picAntigo.TabIndex = 0;
            this.picAntigo.TabStop = false;
            // 
            // lblAntigoNome
            // 
            this.lblAntigoNome.Location = new System.Drawing.Point(5, 160);
            this.lblAntigoNome.Name = "lblAntigoNome";
            this.lblAntigoNome.Size = new System.Drawing.Size(140, 30);
            this.lblAntigoNome.TabIndex = 1;
            this.lblAntigoNome.Text = "N";
            this.lblAntigoNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Location = new System.Drawing.Point(5, 200);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(140, 30);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Q";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEscolher
            // 
            this.btnEscolher.Location = new System.Drawing.Point(10, 235);
            this.btnEscolher.Name = "btnEscolher";
            this.btnEscolher.Size = new System.Drawing.Size(130, 35);
            this.btnEscolher.TabIndex = 3;
            this.btnEscolher.Text = "Escolher";
            this.btnEscolher.UseVisualStyleBackColor = true;
            // 
            // grbNovo
            // 
            this.grbNovo.Controls.Add(this.txtQuantidade);
            this.grbNovo.Controls.Add(this.btnAlterar);
            this.grbNovo.Controls.Add(this.lblNovoNome);
            this.grbNovo.Controls.Add(this.picNovo);
            this.grbNovo.Location = new System.Drawing.Point(170, 55);
            this.grbNovo.Name = "grbNovo";
            this.grbNovo.Size = new System.Drawing.Size(150, 275);
            this.grbNovo.TabIndex = 4;
            this.grbNovo.TabStop = false;
            this.grbNovo.Text = "Novo:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(10, 235);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 35);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblNovoNome
            // 
            this.lblNovoNome.Location = new System.Drawing.Point(5, 160);
            this.lblNovoNome.Name = "lblNovoNome";
            this.lblNovoNome.Size = new System.Drawing.Size(140, 30);
            this.lblNovoNome.TabIndex = 1;
            this.lblNovoNome.Text = "N";
            this.lblNovoNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picNovo
            // 
            this.picNovo.Location = new System.Drawing.Point(10, 20);
            this.picNovo.Name = "picNovo";
            this.picNovo.Size = new System.Drawing.Size(130, 130);
            this.picNovo.TabIndex = 0;
            this.picNovo.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.AllowedChars = UIX.uixAllowedChars.INT;
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.Location = new System.Drawing.Point(10, 200);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(130, 25);
            this.txtQuantidade.TabIndex = 4;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(5, 336);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 40);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(215, 336);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 40);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // frmAlteraIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 385);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.grbNovo);
            this.Controls.Add(this.grbAntigo);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlteraIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar Ingrediente";
            this.Load += new System.EventHandler(this.frmAlteraIngrediente_Load);
            this.grbAntigo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAntigo)).EndInit();
            this.grbNovo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNovo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.GroupBox grbAntigo;
        private System.Windows.Forms.PictureBox picAntigo;
        private System.Windows.Forms.Label lblAntigoNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnEscolher;
        private System.Windows.Forms.GroupBox grbNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblNovoNome;
        private System.Windows.Forms.PictureBox picNovo;
        private UIX.txtUIX txtQuantidade;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnConfirmar;
    }
}