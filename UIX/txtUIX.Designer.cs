namespace UIX
{
    partial class txtUIX
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
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(-2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Campo:";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(40, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 1;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtUIX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lbl);
            this.Name = "txtUIX";
            this.Size = new System.Drawing.Size(150, 20);
            this.Load += new System.EventHandler(this.txtUIX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox txt;
    }
}
