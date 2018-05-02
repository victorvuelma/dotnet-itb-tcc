namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoProdutoVer
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
            this.grbDetalhes = new System.Windows.Forms.GroupBox();
            this.txtDetalhes = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grbDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDetalhes
            // 
            this.grbDetalhes.Controls.Add(this.txtDetalhes);
            this.grbDetalhes.Location = new System.Drawing.Point(5, 5);
            this.grbDetalhes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDetalhes.Name = "grbDetalhes";
            this.grbDetalhes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDetalhes.Size = new System.Drawing.Size(390, 340);
            this.grbDetalhes.TabIndex = 5;
            this.grbDetalhes.TabStop = false;
            this.grbDetalhes.Text = "DETALHES DO PRODUTO";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Location = new System.Drawing.Point(5, 20);
            this.txtDetalhes.Multiline = true;
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.ReadOnly = true;
            this.txtDetalhes.Size = new System.Drawing.Size(380, 310);
            this.txtDetalhes.TabIndex = 0;
            this.txtDetalhes.Text = "Aqui vai o conteudo maneiro";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(240, 360);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 30);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar Produto";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // uctPedidoProdutoVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grbDetalhes);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedidoProdutoVer";
            this.Size = new System.Drawing.Size(400, 400);
            this.grbDetalhes.ResumeLayout(false);
            this.grbDetalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetalhes;
        private System.Windows.Forms.TextBox txtDetalhes;
        private System.Windows.Forms.Button btnConfirmar;
    }
}
