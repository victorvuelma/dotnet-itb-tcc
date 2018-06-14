﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmUtilNumBoard : Form
    {

        private TextBoxBase _input;
        private String _num;

        public String Numero { get => _num; set => _num = value; }
        public TextBoxBase Input { get => _input; set => _input = value; }

        public frmUtilNumBoard()
        {
            InitializeComponent();
        }

        private void focar()
        {
            mtbNum.Focus();
        }

        private void adicionar(char numero)
        {
            definir(Numero + numero);

            focar();
        }

        private void definir(string num)
        {
            mtbNum.Text = num;
            if (Input != null)
            {
                Input.Text = num;
            }
            Numero = clnUtil.retirarFormatacao(mtbNum.Text);
        }

        private void atualizarInput()
        {
            definir(Input.Text);

            if(Input is MaskedTextBox mtb)
            {
                mtbNum.Mask = mtb.Mask;
            } else
            {
                mtbNum.Mask = "";
            }
        }

        private void fechar()
        {
            Hide();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            adicionar('0');
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            adicionar('1');
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            adicionar('2');
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            adicionar('3');
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            adicionar('4');
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            adicionar('5');
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            adicionar('6');
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            adicionar('7');
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            adicionar('8');
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            adicionar('9');
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!Numero.Contains(','))
            {
                adicionar(',');
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            if (Numero.Length > 1)
            {
                definir(Numero.Substring(0, Numero.Length - 1));
            }
            else
            {
                definir("");
            }

            focar();
        }

        private void frmUtilNumBoard_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            UIX.uixMaskedTextBox.mtbApply(mtbNum, App.AppVisualStyle.FormColor);
            clnUtil.atualizarTabIndex(Controls);
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void frmUtilNumBoard_Leave(object sender, EventArgs e)
        {
            fechar();
        }

        private void frmUtilNumBoard_Deactivate(object sender, EventArgs e)
        {
            fechar();
        }

        private void mtbNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                fechar();
            }
        }

        private void mtbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtbNum_TextChanged(object sender, EventArgs e)
        {
            definir(mtbNum.Text);
        }

        public enum NumBoardMode
        {
            INT,
            DOUBLE
        }

        private void frmUtilNumBoard_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                atualizarInput();
        }
    }
}
