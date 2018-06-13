namespace BURGUER_SHACK_DESKTOP
{
    partial class frmTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipo));
            this.hdrUIX = new UIX.hdrUIX();
            this.grbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.columnCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnAcao = new System.Windows.Forms.Button();
            this.txtNome = new UIX.txtUIX();
            this.grbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.alterar;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(400, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Tipo";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // grbDadosPessoais
            // 
            this.grbDadosPessoais.Controls.Add(this.dgvTipos);
            this.grbDadosPessoais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPessoais.Location = new System.Drawing.Point(5, 55);
            this.grbDadosPessoais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Name = "grbDadosPessoais";
            this.grbDadosPessoais.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDadosPessoais.Size = new System.Drawing.Size(390, 280);
            this.grbDadosPessoais.TabIndex = 7;
            this.grbDadosPessoais.TabStop = false;
            this.grbDadosPessoais.Text = "TIPOS";
            // 
            // dgvTipos
            // 
            this.dgvTipos.AllowUserToAddRows = false;
            this.dgvTipos.AllowUserToDeleteRows = false;
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCod,
            this.columnDesc});
            this.dgvTipos.Location = new System.Drawing.Point(5, 20);
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.ReadOnly = true;
            this.dgvTipos.Size = new System.Drawing.Size(380, 250);
            this.dgvTipos.TabIndex = 0;
            this.dgvTipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipos_CellClick);
            // 
            // columnCod
            // 
            this.columnCod.HeaderText = "Código";
            this.columnCod.Name = "columnCod";
            this.columnCod.ReadOnly = true;
            // 
            // columnDesc
            // 
            this.columnDesc.HeaderText = "Descrição";
            this.columnDesc.Name = "columnDesc";
            this.columnDesc.ReadOnly = true;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnAcao);
            this.grbEditar.Controls.Add(this.txtNome);
            this.grbEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(5, 340);
            this.grbEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbEditar.Size = new System.Drawing.Size(390, 50);
            this.grbEditar.TabIndex = 8;
            this.grbEditar.TabStop = false;
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(275, 20);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(110, 25);
            this.btnAcao.TabIndex = 1;
            this.btnAcao.Text = "...";
            this.btnAcao.UseVisualStyleBackColor = true;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // txtNome
            // 
            this.txtNome.AllowedChars = UIX.uixAllowedChars.ALL;
            this.txtNome.Campo = "Descrição";
            this.txtNome.Location = new System.Drawing.Point(5, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);
            this.txtNome.TabIndex = 0;
            // 
            // frmTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbDadosPessoais);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo";
            this.Load += new System.EventHandler(this.frmIngrediente_Load);
            this.grbDadosPessoais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            this.grbEditar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public UIX.hdrUIX hdrUIX;
        public System.Windows.Forms.GroupBox grbDadosPessoais;
        public System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.DataGridView dgvTipos;
        private UIX.txtUIX txtNome;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDesc;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}