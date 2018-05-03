namespace BURGUER_SHACK_DESKTOP
{
    partial class uctPedidoProdutoIngrediente
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grbIngrediente = new System.Windows.Forms.GroupBox();
            this.lblIngredienteDesc = new System.Windows.Forms.Label();
            this.lblIngredienteNome = new System.Windows.Forms.Label();
            this.picIngrediente = new System.Windows.Forms.PictureBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtQuantidade = new UIX.txtUIX();
            this.grbIngredienteNovo = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new UIX.txtUIX();
            this.pnlIngredientes = new System.Windows.Forms.Panel();
            this.grbIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIngrediente)).BeginInit();
            this.grbIngredienteNovo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(290, 360);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // grbIngrediente
            // 
            this.grbIngrediente.Controls.Add(this.lblIngredienteDesc);
            this.grbIngrediente.Controls.Add(this.lblIngredienteNome);
            this.grbIngrediente.Controls.Add(this.picIngrediente);
            this.grbIngrediente.Location = new System.Drawing.Point(5, 5);
            this.grbIngrediente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngrediente.Name = "grbIngrediente";
            this.grbIngrediente.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngrediente.Size = new System.Drawing.Size(390, 100);
            this.grbIngrediente.TabIndex = 5;
            this.grbIngrediente.TabStop = false;
            this.grbIngrediente.Text = "INGREDIENTE";
            // 
            // lblIngredienteDesc
            // 
            this.lblIngredienteDesc.Location = new System.Drawing.Point(80, 40);
            this.lblIngredienteDesc.Name = "lblIngredienteDesc";
            this.lblIngredienteDesc.Size = new System.Drawing.Size(300, 50);
            this.lblIngredienteDesc.TabIndex = 2;
            this.lblIngredienteDesc.Text = "Descrição do ingrediente";
            // 
            // lblIngredienteNome
            // 
            this.lblIngredienteNome.Location = new System.Drawing.Point(80, 20);
            this.lblIngredienteNome.Name = "lblIngredienteNome";
            this.lblIngredienteNome.Size = new System.Drawing.Size(300, 20);
            this.lblIngredienteNome.TabIndex = 1;
            this.lblIngredienteNome.Text = "Nome do Ingrediente";
            // 
            // picIngrediente
            // 
            this.picIngrediente.Location = new System.Drawing.Point(5, 20);
            this.picIngrediente.Name = "picIngrediente";
            this.picIngrediente.Size = new System.Drawing.Size(70, 70);
            this.picIngrediente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIngrediente.TabIndex = 0;
            this.picIngrediente.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(203, 360);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(81, 30);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AccessibleName = "Quantidade";
            this.txtQuantidade.AllowedChars = UIX.uixAllowedChars.INT;
            this.txtQuantidade.Campo = "Quantidade";
            this.txtQuantidade.Location = new System.Drawing.Point(5, 110);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(390, 20);
            this.txtQuantidade.TabIndex = 9;
            // 
            // grbIngredienteNovo
            // 
            this.grbIngredienteNovo.Controls.Add(this.btnPesquisar);
            this.grbIngredienteNovo.Controls.Add(this.txtPesquisa);
            this.grbIngredienteNovo.Controls.Add(this.pnlIngredientes);
            this.grbIngredienteNovo.Location = new System.Drawing.Point(5, 140);
            this.grbIngredienteNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngredienteNovo.Name = "grbIngredienteNovo";
            this.grbIngredienteNovo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbIngredienteNovo.Size = new System.Drawing.Size(390, 210);
            this.grbIngredienteNovo.TabIndex = 6;
            this.grbIngredienteNovo.TabStop = false;
            this.grbIngredienteNovo.Text = "SELECIONE O NOVO INGREDIENTE";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(280, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(106, 22);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AccessibleName = "Ingrediente";
            this.txtPesquisa.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtPesquisa.Campo = "Ingrediente";
            this.txtPesquisa.Location = new System.Drawing.Point(5, 20);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(268, 25);
            this.txtPesquisa.TabIndex = 10;
            // 
            // pnlIngredientes
            // 
            this.pnlIngredientes.AutoScroll = true;
            this.pnlIngredientes.Location = new System.Drawing.Point(6, 45);
            this.pnlIngredientes.MaximumSize = new System.Drawing.Size(380, 10000);
            this.pnlIngredientes.Name = "pnlIngredientes";
            this.pnlIngredientes.Size = new System.Drawing.Size(380, 160);
            this.pnlIngredientes.TabIndex = 0;
            // 
            // uctPedidoProdutoIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbIngredienteNovo);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grbIngrediente);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctPedidoProdutoIngrediente";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.uctPedidoProdutoIngrediente_Load);
            this.grbIngrediente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIngrediente)).EndInit();
            this.grbIngredienteNovo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox picIngrediente;
        private System.Windows.Forms.Label lblIngredienteNome;
        private System.Windows.Forms.Label lblIngredienteDesc;
        private System.Windows.Forms.GroupBox grbIngredienteNovo;
        public System.Windows.Forms.GroupBox grbIngrediente;
        public System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Panel pnlIngredientes;
        public System.Windows.Forms.Button btnPesquisar;
        public UIX.txtUIX txtQuantidade;
        private UIX.txtUIX txtPesquisa;
    }
}
