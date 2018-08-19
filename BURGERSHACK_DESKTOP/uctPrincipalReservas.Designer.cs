namespace BurgerShack.Desktop
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
            this.lstReservas = new vitorrdgs.UiX.Component.UIXItemsList();
            this.dtpListar = new System.Windows.Forms.DateTimePicker();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnNova = new vitorrdgs.UiX.Component.UIXButton();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstReservas
            // 
            this.lstReservas.ItemsSize = 100;
            this.lstReservas.ItemsSpace = 10;
            this.lstReservas.Location = new System.Drawing.Point(10, 10);
            this.lstReservas.MaximumSize = new System.Drawing.Size(780, 10000);
            this.lstReservas.Name = "lstReservas";
            this.lstReservas.PosIndex = 0;
            this.lstReservas.Size = new System.Drawing.Size(780, 630);
            this.lstReservas.TabIndex = 0;
            this.lstReservas.TabStop = false;
            // 
            // dtpListar
            // 
            this.dtpListar.Location = new System.Drawing.Point(514, 3);
            this.dtpListar.Name = "dtpListar";
            this.dtpListar.Size = new System.Drawing.Size(250, 20);
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
            this.btnNova.Image = global::BurgerShack.Desktop.Properties.Resources.adicionar;
            this.btnNova.ImageLocation = null;
            this.btnNova.Location = new System.Drawing.Point(5, 5);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(90, 90);
            this.btnNova.TabIndex = 0;
            this.btnNova.Text = "Nova Reserva";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // uctPrincipalReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lstReservas);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPrincipalReservas";
            this.Size = new System.Drawing.Size(900, 650);
            this.Load += new System.EventHandler(this.uctPrincipalReservas_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private vitorrdgs.UiX.Component.UIXItemsList lstReservas;
        private System.Windows.Forms.DateTimePicker dtpListar;
        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnNova;
    }
}
