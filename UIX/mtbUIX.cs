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
                update();
            }
        }

        public new Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                update();
            }
        }

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
            lbl.AutoSize = true;
            mtb.Size = new Size(Size.Width - lbl.Size.Width, mtb.Size.Height);
            mtb.Location = new Point(lbl.Location.X + lbl.Size.Width, mtb.Location.Y);
        }

        [Editor("System.Windows.Forms.Design.MaskPropertyEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public String Mask { get => mtb.Mask; set => mtb.Mask = value; }

        public Type ValidatingType { get => mtb.ValidatingType; set => mtb.ValidatingType = value; }

        public int MaxLength { get => mtb.MaxLength; set => mtb.MaxLength = value; }

        public new bool Enabled { get => mtb.Enabled; set => mtb.Enabled = value; }

        public override String Text { get => mtb.Text; set => mtb.Text = value; }

        private void mtbUIX_Load(object sender, EventArgs e)
        {
            Campo = Campo;
        }

        private void mtb_Click(object sender, EventArgs e)
        {
            mtb.SelectionStart = 0;
        }
    }
}
