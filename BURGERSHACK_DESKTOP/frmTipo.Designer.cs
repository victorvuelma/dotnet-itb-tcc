namespace BurgerShack.Desktop
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
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.grbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.columnCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txtNome = new vitorrdgs.UiX.Component.UIXTextBox();
            this.btnNovo = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAcao = new vitorrdgs.UiX.Component.UIXButton();
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
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.alterar;
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
            this.grbDadosPessoais.Size = new System.Drawing.Size(390, 245);
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
            this.dgvTipos.Size = new System.Drawing.Size(380, 215);
            this.dgvTipos.TabIndex = 0;
            this.dgvTipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipos_CellClick);
            this.dgvTipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipos_CellDoubleClick);
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
            this.grbEditar.Controls.Add(this.txtNome);
            this.grbEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(100, 300);
            this.grbEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbEditar.Size = new System.Drawing.Size(200, 50);
            this.grbEditar.TabIndex = 8;
            this.grbEditar.TabStop = false;
            this.grbEditar.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.AcceptButton = this.btnAcao;
            this.txtNome.Campo = "Descrição";
            this.txtNome.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtNome.Location = new System.Drawing.Point(5, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Description = "Novo";
            this.btnNovo.HoverColor = System.Drawing.Color.Transparent;
            this.btnNovo.Image = global::BurgerShack.Desktop.Properties.Resources.adicionar;
            this.btnNovo.ImageLocation = null;
            this.btnNovo.Location = new System.Drawing.Point(5, 305);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 90);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "btnvitorrdgs.UiX1";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAcao
            // 
            this.btnAcao.Description = "Alterar";
            this.btnAcao.HoverColor = System.Drawing.Color.Transparent;
            this.btnAcao.Image = global::BurgerShack.Desktop.Properties.Resources.alterar;
            this.btnAcao.ImageLocation = null;
            this.btnAcao.Location = new System.Drawing.Point(305, 305);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(90, 90);
            this.btnAcao.TabIndex = 10;
            this.btnAcao.Text = "btnvitorrdgs.UiX1";
            this.btnAcao.UseVisualStyleBackColor = true;
            this.btnAcao.Visible = false;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // frmTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnAcao);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbDadosPessoais);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        public vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        public System.Windows.Forms.GroupBox grbDadosPessoais;
        public System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.DataGridView dgvTipos;
        private vitorrdgs.UiX.Component.UIXTextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDesc;
        private vitorrdgs.UiX.Component.UIXButton btnNovo;
        private vitorrdgs.UiX.Component.UIXButton btnAcao;
        //private uctProdutoRemover uctPedidoRemover1;
    }
}