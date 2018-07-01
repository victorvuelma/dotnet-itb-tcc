namespace BURGUERSHACK_DESKTOP
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnNova = new UIX.btnUIX();
            this.grbListar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListar
            // 
            this.grbListar.Controls.Add(this.pnlReservas);
            this.grbListar.Controls.Add(this.dtpListar);
            this.grbListar.Location = new System.Drawing.Point(10, 10);
            this.grbListar.Name = "grbListar";
            this.grbListar.Size = new System.Drawing.Size(780, 630);
            this.grbListar.TabIndex = 0;
            this.grbListar.TabStop = false;
            this.grbListar.Text = "RESERVAS";
            // 
            // pnlReservas
            // 
            this.pnlReservas.Location = new System.Drawing.Point(5, 30);
            this.pnlReservas.MaximumSize = new System.Drawing.Size(770, 10000);
            this.pnlReservas.Name = "pnlReservas";
            this.pnlReservas.Size = new System.Drawing.Size(770, 590);
            this.pnlReservas.TabIndex = 1;
            // 
            // dtpListar
            // 
            this.dtpListar.Location = new System.Drawing.Point(514, 3);
            this.dtpListar.Name = "dtpListar";
            this.dtpListar.Size = new System.Drawing.Size(250, 21);
            this.dtpListar.TabIndex = 0;
            this.dtpListar.ValueChanged += new System.EventHandler(this.dtpListar_ValueChanged);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnNova);
            this.pnlMenu.Location = new System.Drawing.Point(800, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 650);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnNova
            // 
            this.btnNova.Description = "Nova Reserva";
            this.btnNova.HoverColor = System.Drawing.Color.Transparent;
            this.btnNova.Image = global::BURGUERSHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnNova.ImageLocation = null;
            this.btnNova.Location = new System.Drawing.Point(5, 5);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(90, 90);
            this.btnNova.TabIndex = 0;
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // uctPrincipalReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.grbListar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPrincipalReservas";
            this.Size = new System.Drawing.Size(900, 650);
            this.Load += new System.EventHandler(this.uctPrincipalReservas_Load);
            this.grbListar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListar;
        private System.Windows.Forms.DateTimePicker dtpListar;
        private System.Windows.Forms.Panel pnlReservas;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnNova;
    }
}
