using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIX
{
    public partial class btnUIX : Button
    {

        private Color _hoverColor;
        private Color _backColor;

        public btnUIX()
        {
            InitializeComponent();

            HoverColor = Color.Transparent;
        }

        public new Color BackColor
        {
            get => base.BackColor;
            set
            {
                pic.BackColor = value;
                lbl.BackColor = value;
                base.BackColor = value;
            }
        }

        public String Description
        {
            get => lbl.Text;
            set => lbl.Text = value;
        }

        public new Image Image
        {
            get => pic.Image;
            set => pic.Image = value;
        }

        public Color HoverColor { get => _hoverColor; set => _hoverColor = value; }

        private void btnUIX_MouseEnter(object sender, EventArgs e)
        {
            _backColor = BackColor;
            BackColor = HoverColor;
        }

        private void btnUIX_MouseLeave(object sender, EventArgs e)
        {
            BackColor = _backColor;
        }

        private void pic_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
