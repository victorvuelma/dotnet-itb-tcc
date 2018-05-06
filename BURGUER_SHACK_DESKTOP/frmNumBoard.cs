using System;
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
    public partial class frmNumBoard : Form
    {

        private TextBoxBase _base;

        public String NumeroPadrao { get => lblNum.Text.Replace(',', '.'); set => lblNum.Text = value.Replace('.', ','); }
        public TextBoxBase Input { get => _base; set => _base = value; }

        public frmNumBoard()
        {
            InitializeComponent();
        }

        private void adicionar(char numero)
        {
            atualizar(lblNum.Text + numero);
        }

        private void atualizar(string text)
        {
            NumeroPadrao = text;
            if (Input != null)
            {
                Input.Text = NumeroPadrao;
            }
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
            if (!lblNum.Text.Contains(','))
            {
                adicionar(',');
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length > 1)
            {
                atualizar(lblNum.Text.Substring(0, lblNum.Text.Length - 1));
            }
            else
            {
                atualizar("");
            }
        }

        private void frmNumKey_Load(object sender, EventArgs e)
        {
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            lblNum.Text = lblNum.Text.Replace('.', ',');
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        public enum NumBoardMode
        {
            INT,
            DOUBLE
        }


    }
}
