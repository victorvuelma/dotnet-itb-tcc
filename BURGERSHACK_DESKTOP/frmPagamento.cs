using BurgerShack.Common;

using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public partial class frmPagamento : Form
    {

        private clnUtilFormValidar _validar;

        private int? _codCliente;
        private clnConta _objConta;
        private clnPagamento _objPagamento;

        public clnConta ObjConta { get => _objConta; set => _objConta = value; }
        public clnPagamento ObjPagamento { get => _objPagamento; set => _objPagamento = value; }
        public int? CodCliente { get => _codCliente; set => _codCliente = value; }

        public frmPagamento()
        {
            InitializeComponent();

            cboMetodo.cbo.SelectedIndexChanged += (object sender, EventArgs args) =>
            {
                carregarBandeiras();
            };
            txtDinheiro.txt.TextChanged += (object sender, EventArgs args) =>
            {
                atualizarTroco();
            };
            txtValor.txt.TextChanged += (object sender, EventArgs args) =>
            {
                atualizarTroco();
                atualizarRestante();
            };

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(mtbCliCPF, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.CPF });
            _validar.addValidacao(cboMetodo, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(cboBandeira, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtValor, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.VALOR });

            mtbCliCPF.Mask = UtilMask.MASK_CPF;
        }

        private void salvar()
        {
            if (ObjPagamento.Cod == -1)
            {
                if (_validar.validar(this))
                {
                    if (CodCliente == null)
                    {
                        if (UtilMensagem.mostrarSimNao("Pagamento", "Deseja identificar o cliente?", UtilMensagem.MensagemIcone.INFO))
                        {
                            encontrarCliente();
                            if (CodCliente == null)
                            {
                                return;
                            }
                        }
                    }
                    if (obterValorPago() > obterValorAPagar())
                    {
                        UtilMensagem.mostrarOk("Pagamento", "Não é possivel realizar um pagamento com o valor maior do que o necessário.");
                        return;
                    }
                    int codForma = codForma = cboBandeira.Items[0].Id;
                    if (cboBandeira.Visible)
                    {
                        codForma = cboBandeira.SelectedItem.Id;
                    }
                    string cpf = "";
                    if (UtilValidar.validarCPF(mtbCliCPF.Text))
                    {
                        cpf = UtilFormatar.retirarFormatacao(mtbCliCPF.Text);
                    }

                    ObjPagamento = new clnPagamento
                    {
                        CodForma = codForma,
                        CodConta = ObjConta.CodAtendimento,
                        Data = DateTime.Now,
                        Valor = obterValorPago(),
                        CodCliente = CodCliente,
                        Cpf = cpf
                    };
                    ObjPagamento.gravar();

                    UtilMensagem.mostrarOk("Novo pagamento", "Pagamento registrado com sucesso!");
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void fechar()
        {
            if (ObjPagamento.Cod == -1)
            {
                if (UtilMensagem.mostrarSimNao("Novo Pagamento", "Deseja cancelar o pagamento?", UtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private bool encontrarCliente()
        {
            if (UtilValidar.validarCPF(mtbCliCPF.Text))
            {
                clnCliente objCliente = new clnCliente
                {
                    Cpf = UtilFormatar.retirarFormatacao(mtbCliCPF.Text)
                }.obterPorCPF();
                if (objCliente != null)
                {
                    definirCliente(objCliente);
                    return true;
                }
                else
                {
                    if (UtilMensagem.mostrarSimNao("Cliente", "Cliente não encontrado, deseja cadastrar?", UtilMensagem.MensagemIcone.INFO))
                    {
                        frmCliente frmNovoCliente = new frmCliente { };
                        frmNovoCliente.mtbCPF.Text = mtbCliCPF.Text;
                        frmNovoCliente.ShowDialog();

                        if (frmNovoCliente.ObjCliente != null)
                        {
                            definirCliente(frmNovoCliente.ObjCliente);
                            return true;
                        }
                    }
                }
            }
            else
            {
                UtilMensagem.mostrarOk("Cliente", "O CPF informado é inválido.");
            }
            return false;
        }

        private void definirCliente(clnCliente objCliente)
        {
            CodCliente = objCliente.Cod;
            lblCliente.Text = "Cliente " + objCliente.Cod +
                            "\n" + "CPF: " + UtilFormatar.formatarCPF(objCliente.Cpf) +
                            "\n" + "Celular: " + UtilFormatar.formatarCelular(objCliente.TelCelular);
        }

        private void carregarBandeiras()
        {
            clnPagamentoForma objFormas = new clnPagamentoForma();
            cboBandeira.clear();

            bool dinheiro = true;
            foreach (clnPagamentoForma objForma in objFormas.obterFormas())
            {
                if (objForma.Nome.Equals(cboMetodo.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!String.IsNullOrWhiteSpace(objForma.Bandeira))
                    {
                        dinheiro = false;
                    }
                    cboBandeira.add(objForma.Cod, objForma.Bandeira);
                }
            }
            if (dinheiro)
            {
                clnUtil.resetarCampos(grbDinheiro.Controls);
                grbDinheiro.Show();
                cboBandeira.Hide();
            }
            else
            {
                grbDinheiro.Hide();
                cboBandeira.Show();
            }
        }

        private void carregarMetodos()
        {
            clnPagamentoForma objFormas = new clnPagamentoForma();
            cboMetodo.clear();

            foreach (clnPagamentoForma objForma in objFormas.obterFormas())
            {
                if (!cboMetodo.contains(objForma.Nome))
                {
                    cboMetodo.add(objForma.Cod, objForma.Nome);
                }
            }
        }

        private decimal obterValorPago()
        {
            if (UtilValidar.validarDecimal(txtValor.Text))
                return UtilConvert.ToDecimal(txtValor.Text);
            return 0;
        }

        private decimal obterValorAPagar()
        {
            decimal valor = clnUtilConta.calcularValor(ObjConta) - clnUtilConta.calcularValorPago(ObjConta.CodAtendimento);

            return valor;
        }

        private decimal obterDinheiro()
        {
            if (UtilValidar.validarDecimal(txtDinheiro.Text))
                return UtilConvert.ToDecimal(txtDinheiro.Text);
            return 0;
        }

        private void atualizarTroco()
        {
            decimal valorPago = obterDinheiro() - obterValorPago();
            lblTroco.Text = "Troco: " + UtilFormatar.formatarValor(valorPago);
        }

        private void atualizarRestante()
        {
            decimal valorRestante = obterValorAPagar() - obterValorPago();
            lblValorRestante.Text = UtilFormatar.formatarValor(valorRestante);
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            hdrUIX.Title = App.Name + " - Novo Pagamento";
            lblValorTotal.Text = UtilFormatar.formatarValor(obterValorAPagar());

            if (ObjPagamento == null)
            {
                ObjPagamento = new clnPagamento();
                CodCliente = null;
            }
            else
            {
                btnSalvar.Hide();
            }

            carregarMetodos();

            grbDinheiro.Hide();

            mtbCliCPF.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnCliEncontrar_Click(object sender, EventArgs e)
        {
            encontrarCliente();
        }

        private void cboMetodo_Leave(object sender, EventArgs e)
        {
            carregarBandeiras();
        }

    }
}
