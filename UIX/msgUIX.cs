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

        public int resultado = -1;

        public msgUIX()
        {
            InitializeComponent();
        }

        public static msgUIX messageBox(String titulo, String mensagem, Image image, uixTemplate template)
        {
            msgUIX msg = new msgUIX();

            msg.hdrUIX.Text = titulo;
            msg.Text = titulo;

            msg.lbl.Text = mensagem;

            msg.hdrUIX.Image = image;

            msg.pic.Image = image;

            template.frmApply(msg, msg.hdrUIX);

            return msg;
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            resultado = 0;

            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            resultado = 1;

            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            resultado = 2;

            Close();
        }
    }
}
