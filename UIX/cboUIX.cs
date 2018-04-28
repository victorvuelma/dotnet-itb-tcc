using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;
using System.Drawing.Design;

namespace UIX
{
    public partial class cboUIX : UserControl
    {
        public cboUIX()
        {
            InitializeComponent();
        }

        public String Campo
        {
            get => lbl.Text;
            set
            {
                lbl.Text = value;
                int x = lbl.Size.Width - 5;
                cbo.Location = new Point(x, cbo.Location.Y);
            }
        }

        public override String Text { get => cbo.Text; set => cbo.Text = value; }

        public new Size Size
        {
            get => base.Size;
            set
            {
                Size current = base.Size;
                cbo.Size = new Size(value.Width - lbl.Size.Width, cbo.Size.Height);
                base.Size = value;
            }
        }

        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public ObjectCollection Items { get => cbo.Items; }

        public bool FormattingEnabled { get => cbo.FormattingEnabled; set => cbo.FormattingEnabled = value; }

    }
}
