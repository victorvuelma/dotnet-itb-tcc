namespace BURGUER_SHACK_DESKTOP
{
    partial class uctAtendimentoMesas
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMesas
            // 
            this.grbMesas.Controls.Add(this.pnlMesas);
            this.grbMesas.Location = new System.Drawing.Point(5, 5);
            this.grbMesas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMesas.Name = "grbMesas";
            this.grbMesas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMesas.Size = new System.Drawing.Size(490, 585);
            this.grbMesas.TabIndex = 8;
            this.grbMesas.TabStop = false;
            this.grbMesas.Text = "MESAS";
            // 
            // pnlMesas
            // 
            this.pnlMesas.Location = new System.Drawing.Point(5, 20);
            this.pnlMesas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMesas.MaximumSize = new System.Drawing.Size(480, 10000);
            this.pnlMesas.Name = "pnlMesas";
            this.pnlMesas.Size = new System.Drawing.Size(480, 560);
            this.pnlMesas.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(295, 595);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(200, 50);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar Mesa";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // uctAtendimentoMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.grbMesas);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctAtendimentoMesas";
            this.Size = new System.Drawing.Size(500, 650);
            this.Load += new System.EventHandler(this.uctAtendimentoPedidos_Load);
            this.grbMesas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbMesas;
        private System.Windows.Forms.Panel pnlMesas;
        private System.Windows.Forms.Button btnAdicionar;
    }
}
