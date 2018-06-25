namespace BURGUER_SHACK_DESKTOP
{
    partial class frmAtendimento
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMesas = new UIX.btnUIX();
            this.btnVoltar = new UIX.btnUIX();
            this.btnConta = new UIX.btnUIX();
            this.btnPedidos = new UIX.btnUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.hdrUIX = new UIX.hdrUIX();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnMesas);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnConta);
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 650);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnMesas
            // 
            this.btnMesas.Description = "Mesas";
            this.btnMesas.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesas.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesa;
            this.btnMesas.ImageLocation = null;
            this.btnMesas.Location = new System.Drawing.Point(5, 105);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(90, 90);
            this.btnMesas.TabIndex = 9;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Description = "Voltar";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.voltar;
            this.btnVoltar.ImageLocation = null;
            this.btnVoltar.Location = new System.Drawing.Point(5, 555);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 90);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConta
            // 
            this.btnConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConta.Description = "Conta";
            this.btnConta.HoverColor = System.Drawing.Color.Transparent;
            this.btnConta.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.conta;
            this.btnConta.ImageLocation = null;
            this.btnConta.Location = new System.Drawing.Point(5, 455);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(90, 90);
            this.btnConta.TabIndex = 7;
            this.btnConta.Text = "Conta";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Description = "Pedidos";
            this.btnPedidos.HoverColor = System.Drawing.Color.Transparent;
            this.btnPedidos.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pedido;
            this.btnPedidos.ImageLocation = null;
            this.btnPedidos.Location = new System.Drawing.Point(5, 5);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(90, 90);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "Pedidos";
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
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.atendimento;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(600, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Atendimento";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mesa";
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
        private UIX.btnUIX btnVoltar;
        private UIX.btnUIX btnMesas;
    }
}