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
            this.pnlLeftButtons = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grpFuncao = new System.Windows.Forms.GroupBox();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnTransportadora = new System.Windows.Forms.Button();
            this.btnTercerizada = new System.Windows.Forms.Button();
            this.uctUIX = new UIX.uctUIX();
            this.uctFuncionario = new BURGUER_SHACK_DESKTOP.uctFuncionario();
            this.pnlLeftButtons.SuspendLayout();
            this.grpFuncao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftButtons
            // 
            this.pnlLeftButtons.Controls.Add(this.btnLogout);
            this.pnlLeftButtons.Controls.Add(this.btnLista);
            this.pnlLeftButtons.Controls.Add(this.btnRemover);
            this.pnlLeftButtons.Controls.Add(this.btnModificar);
            this.pnlLeftButtons.Controls.Add(this.btnAdicionar);
            this.pnlLeftButtons.Location = new System.Drawing.Point(0, 40);
            this.pnlLeftButtons.Name = "pnlLeftButtons";
            this.pnlLeftButtons.Size = new System.Drawing.Size(90, 560);
            this.pnlLeftButtons.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.sair;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(10, 478);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 70);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnLista
            // 
            this.btnLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLista.BackgroundImage")));
            this.btnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLista.Location = new System.Drawing.Point(10, 238);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(70, 70);
            this.btnLista.TabIndex = 4;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.remover_menos;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemover.Location = new System.Drawing.Point(10, 162);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(70, 70);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(10, 86);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 70);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Location = new System.Drawing.Point(10, 10);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(70, 70);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grpFuncao
            // 
            this.grpFuncao.Controls.Add(this.btnProduto);
            this.grpFuncao.Controls.Add(this.btnFuncionario);
            this.grpFuncao.Controls.Add(this.btnTransportadora);
            this.grpFuncao.Controls.Add(this.btnTercerizada);
            this.grpFuncao.Location = new System.Drawing.Point(96, 40);
            this.grpFuncao.Name = "grpFuncao";
            this.grpFuncao.Size = new System.Drawing.Size(818, 54);
            this.grpFuncao.TabIndex = 4;
            this.grpFuncao.TabStop = false;
            this.grpFuncao.Text = "ADICIONAR";
            this.grpFuncao.Visible = false;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(319, 20);
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
            // btnTransportadora
            // 
            this.btnTransportadora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportadora.Location = new System.Drawing.Point(102, 20);
            this.btnTransportadora.Name = "btnTransportadora";
            this.btnTransportadora.Size = new System.Drawing.Size(115, 23);
            this.btnTransportadora.TabIndex = 1;
            this.btnTransportadora.Text = "Transportadora";
            this.btnTransportadora.UseVisualStyleBackColor = true;
            this.btnTransportadora.Click += new System.EventHandler(this.btnTransportadora_Click);
            // 
            // btnTercerizada
            // 
            this.btnTercerizada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTercerizada.Location = new System.Drawing.Point(223, 20);
            this.btnTercerizada.Name = "btnTercerizada";
            this.btnTercerizada.Size = new System.Drawing.Size(90, 23);
            this.btnTercerizada.TabIndex = 2;
            this.btnTercerizada.Text = "Tercerizada";
            this.btnTercerizada.UseVisualStyleBackColor = true;
            this.btnTercerizada.Click += new System.EventHandler(this.btnTercerizada_Click);
            // 
            // uctUIX
            // 
            this.uctUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uctUIX.Location = new System.Drawing.Point(0, 0);
            this.uctUIX.Name = "uctUIX";
            this.uctUIX.Size = new System.Drawing.Size(250, 40);
            this.uctUIX.TabIndex = 0;
            this.uctUIX.UIXButtonCloseEnabled = true;
            this.uctUIX.UIXButtonMinEnabled = true;
            this.uctUIX.UIXImage = global::BURGUER_SHACK_DESKTOP.Properties.Resources.gerenciador;
            this.uctUIX.UIXTitle = "Gerenciador";
            this.uctUIX.Close += new System.EventHandler(this.uctUIX_Close);
            this.uctUIX.Min += new System.EventHandler(this.uctUIX_Min);
            // 
            // uctFuncionario
            // 
            this.uctFuncionario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctFuncionario.Location = new System.Drawing.Point(96, 101);
            this.uctFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctFuncionario.Name = "uctFuncionario";
            this.uctFuncionario.Size = new System.Drawing.Size(818, 488);
            this.uctFuncionario.TabIndex = 5;
            // 
            // frmGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.uctFuncionario);
            this.Controls.Add(this.pnlLeftButtons);
            this.Controls.Add(this.grpFuncao);
            this.Controls.Add(this.uctUIX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.Load += new System.EventHandler(this.frmGerenciador_Load);
            this.pnlLeftButtons.ResumeLayout(false);
            this.grpFuncao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIX.uctUIX uctUIX;
        private System.Windows.Forms.Panel pnlLeftButtons;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grpFuncao;
        private System.Windows.Forms.Button btnTransportadora;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnTercerizada;
        private System.Windows.Forms.Button btnProduto;
        private uctFuncionario uctFuncionario;
    }
}