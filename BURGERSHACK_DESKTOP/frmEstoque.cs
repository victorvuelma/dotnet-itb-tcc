using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public partial class frmEstoque : Form
    {

        private clnUtilFormValidar _validar;

        private clnEstoque _objEstoque;

        public clnEstoque ObjEstoque { get => _objEstoque; set => _objEstoque = value; }

        public frmEstoque()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtQuantidade, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtValor, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.VALOR });
            _validar.addValidacao(mtbValidade, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.DATA });
            _validar.addValidacao(mtbFornCNPJ, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CNPJ });

            mtbFornCNPJ.Mask = UtilMask.MASK_CNPJ;
            mtbValidade.Mask = UtilMask.MASK_DATA;
        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                if (ObjEstoque.Cod == -1)
                {
                    ObjEstoque = new clnEstoque
                    {
                        CodFornecedor = ObjEstoque.CodFornecedor,
                        CodMercadoria = ObjEstoque.CodMercadoria,
                        Entrada = DateTime.Now.Date,
                        Quantidade = UtilConvert.ToInt(txtQuantidade.Text),
                        Validade = UtilConvert.ToDateTime(mtbValidade.Text),
                        Total = UtilConvert.ToInt(txtQuantidade.Text),
                        Valor = UtilConvert.ToDecimal(txtValor.Text)
                    };
                    ObjEstoque.gravar();

                    clnUtilMensagem.mostrarOk("Cadastro de Estoque", "Estoque cadastrado com sucesso!");
                }
                else
                {
                    ObjEstoque.Quantidade = UtilConvert.ToInt(txtQuantidade.Text);

                    ObjEstoque.alterar();
                    clnUtilMensagem.mostrarOk("Altereção de Estoque", "Estoque alterado com sucesso!");
                }
                Close();
            }
        }

        private void fechar()
        {
            if (ObjEstoque.Cod == -1)
            {
                if (clnUtilMensagem.mostrarSimNao("Cadastro de Estoque", "Deseja cancelar o cadastro?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (clnUtilMensagem.mostrarSimNao("Alteração de Estoque", "Deseja cancelar as alterações?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
        }

        private bool encontrarFornecedor()
        {
            if (UtilValidar.validarCNPJ(mtbFornCNPJ.Text))
            {
                clnFornecedor objFornecedor = new clnFornecedor
                {
                    Cnpj = UtilFormatar.retirarFormatacao(mtbFornCNPJ.Text)
                }.obterPorCNPJ();
                if (objFornecedor != null)
                {
                    definirFornecedor(objFornecedor);
                    return true;
                }
                else
                {
                    if (clnUtilMensagem.mostrarSimNao("Fornecedor", "Fornecedor não encontrado, deseja cadastrar?", clnUtilMensagem.MensagemIcone.INFO))
                    {
                        frmFornecedor frmNovoFornecedor = new frmFornecedor();
                        frmNovoFornecedor.mtbCNPJ.Text = mtbFornCNPJ.Text;
                        frmNovoFornecedor.ShowDialog();

                        if (frmNovoFornecedor.ObjFornecedor != null)
                        {
                            definirFornecedor(frmNovoFornecedor.ObjFornecedor);
                            return true;
                        }
                    }
                }
            }
            else
            {
                clnUtilMensagem.mostrarOk("Fornecedor", "O CNPJ informado é inválido.");
            }
            return false;
        }

        private void definirFornecedor(clnFornecedor objFornecedor)
        {
            ObjEstoque.CodFornecedor = objFornecedor.Cod;
            lblFornecedor.Text = "Fornecedor " + objFornecedor.Cod +
                            "\n" + "Razão Social: " + objFornecedor.RazaoSocial +
                            "\n" + "CNPJ: " + UtilFormatar.formatarCNPJ(objFornecedor.Cnpj);
        }

        private void definirIngrediente(clnIngrediente objIngrediente)
        {
            ObjEstoque.CodMercadoria = objIngrediente.Cod;

            int estoqueAtual = new clnEstoque
            {
                CodMercadoria = objIngrediente.Cod
            }.obterQuantidadePorMercadoria();

            lblIngrediente.Text = "Ingrediente " + objIngrediente.Cod +
                            "\n" + "Nome: " + objIngrediente.Nome +
                            "\n" + "Valor: " + objIngrediente.Valor;
        }

        private void selecionarIngrediente()
        {
            clnIngrediente objIngredientes = new clnIngrediente();

            clnIngrediente.clnListar objListar = new clnIngrediente.clnListar
            {
                Icone = Properties.Resources.ingrediente,
                Titulo = "Selecione o Ingrediente",
                Opcoes = objIngredientes.obterIngredientes()
            };

            clnUtilSelecionar<clnIngrediente> objSelecionar = new clnUtilSelecionar<clnIngrediente>
            {
                Quantidade = 0,
                ObjListar = objListar
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
            {
                ObjSelecionar = objSelecionar
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                definirIngrediente(objSelecionar.Selecionado);
            }
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            if (ObjEstoque != null)
            {
                hdrUIX.Title = App.Name + " - Alterando Estoque " + ObjEstoque.Cod;

                txtQuantidade.Text = UtilConvert.ToString(ObjEstoque.Quantidade);
                txtValor.Text = ObjEstoque.Valor.ToString();
                mtbValidade.Text = UtilFormatar.formatarData(ObjEstoque.Validade);

                clnFornecedor objFornecedor = new clnFornecedor
                {
                    Cod = ObjEstoque.CodFornecedor
                }.obterPorCod();

                if (objFornecedor != null)
                {
                    mtbFornCNPJ.Text = objFornecedor.Cnpj;
                    definirFornecedor(objFornecedor);
                }
                btnFornEncontrar.Hide();

                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = ObjEstoque.CodMercadoria
                }.obterPorCod();

                if (objIngrediente != null)
                {
                    definirIngrediente(objIngrediente);
                }
                btnIngSelecionar.Hide();

            }
            else
            {
                ObjEstoque = new clnEstoque();

                hdrUIX.Title = App.Name + " - Novo Estoque";
            }
        }

        private void btnIngSelecionar_Click(object sender, EventArgs e)
        {
            selecionarIngrediente();
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

        private void btnFornEncontrar_Click(object sender, EventArgs e)
        {
            encontrarFornecedor();
        }

    }
}
