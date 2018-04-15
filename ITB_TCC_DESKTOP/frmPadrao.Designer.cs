namespace ITB_TCC_DESKTOP
{
    partial class frmPadrao
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
            this.lblUix = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picFormIcon = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUix
            // 
            this.lblUix.AutoSize = true;
            this.lblUix.Location = new System.Drawing.Point(201, 11);
            this.lblUix.Name = "lblUix";
            this.lblUix.Size = new System.Drawing.Size(50, 16);
            this.lblUix.TabIndex = 9;
            this.lblUix.Text = "labeluix";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(51, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 16);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Burguer Shack - ???";
            // 
            // picFormIcon
            // 
            this.picFormIcon.Location = new System.Drawing.Point(3, 4);
            this.picFormIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picFormIcon.Name = "picFormIcon";
            this.picFormIcon.Size = new System.Drawing.Size(41, 41);
            this.picFormIcon.TabIndex = 7;
            this.picFormIcon.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(411, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 34);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.Text = "MIN";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(462, 2);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 34);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "CLO";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // ctlPedido1
            // 
            // 
            // frmPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 700);
            this.Controls.Add(this.lblUix);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picFormIcon);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPadrao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUix;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picFormIcon;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSair;

    }
}