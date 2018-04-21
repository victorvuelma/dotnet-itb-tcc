namespace UIX
{
    partial class uctUIX
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picFormIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(3, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(54, 13);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Titulo UIX";
            // 
            // picFormIcon
            // 
            this.picFormIcon.Location = new System.Drawing.Point(3, 4);
            this.picFormIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picFormIcon.Name = "picFormIcon";
            this.picFormIcon.Size = new System.Drawing.Size(32, 32);
            this.picFormIcon.TabIndex = 6;
            this.picFormIcon.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(202, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "CLO";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(151, 2);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(45, 34);
            this.btnMin.TabIndex = 9;
            this.btnMin.Text = "MIN";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // uctUIX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picFormIcon);
            this.Controls.Add(this.btnClose);
            this.Name = "uctUIX";
            this.Size = new System.Drawing.Size(250, 40);
            ((System.ComponentModel.ISupportInitialize)(this.picFormIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.PictureBox picFormIcon;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnMin;
    }
}
