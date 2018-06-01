using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

using Caelum.Stella.CSharp.Validation;
using Caelum.Stella.CSharp.Format;

using Caelum.Stella.CSharp.Http;
using Caelum.Stella.CSharp.Http.Exceptions;
using static System.Windows.Forms.Control;
using System.Text.RegularExpressions;
using System.Collections;

namespace BURGUER_SHACK_DESKTOP
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
        public static String MASK_RG = "00,000,000-0";

        private static String FORMAT_CEL = @"(00) 00000-0000";

        private static String REGEX_CEL = @"^\([1-9]{2}\) [9]{0,1}[6-9]{1}[0-9]{3}\-[0-9]{4}$";

        private static CPFValidator _cpfValidator = new CPFValidator();
        private static CNPJValidator _cnpjValidator = new CNPJValidator();

        private static CPFFormatter _cpfFormatter = new CPFFormatter();
        private static CNPJFormatter _cnpjFormatter = new CNPJFormatter();

        private static ViaCEP _viaCep = new ViaCEP();

        // ---- NUMBOARD
        public static void abrirNumBoard(UIX.txtUIX txt)
        {
            if (txt.AllowedChars == UIX.uixAllowedChars.INT)
            {
                abrirNumBoard(txt.txt, frmUtilNumBoard.NumBoardMode.INT);
            }
            else
            {
                abrirNumBoard(txt.txt, frmUtilNumBoard.NumBoardMode.DOUBLE);
            }
        }

        public static void abrirNumBoard(UIX.mtbUIX masked, frmUtilNumBoard.NumBoardMode mode)
        {
            abrirNumBoard(masked.mtb, mode);
        }

        public static void abrirNumBoard(TextBoxBase box, frmUtilNumBoard.NumBoardMode mode)
        {
            box.Click += (object sender, EventArgs args) =>
            {
                frmUtilNumBoard numBoard = new frmUtilNumBoard
                {
                    NumeroPadrao = box.Text,
                    Input = box
                };

                if (mode == frmUtilNumBoard.NumBoardMode.DOUBLE)
                {
                    numBoard.btnPoint.Hide();
                }

                numBoard.ShowDialog();
            };
        }
        // ---- NUMBOARD

        // ---- ENDERECO
        public static void addUFs(ComboBox cbo)
        {
            cbo.Items.AddRange(new String[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
        }

        public static void definirCEP(UIX.mtbUIX mtbCEP, Control ctlRua, Control ctlBairro, Control ctlCidade, ComboBox ctlUF, Control ctlNr)
        {
            addUFs(ctlUF);
            mtbCEP.Validated += (object sender, EventArgs e) =>
            {
                if (clnUtil.validarCEP(mtbCEP.Text))
                {
                    clnUtil.definirEndereco(mtbCEP.Text, ctlRua, ctlBairro, ctlCidade, ctlUF, ctlNr);
                }
            };
        }

        public static void definirEndereco(String cep, Control ctlRua, Control ctlBairro, Control ctlCidade, ComboBox cboUF, Control ctlNr)
        {
            if (validarCEP(cep))
            {
                Endereco end = obterEndereco(cep);
                if (end != null)
                {
                    ctlRua.Text = end.Logradouro;
                    ctlBairro.Text = end.Bairro;
                    ctlCidade.Text = end.Localidade;
                    cboUF.Text = end.UF;
                    ctlNr.Focus();
                }
                else
                {
                    clnUtilMensagem.mostrarOk("Endereço", "Não foi possível obter as informações a partir do CEP, preencha manualmente", clnUtilMensagem.MensagemIcone.INFO);
                    ctlRua.Focus();
                }
            }
        }

        public static Endereco obterEndereco(String cep)
        {
            // PEGAR DO BANCO, SE NÃO..
            return obterEnderecoViaCep(cep);
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

        public static bool validarCEP(String cep)
        {
            try
            {
                new CEP(cep);
                return true;
            }
            catch (InvalidZipCodeFormat)
            {
                return false;
            }
        }
        // ---- ENDERECO

        internal static string retirarFormatacao(string texto)
        {
            if (texto == null)
                return null;
            return new String(texto.Where(Char.IsDigit).ToArray()); ;
        }

        public static String formatarCelular(String celular)
        {
            if (celular == null || vazio(celular))
                return null;
            return long.Parse(celular).ToString(FORMAT_CEL);
        }

        public static String formatarCPF(String cpf)
        {
            return _cpfFormatter.Format(cpf);
        }
        
        public static String formatarCNPJ(String cnpj)
        {
            return _cnpjFormatter.Format(cnpj);
        }

        // ---- VALIDACOES
        public static bool validarCelular(String cel)
        {
            return Regex.IsMatch(cel, REGEX_CEL);
        }

        public static bool validarData(String data)
        {
            return DateTime.TryParseExact(data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime result);
        }

        public static bool validarDataNasc(String data)
        {
            return clnUtilConvert.ObterData(data).CompareTo(DateTime.Now) < 0;
        }

        public static bool vazio(String str)
        {
            return String.IsNullOrWhiteSpace(str);
        }

        public static bool validarInt(String inteiro)
        {
            return Int32.TryParse(inteiro, out int r);
        }

        public static bool validarCPF(String cpf)
        {
            return _cpfValidator.IsValid(cpf);
        }

        public static bool validarCNPJ(String cnpj)
        {
            return _cnpjValidator.IsValid(cnpj);
        }

        public static bool validarEmail(String mail)
        {
            try
            {
                System.Net.Mail.MailAddress mailAddress = new System.Net.Mail.MailAddress(mail);
                return mailAddress.Address.ToLower().Equals(mail.ToLower());
            }
            catch (Exception)
            {
                return false;
            }
        }
        // ---- VALIDACOES

        public static void resetarCampos(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox || control is MaskedTextBox || control is UIX.txtUIX || control is UIX.mtbUIX)
                {
                    control.ResetText();
                }
                else
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

        public static void adicionarControles(Panel panel, List<Control> controles, int espaco)
        {
            panel.Hide();

            int X = espaco / 2;
            int Y = espaco / 2;
            foreach (Control controle in controles)
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

            App.AppVisualTemplate.pnlApply(panel);
            clnUtil.atualizarTabIndex(panel.Controls);

            panel.Show();
        }

        public static void atualizarTabIndex(ControlCollection controls)
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

                atualizarTabIndex(control.Controls);
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

        public static void alterarConteudo(Panel pnlConteudo, UserControl uctConteudo, UIX.hdrUIX hdrUIX, String titulo)
        {
            if (pnlConteudo.Controls.Count == 1)
            {
                Control controlAnterior = pnlConteudo.Controls[0];
                if (uctConteudo == null || !uctConteudo.GetType().Equals(controlAnterior.GetType()))
                {
                    controlAnterior.Controls.Clear();
                    controlAnterior.Dispose();
                    pnlConteudo.Controls.Remove(controlAnterior);
                }
                else
                {
                    return;
                }
            }
            if (uctConteudo == null)
            {
                hdrUIX.Title = App.AppName + " - " + titulo;
                return;
            }

            clnUtil.atualizarTabIndex(uctConteudo.Controls);
            App.AppVisualTemplate.uctApply(uctConteudo);

            pnlConteudo.Controls.Add(uctConteudo);
            uctConteudo.Location = new Point(0, 0);
            uctConteudo.Size = pnlConteudo.Size;
            if (!pnlConteudo.Visible)
            {
                pnlConteudo.Visible = true;
            }

            hdrUIX.Title = App.AppName + " - " + titulo;
        }

    }
}
