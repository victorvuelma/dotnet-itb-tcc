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
    public partial class txtUIX : UserControl
    {

        private uixAllowedChars _allowedChars = uixAllowedChars.ALL;
        private char[] allowedChars = new char[] { };

        public txtUIX()
        {
            InitializeComponent();
        }

        public String Campo
        {
            get => AccessibleName;
            set
            {
                AccessibleName = value;
                lbl.Text = value + ":";
                int x = lbl.Size.Width - 5;
                txt.Location = new Point(x, txt.Location.Y);
            }
        }

        public new Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                Campo = Campo;
            }
        }

        public override String Text { get => txt.Text; set => txt.Text = value; }

        public new Size Size
        {
            get => base.Size;
            set
            {
                Size current = base.Size;
                txt.Size = new Size(value.Width - lbl.Size.Width, txt.Size.Height);
                base.Size = value;
            }
        }

        public int MaxLength { get => txt.MaxLength; set => txt.MaxLength = value; }

        public uixAllowedChars AllowedChars
        {
            get => _allowedChars; set
            {
                allowedChars = uixUtil.getChars(value);
                _allowedChars = value;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(allowedChars.Count() >= 1)
            {
                if (!char.IsControl(e.KeyChar) && !allowedChars.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }   
            }
        }

        public static int confirmar = 0;

        public static void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmar = 1;
            }
        }

        private void txtUIX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmar = 1;
            }
        }
    }
}
