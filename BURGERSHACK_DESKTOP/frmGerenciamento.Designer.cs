namespace BurgerShack.Desktop
{
    partial class frmGerenciamento
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMercadorias = new vitorrdgs.UiX.Component.UIXButton();
            this.btnPagamentos = new vitorrdgs.UiX.Component.UIXButton();
            this.btnPedidos = new vitorrdgs.UiX.Component.UIXButton();
            this.btnReservas = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAtendimentos = new vitorrdgs.UiX.Component.UIXButton();
            this.btnMesas = new vitorrdgs.UiX.Component.UIXButton();
            this.btnEstoque = new vitorrdgs.UiX.Component.UIXButton();
            this.btnFornecedores = new vitorrdgs.UiX.Component.UIXButton();
            this.btnFuncionarios = new vitorrdgs.UiX.Component.UIXButton();
            this.btnClientes = new vitorrdgs.UiX.Component.UIXButton();
            this.btnProdutos = new vitorrdgs.UiX.Component.UIXButton();
            this.btnIngredientes = new vitorrdgs.UiX.Component.UIXButton();
            this.btnVoltar = new vitorrdgs.UiX.Component.UIXButton();
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.uctListar = new BurgerShack.Desktop.uctGerenciamentoListar();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnMercadorias);
            this.pnlMenu.Controls.Add(this.btnPagamentos);
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Controls.Add(this.btnReservas);
            this.pnlMenu.Controls.Add(this.btnAtendimentos);
            this.pnlMenu.Controls.Add(this.btnMesas);
            this.pnlMenu.Controls.Add(this.btnEstoque);
            this.pnlMenu.Controls.Add(this.btnFornecedores);
            this.pnlMenu.Controls.Add(this.btnFuncionarios);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnProdutos);
            this.pnlMenu.Controls.Add(this.btnIngredientes);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(300, 500);
            this.pnlMenu.TabIndex = 7;
            // 
            // btnMercadorias
            // 
            this.btnMercadorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMercadorias.Description = "MERCADORIAS";
            this.btnMercadorias.HoverColor = System.Drawing.Color.Transparent;
            this.btnMercadorias.Image = global::BurgerShack.Desktop.Properties.Resources.mercadoria;
            this.btnMercadorias.ImageLocation = null;
            this.btnMercadorias.Location = new System.Drawing.Point(105, 5);
            this.btnMercadorias.Name = "btnMercadorias";
            this.btnMercadorias.Size = new System.Drawing.Size(90, 90);
            this.btnMercadorias.TabIndex = 17;
            this.btnMercadorias.Text = "Mercadorias";
            this.btnMercadorias.UseVisualStyleBackColor = true;
            this.btnMercadorias.Visible = false;
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagamentos.Description = "PAGAMENTOS";
            this.btnPagamentos.HoverColor = System.Drawing.Color.Transparent;
            this.btnPagamentos.Image = global::BurgerShack.Desktop.Properties.Resources.pagamento;
            this.btnPagamentos.ImageLocation = null;
            this.btnPagamentos.Location = new System.Drawing.Point(205, 305);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(90, 90);
            this.btnPagamentos.TabIndex = 16;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.UseVisualStyleBackColor = true;
            this.btnPagamentos.Visible = false;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedidos.Description = "PEDIDOS";
            this.btnPedidos.HoverColor = System.Drawing.Color.Transparent;
            this.btnPedidos.Image = global::BurgerShack.Desktop.Properties.Resources.pedido;
            this.btnPedidos.ImageLocation = null;
            this.btnPedidos.Location = new System.Drawing.Point(205, 205);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(90, 90);
            this.btnPedidos.TabIndex = 15;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservas.Description = "RESERVAS";
            this.btnReservas.HoverColor = System.Drawing.Color.Transparent;
            this.btnReservas.Image = global::BurgerShack.Desktop.Properties.Resources.reserva;
            this.btnReservas.ImageLocation = null;
            this.btnReservas.Location = new System.Drawing.Point(205, 5);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(90, 90);
            this.btnReservas.TabIndex = 14;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnAtendimentos
            // 
            this.btnAtendimentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtendimentos.Description = "ATENDIMENTOS";
            this.btnAtendimentos.HoverColor = System.Drawing.Color.Transparent;
            this.btnAtendimentos.Image = global::BurgerShack.Desktop.Properties.Resources.atendimento;
            this.btnAtendimentos.ImageLocation = null;
            this.btnAtendimentos.Location = new System.Drawing.Point(205, 105);
            this.btnAtendimentos.Name = "btnAtendimentos";
            this.btnAtendimentos.Size = new System.Drawing.Size(90, 90);
            this.btnAtendimentos.TabIndex = 13;
            this.btnAtendimentos.Text = "Atendimentos";
            this.btnAtendimentos.UseVisualStyleBackColor = true;
            this.btnAtendimentos.Click += new System.EventHandler(this.btnAtendimentos_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesas.Description = "MESAS";
            this.btnMesas.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesas.Image = global::BurgerShack.Desktop.Properties.Resources.mesa;
            this.btnMesas.ImageLocation = null;
            this.btnMesas.Location = new System.Drawing.Point(5, 305);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(90, 90);
            this.btnMesas.TabIndex = 12;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstoque.Description = "ESTOQUE";
            this.btnEstoque.HoverColor = System.Drawing.Color.Transparent;
            this.btnEstoque.Image = global::BurgerShack.Desktop.Properties.Resources.estoque;
            this.btnEstoque.ImageLocation = null;
            this.btnEstoque.Location = new System.Drawing.Point(105, 105);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(90, 90);
            this.btnEstoque.TabIndex = 11;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFornecedores.Description = "FORNECEDORES";
            this.btnFornecedores.HoverColor = System.Drawing.Color.Transparent;
            this.btnFornecedores.Image = global::BurgerShack.Desktop.Properties.Resources.fornecedor;
            this.btnFornecedores.ImageLocation = null;
            this.btnFornecedores.Location = new System.Drawing.Point(5, 105);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(90, 90);
            this.btnFornecedores.TabIndex = 10;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFuncionarios.Description = "FUNCIONÁRIOS";
            this.btnFuncionarios.HoverColor = System.Drawing.Color.Transparent;
            this.btnFuncionarios.Image = global::BurgerShack.Desktop.Properties.Resources.funcionario;
            this.btnFuncionarios.ImageLocation = null;
            this.btnFuncionarios.Location = new System.Drawing.Point(5, 5);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(90, 90);
            this.btnFuncionarios.TabIndex = 9;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.Description = "CLIENTES";
            this.btnClientes.HoverColor = System.Drawing.Color.Transparent;
            this.btnClientes.Image = global::BurgerShack.Desktop.Properties.Resources.cliente;
            this.btnClientes.ImageLocation = null;
            this.btnClientes.Location = new System.Drawing.Point(5, 205);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(90, 90);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdutos.Description = "PRODUTOS";
            this.btnProdutos.HoverColor = System.Drawing.Color.Transparent;
            this.btnProdutos.Image = global::BurgerShack.Desktop.Properties.Resources.produto;
            this.btnProdutos.ImageLocation = null;
            this.btnProdutos.Location = new System.Drawing.Point(105, 305);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(90, 90);
            this.btnProdutos.TabIndex = 7;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngredientes.Description = "INGREDIENTES";
            this.btnIngredientes.HoverColor = System.Drawing.Color.Transparent;
            this.btnIngredientes.Image = global::BurgerShack.Desktop.Properties.Resources.ingrediente;
            this.btnIngredientes.ImageLocation = null;
            this.btnIngredientes.Location = new System.Drawing.Point(105, 205);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(90, 90);
            this.btnIngredientes.TabIndex = 6;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Description = "VOLTAR";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BurgerShack.Desktop.Properties.Resources.voltar;
            this.btnVoltar.ImageLocation = null;
            this.btnVoltar.Location = new System.Drawing.Point(5, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(290, 90);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.gerenciador;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(1000, 50);
            this.hdrUIX.TabIndex = 6;
            this.hdrUIX.Title = "Gerenciamento";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // uctListar
            // 
            this.uctListar.Colunas = null;
            this.uctListar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctListar.Inativos = false;
            this.uctListar.Location = new System.Drawing.Point(300, 50);
            this.uctListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uctListar.Name = "uctListar";
            this.uctListar.Size = new System.Drawing.Size(700, 500);
            this.uctListar.TabIndex = 8;
            // 
            // frmGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.uctListar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciamento";
            this.Load += new System.EventHandler(this.frmGerenciador_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private vitorrdgs.UiX.Component.UIXButton btnIngredientes;
        private vitorrdgs.UiX.Component.UIXButton btnVoltar;
        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private vitorrdgs.UiX.Component.UIXButton btnProdutos;
        private vitorrdgs.UiX.Component.UIXButton btnClientes;
        private vitorrdgs.UiX.Component.UIXButton btnFuncionarios;
        private vitorrdgs.UiX.Component.UIXButton btnFornecedores;
        private vitorrdgs.UiX.Component.UIXButton btnEstoque;
        private vitorrdgs.UiX.Component.UIXButton btnMesas;
        private vitorrdgs.UiX.Component.UIXButton btnAtendimentos;
        private vitorrdgs.UiX.Component.UIXButton btnReservas;
        private vitorrdgs.UiX.Component.UIXButton btnPedidos;
        private vitorrdgs.UiX.Component.UIXButton btnPagamentos;
        private vitorrdgs.UiX.Component.UIXButton btnMercadorias;
        private uctGerenciamentoListar uctListar;
    }
}