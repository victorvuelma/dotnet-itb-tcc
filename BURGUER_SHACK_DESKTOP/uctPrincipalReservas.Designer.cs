namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPrincipalReservas
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
            this.grbListar = new System.Windows.Forms.GroupBox();
            this.pnlReservas = new System.Windows.Forms.Panel();
            this.dtpListar = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbListar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListar
            // 
            this.grbListar.Controls.Add(this.pnlReservas);
            this.grbListar.Controls.Add(this.dtpListar);
            this.grbListar.Location = new System.Drawing.Point(10, 10);
            this.grbListar.Name = "grbListar";
            this.grbListar.Size = new System.Drawing.Size(500, 630);
            this.grbListar.TabIndex = 0;
            this.grbListar.TabStop = false;
            this.grbListar.Text = "RESERVAS";
            // 
            // pnlReservas
            // 
            this.pnlReservas.Location = new System.Drawing.Point(5, 30);
            this.pnlReservas.MaximumSize = new System.Drawing.Size(485, 10000);
            this.pnlReservas.Name = "pnlReservas";
            this.pnlReservas.Size = new System.Drawing.Size(485, 590);
            this.pnlReservas.TabIndex = 1;
            // 
            // dtpListar
            // 
            this.dtpListar.Location = new System.Drawing.Point(240, 0);
            this.dtpListar.Name = "dtpListar";
            this.dtpListar.Size = new System.Drawing.Size(250, 21);
            this.dtpListar.TabIndex = 0;
            this.dtpListar.ValueChanged += new System.EventHandler(this.dtpListar_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(520, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 630);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // uctPrincipalReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbListar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPrincipalReservas";
            this.Size = new System.Drawing.Size(900, 650);
            this.Load += new System.EventHandler(this.uctPrincipalReservas_Load);
            this.grbListar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpListar;
        private System.Windows.Forms.Panel pnlReservas;
    }
}
