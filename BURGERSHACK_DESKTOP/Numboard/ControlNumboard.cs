using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vitorrdgs.UiX.Component;
using System.Windows.Forms;
using vitorrdgs.UiX.Property;
using static System.Windows.Forms.Control;

namespace BurgerShack.Desktop.Numboard
{
    public class ControlNumboard
    {
        private static FormNumboard frmNumboard;

        public static void esconderNumBoard()
        {
            frmNumboard.Hide();
        }

        public static void definirNumBoard(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is UIXMaskedTextBox mtb)
                {
                    definirNumBoard(mtb);
                }
                else if (control is UIXTextBox txt)
                {
                    definirNumBoard(txt);
                }

                definirNumBoard(control.Controls);
            }
        }

        public static void definirNumBoard(UIXTextBox txt)
        {
            switch (txt.Mode)
            {
                case uixEnum.uixTextBoxMode.DOUBLE:
                    definirNumBoard(txt.txt, FormNumboard.NumBoardMode.DOUBLE);
                    break;
                case uixEnum.uixTextBoxMode.MONEY:
                    definirNumBoard(txt.txt, FormNumboard.NumBoardMode.MONEY);
                    break;
                case uixEnum.uixTextBoxMode.INT:
                    definirNumBoard(txt.txt, FormNumboard.NumBoardMode.INT);
                    break;
            }
        }

        public static void definirNumBoard(UIXMaskedTextBox mtb)
        {
            definirNumBoard(mtb.mtb, FormNumboard.NumBoardMode.INT);
        }

        public static void definirNumBoard(TextBoxBase input, FormNumboard.NumBoardMode mode)
        {
            input.MouseClick += (object sender, MouseEventArgs args) =>
            {
                abrirNumBoard(input, mode);
            };
            input.Enter += (object sender, EventArgs args) =>
            {
                if (!input.Focused)
                    abrirNumBoard(input, mode);
            };
        }

        public static void abrirNumBoard(TextBoxBase input, FormNumboard.NumBoardMode mode)
        {
            if (frmNumboard == null)
            {
                frmNumboard = new FormNumboard
                {
                    Input = input,
                    Mode = mode
                };
            }
            else if (frmNumboard.Input != input)
            {
                frmNumboard.Mode = mode;
                frmNumboard.Input = input;
            }

            if (frmNumboard.Input.Equals(input) && frmNumboard.Visible)
            {
                frmNumboard.Hide();
            }
            else
            {
                frmNumboard.Show();
            }
        }

    }
}
