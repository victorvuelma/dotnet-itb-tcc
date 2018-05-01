namespace BURGUER_SHACK_DESKTOP
{
    partial class frmMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesa));
            this.uctUIX = new UIX.uctUIX();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnNovoPedido = new UIX.btnUIX();
            this.btnSair = new UIX.btnUIX();
            this.btnConta = new UIX.btnUIX();
            this.btnPedidos = new UIX.btnUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(600, 40);
            this.uctUIX.TabIndex = 0;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = false;
            this.uctUIX.UIXImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.garcom;
            this.uctUIX.UIXTitle = "Mesas";
            this.uctUIX.Close += new System.EventHandler(this.uctUIX_Close);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnNovoPedido);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnConta);
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 700);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Description = "Novo Pedido";
            this.btnNovoPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnNovoPedido.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.btnNovoPedido.Location = new System.Drawing.Point(10, 10);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(80, 80);
            this.btnNovoPedido.TabIndex = 8;
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Description = "Sair";
            this.btnSair.HoverColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(10, 610);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 80);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConta
            // 
            this.btnConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConta.Description = "Conta";
            this.btnConta.HoverColor = System.Drawing.Color.Transparent;
            this.btnConta.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pagamento;
            this.btnConta.Location = new System.Drawing.Point(10, 190);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(80, 80);
            this.btnConta.TabIndex = 7;
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Description = "Pedidos";
            this.btnPedidos.HoverColor = System.Drawing.Color.Transparent;
            this.btnPedidos.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.btnPedidos.Location = new System.Drawing.Point(10, 100);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(80, 80);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Location = new System.Drawing.Point(100, 40);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(500, 700);
            this.pnlConteudo.TabIndex = 4;
            // 
            // frmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 740);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.uctUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMesa";
            this.Load += new System.EventHandler(this.frmMesa_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.uctUIX uctUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnConta;
        private UIX.btnUIX btnPedidos;
        public System.Windows.Forms.Panel pnlConteudo;
        private UIX.btnUIX btnSair;
        private UIX.btnUIX btnNovoPedido;
    }
}