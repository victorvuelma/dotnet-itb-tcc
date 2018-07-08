using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Windows.Forms;
using System.Drawing;

using Caelum.Stella.CSharp.Validation;
using Caelum.Stella.CSharp.Format;

using Caelum.Stella.CSharp.Http;
using Caelum.Stella.CSharp.Http.Exceptions;
using static System.Windows.Forms.Control;
using System.Text.RegularExpressions;
using System.Collections;
using BURGUERSHACK_COMMON;
namespace BURGUERSHACK_DESKTOP
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

        private static String FORMAT_CEL = @"(00) 00000-0000";
        private static String FORMAT_TEL = @"(00) 0000-0000";

        private static CPFFormatter _cpfFormatter = new CPFFormatter();
        private static CNPJFormatter _cnpjFormatter = new CNPJFormatter();

        private static ViaCEP _viaCep = new ViaCEP();

        // ---- NUMBOARD
        public static void definirNumBoard(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is UIX.mtbUIX mtb)
                {
                    definirNumBoard(mtb);
                }
                else if (control is UIX.txtUIX txt)
                {
                    definirNumBoard(txt);
                }

                definirNumBoard(control.Controls);
            }
        }

        public static void definirNumBoard(UIX.txtUIX txt)
        {
            switch (txt.Mode)
            {
                case UIX.uixEnum.uixTextBoxMode.DOUBLE:
                    definirNumBoard(txt.txt, frmUtilNumBoard.NumBoardMode.DOUBLE);
                    break;
                case UIX.uixEnum.uixTextBoxMode.MONEY:
                    definirNumBoard(txt.txt, frmUtilNumBoard.NumBoardMode.MONEY);
                    break;
                case UIX.uixEnum.uixTextBoxMode.INT:
                    definirNumBoard(txt.txt, frmUtilNumBoard.NumBoardMode.INT);
                    break;
            }
        }

        public static void definirNumBoard(UIX.mtbUIX masked)
        {
            definirNumBoard(masked.mtb, frmUtilNumBoard.NumBoardMode.INT);
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

        public static void definirCEP(UIX.mtbUIX mtbCEP, Control ctlLogradouro, Control ctlBairro, Control ctlCidade, ComboBox cboUF, Control ctlNr, Control ctlComplemento)
        {
            ctlLogradouro.Enabled = false;
            ctlBairro.Enabled = false;
            ctlCidade.Enabled = false;
            cboUF.Enabled = false;

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
                clnEndereco objEndereco = obterEndereco(cep);
                if (objEndereco != null)
                {
                    ctlLogradouro.Enabled = false;
                    ctlBairro.Enabled = false;
                    ctlCidade.Enabled = false;
                    cboUF.Enabled = false;

                    ctlLogradouro.Text = objEndereco.Logradouro;
                    ctlBairro.Text = objEndereco.Bairro;
                    ctlCidade.Text = objEndereco.Localidade;
                    cboUF.Text = objEndereco.UF;
                    ctlComplemento.Text = objEndereco.Complemento;
                    ctlNr.Focus();
                }
                else
                {
                    ctlLogradouro.Enabled = true;
                    ctlBairro.Enabled = true;
                    ctlCidade.Enabled = true;
                    cboUF.Enabled = true;

                    clnUtilMensagem.mostrarOk("Endereço", "Não foi possível obter as informações a partir do CEP, preencha manualmente", clnUtilMensagem.MensagemIcone.INFO);
                    ctlLogradouro.Focus();
                }
            }
        }

        public static clnEndereco obterEndereco(String cep)
        {
            Cursor.Current = Cursors.WaitCursor;
            clnEndereco objEndereco = new clnEndereco
            {
                CEP = retirarFormatacao(cep)
            }.obterPorCep();
            if (objEndereco == null)
            {
                objEndereco = clnEndereco.from(obterEnderecoViaCep(cep));
            }
            Cursor.Current = Cursors.Default;
            return objEndereco;
        }

        public static Endereco obterEnderecoViaCep(String cep)
        {
            try
            {
                return _viaCep.GetEndereco(new CEP(cep));
            }
            catch (Exception)
            {
                return null;
            }
        }

        // ---- ENDERECO

        // ---- FORMATACOES
        internal static string retirarFormatacao(string texto)
        {
            if (texto == null)
                return null;
            return new String(texto.Where(Char.IsDigit).ToArray());
        }

        public static String formatarValor(decimal valor)
        {
            return string.Format("{0:C}", valor);
        }

        public static String formatarCelular(String celular)
        {
            if (celular == null || clnUtilValidar.vazio(celular))
                return null;
            return long.Parse(celular).ToString(FORMAT_CEL);
        }

        public static String formatarTelefone(String telefone)
        {
            if (telefone == null || clnUtilValidar.vazio(telefone))
                return null;
            return long.Parse(telefone).ToString(FORMAT_TEL);
        }

        public static String formatarCPF(String cpf)
        {
            return _cpfFormatter.Format(cpf);
        }

        public static String formatarCNPJ(String cnpj)
        {
            return _cnpjFormatter.Format(cnpj);
        }

        public static String formatarData(DateTime? data)
        {
            return ((data != null) ? formatarData((DateTime)data) : "");
        }

        public static String formatarData(DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }

        public static String formatarHora(DateTime hora)
        {
            return hora.ToString("HH:mm");
        }

        public static String formatarDataHora(DateTime dataHora)
        {
            return dataHora.ToString("dd/MM/yyyy HH:mm");
        }
        // ---- FORMATACOES

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
            clnUtil.atualizarIndex(panel.Controls);

            panel.Show();
        }

        public static void atualizarForm(Form form)
        {
            UIX.hdrUIX hdr = null;
            foreach (Control control in form.Controls)
            {
                if (control is UIX.hdrUIX hdrUIX)
                {
                    hdr = hdrUIX;
                    break;
                }
            }
            if (hdr != null)
            {
                AppDesktop.VisualTemplate.frmApply(form, hdr);
            }

            atualizarIndex(form.Controls);
            if (form.AcceptButton != null)
            {
                definirBotaoConfirmacao(form.Controls, form.AcceptButton);
                form.AcceptButton = null;
            }

            definirNumBoard(form.Controls);
        }

        public static void atualizarIndex(ControlCollection controls)
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

                atualizarIndex(control.Controls);
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

        public static void definirBotaoConfirmacao(ControlCollection controls, IButtonControl acceptButton)
        {
            foreach (Control control in controls)
            {
                if (control is UIX.txtUIX txt)
                {
                    if (txt.AcceptButton == null)
                        txt.AcceptButton = acceptButton;
                }
                else if (control is UIX.mtbUIX mtb)
                {
                    if (mtb.AcceptButton == null)
                        mtb.AcceptButton = acceptButton;
                }
                else if (control is UIX.cboUIX cbo)
                {
                    if (cbo.AcceptButton == null)
                        cbo.AcceptButton = acceptButton;
                }
                definirBotaoConfirmacao(control.Controls, acceptButton);
            }
        }

        public static void alterarConteudo(Panel pnlConteudo, UserControl uctConteudo, UIX.hdrUIX hdrUIX, String titulo)
        {
            alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, titulo, false);
        }

        public static void alterarConteudo(Panel pnlConteudo, UserControl uctConteudo, UIX.hdrUIX hdrUIX, String titulo, bool ignorarTipo)
        {
            if (pnlConteudo.Controls.Count == 1)
            {
                Control controlAnterior = pnlConteudo.Controls[0];
                if (ignorarTipo || uctConteudo == null || !uctConteudo.GetType().Equals(controlAnterior.GetType()))
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

            hdrUIX.Title = App.Name + " - " + titulo;
            if (uctConteudo == null)
            {
                pnlConteudo.Show();
                Cursor.Current = Cursors.Default;
                return;
            }

            clnUtil.atualizarIndex(uctConteudo.Controls);
            AppDesktop.VisualTemplate.ctlApply(uctConteudo);

            pnlConteudo.Controls.Add(uctConteudo);
            uctConteudo.Location = new Point(0, 0);
            uctConteudo.Size = pnlConteudo.Size;

            pnlConteudo.Show();
            Cursor.Current = Cursors.Default;
        }

    }
}
