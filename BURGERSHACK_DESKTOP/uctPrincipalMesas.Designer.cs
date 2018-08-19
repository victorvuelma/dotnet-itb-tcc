namespace BurgerShack.Desktop
{
    partial class uctPrincipalMesas
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
            this.lstMesas = new vitorrdgs.UiX.Component.UIXItemsList();
            this.lblOcupada = new System.Windows.Forms.Label();
            this.pnlOcupada = new System.Windows.Forms.Panel();
            this.lblLivre = new System.Windows.Forms.Label();
            this.pnlLivre = new System.Windows.Forms.Panel();
            this.grbMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMesas
            // 
            this.grbMesas.Controls.Add(this.lstMesas);
            this.grbMesas.Controls.Add(this.lblOcupada);
            this.grbMesas.Controls.Add(this.pnlOcupada);
            this.grbMesas.Controls.Add(this.lblLivre);
            this.grbMesas.Controls.Add(this.pnlLivre);
            this.grbMesas.Location = new System.Drawing.Point(5, 5);
            this.grbMesas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMesas.Name = "grbMesas";
            this.grbMesas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMesas.Size = new System.Drawing.Size(890, 640);
            this.grbMesas.TabIndex = 0;
            this.grbMesas.TabStop = false;
            this.grbMesas.Text = "MESAS";
            // 
            // pnlMesas
            // 
            this.lstMesas.AutoScroll = true;
            this.lstMesas.Location = new System.Drawing.Point(5, 15);
            this.lstMesas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMesas.MaximumSize = new System.Drawing.Size(880, 123077);
            this.lstMesas.Name = "pnlMesas";
            this.lstMesas.Size = new System.Drawing.Size(880, 620);
            this.lstMesas.TabIndex = 5;
            // 
            // lblOcupada
            // 
            this.lblOcupada.AutoSize = true;
            this.lblOcupada.Location = new System.Drawing.Point(800, 0);
            this.lblOcupada.Name = "lblOcupada";
            this.lblOcupada.Size = new System.Drawing.Size(64, 16);
            this.lblOcupada.TabIndex = 4;
            this.lblOcupada.Text = "OCUPADA";
            // 
            // pnlOcupada
            // 
            this.pnlOcupada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlOcupada.Location = new System.Drawing.Point(785, 0);
            this.pnlOcupada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOcupada.Name = "pnlOcupada";
            this.pnlOcupada.Size = new System.Drawing.Size(15, 15);
            this.pnlOcupada.TabIndex = 3;
            // 
            // lblLivre
            // 
            this.lblLivre.AutoSize = true;
            this.lblLivre.Location = new System.Drawing.Point(735, 0);
            this.lblLivre.Name = "lblLivre";
            this.lblLivre.Size = new System.Drawing.Size(36, 16);
            this.lblLivre.TabIndex = 2;
            this.lblLivre.Text = "LIVRE";
            // 
            // pnlLivre
            // 
            this.pnlLivre.BackColor = System.Drawing.Color.White;
            this.pnlLivre.Location = new System.Drawing.Point(720, 0);
            this.pnlLivre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLivre.Name = "pnlLivre";
            this.pnlLivre.Size = new System.Drawing.Size(15, 15);
            this.pnlLivre.TabIndex = 1;
            // 
            // uctPrincipalMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbMesas);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPrincipalMesas";
            this.Size = new System.Drawing.Size(900, 650);
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
        private vitorrdgs.UiX.Component.UIXItemsList lstMesas;
    }
}
