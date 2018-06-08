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
            get => cbo.AccessibleName;
            set
            {
                cbo.AccessibleName = value;
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
            cbo.Location = new Point(lbl.Location.X + lbl.Size.Width, cbo.Location.Y);
            cbo.Size = new Size(Size.Width - cbo.Location.X, cbo.Size.Height);
        }

        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public ObjectCollection Items => cbo.Items;

        public bool FormattingEnabled { get => cbo.FormattingEnabled; set => cbo.FormattingEnabled = value; }

        public new bool Enabled { get => cbo.Enabled; set => cbo.Enabled = value; }

        public override String Text { get => cbo.Text; set => cbo.Text = value; }

        private void cboUIX_Load(object sender, EventArgs e)
        {
            update();
        }
    }
}
