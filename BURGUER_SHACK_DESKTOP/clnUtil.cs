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

namespace BURGUER_SHACK_DESKTOP
{
    class clnUtil
    {

        public static String MASK_TEL = "(00) 0000-0000";
        public static String MASK_CEL = "(00) 00000-0000";

        public static String MASK_DATA = "00/00/0000";
        public static String MASK_CEP = "00000-000";

        public static String MASK_CNPJ = "00,000,000/0000-00";
        public static String MASK_IE = "000,000,000,000";
        public static String MASK_CPF = "000,000,000-00";
        public static String MASK_RG = "00,000,000-0";

        private static CPFValidator _cpfValidator = new CPFValidator();
        private static CNPJValidator _cnpjValidator = new CNPJValidator();

        private static CPFFormatter _cpfFormatter = new CPFFormatter();
        private static CNPJFormatter _cnpjFormatter = new CNPJFormatter();

        private static ViaCEP _viaCep = new ViaCEP();

        public static void abrirNumBoard(UIX.txtUIX txt)
        {
            if (txt.AllowedChars == UIX.uixAllowedChars.INT)
            {
                abrirNumBoard(txt.txt, frmNumBoard.NumBoardMode.INT);
            }
            else
            {
                abrirNumBoard(txt.txt, frmNumBoard.NumBoardMode.DOUBLE);
            }
        }

        public static void abrirNumBoard(UIX.mtbUIX masked, frmNumBoard.NumBoardMode mode)
        {
            abrirNumBoard(masked.mtb, mode);
        }

        public static void abrirNumBoard(TextBoxBase box, frmNumBoard.NumBoardMode mode)
        {
            box.Click += (object sender, EventArgs args) =>
            {
                frmNumBoard numBoard = new frmNumBoard();
                numBoard.NumeroPadrao = box.Text;
                numBoard.Input = box;

                if (mode == frmNumBoard.NumBoardMode.DOUBLE)
                {
                    numBoard.btnPoint.Hide();
                }

                numBoard.ShowDialog();
            };
        }

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
        public static void trocarValor<T>(List<T> lista, T valorAntigo, T valorNovo)
        {
            int index = lista.IndexOf(valorAntigo);
            if (index != -1)
                lista[index] = valorNovo;
        }

        public static void adicionarControles(Control onde, List<Control> controles, int espaco)
        {
            int X = espaco / 2;
            int Y = espaco / 2;
            foreach (Control controle in controles)
            {
                controle.Location = new Point(X, Y);
                onde.Controls.Add(controle);
                X += espaco;
                X += controle.Width;
                if ((X + controle.Width) >= onde.MaximumSize.Width)
                {
                    X = espaco / 2;
                    Y += espaco;
                    Y += controle.Height;
                }
            }

            clnUtil.atualizarTabIndex(onde.Controls);
        }

        public static void atualizarTabIndex(ControlCollection controls)
        {
            SortedDictionary<int, SortedDictionary<int, List<Control>>> positionControl = new SortedDictionary<int, SortedDictionary<int, List<Control>>>();

            foreach (Control control in controls)
            {
                int Y = control.Location.Y;
                int X = control.Location.X;

                SortedDictionary<int, List<Control>> yControls = null;
                if (!positionControl.TryGetValue(Y, out yControls))
                {
                    yControls = new SortedDictionary<int, List<Control>>();
                    positionControl.Add(Y, yControls);
                }

                List<Control> xControls = null;
                if (!yControls.TryGetValue(X, out xControls))
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

        public static void definirCEP(UIX.mtbUIX mtbCEP, Control rua, Control bairro, Control cidade, ComboBox estado, Control nr)
        {
            addUFs(estado);
            mtbCEP.Validated += (object sender, EventArgs e) =>
            {
                if (clnUtil.validarCEP(mtbCEP.Text))
                {
                    clnUtil.definirEndereco(mtbCEP.Text, rua, bairro, cidade, estado, nr);
                }
            };
        }

        public static void addUFs(ComboBox cbo)
        {
            cbo.Items.AddRange(new String[] { "AC", "AL", "AM", "AP", "BA", "CE", "ES", "GO", "MA", "MG", "MT", "MS", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
        }

        public static void definirEndereco(String cep, Control rua, Control bairro, Control cidade, ComboBox estado, Control nr)
        {
            if (validarCEP(cep))
            {
                Endereco end = obterEndereco(cep);
                if (end != null)
                {
                    rua.Text = end.Logradouro;
                    bairro.Text = end.Bairro;
                    cidade.Text = end.Localidade;
                    estado.Text = end.UF;
                    nr.Focus();
                }
                else
                {
                    clnMensagem.mostrarOk("Endereço", "Não foi possível obter as informações a partir do CEP, preencha manualmente", clnMensagem.MensagemIcone.INFO);
                    rua.Focus();
                }
            }
        }

        public static Endereco obterEndereco(String cep)
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

        public static bool validarInt(String inteiro)
        {
            int r;
            return Int32.TryParse(inteiro, out r);
        }

        public static String formatarCPF(String cpf)
        {
            return _cpfFormatter.Format(cpf);
        }

        public static bool validarCPF(String cpf)
        {
            return _cpfValidator.IsValid(cpf);
        }

        public static String formatarCNPJ(String cnpj)
        {
            return _cnpjFormatter.Format(cnpj);
        }

        public static bool validarCNPJ(String cnpj)
        {
            return _cnpjValidator.IsValid(cnpj);
        }

        public static bool validarEmail(String email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void alterarConteudo(Panel pnlConteudo, UserControl uctConteudo, UIX.hdrUIX hdrUIX, String titulo)
        {
            if (pnlConteudo.Controls.Count == 1)
            {
                Control controlAnterior = pnlConteudo.Controls[0];
                if (!uctConteudo.GetType().Equals(controlAnterior.GetType()))
                {
                    controlAnterior.Controls.Clear();
                    pnlConteudo.Controls.Remove(controlAnterior);
                }
                else
                {
                    return;
                }
            }

            clnUtil.atualizarTabIndex(uctConteudo.Controls);
            clnApp.AppVisualTemplate.uctApply(uctConteudo);

            pnlConteudo.Controls.Add(uctConteudo);
            uctConteudo.Location = new Point(0, 0);
            uctConteudo.Size = pnlConteudo.Size;
            if (!pnlConteudo.Visible)
            {
                pnlConteudo.Visible = true;
            }

            hdrUIX.Title = clnApp.AppName + " - " + titulo;
        }

    }
}
