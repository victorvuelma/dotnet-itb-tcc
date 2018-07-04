using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIX
{
    public class uixUtil
    {

        private static char[] INT_CHARS = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private static char[] DOUBLE_CHARS = new char[] { ',', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        //RETIRADA DA BIBLIOTECA DE COMANDOS DO LEOMAR. 
        //ALTERADO POR VITORRDGS
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

        public static char[] getChars(uixEnum.uixTextBoxMode mode)
        {
            switch (mode)
            {
                case uixEnum.uixTextBoxMode.INT:
                    return INT_CHARS;
                case uixEnum.uixTextBoxMode.DOUBLE:
                case uixEnum.uixTextBoxMode.MONEY:
                    return DOUBLE_CHARS;
                default:
                    return new char[] { };
            }
        }

        public static void defineSizeForWidht(Control ctl)
        {
            int width = ctl.Width;

            defineSizeForWidht(ctl, width);
        }

        public static void defineSizeForWidht(Control ctl, int widht)
        {
            ctl.AutoSize = true;
            while (ctl.Width > widht)
            {
                ctl.Font = uixFont.alterFont(ctl.Font, ctl.Font.Size - 0.1f);
            }
            ctl.AutoSize = false;
            ctl.Size = new Size(widht, ctl.Height);
        }
        
    }
}
