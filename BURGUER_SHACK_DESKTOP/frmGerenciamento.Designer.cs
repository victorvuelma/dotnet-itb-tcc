namespace BURGUER_SHACK_DESKTOP
{
    partial class frmGerenciamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciamento));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnIngredientes = new UIX.btnUIX();
            this.btnSair = new UIX.btnUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.hdrUIX = new UIX.hdrUIX();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnIngredientes);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 500);
            this.pnlMenu.TabIndex = 7;
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngredientes.Description = "Ingredientes";
            this.btnIngredientes.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngredientes.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.ingrediente;
            this.btnIngredientes.ImageLocation = null;
            this.btnIngredientes.Location = new System.Drawing.Point(5, 10);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(90, 90);
            this.btnIngredientes.TabIndex = 6;
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Description = "Sair";
            this.btnSair.HoverColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sair;
            this.btnSair.ImageLocation = null;
            this.btnSair.Location = new System.Drawing.Point(5, 400);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 90);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConteudo.Location = new System.Drawing.Point(100, 50);
            this.pnlConteudo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(700, 500);
            this.pnlConteudo.TabIndex = 8;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.gerenciador;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(800, 50);
            this.hdrUIX.TabIndex = 6;
            this.hdrUIX.Title = "Gerenciamento";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // frmGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciamento";
            this.Load += new System.EventHandler(this.frmGerenciador_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnIngredientes;
        private UIX.btnUIX btnSair;
        public System.Windows.Forms.Panel pnlConteudo;
        private UIX.hdrUIX hdrUIX;
    }
}