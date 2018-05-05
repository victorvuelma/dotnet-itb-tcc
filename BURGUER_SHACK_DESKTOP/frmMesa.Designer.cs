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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnNovoPedido = new UIX.btnUIX();
            this.btnSair = new UIX.btnUIX();
            this.btnConta = new UIX.btnUIX();
            this.btnPedidos = new UIX.btnUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.hdrUIX = new UIX.hdrUIX();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnNovoPedido);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnConta);
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 650);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Description = "Novo Pedido";
            this.btnNovoPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnNovoPedido.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnNovoPedido.Location = new System.Drawing.Point(5, 5);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(90, 90);
            this.btnNovoPedido.TabIndex = 8;
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // btnSair
            // 
            this.btnSair.Description = "Sair";
            this.btnSair.HoverColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(5, 555);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 90);
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
            this.btnConta.Location = new System.Drawing.Point(5, 205);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(90, 90);
            this.btnConta.TabIndex = 7;
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Description = "Pedidos";
            this.btnPedidos.HoverColor = System.Drawing.Color.Transparent;
            this.btnPedidos.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pedido;
            this.btnPedidos.Location = new System.Drawing.Point(5, 105);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(90, 90);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Location = new System.Drawing.Point(100, 50);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(500, 650);
            this.pnlConteudo.TabIndex = 4;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(600, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.UIXButtonCloseEnabled = true;
            this.hdrUIX.UIXButtonMinEnabled = false;
            this.hdrUIX.UIXImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesa;
            this.hdrUIX.UIXTitle = "Mesas";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // frmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.frmMesa_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnConta;
        private UIX.btnUIX btnPedidos;
        public System.Windows.Forms.Panel pnlConteudo;
        private UIX.btnUIX btnSair;
        private UIX.btnUIX btnNovoPedido;
    }
}