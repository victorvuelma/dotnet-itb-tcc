namespace BURGUER_SHACK_DESKTOP
{
    partial class frmGerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciador));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAdicionar = new UIX.btnUIX();
            this.btnSair = new UIX.btnUIX();
            this.btnLista = new UIX.btnUIX();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.hdrUIX = new UIX.hdrUIX();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTercerizada = new System.Windows.Forms.DataGridView();
            this.razaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.PIC = new System.Windows.Forms.DataGridViewImageColumn();
            this.uctGerenTerceirizada = new BURGUER_SHACK_DESKTOP.uctGerenTerceirizada();
            this.uctGerenProduto = new BURGUER_SHACK_DESKTOP.uctGerenProduto();
            this.uctGerenFuncionario = new BURGUER_SHACK_DESKTOP.uctGerenFuncionario();
            this.pnlMenu.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTercerizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnAdicionar);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnLista);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 549);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Description = "Adicionar";
            this.btnAdicionar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.btnAdicionar.Location = new System.Drawing.Point(10, 6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 80);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Description = "Sair";
            this.btnSair.HoverColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(10, 465);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 80);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLista.Description = "Lista";
            this.btnLista.HoverColor = System.Drawing.Color.Transparent;
            this.btnLista.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.lista;
            this.btnLista.Location = new System.Drawing.Point(10, 101);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(80, 80);
            this.btnLista.TabIndex = 4;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.uctGerenTerceirizada);
            this.pnlConteudo.Controls.Add(this.uctGerenProduto);
            this.pnlConteudo.Controls.Add(this.dgvFuncionario);
            this.pnlConteudo.Controls.Add(this.dgvProduto);
            this.pnlConteudo.Controls.Add(this.uctGerenFuncionario);
            this.pnlConteudo.Controls.Add(this.dgvTercerizada);
            this.pnlConteudo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConteudo.Location = new System.Drawing.Point(106, 57);
            this.pnlConteudo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(818, 538);
            this.pnlConteudo.TabIndex = 5;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = true;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.gerenciador;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(930, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Gerenciador";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            this.hdrUIX.Min += new System.EventHandler(this.hdrUIX_Min);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.Cargo,
            this.Salario});
            this.dgvFuncionario.Location = new System.Drawing.Point(627, 396);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.Size = new System.Drawing.Size(100, 100);
            this.dgvFuncionario.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "COD";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "CARGO";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "SALÁRIO";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // dgvTercerizada
            // 
            this.dgvTercerizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTercerizada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.razaoSocial});
            this.dgvTercerizada.Location = new System.Drawing.Point(521, 396);
            this.dgvTercerizada.Name = "dgvTercerizada";
            this.dgvTercerizada.Size = new System.Drawing.Size(100, 100);
            this.dgvTercerizada.TabIndex = 1;
            this.dgvTercerizada.Visible = false;
            // 
            // razaoSocial
            // 
            this.razaoSocial.HeaderText = "RAZÃO SOCIAL";
            this.razaoSocial.Name = "razaoSocial";
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIC});
            this.dgvProduto.Location = new System.Drawing.Point(415, 396);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(100, 100);
            this.dgvProduto.TabIndex = 2;
            // 
            // PIC
            // 
            this.PIC.HeaderText = "IMAGEM";
            this.PIC.Name = "PIC";
            // 
            // uctGerenTerceirizada
            // 
            this.uctGerenTerceirizada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctGerenTerceirizada.Location = new System.Drawing.Point(463, 218);
            this.uctGerenTerceirizada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctGerenTerceirizada.Name = "uctGerenTerceirizada";
            this.uctGerenTerceirizada.Size = new System.Drawing.Size(100, 100);
            this.uctGerenTerceirizada.TabIndex = 2;
            // 
            // uctGerenProduto
            // 
            this.uctGerenProduto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uctGerenProduto.Location = new System.Drawing.Point(318, 218);
            this.uctGerenProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctGerenProduto.Name = "uctGerenProduto";
            this.uctGerenProduto.Size = new System.Drawing.Size(100, 100);
            this.uctGerenProduto.TabIndex = 1;
            // 
            // uctGerenFuncionario
            // 
            this.uctGerenFuncionario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctGerenFuncionario.Location = new System.Drawing.Point(595, 218);
            this.uctGerenFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctGerenFuncionario.Name = "uctGerenFuncionario";
            this.uctGerenFuncionario.Size = new System.Drawing.Size(100, 100);
            this.uctGerenFuncionario.TabIndex = 0;
            // 
            // frmGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.Load += new System.EventHandler(this.frmGerenciador_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTercerizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.hdrUIX hdrUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnSair;
        private UIX.btnUIX btnLista;
        private System.Windows.Forms.Panel pnlConteudo;
        private UIX.btnUIX btnAdicionar;
        public System.Windows.Forms.DataGridView dgvProduto;
        public System.Windows.Forms.DataGridView dgvTercerizada;
        public System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridViewImageColumn PIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private uctGerenFuncionario uctGerenFuncionario;
        private uctGerenProduto uctGerenProduto;
        private uctGerenTerceirizada uctGerenTerceirizada;
    }
}