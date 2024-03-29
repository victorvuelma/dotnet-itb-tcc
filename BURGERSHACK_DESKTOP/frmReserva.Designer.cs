﻿namespace BurgerShack.Desktop
{
    partial class frmReserva
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
            this.btnExcluir = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAtendimento = new vitorrdgs.UiX.Component.UIXButton();
            this.btnVoltar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnAlterar = new vitorrdgs.UiX.Component.UIXButton();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCliEncontrar = new vitorrdgs.UiX.Component.UIXButton();
            this.mtbCliCPF = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.grbReserva = new System.Windows.Forms.GroupBox();
            this.mtbHora = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.txtPessoas = new vitorrdgs.UiX.Component.UIXTextBox();
            this.mtbData = new vitorrdgs.UiX.Component.UIXMaskedTextBox();
            this.grbMesas = new System.Windows.Forms.GroupBox();
            this.btnMesaVer = new vitorrdgs.UiX.Component.UIXButton();
            this.btnMesaAdd = new vitorrdgs.UiX.Component.UIXButton();
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new vitorrdgs.UiX.Component.UIXButton();
            this.btnConfirmar = new vitorrdgs.UiX.Component.UIXButton();
            this.txtInformacoes = new vitorrdgs.UiX.Component.UIXTextBox();
            this.pnlMenu.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.grbReserva.SuspendLayout();
            this.grbMesas.SuspendLayout();
            this.grbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnExcluir);
            this.pnlMenu.Controls.Add(this.btnAtendimento);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Location = new System.Drawing.Point(0, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 400);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Description = "EXCLUIR";
            this.btnExcluir.HoverColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Image = global::BurgerShack.Desktop.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.ImageLocation = null;
            this.btnExcluir.Location = new System.Drawing.Point(5, 205);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 90);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtendimento
            // 
            this.btnAtendimento.Description = "ATENDIMENTO";
            this.btnAtendimento.HoverColor = System.Drawing.Color.Transparent;
            this.btnAtendimento.Image = global::BurgerShack.Desktop.Properties.Resources.atendimento;
            this.btnAtendimento.ImageLocation = null;
            this.btnAtendimento.Location = new System.Drawing.Point(5, 105);
            this.btnAtendimento.Name = "btnAtendimento";
            this.btnAtendimento.Size = new System.Drawing.Size(90, 90);
            this.btnAtendimento.TabIndex = 7;
            this.btnAtendimento.Text = "ATENDIMENTO";
            this.btnAtendimento.UseVisualStyleBackColor = true;
            this.btnAtendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Description = "CANCELAR";
            this.btnVoltar.HoverColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::BurgerShack.Desktop.Properties.Resources.voltar;
            this.btnVoltar.ImageLocation = null;
            this.btnVoltar.Location = new System.Drawing.Point(5, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 90);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "CANCELAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Description = "SALVAR";
            this.btnAlterar.HoverColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Image = global::BurgerShack.Desktop.Properties.Resources.salvar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.ImageLocation = null;
            this.btnAlterar.Location = new System.Drawing.Point(5, 305);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 90);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "SALVAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.lblCliente);
            this.grbCliente.Controls.Add(this.btnCliEncontrar);
            this.grbCliente.Controls.Add(this.mtbCliCPF);
            this.grbCliente.Location = new System.Drawing.Point(105, 55);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(340, 100);
            this.grbCliente.TabIndex = 6;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "CLIENTE";
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(5, 45);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(245, 50);
            this.lblCliente.TabIndex = 8;
            // 
            // btnCliEncontrar
            // 
            this.btnCliEncontrar.Description = "ENCONTRAR";
            this.btnCliEncontrar.HoverColor = System.Drawing.Color.Transparent;
            this.btnCliEncontrar.Image = global::BurgerShack.Desktop.Properties.Resources.cliente;
            this.btnCliEncontrar.ImageLocation = null;
            this.btnCliEncontrar.Location = new System.Drawing.Point(255, 15);
            this.btnCliEncontrar.Name = "btnCliEncontrar";
            this.btnCliEncontrar.Size = new System.Drawing.Size(80, 80);
            this.btnCliEncontrar.TabIndex = 7;
            this.btnCliEncontrar.Text = "ENCONTRAR";
            this.btnCliEncontrar.UseVisualStyleBackColor = true;
            this.btnCliEncontrar.Click += new System.EventHandler(this.btnCliEncontrar_Click);
            // 
            // mtbCliCPF
            // 
            this.mtbCliCPF.AcceptButton = this.btnCliEncontrar;
            this.mtbCliCPF.AccessibleName = "CPF";
            this.mtbCliCPF.Campo = "CPF";
            this.mtbCliCPF.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbCliCPF.Location = new System.Drawing.Point(5, 20);
            this.mtbCliCPF.Mask = "";
            this.mtbCliCPF.MaxLength = 32767;
            this.mtbCliCPF.Name = "mtbCliCPF";
            this.mtbCliCPF.Size = new System.Drawing.Size(245, 21);
            this.mtbCliCPF.TabIndex = 0;
            this.mtbCliCPF.ValidatingType = null;
            // 
            // grbReserva
            // 
            this.grbReserva.Controls.Add(this.txtInformacoes);
            this.grbReserva.Controls.Add(this.mtbHora);
            this.grbReserva.Controls.Add(this.txtPessoas);
            this.grbReserva.Controls.Add(this.mtbData);
            this.grbReserva.Location = new System.Drawing.Point(105, 155);
            this.grbReserva.Name = "grbReserva";
            this.grbReserva.Size = new System.Drawing.Size(340, 140);
            this.grbReserva.TabIndex = 9;
            this.grbReserva.TabStop = false;
            this.grbReserva.Text = "RESERVA";
            // 
            // mtbHora
            // 
            this.mtbHora.AcceptButton = null;
            this.mtbHora.AccessibleName = "Hora";
            this.mtbHora.Campo = "Hora";
            this.mtbHora.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbHora.Location = new System.Drawing.Point(127, 20);
            this.mtbHora.Mask = "";
            this.mtbHora.MaxLength = 32767;
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(97, 21);
            this.mtbHora.TabIndex = 9;
            this.mtbHora.ValidatingType = null;
            // 
            // txtPessoas
            // 
            this.txtPessoas.AcceptButton = null;
            this.txtPessoas.AccessibleName = "Pessoas";
            this.txtPessoas.Campo = "Pessoas";
            this.txtPessoas.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtPessoas.Location = new System.Drawing.Point(230, 20);
            this.txtPessoas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPessoas.MaxLength = 32767;
            this.txtPessoas.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.INT;
            this.txtPessoas.Multiline = false;
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPessoas.Size = new System.Drawing.Size(104, 21);
            this.txtPessoas.TabIndex = 10;
            // 
            // mtbData
            // 
            this.mtbData.AcceptButton = null;
            this.mtbData.AccessibleName = "Dia";
            this.mtbData.Campo = "Dia";
            this.mtbData.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.mtbData.Location = new System.Drawing.Point(5, 20);
            this.mtbData.Mask = "";
            this.mtbData.MaxLength = 32767;
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(116, 21);
            this.mtbData.TabIndex = 8;
            this.mtbData.ValidatingType = null;
            this.mtbData.TextChange += new System.EventHandler(this.mtbData_TextChange);
            // 
            // grbMesas
            // 
            this.grbMesas.Controls.Add(this.btnMesaVer);
            this.grbMesas.Controls.Add(this.btnMesaAdd);
            this.grbMesas.Location = new System.Drawing.Point(105, 300);
            this.grbMesas.Name = "grbMesas";
            this.grbMesas.Size = new System.Drawing.Size(165, 90);
            this.grbMesas.TabIndex = 12;
            this.grbMesas.TabStop = false;
            this.grbMesas.Text = "MESAS";
            // 
            // btnMesaVer
            // 
            this.btnMesaVer.Description = "VISUALIZAR";
            this.btnMesaVer.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesaVer.Image = global::BurgerShack.Desktop.Properties.Resources.lista;
            this.btnMesaVer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesaVer.ImageLocation = null;
            this.btnMesaVer.Location = new System.Drawing.Point(85, 15);
            this.btnMesaVer.Name = "btnMesaVer";
            this.btnMesaVer.Size = new System.Drawing.Size(70, 70);
            this.btnMesaVer.TabIndex = 11;
            this.btnMesaVer.Text = "VISUALIZAR";
            this.btnMesaVer.UseVisualStyleBackColor = true;
            this.btnMesaVer.Click += new System.EventHandler(this.btnMesaVer_Click);
            // 
            // btnMesaAdd
            // 
            this.btnMesaAdd.Description = "ADICIONAR";
            this.btnMesaAdd.HoverColor = System.Drawing.Color.Transparent;
            this.btnMesaAdd.Image = global::BurgerShack.Desktop.Properties.Resources.adicionar;
            this.btnMesaAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesaAdd.ImageLocation = null;
            this.btnMesaAdd.Location = new System.Drawing.Point(10, 15);
            this.btnMesaAdd.Name = "btnMesaAdd";
            this.btnMesaAdd.Size = new System.Drawing.Size(70, 70);
            this.btnMesaAdd.TabIndex = 10;
            this.btnMesaAdd.Text = "ADICIONAR";
            this.btnMesaAdd.UseVisualStyleBackColor = true;
            this.btnMesaAdd.Click += new System.EventHandler(this.btnMesaAdd_Click);
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.reserva;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(450, 50);
            this.hdrUIX.TabIndex = 0;
            this.hdrUIX.Title = "Reserva";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.btnCancelar);
            this.grbSituacao.Controls.Add(this.btnConfirmar);
            this.grbSituacao.Location = new System.Drawing.Point(280, 300);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Size = new System.Drawing.Size(165, 90);
            this.grbSituacao.TabIndex = 13;
            this.grbSituacao.TabStop = false;
            this.grbSituacao.Text = "SITUAÇÃO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Description = "CANCELAR";
            this.btnCancelar.HoverColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = global::BurgerShack.Desktop.Properties.Resources.excluir;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageLocation = null;
            this.btnCancelar.Location = new System.Drawing.Point(85, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 70);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Description = "CONFIRMAR";
            this.btnConfirmar.HoverColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Image = global::BurgerShack.Desktop.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.ImageLocation = null;
            this.btnConfirmar.Location = new System.Drawing.Point(10, 15);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(70, 70);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.AcceptButton = null;
            this.txtInformacoes.Campo = "Informações";
            this.txtInformacoes.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.UP;
            this.txtInformacoes.Location = new System.Drawing.Point(5, 50);
            this.txtInformacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInformacoes.MaxLength = 32767;
            this.txtInformacoes.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtInformacoes.Multiline = true;
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInformacoes.Size = new System.Drawing.Size(330, 80);
            this.txtInformacoes.TabIndex = 11;
            // 
            // frmReserva
            // 
            this.AcceptButton = this.btnAlterar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.grbSituacao);
            this.Controls.Add(this.grbMesas);
            this.Controls.Add(this.grbReserva);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.hdrUIX);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.pnlMenu.ResumeLayout(false);
            this.grbCliente.ResumeLayout(false);
            this.grbReserva.ResumeLayout(false);
            this.grbMesas.ResumeLayout(false);
            this.grbSituacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private vitorrdgs.UiX.Component.UIXButton btnAlterar;
        private vitorrdgs.UiX.Component.UIXButton btnVoltar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.GroupBox grbCliente;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbCliCPF;
        private vitorrdgs.UiX.Component.UIXButton btnCliEncontrar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox grbReserva;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbData;
        private vitorrdgs.UiX.Component.UIXMaskedTextBox mtbHora;
        private vitorrdgs.UiX.Component.UIXTextBox txtPessoas;
        private vitorrdgs.UiX.Component.UIXButton btnMesaAdd;
        private vitorrdgs.UiX.Component.UIXButton btnMesaVer;
        private System.Windows.Forms.GroupBox grbMesas;
        private vitorrdgs.UiX.Component.UIXButton btnAtendimento;
        private System.Windows.Forms.GroupBox grbSituacao;
        private vitorrdgs.UiX.Component.UIXButton btnCancelar;
        private vitorrdgs.UiX.Component.UIXButton btnConfirmar;
        private vitorrdgs.UiX.Component.UIXButton btnExcluir;
        private vitorrdgs.UiX.Component.UIXTextBox txtInformacoes;
    }
}