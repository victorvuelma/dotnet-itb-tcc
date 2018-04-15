namespace BURGUER_SHACK_DESKTOP
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
            this.uctUIX = new UIX.uctUIX();
            this.uctPedido1 = new BURGUER_SHACK_DESKTOP.uctPedido();
            this.picFormIcon = new System.Windows.Forms.PictureBox();
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
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(250, 39);
            this.uctUIX.TabIndex = 1;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = true;
            this.uctUIX.UIXTitle = "Burguer Shack - ???";
            // 
            // uctPedido1
            // 
            this.uctPedido1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctPedido1.Location = new System.Drawing.Point(0, 49);
            this.uctPedido1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctPedido1.Name = "uctPedido1";
            this.uctPedido1.Size = new System.Drawing.Size(508, 649);
            this.uctPedido1.TabIndex = 0;
            // 
            // picFormIcon
            // 
            this.picFormIcon.Location = new System.Drawing.Point(0, 0);
            this.picFormIcon.Name = "picFormIcon";
            this.picFormIcon.Size = new System.Drawing.Size(100, 50);
            this.picFormIcon.TabIndex = 10;
            this.picFormIcon.TabStop = false;
            // 
            // frmPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 699);
            this.Controls.Add(this.uctPedido1);
            this.Controls.Add(this.uctUIX);
            this.Controls.Add(this.lblUix);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picFormIcon);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPadrao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPadrao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctPedido uctPedido1;

        private System.Windows.Forms.Label lblUix;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picFormIcon;
        public UIX.uctUIX uctUIX;
    }
}