namespace UIX
{
    partial class cboUIX
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
            this.cbo = new System.Windows.Forms.ComboBox();
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
            // cbo
            // 
            this.cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(40, 0);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(100, 21);
            this.cbo.TabIndex = 2;
            this.cbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_KeyPress);
            // 
            // cboUIX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.lbl);
            this.Name = "cboUIX";
            this.Size = new System.Drawing.Size(150, 20);
            this.Load += new System.EventHandler(this.cboUIX_Load);
            this.FontChanged += new System.EventHandler(this.cboUIX_FontChanged);
            this.SizeChanged += new System.EventHandler(this.cboUIX_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.ComboBox cbo;
    }
}
