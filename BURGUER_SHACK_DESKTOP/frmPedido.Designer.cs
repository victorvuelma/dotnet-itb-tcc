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
            this.uctUIX = new UIX.uctUIX();
            this.pnlLeftButtons = new System.Windows.Forms.Panel();
            this.uctPedidoAlterar = new BURGUER_SHACK_DESKTOP.uctPedidoAlterar();
            this.btnApagarPedido = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnAlterarPedido = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.uctPedidoNovo = new BURGUER_SHACK_DESKTOP.uctPedidoNovo();
            this.uctProdutoRemover = new BURGUER_SHACK_DESKTOP.uctProdutoRemover();
            this.pnlLeftButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(250, 32);
            this.uctUIX.TabIndex = 0;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = true;
            this.uctUIX.UIXTitle = "Titulo UIX";
            // 
            // pnlLeftButtons
            // 
            this.pnlLeftButtons.Controls.Add(this.btnApagarPedido);
            this.pnlLeftButtons.Controls.Add(this.btnRemoverProduto);
            this.pnlLeftButtons.Controls.Add(this.btnAlterarPedido);
            this.pnlLeftButtons.Controls.Add(this.btnNovoPedido);
            this.pnlLeftButtons.Location = new System.Drawing.Point(0, 38);
            this.pnlLeftButtons.Name = "pnlLeftButtons";
            this.pnlLeftButtons.Size = new System.Drawing.Size(70, 756);
            this.pnlLeftButtons.TabIndex = 2;
            // 
            // uctPedidoAlterar
            // 
            this.uctPedidoAlterar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uctPedidoAlterar.Location = new System.Drawing.Point(70, 38);
            this.uctPedidoAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctPedidoAlterar.Name = "uctPedidoAlterar";
            this.uctPedidoAlterar.Size = new System.Drawing.Size(502, 746);
            this.uctPedidoAlterar.TabIndex = 4;
            // 
            // btnApagarPedido
            // 
            this.btnApagarPedido.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.removerpedido;
            this.btnApagarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagarPedido.Location = new System.Drawing.Point(0, 251);
            this.btnApagarPedido.Name = "btnApagarPedido";
            this.btnApagarPedido.Size = new System.Drawing.Size(70, 70);
            this.btnApagarPedido.TabIndex = 3;
            this.btnApagarPedido.UseVisualStyleBackColor = true;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover;
            this.btnRemoverProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoverProduto.Location = new System.Drawing.Point(0, 175);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(70, 70);
            this.btnRemoverProduto.TabIndex = 2;
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnPedidoRemover_Click);
            // 
            // btnAlterarPedido
            // 
            this.btnAlterarPedido.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnAlterarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarPedido.Location = new System.Drawing.Point(0, 99);
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.Size = new System.Drawing.Size(70, 70);
            this.btnAlterarPedido.TabIndex = 1;
            this.btnAlterarPedido.UseVisualStyleBackColor = true;
            this.btnAlterarPedido.Click += new System.EventHandler(this.btnAlterarPedido_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnNovoPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoPedido.Location = new System.Drawing.Point(0, 23);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(70, 70);
            this.btnNovoPedido.TabIndex = 0;
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // uctPedidoNovo
            // 
            this.uctPedidoNovo.AutoSize = true;
            this.uctPedidoNovo.Location = new System.Drawing.Point(70, 38);
            this.uctPedidoNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctPedidoNovo.Name = "uctPedidoNovo";
            this.uctPedidoNovo.Size = new System.Drawing.Size(502, 745);
            this.uctPedidoNovo.TabIndex = 5;
            // 
            // uctProdutoRemover
            // 
            this.uctProdutoRemover.Location = new System.Drawing.Point(70, 38);
            this.uctProdutoRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctProdutoRemover.Name = "uctProdutoRemover";
            this.uctProdutoRemover.Size = new System.Drawing.Size(502, 756);
            this.uctProdutoRemover.TabIndex = 6;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 794);
            this.Controls.Add(this.uctProdutoRemover);
            this.Controls.Add(this.uctPedidoNovo);
            this.Controls.Add(this.uctPedidoAlterar);
            this.Controls.Add(this.pnlLeftButtons);
            this.Controls.Add(this.uctUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEDIDO";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.pnlLeftButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIX.uctUIX uctUIX;
        private System.Windows.Forms.Panel pnlLeftButtons;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Button btnAlterarPedido;
        private uctPedidoAlterar uctPedidoAlterar;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnApagarPedido;
        private uctPedidoNovo uctPedidoNovo;
        private uctProdutoRemover uctProdutoRemover;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}