namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoProdutos
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
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.btnConfirmar = new UIX.btnUIX();
            this.grbProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.pnlProdutos);
            this.grbProdutos.Location = new System.Drawing.Point(5, 5);
            this.grbProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProdutos.Size = new System.Drawing.Size(440, 485);
            this.grbProdutos.TabIndex = 5;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "PRODUTOS";
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.Location = new System.Drawing.Point(5, 20);
            this.pnlProdutos.MaximumSize = new System.Drawing.Size(430, 1000);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(430, 455);
            this.pnlProdutos.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Description = "Confirmar";
            this.btnConfirmar.HoverColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.confirmar;
            this.btnConfirmar.ImageLocation = null;
            this.btnConfirmar.Location = new System.Drawing.Point(345, 495);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 100);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar Pedido";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // uctPedidoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grbProdutos);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedidoProdutos";
            this.Size = new System.Drawing.Size(450, 600);
            this.Load += new System.EventHandler(this.uctPedidoProdutos_Load);
            this.grbProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProdutos;
        private UIX.btnUIX btnConfirmar;
        private System.Windows.Forms.Panel pnlProdutos;
    }
}
