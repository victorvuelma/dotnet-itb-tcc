﻿namespace BURGUER_SHACK_DESKTOP
{
    partial class frmPedidoIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoIngrediente));
            this.grbIngrediente = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new UIX.txtUIX();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.picIngrediente = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.hdrUIX = new UIX.hdrUIX();
            this.grbIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIngrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // grbIngrediente
            // 
            this.grbIngrediente.Controls.Add(this.txtQuantidade);
            this.grbIngrediente.Controls.Add(this.btnAlterar);
            this.grbIngrediente.Controls.Add(this.lblNome);
            this.grbIngrediente.Controls.Add(this.picIngrediente);
            this.grbIngrediente.Location = new System.Drawing.Point(5, 55);
            this.grbIngrediente.Name = "grbIngrediente";
            this.grbIngrediente.Size = new System.Drawing.Size(440, 145);
            this.grbIngrediente.TabIndex = 7;
            this.grbIngrediente.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.AllowedChars = UIX.uixAllowedChars.INT;
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtQuantidade.Location = new System.Drawing.Point(135, 110);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(175, 25);
            this.txtQuantidade.TabIndex = 4;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(315, 95);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 40);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(130, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(305, 30);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "N";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picIngrediente
            // 
            this.picIngrediente.Location = new System.Drawing.Point(5, 15);
            this.picIngrediente.Name = "picIngrediente";
            this.picIngrediente.Size = new System.Drawing.Size(120, 120);
            this.picIngrediente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIngrediente.TabIndex = 0;
            this.picIngrediente.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(325, 205);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 40);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(5, 205);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 40);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pedido;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(450, 50);
            this.hdrUIX.TabIndex = 6;
            this.hdrUIX.Title = "Pedido Ingrediente";
            // 
            // frmPedidoIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.grbIngrediente);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPedidoIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedido Ingrediente";
            this.Load += new System.EventHandler(this.frmAlteraIngrediente_Load);
            this.grbIngrediente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIngrediente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIngrediente;
        private UIX.txtUIX txtQuantidade;
        public System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox picIngrediente;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Button btnRemover;
        private UIX.hdrUIX hdrUIX;
    }
}