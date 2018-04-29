namespace BURGUER_SHACK_DESKTOP
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new UIX.btnUIX();
            this.btnPedidos = new UIX.btnUIX();
            this.btnApagarPedido = new UIX.btnUIX();
            this.btnRemoverProduto = new UIX.btnUIX();
            this.btnAlterarPedido = new UIX.btnUIX();
            this.btnNovoPedido = new UIX.btnUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.uctUIX = new UIX.uctUIX();
            this.btnFinalizarPedido = new UIX.btnUIX();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnFinalizarPedido);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Controls.Add(this.btnApagarPedido);
            this.pnlMenu.Controls.Add(this.btnRemoverProduto);
            this.pnlMenu.Controls.Add(this.btnAlterarPedido);
            this.pnlMenu.Controls.Add(this.btnNovoPedido);
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 760);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Description = "Sair";
            this.btnSair.HoverColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(10, 670);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 80);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Description = "Pedidos";
            this.btnPedidos.HoverColor = System.Drawing.Color.Transparent;
            this.btnPedidos.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.btnPedidos.Location = new System.Drawing.Point(10, 370);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(80, 80);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnApagarPedido
            // 
            this.btnApagarPedido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnApagarPedido.Description = "Apagar";
            this.btnApagarPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnApagarPedido.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover_x;
            this.btnApagarPedido.Location = new System.Drawing.Point(10, 280);
            this.btnApagarPedido.Name = "btnApagarPedido";
            this.btnApagarPedido.Size = new System.Drawing.Size(80, 80);
            this.btnApagarPedido.TabIndex = 3;
            this.btnApagarPedido.UseVisualStyleBackColor = true;
            this.btnApagarPedido.Click += new System.EventHandler(this.btnApagarPedido_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Description = "Produtos";
            this.btnRemoverProduto.HoverColor = System.Drawing.Color.Transparent;
            this.btnRemoverProduto.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover_menos;
            this.btnRemoverProduto.Location = new System.Drawing.Point(10, 190);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(80, 80);
            this.btnRemoverProduto.TabIndex = 2;
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnPedidoRemover_Click);
            // 
            // btnAlterarPedido
            // 
            this.btnAlterarPedido.Description = "Modificar";
            this.btnAlterarPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnAlterarPedido.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnAlterarPedido.Location = new System.Drawing.Point(10, 100);
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.Size = new System.Drawing.Size(80, 80);
            this.btnAlterarPedido.TabIndex = 1;
            this.btnAlterarPedido.UseVisualStyleBackColor = true;
            this.btnAlterarPedido.Click += new System.EventHandler(this.btnAlterarPedido_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Description = "Novo ";
            this.btnNovoPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnNovoPedido.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnNovoPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoPedido.Location = new System.Drawing.Point(10, 10);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(80, 80);
            this.btnNovoPedido.TabIndex = 0;
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Location = new System.Drawing.Point(100, 40);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(500, 760);
            this.pnlConteudo.TabIndex = 3;
            // 
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(600, 40);
            this.uctUIX.TabIndex = 0;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = true;
            this.uctUIX.UIXImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.garcom;
            this.uctUIX.UIXTitle = "Pedidos";
            this.uctUIX.Close += new System.EventHandler(this.uctUIX_Close);
            this.uctUIX.Min += new System.EventHandler(this.uctUIX_Min);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizarPedido.Description = "Finalizar";
            this.btnFinalizarPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnFinalizarPedido.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pagamento;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(10, 456);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(80, 80);
            this.btnFinalizarPedido.TabIndex = 7;
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.uctUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEDIDO";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnNovoPedido;
        private UIX.btnUIX btnAlterarPedido;
        private UIX.btnUIX btnRemoverProduto;
        private UIX.btnUIX btnApagarPedido;
        private UIX.btnUIX btnPedidos;
        private UIX.btnUIX btnSair;
        public UIX.uctUIX uctUIX;
        public System.Windows.Forms.Panel pnlConteudo;
        private UIX.btnUIX btnFinalizarPedido;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}