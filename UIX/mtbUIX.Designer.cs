namespace UIX
{
    partial class mtbUIX
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
            this.mtb = new System.Windows.Forms.MaskedTextBox();
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
            // mtb
            // 
            this.mtb.Location = new System.Drawing.Point(40, 0);
            this.mtb.Name = "mtb";
            this.mtb.Size = new System.Drawing.Size(100, 20);
            this.mtb.TabIndex = 1;
            this.mtb.Click += new System.EventHandler(this.mtb_Click);
            this.mtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_KeyDown);
            // 
            // mtbUIX
            // 
            this.Controls.Add(this.mtb);
            this.Controls.Add(this.lbl);
            this.Name = "mtbUIX";
            this.Size = new System.Drawing.Size(150, 20);
            this.Load += new System.EventHandler(this.mtbUIX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.MaskedTextBox mtb;
    }
}
