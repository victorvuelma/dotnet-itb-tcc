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
            this.btnCardapio = new UIX.btnUIX();
            this.btnFinalizarPedido = new UIX.btnUIX();
            this.btnPedidos = new UIX.btnUIX();
            this.btnApagarPedido = new UIX.btnUIX();
            this.btnAlterarPedido = new UIX.btnUIX();
            this.btnMesas = new UIX.btnUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.btnSair = new UIX.btnUIX();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(700, 40);
            this.uctUIX.TabIndex = 0;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = false;
            this.uctUIX.UIXImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.garcom;
            this.uctUIX.UIXTitle = "Mesas";
            this.uctUIX.Close += new System.EventHandler(this.uctUIX_Close);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnCardapio);
            this.pnlMenu.Controls.Add(this.btnFinalizarPedido);
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Controls.Add(this.btnApagarPedido);
            this.pnlMenu.Controls.Add(this.btnAlterarPedido);
            this.pnlMenu.Controls.Add(this.btnMesas);
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 660);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnCardapio
            // 
            this.btnCardapio.Description = "Cardápio";
            this.btnCardapio.HoverColor = System.Drawing.Color.Transparent;
            this.btnCardapio.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pedidos1;
            this.btnCardapio.Location = new System.Drawing.Point(10, 394);
            this.btnCardapio.Name = "btnCardapio";
            this.btnCardapio.Size = new System.Drawing.Size(80, 80);
            this.btnCardapio.TabIndex = 2;
            this.btnCardapio.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizarPedido.Description = "Finalizar";
            this.btnFinalizarPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnFinalizarPedido.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pagamento;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(10, 489);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(80, 80);
            this.btnFinalizarPedido.TabIndex = 7;
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.Description = "Pedidos";
            this.btnPedidos.HoverColor = System.Drawing.Color.Transparent;
            this.btnPedidos.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.btnPedidos.Location = new System.Drawing.Point(10, 298);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(80, 80);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnApagarPedido
            // 
            this.btnApagarPedido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnApagarPedido.Description = "Apagar";
            this.btnApagarPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnApagarPedido.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover_x;
            this.btnApagarPedido.Location = new System.Drawing.Point(10, 202);
            this.btnApagarPedido.Name = "btnApagarPedido";
            this.btnApagarPedido.Size = new System.Drawing.Size(80, 80);
            this.btnApagarPedido.TabIndex = 3;
            this.btnApagarPedido.UseVisualStyleBackColor = true;
            // 
            // btnAlterarPedido
            // 
            this.btnAlterarPedido.Description = "Modificar";
            this.btnAlterarPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnAlterarPedido.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnAlterarPedido.Location = new System.Drawing.Point(10, 106);
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.Size = new System.Drawing.Size(80, 80);
            this.btnAlterarPedido.TabIndex = 1;
            this.btnAlterarPedido.UseVisualStyleBackColor = true;
            // 
            // btnMesas
            // 
            this.btnMesas.Description = "Mesas";
            this.btnMesas.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesas.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesalivre1;
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesas.Location = new System.Drawing.Point(10, 10);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(80, 80);
            this.btnMesas.TabIndex = 0;
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Location = new System.Drawing.Point(100, 40);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(600, 660);
            this.pnlConteudo.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Description = "Sair";
            this.btnSair.HoverColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(10, 570);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 80);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.uctUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMesa";
            this.Text = "frmMesa";
            this.Load += new System.EventHandler(this.frmMesa_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.uctUIX uctUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnCardapio;
        private UIX.btnUIX btnFinalizarPedido;
        private UIX.btnUIX btnPedidos;
        private UIX.btnUIX btnApagarPedido;
        private UIX.btnUIX btnAlterarPedido;
        private UIX.btnUIX btnMesas;
        public System.Windows.Forms.Panel pnlConteudo;
        private UIX.btnUIX btnSair;
    }
}