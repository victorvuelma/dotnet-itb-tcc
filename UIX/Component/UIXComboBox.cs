using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using vitorrdgs.UiX.Property;

namespace vitorrdgs.UiX.Component
{
    public partial class UIXComboBox : UserControl
    {

        private bool _loaded = false;

        private IButtonControl _acceptButton;
        private uixEnum.uixLabelPosition _labelPosition = uixEnum.uixLabelPosition.SIDE;

        public UIXComboBox()
        {
            InitializeComponent();
        }

        //---- PROPRIEDADES UIX
        public IButtonControl AcceptButton { get => _acceptButton; set => _acceptButton = value; }

        public new bool Enabled { get => cbo.Enabled; set => cbo.Enabled = value; }

        public uixEnum.uixLabelPosition LabelPosition
        {
            get => _labelPosition;
            set
            {
                _labelPosition = value;
                update();
            }
        }

        public void add(int id, object obj)
        {
            cbo.Items.Add(new UIXComboBoxItem
            {
                Id = id,
                Name = obj.ToString()
            });
        }

        public void add(object obj)
        {
            add(cbo.Items.Count, obj);
        }

        public void addRange(object[] objects)
        {
            foreach (object obj in objects)
            {
                add(obj);
            }
        }

        public void clear()
        {
            cbo.Items.Clear();
        }

        public bool contains(string nome)
        {
            foreach (UIXComboBoxItem item in Items)
            {
                if (item.Name.Equals(nome))
                {
                    return true;
                }
            }
            return false;
        }

        public List<UIXComboBoxItem> Items
        {
            get
            {
                List<UIXComboBoxItem> items = new List<UIXComboBoxItem>();
                foreach (object obj in cbo.Items)
                {
                    if (obj is UIXComboBoxItem item)
                        items.Add(item);
                }
                return items;
            }
        }

        public UIXComboBoxItem SelectedItem
        {
            get => (UIXComboBoxItem)cbo.SelectedItem;
            set
            {
                cbo.SelectedItem = value;
                updateLabel();
            }
        }
        //---- PROPRIEDADES UIX

        public bool FormattingEnabled { get => cbo.FormattingEnabled; set => cbo.FormattingEnabled = value; }

        public override String Text { get => cbo.Text; set => cbo.Text = value; }

        public String Campo
        {
            get => cbo.AccessibleName;
            set
            {
                cbo.AccessibleName = value;
                updateLabel();
                update();
            }
        }

        public new String Name
        {
            get => base.Name;
            set
            {
                base.Name = value;
                cbo.Name = value;
            }
        }

        private void updateLabel()
        {
            lbl.Text = Campo + ":";
            if (!cbo.Enabled)
            {
                switch (LabelPosition)
                {
                    case uixEnum.uixLabelPosition.SIDE:
                        lbl.Text += " " + cbo.Text;
                        break;
                    case uixEnum.uixLabelPosition.UP:
                        lbl.Text += "\n" + cbo.Text;
                        break;
                }
            }
        }

        private void update()
        {
            if (_loaded)
            {
                lbl.AutoSize = true;
                switch (LabelPosition)
                {
                    case uixEnum.uixLabelPosition.SIDE:
                        lbl.MaximumSize = new Size(0, 0);
                        cbo.Location = new Point(lbl.Location.X + lbl.Size.Width, cbo.Location.Y);
                        cbo.Size = new Size(Size.Width - cbo.Location.X, Size.Height);
                        break;
                    case uixEnum.uixLabelPosition.UP:
                        lbl.MaximumSize = new Size(Width, 1000);
                        cbo.Location = new Point(0, lbl.Location.Y + lbl.Size.Height);
                        cbo.Size = new Size(Size.Width, Size.Height - cbo.Location.Y);
                        break;
                }
            }
        }

        private void cboUIX_Load(object sender, EventArgs e)
        {
            _loaded = true;

            update();
        }

        private void cbo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (AcceptButton != null)
                {
                    AcceptButton.PerformClick();
                }
            }
        }

        public class UIXComboBoxItem
        {

            private string _name;
            private int _id;

            public string Name { get => _name; set => _name = value; }
            public int Id { get => _id; set => _id = value; }

            public override string ToString()
            {
                return Name;
            }

        }

        private void cboUIX_SizeChanged(object sender, EventArgs e)
        {
            update();
        }

        private void cboUIX_FontChanged(object sender, EventArgs e)
        {
            update();
        }

        private void cbo_EnabledChanged(object sender, EventArgs e)
        {
            cbo.Visible = cbo.Enabled;
            lbl.Text = Campo + ":";
            updateLabel();
        }

        private void cbo_TextChanged(object sender, EventArgs e)
        {
            updateLabel();
        }
    }
}
