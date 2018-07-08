using BURGUERSHACK_COMMON.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUERSHACK_DESKTOP
{
    public partial class frmPagamento : Form
    {

        private clnUtilFormValidar _validar;

        private int _codFuncionario;
        private int? _codCliente;
        private clnConta _objConta;
        private clnPagamento _objPagamento;

        public clnConta ObjConta { get => _objConta; set => _objConta = value; }
        public clnPagamento ObjPagamento { get => _objPagamento; set => _objPagamento = value; }
        public int? CodCliente { get => _codCliente; set => _codCliente = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }

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
            _validar.addValidacao(mtbCliCPF, new clnUtilFormValidar.ValidarTipo[] { clnUtilFormValidar.ValidarTipo.CPF });
            _validar.addValidacao(cboMetodo, clnUtilFormValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(cboBandeira, clnUtilFormValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(txtValor, new clnUtilFormValidar.ValidarTipo[] { clnUtilFormValidar.ValidarTipo.OBRIGATORIO, clnUtilFormValidar.ValidarTipo.VALOR });

            mtbCliCPF.Mask = clnUtil.MASK_CPF;
        }

        private void salvar()
        {
            if (ObjPagamento.Cod == -1)
            {
                if (_validar.valido())
                {
                    if (CodCliente == null)
                    {
                        if (clnUtilMensagem.mostrarSimNao("Pagamento", "Deseja identificar o cliente?", clnUtilMensagem.MensagemIcone.INFO))
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
                        clnUtilMensagem.mostrarOk("Pagamento", "Não é possivel realizar um pagamento com o valor maior do que o necessário.", clnUtilMensagem.MensagemIcone.ERRO);
                        return;
                    }
                    int codForma = -1;
                    if (cboBandeira.Visible)
                    {
                        codForma = cboBandeira.SelectedItem.Id;
                    }
                    else
                    {
                        codForma = cboBandeira.Items[0].Id;
                    }

                    ObjPagamento = new clnPagamento
                    {
                        CodForma = codForma,
                        CodConta = ObjConta.CodAtendimento,
                        Data = DateTime.Now,
                        Valor = obterValorPago(),
                        CodCliente = CodCliente
                    };
                    ObjPagamento.gravar();

                    clnUtilMensagem.mostrarOk("Novo pagamento", "Pagamento registrado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
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
                if (clnUtilMensagem.mostrarSimNao("Novo Pagamento", "Deseja cancelar o pagamento?", clnUtilMensagem.MensagemIcone.ERRO))
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
            if (clnUtilValidar.validarCPF(mtbCliCPF.Text))
            {
                clnCliente objCliente = new clnCliente
                {
                    Cpf = clnUtil.retirarFormatacao(mtbCliCPF.Text)
                }.obterPorCPF();
                if (objCliente != null)
                {
                    definirCliente(objCliente);
                    return true;
                }
                else
                {
                    if (clnUtilMensagem.mostrarSimNao("Cliente", "Cliente não encontrado, deseja cadastrar?", clnUtilMensagem.MensagemIcone.INFO))
                    {
                        frmCliente frmNovoCliente = new frmCliente
                        {
                            CodFuncionario = CodFuncionario
                        };
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
                clnUtilMensagem.mostrarOk("Cliente", "O CPF informado é inválido.", clnUtilMensagem.MensagemIcone.ERRO);
            }
            return false;
        }

        private void definirCliente(clnCliente objCliente)
        {
            CodCliente = objCliente.Cod;
            lblCliente.Text = "Cliente " + objCliente.Cod +
                            "\n" + "CPF: " + clnUtil.formatarCPF(objCliente.Cpf) +
                            "\n" + "Celular: " + clnUtil.formatarCelular(objCliente.TelCelular);
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
            if (clnUtilValidar.validarDecimal(txtValor.Text))
                return clnUtilConvert.ToDecimal(txtValor.Text);
            return 0;
        }

        private decimal obterValorAPagar()
        {
            decimal valor = clnUtilConta.calcularValor(ObjConta) - clnUtilConta.calcularValorPago(ObjConta.CodAtendimento);

            return valor;
        }

        private decimal obterDinheiro()
        {
            if (clnUtilValidar.validarDecimal(txtDinheiro.Text))
                return clnUtilConvert.ToDecimal(txtDinheiro.Text);
            return 0;
        }

        private void atualizarTroco()
        {
            decimal valorPago = obterDinheiro() - obterValorPago();
            lblTroco.Text = "Troco: " + clnUtil.formatarValor(valorPago);
        }

        private void atualizarRestante()
        {
            decimal valorRestante = obterValorAPagar() - obterValorPago();
            lblValorRestante.Text = clnUtil.formatarValor(valorRestante);
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            UIX.uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            hdrUIX.Title = App.Name + " - Novo Pagamento";
            lblValorTotal.Text = clnUtil.formatarValor(obterValorAPagar());

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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

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
