using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vitorrdgs.Util.Form
{
    public class UtilFormValor
    {

        public static void defineForMoney(TextBoxBase box)
        {
            string input = string.Empty;
            decimal value = 0;
            try
            {
                input = box.Text.Replace(",", "").Replace(".", "");
                if (input.Equals(""))
                    input = "";
                input = input.PadLeft(3, '0');
                if (input.Length > 3 & input.Substring(0, 1) == "0")
                    input = input.Substring(1, input.Length - 1);
                value = Convert.ToDecimal(input) / 100;
                box.Text = string.Format("{0:n}", value);
                box.SelectionStart = box.Text.Length;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
