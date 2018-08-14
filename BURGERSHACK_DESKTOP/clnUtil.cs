using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Windows.Forms;
using System.Drawing;

using static System.Windows.Forms.Control;
using System.Collections;
using BurgerShack.Common.UTIL;
using BurgerShack.Common;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Property;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop
{
    class clnUtil
    {

        public static String MASK_TEL = "(00) 0000-0000";
        public static String MASK_CEL = "(00) 00000-0000";

        public static String MASK_DATA = "00/00/0000";
        public static String MASK_HORA = "00:00";

        public static String MASK_CEP = "00000-000";

        public static String MASK_CNPJ = "00,000,000/0000-00";
        public static String MASK_IE = "000,000,000,000";
        public static String MASK_CPF = "000,000,000-00";

        private static frmUtilNumBoard frmNumBoard;

        // ---- NUMBOARD
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
                    definirNumBoard(txt.txt, frmUtilNumBoard.NumBoardMode.DOUBLE);
                    break;
                case uixEnum.uixTextBoxMode.MONEY:
                    definirNumBoard(txt.txt, frmUtilNumBoard.NumBoardMode.MONEY);
                    break;
                case uixEnum.uixTextBoxMode.INT:
                    definirNumBoard(txt.txt, frmUtilNumBoard.NumBoardMode.INT);
                    break;
            }
        }

        public static void definirNumBoard(UIXMaskedTextBox mtb)
        {
            definirNumBoard(mtb.mtb, frmUtilNumBoard.NumBoardMode.INT);
        }

        public static void definirNumBoard(TextBoxBase input, frmUtilNumBoard.NumBoardMode mode)
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

        public static void abrirNumBoard(TextBoxBase input, frmUtilNumBoard.NumBoardMode mode)
        {
            if (frmNumBoard == null)
            {
                frmNumBoard = new frmUtilNumBoard
                {
                    Input = input,
                    Mode = mode
                };
            }
            else if (frmNumBoard.Input != input)
            {
                frmNumBoard.Mode = mode;
                frmNumBoard.Input = input;
            }

            if (frmNumBoard.Input.Equals(input) && frmNumBoard.Visible)
            {
                frmNumBoard.Hide();
            }
            else
            {
                frmNumBoard.Show();
            }
        }
        // ---- NUMBOARD

        // ---- ENDERECO
        public static void addUFs(ComboBox cbo)
        {
            cbo.Items.AddRange(new String[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
        }

        public static void definirCEP(UIXMaskedTextBox mtbCEP, Control ctlLogradouro, Control ctlBairro, Control ctlCidade, ComboBox cboUF, Control ctlNr, Control ctlComplemento)
        {
            UtilForm.Disable(ctlLogradouro);
            UtilForm.Disable(ctlBairro);
            UtilForm.Disable(ctlCidade);
            UtilForm.Disable(cboUF);

            addUFs(cboUF);
            mtbCEP.mtb.Validated += (object sender, EventArgs e) =>
            {
                if (clnUtilValidar.validarCEP(mtbCEP.Text))
                {
                    clnUtil.definirEndereco(mtbCEP.Text, ctlLogradouro, ctlBairro, ctlCidade, cboUF, ctlNr, ctlComplemento);
                }
            };
        }

        public static void definirEndereco(String cep, Control ctlLogradouro, Control ctlBairro, Control ctlCidade, ComboBox cboUF, Control ctlNr, Control ctlComplemento)
        {
            if (clnUtilValidar.validarCEP(cep))
            {
                Cursor.Current = Cursors.WaitCursor;
                clnEndereco objEndereco = clnUtilEndereco.obterEndereco(cep);
                if (objEndereco != null)
                {
                    UtilForm.Disable(ctlLogradouro);
                    UtilForm.Disable(ctlBairro);
                    UtilForm.Disable(ctlCidade);
                    UtilForm.Disable(cboUF);

                    ctlLogradouro.Text = objEndereco.Logradouro;
                    ctlBairro.Text = objEndereco.Bairro;
                    ctlCidade.Text = objEndereco.Localidade;
                    cboUF.Text = objEndereco.UF;
                    ctlComplemento.Text = objEndereco.Complemento;
                    ctlNr.Focus();
                }
                else
                {
                    UtilForm.Enable(ctlLogradouro);
                    UtilForm.Enable(ctlBairro);
                    UtilForm.Enable(ctlCidade);
                    UtilForm.Enable(cboUF);

                    clnUtilMensagem.mostrarOk("Endereço", "Não foi possível obter as informações a partir do CEP, preencha manualmente");
                    ctlLogradouro.Focus();
                }
                Cursor.Current = Cursors.Default;
            }
        }

        // ---- ENDERECO

        public static String obterConteudo(Control control)
        {
            String conteudo = control.Text;
            if (control is MaskedTextBox mtb)
            {
                MaskFormat oldFormat = mtb.TextMaskFormat;
                String oldText = mtb.Text;
                mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                conteudo = mtb.Text;
                mtb.Text = oldText;
                mtb.TextMaskFormat = oldFormat;
            }
            return conteudo;
        }

        public static void resetarCampos(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.ResetText();
                if (control is DataGridView)
                {
                    ((DataGridView)control).Rows.Clear();
                }
            }
        }

        //https://stackoverflow.com/questions/17188966/how-to-replace-list-item-in-best-way
        public static void listTrocar<T>(IList lista, T valorAntigo, T valorNovo)
        {
            int index = lista.IndexOf(valorAntigo);
            if (index != -1)
                lista[index] = valorNovo;
        }

        public static void dictTrocar<T, C>(Dictionary<T, C> dict, T chaveAntiga, T chaveNova, C conteudoNova)
        {
            dict.Remove(chaveAntiga);
            dict.Add(chaveNova, conteudoNova);
        }

        public static void adicionarControles(Panel panel, List<Control> controls, int espaco)
        {
            panel.Hide();

            int X = espaco / 2;
            int Y = espaco / 2;
            foreach (Control controle in controls)
            {
                controle.Location = new Point(X, Y);
                panel.Controls.Add(controle);
                X += espaco;
                X += controle.Width;
                if ((X + controle.Width) >= panel.MaximumSize.Width)
                {
                    X = espaco / 2;
                    Y += espaco;
                    Y += controle.Height;
                }
            }

            AppDesktop.VisualTemplate.ctlApply(panel);
            UtilForm.UpdateIndexes(panel.Controls);

            panel.Show();
        }

        public static void atualizarForm(Form form)
        {
            UIXHeader hdr = null;
            foreach (Control control in form.Controls)
            {
                if (control is UIXHeader hdrUIX)
                {
                    hdr = hdrUIX;
                    break;
                }
            }
            if (hdr != null)
            {
                AppDesktop.VisualTemplate.frmApply(form, hdr);
            }

            UtilForm.UpdateIndexes(form.Controls);
            if (form.AcceptButton != null)
            {
                definirBotaoConfirmacao(form.Controls, form.AcceptButton);
                form.AcceptButton = null;
            }

            definirNumBoard(form.Controls);
        }

        public static void definirBotaoConfirmacao(ControlCollection controls, IButtonControl acceptButton)
        {
            foreach (Control control in controls)
            {
                if (control is UIXTextBox txt)
                {
                    if (txt.AcceptButton == null)
                        txt.AcceptButton = acceptButton;
                }
                else if (control is UIXMaskedTextBox mtb)
                {
                    if (mtb.AcceptButton == null)
                        mtb.AcceptButton = acceptButton;
                }
                else if (control is UIXComboBox cbo)
                {
                    if (cbo.AcceptButton == null)
                        cbo.AcceptButton = acceptButton;
                }
                definirBotaoConfirmacao(control.Controls, acceptButton);
            }
        }

        public static void alterarConteudo(Panel pnlConteudo, UserControl uctConteudo, UIXHeader hdr, String titulo)
        {
            if (pnlConteudo.Controls.Count == 1)
            {
                Control controlAnterior = pnlConteudo.Controls[0];
                if (uctConteudo == null || !titulo.Equals(pnlConteudo.AccessibleName))
                {
                    pnlConteudo.Hide();
                    Cursor.Current = Cursors.WaitCursor;

                    controlAnterior.Controls.Clear();
                    controlAnterior.Dispose();
                    pnlConteudo.Controls.Remove(controlAnterior);
                }
                else
                {
                    return;
                }
            }

            pnlConteudo.AccessibleName = titulo;
            hdr.Title = App.Name + " - " + titulo;
            if (uctConteudo == null)
            {
                pnlConteudo.Show();
                Cursor.Current = Cursors.Default;
                return;
            }

            UtilForm.UpdateIndexes(uctConteudo.Controls);
            AppDesktop.VisualTemplate.ctlApply(uctConteudo);

            pnlConteudo.Controls.Add(uctConteudo);
            uctConteudo.Location = new Point(0, 0);
            uctConteudo.Size = pnlConteudo.Size;

            pnlConteudo.Show();
            Cursor.Current = Cursors.Default;
        }

    }
}
