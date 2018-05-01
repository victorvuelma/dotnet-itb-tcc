namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoAdicionar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAdicionarProduto = new System.Windows.Forms.GroupBox();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnUIX4 = new UIX.btnUIX();
            this.btnUIX3 = new UIX.btnUIX();
            this.btnAcompanhamento = new UIX.btnUIX();
            this.btnSanduiches = new UIX.btnUIX();
            this.grbAdicionarProduto.SuspendLayout();
            this.grbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdicionarProduto
            // 
            this.grbAdicionarProduto.Controls.Add(this.grbTipo);
            this.grbAdicionarProduto.Location = new System.Drawing.Point(5, 5);
            this.grbAdicionarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbAdicionarProduto.Name = "grbAdicionarProduto";
            this.grbAdicionarProduto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbAdicionarProduto.Size = new System.Drawing.Size(490, 730);
            this.grbAdicionarProduto.TabIndex = 5;
            this.grbAdicionarProduto.TabStop = false;
            this.grbAdicionarProduto.Text = "ADICIONAR PRODUTO";
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.btnUIX4);
            this.grbTipo.Controls.Add(this.btnUIX3);
            this.grbTipo.Controls.Add(this.btnAcompanhamento);
            this.grbTipo.Controls.Add(this.btnSanduiches);
            this.grbTipo.Location = new System.Drawing.Point(5, 20);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(480, 139);
            this.grbTipo.TabIndex = 0;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "TIPO DO PRODUTO";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(345, 745);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(150, 50);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = "Confirmar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // btnUIX4
            // 
            this.btnUIX4.Description = "Sobremesas";
            this.btnUIX4.HoverColor = System.Drawing.Color.Transparent;
            this.btnUIX4.Image = null;
            this.btnUIX4.Location = new System.Drawing.Point(313, 20);
            this.btnUIX4.Name = "btnUIX4";
            this.btnUIX4.Size = new System.Drawing.Size(80, 80);
            this.btnUIX4.TabIndex = 3;
            this.btnUIX4.Text = "btnUIX4";
            this.btnUIX4.UseVisualStyleBackColor = true;
            // 
            // btnUIX3
            // 
            this.btnUIX3.Description = "Bebidas";
            this.btnUIX3.HoverColor = System.Drawing.Color.Transparent;
            this.btnUIX3.Image = null;
            this.btnUIX3.Location = new System.Drawing.Point(227, 20);
            this.btnUIX3.Name = "btnUIX3";
            this.btnUIX3.Size = new System.Drawing.Size(80, 80);
            this.btnUIX3.TabIndex = 2;
            this.btnUIX3.Text = "btnUIX3";
            this.btnUIX3.UseVisualStyleBackColor = true;
            // 
            // btnAcompanhamento
            // 
            this.btnAcompanhamento.Description = "Acompanhamento";
            this.btnAcompanhamento.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcompanhamento.HoverColor = System.Drawing.Color.Transparent;
            this.btnAcompanhamento.Image = null;
            this.btnAcompanhamento.Location = new System.Drawing.Point(140, 20);
            this.btnAcompanhamento.Name = "btnAcompanhamento";
            this.btnAcompanhamento.Size = new System.Drawing.Size(80, 80);
            this.btnAcompanhamento.TabIndex = 1;
            this.btnAcompanhamento.Text = "btnUIX2";
            this.btnAcompanhamento.UseVisualStyleBackColor = true;
            // 
            // btnSanduiches
            // 
            this.btnSanduiches.Description = "Lanches";
            this.btnSanduiches.HoverColor = System.Drawing.Color.Transparent;
            this.btnSanduiches.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.hamburger;
            this.btnSanduiches.Location = new System.Drawing.Point(10, 20);
            this.btnSanduiches.Name = "btnSanduiches";
            this.btnSanduiches.Size = new System.Drawing.Size(100, 100);
            this.btnSanduiches.TabIndex = 0;
            this.btnSanduiches.Text = "btnUIX1";
            this.btnSanduiches.UseVisualStyleBackColor = true;
            // 
            // uctPedidoAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.grbAdicionarProduto);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedidoAdicionar";
            this.Size = new System.Drawing.Size(500, 800);
            this.grbAdicionarProduto.ResumeLayout(false);
            this.grbTipo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdicionarProduto;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.GroupBox grbTipo;
        private UIX.btnUIX btnSanduiches;
        private UIX.btnUIX btnUIX4;
        private UIX.btnUIX btnUIX3;
        private UIX.btnUIX btnAcompanhamento;
    }
}
