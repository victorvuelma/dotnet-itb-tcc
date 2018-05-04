namespace UIX
{
    partial class hdrUIX
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
            this.lbl = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnClo = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(50, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 50);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Título";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(5, 5);
            this.pic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(40, 40);
            this.pic.TabIndex = 6;
            this.pic.TabStop = false;
            // 
            // btnClo
            // 
            this.btnClo.Location = new System.Drawing.Point(200, 5);
            this.btnClo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClo.Name = "btnClo";
            this.btnClo.Size = new System.Drawing.Size(40, 40);
            this.btnClo.TabIndex = 5;
            this.btnClo.Text = "X";
            this.btnClo.UseVisualStyleBackColor = true;
            this.btnClo.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(156, 5);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 40);
            this.btnMin.TabIndex = 9;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // hdrUIX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnClo);
            this.Name = "hdrUIX";
            this.Size = new System.Drawing.Size(250, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.PictureBox pic;
        public System.Windows.Forms.Button btnClo;
        public System.Windows.Forms.Button btnMin;
    }
}
