namespace BURGUER_SHACK_DESKTOP
{
    partial class frmGerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciador));
            this.uctUIX = new UIX.uctUIX();
            this.pnlLeftButtons = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnApagarPedido = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnAlterarPedido = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.pnlLeftButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(250, 40);
            this.uctUIX.TabIndex = 0;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = true;
            this.uctUIX.UIXTitle = "Titulo UIX";
            // 
            // pnlLeftButtons
            // 
            this.pnlLeftButtons.Controls.Add(this.btnLogout);
            this.pnlLeftButtons.Controls.Add(this.btnPedidos);
            this.pnlLeftButtons.Controls.Add(this.btnApagarPedido);
            this.pnlLeftButtons.Controls.Add(this.btnRemoverProduto);
            this.pnlLeftButtons.Controls.Add(this.btnAlterarPedido);
            this.pnlLeftButtons.Controls.Add(this.btnNovoPedido);
            this.pnlLeftButtons.Location = new System.Drawing.Point(0, 39);
            this.pnlLeftButtons.Name = "pnlLeftButtons";
            this.pnlLeftButtons.Size = new System.Drawing.Size(70, 545);
            this.pnlLeftButtons.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(0, 470);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 70);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pedidos;
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.Location = new System.Drawing.Point(0, 307);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(70, 70);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnApagarPedido
            // 
            this.btnApagarPedido.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.removerpedido;
            this.btnApagarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagarPedido.Location = new System.Drawing.Point(0, 231);
            this.btnApagarPedido.Name = "btnApagarPedido";
            this.btnApagarPedido.Size = new System.Drawing.Size(70, 70);
            this.btnApagarPedido.TabIndex = 3;
            this.btnApagarPedido.UseVisualStyleBackColor = true;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover;
            this.btnRemoverProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoverProduto.Location = new System.Drawing.Point(0, 155);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(70, 70);
            this.btnRemoverProduto.TabIndex = 2;
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // btnAlterarPedido
            // 
            this.btnAlterarPedido.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnAlterarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarPedido.Location = new System.Drawing.Point(0, 79);
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.Size = new System.Drawing.Size(70, 70);
            this.btnAlterarPedido.TabIndex = 1;
            this.btnAlterarPedido.UseVisualStyleBackColor = true;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnNovoPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoPedido.Location = new System.Drawing.Point(0, 3);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(70, 70);
            this.btnNovoPedido.TabIndex = 0;
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            // 
            // frmGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 584);
            this.Controls.Add(this.pnlLeftButtons);
            this.Controls.Add(this.uctUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.Load += new System.EventHandler(this.frmGerenciador_Load);
            this.pnlLeftButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.uctUIX uctUIX;
        private System.Windows.Forms.Panel pnlLeftButtons;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnApagarPedido;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnAlterarPedido;
        private System.Windows.Forms.Button btnNovoPedido;
    }
}