namespace BURGUER_SHACK_DESKTOP
{
    partial class uctMesaListar
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
            this.grbMesas = new System.Windows.Forms.GroupBox();
            this.pnlMesas = new System.Windows.Forms.Panel();
            this.lblOcupada = new System.Windows.Forms.Label();
            this.pnlOcupada = new System.Windows.Forms.Panel();
            this.lblLivre = new System.Windows.Forms.Label();
            this.pnlLivre = new System.Windows.Forms.Panel();
            this.grbMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMesas
            // 
            this.grbMesas.Controls.Add(this.pnlMesas);
            this.grbMesas.Controls.Add(this.lblOcupada);
            this.grbMesas.Controls.Add(this.pnlOcupada);
            this.grbMesas.Controls.Add(this.lblLivre);
            this.grbMesas.Controls.Add(this.pnlLivre);
            this.grbMesas.Location = new System.Drawing.Point(5, 5);
            this.grbMesas.Name = "grbMesas";
            this.grbMesas.Size = new System.Drawing.Size(420, 600);
            this.grbMesas.TabIndex = 0;
            this.grbMesas.TabStop = false;
            this.grbMesas.Text = "SELECIONAR MESA";
            // 
            // pnlMesas
            // 
            this.pnlMesas.AutoScroll = true;
            this.pnlMesas.Location = new System.Drawing.Point(5, 10);
            this.pnlMesas.MaximumSize = new System.Drawing.Size(410, 100000);
            this.pnlMesas.Name = "pnlMesas";
            this.pnlMesas.Size = new System.Drawing.Size(410, 580);
            this.pnlMesas.TabIndex = 5;
            // 
            // lblOcupada
            // 
            this.lblOcupada.AutoSize = true;
            this.lblOcupada.Location = new System.Drawing.Point(300, 0);
            this.lblOcupada.Name = "lblOcupada";
            this.lblOcupada.Size = new System.Drawing.Size(59, 13);
            this.lblOcupada.TabIndex = 4;
            this.lblOcupada.Text = "OCUPADA";
            // 
            // pnlOcupada
            // 
            this.pnlOcupada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlOcupada.Location = new System.Drawing.Point(290, 0);
            this.pnlOcupada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOcupada.Name = "pnlOcupada";
            this.pnlOcupada.Size = new System.Drawing.Size(10, 10);
            this.pnlOcupada.TabIndex = 3;
            // 
            // lblLivre
            // 
            this.lblLivre.AutoSize = true;
            this.lblLivre.Location = new System.Drawing.Point(240, 0);
            this.lblLivre.Name = "lblLivre";
            this.lblLivre.Size = new System.Drawing.Size(38, 13);
            this.lblLivre.TabIndex = 2;
            this.lblLivre.Text = "LIVRE";
            // 
            // pnlLivre
            // 
            this.pnlLivre.BackColor = System.Drawing.Color.White;
            this.pnlLivre.Location = new System.Drawing.Point(230, 0);
            this.pnlLivre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLivre.Name = "pnlLivre";
            this.pnlLivre.Size = new System.Drawing.Size(10, 10);
            this.pnlLivre.TabIndex = 1;
            // 
            // uctPedidoMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbMesas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "uctPedidoMesa";
            this.Size = new System.Drawing.Size(430, 610);
            this.Load += new System.EventHandler(this.uctPedidoMesa_Load);
            this.grbMesas.ResumeLayout(false);
            this.grbMesas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMesas;
        private System.Windows.Forms.Label lblOcupada;
        private System.Windows.Forms.Panel pnlOcupada;
        private System.Windows.Forms.Label lblLivre;
        private System.Windows.Forms.Panel pnlLivre;
        private System.Windows.Forms.Panel pnlMesas;
    }
}
