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
                }
            }

            positionControl.Clear();
        }

        public static void definirCEP(UIX.mtbUIX mtbCEP, Control rua, Control bairro, Control cidade, Control estado, Control nr)
        {
            mtbCEP.Validated += (object sender, EventArgs e) =>
            {
                if (clnUtil.validarCEP(mtbCEP.Text))
                {
                    clnUtil.definirEndereco(mtbCEP.Text, rua, bairro, cidade, estado, nr);
                }
            };
        }

        public static void definirEndereco(String cep, Control rua, Control bairro, Control cidade, Control estado, Control nr)
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
                    clnMensagem.mostrarOk("Endereço", "Não foi possível obter as informações a partir do CEP, preencha manualmente", clnMensagem.MSG_ERRO);
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

        private static Panel _pnlConteudo;
        private static UIX.uctUIX _uixBar;

        public static void alterarConteudo(Panel pnlConteudo, UserControl uctConteudo, UIX.uctUIX uctUIX, String titulo)
        {
            _pnlConteudo = pnlConteudo;
            _uixBar = uctUIX;

            if (pnlConteudo.Controls.Count == 1)
            {
                if (!uctConteudo.GetType().Equals(pnlConteudo.Controls[0].GetType()))
                {
                    pnlConteudo.Controls.Remove(pnlConteudo.Controls[0]);
                }
                else
                {
                    return;
                }
            }

            clnUtil.atualizarTabIndex(uctConteudo.Controls);
            clnTemplate.CommonTemplate.uctApply(uctConteudo);

            pnlConteudo.Controls.Add(uctConteudo);
            uctConteudo.Location = new Point(0, 0);
            uctConteudo.Size = pnlConteudo.Size;
            if (!pnlConteudo.Visible)
            {
                pnlConteudo.Visible = true;
            }

            uctUIX.UIXTitle = clnTemplate.AppName + " - " + titulo;
        }

        public static void alterarConteudo(UserControl novoConteudo, String titulo)
        {
            alterarConteudo(_pnlConteudo, novoConteudo, _uixBar, titulo);
        }

    }
}
