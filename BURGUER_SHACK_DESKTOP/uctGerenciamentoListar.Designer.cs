namespace BURGUER_SHACK_DESKTOP
{
    partial class uctGerenciamentoListar
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
            this.grbItens = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblPesquisaRes = new System.Windows.Forms.Label();
            this.txtPesquisar = new UIX.txtUIX();
            this.btnPesquisar = new UIX.btnUIX();
            this.btnNovo = new UIX.btnUIX();
            this.grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.grbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbItens
            // 
            this.grbItens.Controls.Add(this.dgvItens);
            this.grbItens.Location = new System.Drawing.Point(5, 110);
            this.grbItens.Name = "grbItens";
            this.grbItens.Size = new System.Drawing.Size(690, 380);
            this.grbItens.TabIndex = 0;
            this.grbItens.TabStop = false;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(5, 15);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(680, 360);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.lblPesquisaRes);
            this.grbPesquisa.Controls.Add(this.txtPesquisar);
            this.grbPesquisa.Controls.Add(this.btnPesquisar);
            this.grbPesquisa.Location = new System.Drawing.Point(5, 5);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(580, 105);
            this.grbPesquisa.TabIndex = 1;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "ENCONTRAR";
            // 
            // lblPesquisaRes
            // 
            this.lblPesquisaRes.Location = new System.Drawing.Point(5, 75);
            this.lblPesquisaRes.Name = "lblPesquisaRes";
            this.lblPesquisaRes.Size = new System.Drawing.Size(480, 20);
            this.lblPesquisaRes.TabIndex = 4;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AcceptButton = this.btnPesquisar;
            this.txtPesquisar.Mode = UIX.uixEnum.uixTextBoxMode.ALL;
            this.txtPesquisar.Campo = "Pesquisar por";
            this.txtPesquisar.LabelPosition = UIX.uixEnum.uixLabelPosition.UP;
            this.txtPesquisar.Location = new System.Drawing.Point(5, 25);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.Multiline = false;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisar.Size = new System.Drawing.Size(480, 40);
            this.txtPesquisar.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Description = "Pesquisar";
            this.btnPesquisar.HoverColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.pesquisar;
            this.btnPesquisar.ImageLocation = null;
            this.btnPesquisar.Location = new System.Drawing.Point(490, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 80);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "btnUIX1";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Description = "Novo";
            this.btnNovo.HoverColor = System.Drawing.Color.Transparent;
            this.btnNovo.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnNovo.ImageLocation = null;
            this.btnNovo.Location = new System.Drawing.Point(595, 5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 100);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "btnUIX1";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // uctGerenciamentoListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grbItens);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctGerenciamentoListar";
            this.Size = new System.Drawing.Size(700, 500);
            this.Load += new System.EventHandler(this.uctGerenciamentoListar_Load);
            this.grbItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.grbPesquisa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbItens;
        private UIX.btnUIX btnNovo;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private UIX.btnUIX btnPesquisar;
        private UIX.txtUIX txtPesquisar;
        private System.Windows.Forms.Label lblPesquisaRes;
    }
}
