namespace BURGUER_SHACK_DESKTOP
{
    partial class frmCozinha
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uctCozinha1 = new BURGUER_SHACK_DESKTOP.uctCozinha();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.hdrUIX = new UIX.hdrUIX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uctCozinha1);
            this.panel1.Controls.Add(this.dgvPedidos);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 379);
            this.panel1.TabIndex = 1;
            // 
            // uctCozinha1
            // 
            this.uctCozinha1.Location = new System.Drawing.Point(-12, 0);
            this.uctCozinha1.Name = "uctCozinha1";
            this.uctCozinha1.Size = new System.Drawing.Size(857, 379);
            this.uctCozinha1.TabIndex = 1;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(3, 3);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(988, 373);
            this.dgvPedidos.TabIndex = 0;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(1019, 40);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.UIXButtonCloseEnabled = true;
            this.hdrUIX.UIXButtonMinEnabled = true;
            this.hdrUIX.UIXImage = null;
            this.hdrUIX.UIXTitle = "Titulo UIX";
            // 
            // frmCozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCozinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCozinha";
            this.Load += new System.EventHandler(this.frmCozinha_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private uctCozinha uctCozinha1;
    }
}