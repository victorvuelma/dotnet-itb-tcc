namespace UIX
{
    partial class msgUIX
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
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.hdrUIX = new UIX.hdrUIX();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(310, 200);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(80, 40);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "S";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(220, 200);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(80, 40);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "N";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(10, 60);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(120, 120);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // txt
            // 
            this.txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(140, 60);
            this.txt.MaximumSize = new System.Drawing.Size(250, 1000);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(250, 120);
            this.txt.TabIndex = 4;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = null;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(400, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "T";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // msgUIX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msgUIX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensagem ";
            this.Load += new System.EventHandler(this.msgUIX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hdrUIX hdrUIX;
        public System.Windows.Forms.Button btnYes;
        public System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox txt;
    }
}