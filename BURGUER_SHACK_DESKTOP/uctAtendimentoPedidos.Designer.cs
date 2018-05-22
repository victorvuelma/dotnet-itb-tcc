namespace BURGUER_SHACK_DESKTOP
{
    partial class uctAtendimentoPedidos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPedidos = new System.Windows.Forms.GroupBox();
            this.pnlPedidos = new System.Windows.Forms.Panel();
            this.grbPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPedidos
            // 
            this.grbPedidos.Controls.Add(this.pnlPedidos);
            this.grbPedidos.Location = new System.Drawing.Point(5, 5);
            this.grbPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPedidos.Size = new System.Drawing.Size(490, 640);
            this.grbPedidos.TabIndex = 8;
            this.grbPedidos.TabStop = false;
            this.grbPedidos.Text = "PEDIDOS";
            // 
            // pnlPedidos
            // 
            this.pnlPedidos.Location = new System.Drawing.Point(5, 20);
            this.pnlPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPedidos.Name = "pnlPedidos";
            this.pnlPedidos.Size = new System.Drawing.Size(480, 615);
            this.pnlPedidos.TabIndex = 4;
            // 
            // uctAtendimentoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPedidos);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctAtendimentoPedidos";
            this.Size = new System.Drawing.Size(500, 650);
            this.Load += new System.EventHandler(this.uctAtendimentoPedidos_Load);
            this.grbPedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbPedidos;
        private System.Windows.Forms.Panel pnlPedidos;
    }
}
