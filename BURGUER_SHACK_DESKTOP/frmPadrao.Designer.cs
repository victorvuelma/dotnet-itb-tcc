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
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
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
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(6, 4);
            this.uctUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(189, 48);
            this.uctUIX.TabIndex = 10;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = true;
            this.uctUIX.UIXTitle = "BurguerShack - ???";
            // 
            // uctPedido1
            // 
            this.uctPedido1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctPedido1.Location = new System.Drawing.Point(3, 60);
            this.uctPedido1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctPedido1.Name = "uctPedido1";
            this.uctPedido1.Size = new System.Drawing.Size(508, 649);
            this.uctPedido1.TabIndex = 11;
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
            // frmPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 711);
            this.Controls.Add(this.uctPedido1);
            this.Controls.Add(this.uctUIX);
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
            this.Load += new System.EventHandler(this.frmPadrao_Load);
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
        private UIX.uctUIX uctUIX;
        private uctPedido uctPedido1;
    }
}