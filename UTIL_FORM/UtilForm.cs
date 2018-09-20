using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace vitorrdgs.Util.Form
{
    public class UtilForm
    {

        public static void UpdateIndexes(ControlCollection controls)
        {
            SortedDictionary<int, SortedDictionary<int, List<Control>>> positionControl = new SortedDictionary<int, SortedDictionary<int, List<Control>>>();

            foreach (Control control in controls)
            {
                int Y = control.Location.Y;
                int X = control.Location.X;

                if (!positionControl.TryGetValue(Y, out SortedDictionary<int, List<Control>> yControls))
                {
                    yControls = new SortedDictionary<int, List<Control>>();
                    positionControl.Add(Y, yControls);
                }

                if (!yControls.TryGetValue(X, out List<Control> xControls))
                {
                    xControls = new List<Control>();
                    yControls.Add(X, xControls);
                }
                xControls.Add(control);

                UpdateIndexes(control.Controls);
            }

            int index = 1;
            foreach (KeyValuePair<int, SortedDictionary<int, List<Control>>> yControls in positionControl)
            {
                foreach (KeyValuePair<int, List<Control>> xControls in yControls.Value)
                {
                    foreach (Control control in xControls.Value)
                    {
                        control.TabIndex = index;
                        index++;
                    }
                    xControls.Value.Clear();
                }
                yControls.Value.Clear();
            }

            positionControl.Clear();
        }

        public static void Disable(Control control)
        {
            Enabled(control, false);
        }

        public static void Enable(Control control)
        {
            Enabled(control, true);
        }

        private static void Enabled(Control control, bool enabled)
        {
            if (control.Controls.Count > 0)
            {
                foreach (Control ctl in control.Controls)
                {
                    Enabled(ctl, enabled);
                }
            }
            else if (!(control is Label || control is Button))
            {
                control.Enabled = enabled;
            }
        }

    }
}
