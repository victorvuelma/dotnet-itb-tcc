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
            this.pnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.Control;
            this.pic.Location = new System.Drawing.Point(2, 5);
            this.pic.Margin = new System.Windows.Forms.Padding(0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(76, 60);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pic_LoadCompleted);
            this.pic.Click += new System.EventHandler(this.onClick);
            this.pic.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pic.MouseLeave += new System.EventHandler(this.onMouseLeave);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.Control;
            this.lbl.Location = new System.Drawing.Point(0, 65);
            this.lbl.Margin = new System.Windows.Forms.Padding(0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(80, 15);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Text";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl.Click += new System.EventHandler(this.onClick);
            this.lbl.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.lbl.MouseLeave += new System.EventHandler(this.onMouseLeave);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lbl);
            this.pnl.Controls.Add(this.pic);
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Margin = new System.Windows.Forms.Padding(0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(200, 100);
            this.pnl.TabIndex = 0;
            this.pnl.Click += new System.EventHandler(this.onClick);
            this.pnl.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.pnl.MouseLeave += new System.EventHandler(this.onMouseLeave);
            // 
            // btnUIX
            // 
            this.Controls.Add(this.pnl);
            this.Size = new System.Drawing.Size(80, 80);
            this.BackColorChanged += new System.EventHandler(this.btnUIX_BackColorChanged);
            this.MouseEnter += new System.EventHandler(this.onMouseEnter);
            this.MouseLeave += new System.EventHandler(this.onMouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox pic;
        protected System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel pnl;
    }
}
