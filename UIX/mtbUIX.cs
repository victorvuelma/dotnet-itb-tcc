using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace UIX
{
    public partial class mtbUIX : UserControl
    {
        public mtbUIX()
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
                box.Location = new Point(x, box.Location.Y);
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

        public override String Text { get => box.Text; set => box.Text = value; }

        public new Size Size
        {
            get => base.Size;
            set
            {
                Size current = base.Size;
                box.Size = new Size(value.Width - lbl.Size.Width , box.Size.Height);
                base.Size = value;
            }
        }

        [Editor("System.Windows.Forms.Design.MaskPropertyEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public String Mask { get => box.Mask; set => box.Mask = value; }

        public Type ValidatingType { get => box.ValidatingType; set => box.ValidatingType = value; }

        public int MaxLength { get => box.MaxLength; set => box.MaxLength = value; }

        private void mtbUIX_Load(object sender, EventArgs e)
        {
            Campo = Campo;
        }
    }
}
