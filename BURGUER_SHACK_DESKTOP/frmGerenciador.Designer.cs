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
            this.btnSair = new UIX.btnUIX();
            this.btnLista = new UIX.btnUIX();
            this.btnRemover = new UIX.btnUIX();
            this.btnModificar = new UIX.btnUIX();
            this.btnAdicionar = new UIX.btnUIX();
            this.grpFuncao = new System.Windows.Forms.GroupBox();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnTercerizada = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.uctUIX = new UIX.uctUIX();
            this.pnlMenu.SuspendLayout();
            this.grpFuncao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnLista);
            this.pnlMenu.Controls.Add(this.btnRemover);
            this.pnlMenu.Controls.Add(this.btnModificar);
            this.pnlMenu.Controls.Add(this.btnAdicionar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 560);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Description = "Sair";
            this.btnSair.HoverColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(10, 470);
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
            this.btnLista.Location = new System.Drawing.Point(10, 280);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(80, 80);
            this.btnLista.TabIndex = 4;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemover.Description = "Remover";
            this.btnRemover.HoverColor = System.Drawing.Color.Transparent;
            this.btnRemover.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover_menos;
            this.btnRemover.Location = new System.Drawing.Point(10, 190);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(80, 80);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Description = "Modificar";
            this.btnModificar.HoverColor = System.Drawing.Color.Transparent;
            this.btnModificar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.btnModificar.Location = new System.Drawing.Point(10, 100);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 80);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Description = "Adicionar";
            this.btnAdicionar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.adicionar;
            this.btnAdicionar.Location = new System.Drawing.Point(10, 10);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 80);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grpFuncao
            // 
            this.grpFuncao.Controls.Add(this.btnProduto);
            this.grpFuncao.Controls.Add(this.btnFuncionario);
            this.grpFuncao.Controls.Add(this.btnTercerizada);
            this.grpFuncao.Location = new System.Drawing.Point(105, 45);
            this.grpFuncao.Name = "grpFuncao";
            this.grpFuncao.Size = new System.Drawing.Size(810, 55);
            this.grpFuncao.TabIndex = 4;
            this.grpFuncao.TabStop = false;
            this.grpFuncao.Text = "ADICIONAR";
            this.grpFuncao.Visible = false;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(198, 20);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(90, 23);
            this.btnProduto.TabIndex = 3;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(6, 20);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(90, 23);
            this.btnFuncionario.TabIndex = 0;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnTercerizada
            // 
            this.btnTercerizada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTercerizada.Location = new System.Drawing.Point(102, 20);
            this.btnTercerizada.Name = "btnTercerizada";
            this.btnTercerizada.Size = new System.Drawing.Size(90, 23);
            this.btnTercerizada.TabIndex = 2;
            this.btnTercerizada.Text = "Tercerizada";
            this.btnTercerizada.UseVisualStyleBackColor = true;
            this.btnTercerizada.Click += new System.EventHandler(this.btnTercerizada_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConteudo.Location = new System.Drawing.Point(105, 110);
            this.pnlConteudo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(810, 470);
            this.pnlConteudo.TabIndex = 5;
            // 
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(930, 40);
            this.uctUIX.TabIndex = 0;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = true;
            this.uctUIX.UIXImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.gerenciador;
            this.uctUIX.UIXTitle = "Gerenciador";
            this.uctUIX.Close += new System.EventHandler(this.uctUIX_Close);
            this.uctUIX.Min += new System.EventHandler(this.uctUIX_Min);
            // 
            // frmGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 600);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.grpFuncao);
            this.Controls.Add(this.uctUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciador";
            this.Load += new System.EventHandler(this.frmGerenciador_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grpFuncao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.uctUIX uctUIX;
        private System.Windows.Forms.Panel pnlMenu;
        private UIX.btnUIX btnSair;
        private UIX.btnUIX btnLista;
        private UIX.btnUIX btnRemover;
        private UIX.btnUIX btnModificar;
        private UIX.btnUIX btnAdicionar;
        private System.Windows.Forms.GroupBox grpFuncao;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnTercerizada;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Panel pnlConteudo;
    }
}