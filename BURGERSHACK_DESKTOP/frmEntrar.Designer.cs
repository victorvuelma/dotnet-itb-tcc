﻿namespace BurgerShack.Desktop
{
    partial class frmEntrar
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
            this.picVer = new System.Windows.Forms.PictureBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.hdrUIX = new vitorrdgs.UiX.Component.UIXHeader();
            this.txtSenha = new vitorrdgs.UiX.Component.UIXTextBox();
            this.txtUsuario = new vitorrdgs.UiX.Component.UIXTextBox();
            this.btnEntrar = new vitorrdgs.UiX.Component.UIXButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picVer
            // 
            this.picVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVer.Image = global::BurgerShack.Desktop.Properties.Resources.eye;
            this.picVer.Location = new System.Drawing.Point(275, 210);
            this.picVer.Name = "picVer";
            this.picVer.Size = new System.Drawing.Size(20, 20);
            this.picVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVer.TabIndex = 12;
            this.picVer.TabStop = false;
            this.picVer.MouseEnter += new System.EventHandler(this.picVer_MouseEnter);
            this.picVer.MouseLeave += new System.EventHandler(this.picVer_MouseLeave);
            // 
            // lblProgram
            // 
            this.lblProgram.Location = new System.Drawing.Point(0, 260);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(400, 25);
            this.lblProgram.TabIndex = 14;
            this.lblProgram.Text = "BurgerShack - Copyright 2018";
            this.lblProgram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.usuarios;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(500, 50);
            this.hdrUIX.TabIndex = 11;
            this.hdrUIX.Title = "Acesso ao Sistema";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // txtSenha
            // 
            this.txtSenha.AcceptButton = null;
            this.txtSenha.AccessibleName = "Senha";
            this.txtSenha.Campo = "Senha";
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtSenha.Location = new System.Drawing.Point(15, 210);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.Size = new System.Drawing.Size(255, 30);
            this.txtSenha.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptButton = null;
            this.txtUsuario.AccessibleName = "Usuário";
            this.txtUsuario.Campo = "Usuário";
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.LabelPosition = vitorrdgs.UiX.Property.uixEnum.uixLabelPosition.SIDE;
            this.txtUsuario.Location = new System.Drawing.Point(15, 180);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Mode = vitorrdgs.UiX.Property.uixEnum.uixTextBoxMode.ALL;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.Size = new System.Drawing.Size(280, 30);
            this.txtUsuario.TabIndex = 7;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Description = "ACESSAR";
            this.btnEntrar.HoverColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Image = global::BurgerShack.Desktop.Properties.Resources.acesso;
            this.btnEntrar.ImageLocation = null;
            this.btnEntrar.Location = new System.Drawing.Point(305, 170);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(80, 80);
            this.btnEntrar.TabIndex = 15;
            this.btnEntrar.Text = "btnvitorrdgs.UiX1";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BurgerShack.Desktop.Properties.Resources.logo_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(15, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmEntrar
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.picVer);
            this.Controls.Add(this.hdrUIX);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEntrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ao Sistema";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private vitorrdgs.UiX.Component.UIXTextBox txtUsuario;
        private vitorrdgs.UiX.Component.UIXTextBox txtSenha;
        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.PictureBox picVer;
        private System.Windows.Forms.Label lblProgram;
        private vitorrdgs.UiX.Component.UIXButton btnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

