namespace BurgerShack.Desktop
{
    partial class uctAtendimentoPedidos
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
            this.grbPedidos = new System.Windows.Forms.GroupBox();
            this.lstPedidos = new vitorrdgs.UiX.Component.UIXItemsList();
            this.btnNovoPedido = new vitorrdgs.UiX.Component.UIXButton();
            this.lblValor = new System.Windows.Forms.Label();
            this.grbValor = new System.Windows.Forms.GroupBox();
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbPedidos.SuspendLayout();
            this.grbValor.SuspendLayout();
            this.grbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPedidos
            // 
            this.grbPedidos.Controls.Add(this.lstPedidos);
            this.grbPedidos.Location = new System.Drawing.Point(5, 5);
            this.grbPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbPedidos.Size = new System.Drawing.Size(490, 535);
            this.grbPedidos.TabIndex = 8;
            this.grbPedidos.TabStop = false;
            this.grbPedidos.Text = "PEDIDOS";
            // 
            // pnlPedidos
            // 
            this.lstPedidos.Location = new System.Drawing.Point(5, 20);
            this.lstPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstPedidos.MaximumSize = new System.Drawing.Size(480, 10000);
            this.lstPedidos.Name = "pnlPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(480, 510);
            this.lstPedidos.TabIndex = 4;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Description = "Novo Pedido";
            this.btnNovoPedido.HoverColor = System.Drawing.Color.Transparent;
            this.btnNovoPedido.Image = global::BurgerShack.Desktop.Properties.Resources.adicionar;
            this.btnNovoPedido.ImageLocation = null;
            this.btnNovoPedido.Location = new System.Drawing.Point(395, 545);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(100, 100);
            this.btnNovoPedido.TabIndex = 9;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(5, 20);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(190, 40);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "0,00";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbValor
            // 
            this.grbValor.Controls.Add(this.lblValor);
            this.grbValor.Location = new System.Drawing.Point(5, 580);
            this.grbValor.Name = "grbValor";
            this.grbValor.Size = new System.Drawing.Size(200, 65);
            this.grbValor.TabIndex = 11;
            this.grbValor.TabStop = false;
            this.grbValor.Text = "VALOR TOTAL:";
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.lblSituacao);
            this.grbSituacao.Location = new System.Drawing.Point(215, 550);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Size = new System.Drawing.Size(170, 95);
            this.grbSituacao.TabIndex = 12;
            this.grbSituacao.TabStop = false;
            // 
            // label1
            // 
            this.lblSituacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(5, 20);
            this.lblSituacao.Name = "label1";
            this.lblSituacao.Size = new System.Drawing.Size(160, 65);
            this.lblSituacao.TabIndex = 10;
            this.lblSituacao.Text = "Situação Top Aqui";
            this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uctAtendimentoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbSituacao);
            this.Controls.Add(this.grbValor);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.grbPedidos);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctAtendimentoPedidos";
            this.Size = new System.Drawing.Size(500, 650);
            this.Load += new System.EventHandler(this.uctAtendimentoPedidos_Load);
            this.grbPedidos.ResumeLayout(false);
            this.grbValor.ResumeLayout(false);
            this.grbSituacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbPedidos;
        private vitorrdgs.UiX.Component.UIXItemsList lstPedidos;
        private vitorrdgs.UiX.Component.UIXButton btnNovoPedido;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox grbValor;
        private System.Windows.Forms.GroupBox grbSituacao;
        private System.Windows.Forms.Label lblSituacao;
    }
}
