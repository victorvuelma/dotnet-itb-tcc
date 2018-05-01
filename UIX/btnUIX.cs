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
            base.Size = new Size(80, 80);

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

        public new Font Font
        {
            get => base.Font;
            set
            {
                pic.Font = value;
                lbl.Font = value;
                base.Font = value;
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

        public new Size Size
        {
            get => base.Size;
            set
            {
                Size oldSize = base.Size;

                int heightDiff = value.Height - oldSize.Height;
                int widthDiff = value.Width - oldSize.Width;

                pic.Size = new Size(pic.Size.Width + widthDiff, pic.Size.Height + heightDiff);

                lbl.Size = new Size(value.Width, lbl.Size.Height);
                int lblY = value.Height - lbl.Height;
                lbl.Location = new Point( lbl.Location.X, lblY);

                base.Size = value;
            }
        }

        public Color HoverColor { get => _hoverColor; set => _hoverColor = value; }

        private void btnUIX_MouseEnter(object sender, EventArgs e)
        {
            _backColor = BackColor;
            BackColor = HoverColor;
            Size = Size;
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

        private void btnUIX_BackColorChanged(object sender, EventArgs e)
        {
            BackColor = BackColor;
        }
    }
}
