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

        public new event EventHandler Click;

        private Color _hoverColor;
        private Color _backColor;

        public btnUIX()
        {
            InitializeComponent();

            HoverColor = Color.Transparent;
        }

        public Color HoverColor { get => _hoverColor; set => _hoverColor = value; }

        public new Color BackColor
        {
            get => base.BackColor;
            set
            {
                pic.BackColor = value;
                lbl.BackColor = value;
                pnl.BackColor = value;
                base.BackColor = value;
            }
        }

        public new Font Font
        {
            get => lbl.Font;
            set
            {
                lbl.Font = value;
                update();
            }
        }

        public String Description
        {
            get => lbl.Text;
            set
            {
                lbl.Text = value;
                base.Text = value;
                update();
            }
        }

        public new Image Image { get => pic.Image; set => pic.Image = value; }

        public String ImageLocation { get => pic.ImageLocation; set => pic.ImageLocation = value; }

        public new Size Size
        {
            get => base.Size;
            set
            {
                base.Size = value;

                update();
            }
        }

        private void update()
        {
            int MARGIN = 3;

            pnl.Size = new Size(Size.Width - (MARGIN * 2), Size.Height - (MARGIN * 2));
            pnl.Location = new Point(MARGIN, MARGIN);

            lbl.AutoSize = true;
            lbl.Location = new Point(0, pnl.Height - lbl.Height);
            int height = lbl.Height;
            lbl.AutoSize = false;
            lbl.Size = new Size(pnl.Width, height);

            int picSize = pnl.Height - lbl.Height;
            pic.Size = new Size(picSize, picSize);
            pic.Location = new Point((pnl.Height / 2) - (pic.Height / 2), 0);
        }

        private void onMouseEnter(object sender, EventArgs e)
        {
            _backColor = BackColor;
            BackColor = HoverColor;
        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            BackColor = _backColor;
        }

        private void onClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (Click != null)
            {
                Click(sender, e);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnUIX_BackColorChanged(object sender, EventArgs e)
        {
            BackColor = BackColor;
        }

        private void pic_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            update();
        }
    }
}
