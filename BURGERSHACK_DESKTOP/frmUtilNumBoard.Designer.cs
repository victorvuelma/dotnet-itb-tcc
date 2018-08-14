namespace BurgerShack.Desktop
{
    partial class frmUtilNumBoard
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
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.grbBotoes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbNum = new System.Windows.Forms.MaskedTextBox();
            this.grbBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrUIX
            // 
            this.hdrUIX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hdrUIX.ButtonCloseEnabled = true;
            this.hdrUIX.ButtonMinEnabled = false;
            this.hdrUIX.Image = global::BurgerShack.Desktop.Properties.Resources.calculadora;
            this.hdrUIX.Location = new System.Drawing.Point(0, 0);
            this.hdrUIX.Name = "hdrUIX";
            this.hdrUIX.Size = new System.Drawing.Size(220, 50);
            this.hdrUIX.TabIndex = 31;
            this.hdrUIX.Title = "Teclado Numérico";
            this.hdrUIX.Close += new System.EventHandler(this.hdrUIX_Close);
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.Location = new System.Drawing.Point(140, 70);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(65, 35);
            this.btnCorrigir.TabIndex = 28;
            this.btnCorrigir.Text = "←";
            this.btnCorrigir.UseVisualStyleBackColor = true;
            this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(5, 70);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 35);
            this.btnConfirmar.TabIndex = 24;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(135, 210);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(60, 60);
            this.btnPoint.TabIndex = 23;
            this.btnPoint.Text = ",";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(5, 210);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(126, 60);
            this.btnNum0.TabIndex = 22;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(135, 145);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(60, 60);
            this.btnNum3.TabIndex = 21;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(70, 145);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(60, 60);
            this.btnNum2.TabIndex = 20;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(70, 15);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(60, 60);
            this.btnNum8.TabIndex = 14;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(5, 145);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(60, 60);
            this.btnNum1.TabIndex = 19;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(135, 80);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(60, 60);
            this.btnNum6.TabIndex = 18;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(70, 80);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(60, 60);
            this.btnNum5.TabIndex = 17;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(5, 80);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(60, 60);
            this.btnNum4.TabIndex = 16;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(135, 15);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(60, 60);
            this.btnNum9.TabIndex = 15;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(5, 15);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(60, 60);
            this.btnNum7.TabIndex = 0;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // grbBotoes
            // 
            this.grbBotoes.Controls.Add(this.btnPoint);
            this.grbBotoes.Controls.Add(this.btnNum0);
            this.grbBotoes.Controls.Add(this.btnNum3);
            this.grbBotoes.Controls.Add(this.btnNum2);
            this.grbBotoes.Controls.Add(this.btnNum1);
            this.grbBotoes.Controls.Add(this.btnNum6);
            this.grbBotoes.Controls.Add(this.btnNum5);
            this.grbBotoes.Controls.Add(this.btnNum4);
            this.grbBotoes.Controls.Add(this.btnNum9);
            this.grbBotoes.Controls.Add(this.btnNum7);
            this.grbBotoes.Controls.Add(this.btnNum8);
            this.grbBotoes.Location = new System.Drawing.Point(5, 110);
            this.grbBotoes.Name = "grbBotoes";
            this.grbBotoes.Size = new System.Drawing.Size(200, 275);
            this.grbBotoes.TabIndex = 27;
            this.grbBotoes.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbNum);
            this.groupBox1.Controls.Add(this.grbBotoes);
            this.groupBox1.Controls.Add(this.btnCorrigir);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Location = new System.Drawing.Point(5, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 390);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // mtbNum
            // 
            this.mtbNum.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNum.Location = new System.Drawing.Point(5, 20);
            this.mtbNum.Name = "mtbNum";
            this.mtbNum.Size = new System.Drawing.Size(200, 37);
            this.mtbNum.TabIndex = 29;
            this.mtbNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbNum.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbNum.TextChanged += new System.EventHandler(this.mtbNum_TextChanged);
            this.mtbNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbNum_KeyDown);
            this.mtbNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbNum_KeyPress);
            this.mtbNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbNum_KeyUp);
            // 
            // frmUtilNumBoard
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 450);
            this.Controls.Add(this.hdrUIX);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUtilNumBoard";
            this.Text = "Teclado Numérico";
            this.Deactivate += new System.EventHandler(this.frmUtilNumBoard_Deactivate);
            this.Load += new System.EventHandler(this.frmUtilNumBoard_Load);
            this.grbBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private vitorrdgs.UiX.Component.UIXHeader hdrUIX;
        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.GroupBox grbBotoes;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnPoint;
        public System.Windows.Forms.MaskedTextBox mtbNum;
    }
}