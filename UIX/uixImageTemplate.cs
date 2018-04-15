using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace UIX
{
    public class uixImageTemplate
    {

        private Image _logo;
        private Icon _icon;

        public uixImageTemplate(Image logo, Icon icon)
        {
            _logo = logo;
            _icon = icon;

        }

        public Image Logo { get => _logo; }
        public Icon Icon { get => _icon; }
    }

}
