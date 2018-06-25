namespace UIX
{
    partial class btnUIX
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.Control;
            this.pic.Location = new System.Drawing.Point(2, 5);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(76, 60);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.onClick);
            this.pic.MouseEnter += new System.EventHandler(this.btnUIX_MouseEnter);
            this.pic.MouseLeave += new System.EventHandler(this.btnUIX_MouseLeave);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.Control;
            this.lbl.Location = new System.Drawing.Point(0, 65);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(80, 15);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Text";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl.Click += new System.EventHandler(this.onClick);
            this.lbl.MouseEnter += new System.EventHandler(this.btnUIX_MouseEnter);
            this.lbl.MouseLeave += new System.EventHandler(this.btnUIX_MouseLeave);
            // 
            // btnUIX
            // 
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pic);
            this.Size = new System.Drawing.Size(80, 80);
            this.BackColorChanged += new System.EventHandler(this.btnUIX_BackColorChanged);
            base.Click += new System.EventHandler(this.onClick);
            this.MouseEnter += new System.EventHandler(this.btnUIX_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.btnUIX_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox pic;
        protected System.Windows.Forms.Label lbl;
    }
}
