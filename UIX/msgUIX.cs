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

            msg.uctUIX.UIXTitle = titulo;
            msg.Text = titulo;

            msg.lbl.Text = mensagem;

            msg.uctUIX.UIXImage = image;

            msg.pic.Image = image;

            template.frmApply(msg, msg.uctUIX);

            return msg;
        }

        private void uctUIX_Close(object sender, EventArgs e)
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
