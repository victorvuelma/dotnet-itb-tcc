using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Property;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Form;
using static System.Windows.Forms.Control;

namespace BurgerShack.Desktop
{
    class clnUtil
    {

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
                if (UtilValidar.validarCEP(mtbCEP.Text))
                {
                    clnUtil.definirEndereco(mtbCEP.Text, ctlLogradouro, ctlBairro, ctlCidade, cboUF, ctlNr, ctlComplemento);
                }
            };
        }

        public static void definirEndereco(String cep, Control ctlLogradouro, Control ctlBairro, Control ctlCidade, ComboBox cboUF, Control ctlNr, Control ctlComplemento)
        {
            if (UtilValidar.validarCEP(cep))
            {
                Cursor.Current = Cursors.WaitCursor;
                Endereco objEndereco = Endereco.obterEndereco(cep);
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

                    UtilMensagem.mostrarOk("Endereço", "Não foi possível obter as informações a partir do CEP, preencha manualmente");
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

            Numboard.ControlNumboard.definirNumBoard(form.Controls);
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
