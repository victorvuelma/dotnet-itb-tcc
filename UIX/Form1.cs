using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            UIX.UIXTemplate _frmTemplate = new UIX.UIXTemplate(UIX.UIXStyle.BLUE);

            _frmTemplate.frmApply(this, label1, lblTitle, picLogo, btnClose, btnMin);
            _frmTemplate.ctrApply(new Control[] { btnLogin, lblLogin, lblSenha, txtLogin, txtSenha, grbLogin });

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }
    }
}
