﻿using System;
using System.Linq;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop.Numboard
{
    public partial class FormNumboard : Form
    {

        public enum NumBoardMode
        {
            INT,
            DOUBLE,
            MONEY
        }

        private NumBoardMode _mode;

        private TextBoxBase _input;
        private String _num;

        public String Numero { get => _num; set => _num = value; }
        public TextBoxBase Input
        {
            get => _input;
            set
            {
                _input = value;
                atualizarInput();
            }
        }
        public NumBoardMode Mode { get => _mode; set => _mode = value; }

        public FormNumboard()
        {
            InitializeComponent();
        }

        private void adicionar(char conteudo)
        {
            definir(clnUtil.obterConteudo(mtbNum) + conteudo);

            mtbNum.Focus();
        }

        private void definir(string num)
        {
            mtbNum.Text = num;
            if (Input != null)
            {
                Input.Text = num;
            }
            Numero = mtbNum.Text;
        }

        private void atualizarInput()
        {
            if (Input != null && Input is MaskedTextBox mtb)
            {
                mtbNum.Mask = mtb.Mask;
            }
            else
            {
                mtbNum.Mask = "";
            }

            definir(Input.Text);
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
            if (clnUtil.obterConteudo(mtbNum).Length > 1)
            {
                definir(clnUtil.obterConteudo(mtbNum).Substring(0, clnUtil.obterConteudo(mtbNum).Length - 1));
            }
            else
            {
                definir("");
            }

            mtbNum.Focus();
        }

        private void frmUtilNumBoard_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixMaskedTextBox.mtbApply(mtbNum, AppDesktop.VisualStyle.ContentColor);
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
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (!btnPoint.Visible || e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        public new void Show()
        {
            if (Mode == FormNumboard.NumBoardMode.INT)
            {
                btnPoint.Hide();
            }
            else
            {
                btnPoint.Show();
            }

            base.Show();

            mtbNum.Mask = "";
            mtbNum.Text = "";
            Focus();
            mtbNum.Focus();

            atualizarInput();

            if(mtbNum.Mask == "")
            {
                mtbNum.SelectionStart = mtbNum.Text.Length;
            }
        }

        private void mtbNum_KeyUp(object sender, KeyEventArgs e)
        {
            definir(mtbNum.Text);
        }

        private void mtbNum_TextChanged(object sender, EventArgs e)
        {
            if (mtbNum.Text.Length > Input.MaxLength)
            {
                mtbNum.Text = mtbNum.Text.Substring(0, Input.MaxLength);
            }
            if (Mode == NumBoardMode.MONEY)
            {
                UtilFormValor.defineForMoney(mtbNum);
            }
        }
    }
}
