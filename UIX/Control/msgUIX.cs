using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIX
{
    public partial class msgUIX : Form
    {

        private int _result = -1;

        public int Result { get => _result; set => _result = value; }

        public msgUIX()
        {
            InitializeComponent();
        }

        public static msgUIX messageBox(String title, String message, Image img, uixTemplate template)
        {
            msgUIX msg = new msgUIX();

            msg.hdrUIX.Title = title;
            msg.Text = title;
            msg.Icon = template.Icon;

            msg.txt.Text = message;

            msg.hdrUIX.Image = img;
            msg.pic.Image = img;

            template.frmApply(msg, msg.hdrUIX);
            UIX.uixTextBox.txtApply(msg.txt, template.Style.FormColor);

            return msg;
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            Result = 0;

            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Result = 1;

            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Result = 2;

            Close();
        }

        private void msgUIX_Load(object sender, EventArgs e)
        {

        }
    }
}
