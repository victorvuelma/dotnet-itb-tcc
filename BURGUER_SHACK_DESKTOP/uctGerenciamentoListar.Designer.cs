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
            this.btnNovo = new UIX.btnUIX();
            this.grbBusca = new System.Windows.Forms.GroupBox();
            this.lblPesquisaRes = new System.Windows.Forms.Label();
            this.txtPesquisar = new UIX.txtUIX();
            this.btnBuscar = new UIX.btnUIX();
            this.grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.grbBusca.SuspendLayout();
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
            // grbBusca
            // 
            this.grbBusca.Controls.Add(this.lblPesquisaRes);
            this.grbBusca.Controls.Add(this.txtPesquisar);
            this.grbBusca.Controls.Add(this.btnBuscar);
            this.grbBusca.Location = new System.Drawing.Point(5, 5);
            this.grbBusca.Name = "grbBusca";
            this.grbBusca.Size = new System.Drawing.Size(580, 105);
            this.grbBusca.TabIndex = 1;
            this.grbBusca.TabStop = false;
            this.grbBusca.Text = "Busca";
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
            this.txtPesquisar.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtPesquisar.Campo = "Pesquisar";
            this.txtPesquisar.Location = new System.Drawing.Point(5, 25);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.Multiline = false;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(480, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Description = "Pesquisar";
            this.btnBuscar.HoverColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnBuscar.ImageLocation = null;
            this.btnBuscar.Location = new System.Drawing.Point(490, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 80);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "btnUIX1";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // uctGerenciadorListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbBusca);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grbItens);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctGerenciadorListar";
            this.Size = new System.Drawing.Size(700, 500);
            this.Load += new System.EventHandler(this.uctGerenciamentoListar_Load);
            this.grbItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.grbBusca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbItens;
        private UIX.btnUIX btnNovo;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.GroupBox grbBusca;
        private UIX.btnUIX btnBuscar;
        private UIX.txtUIX txtPesquisar;
        private System.Windows.Forms.Label lblPesquisaRes;
    }
}
