using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmConta : Form
    {

        private clnUtilValidar _validar;

        private clnEstoque _objEstoque;

        public clnEstoque ObjEstoque { get => _objEstoque; set => _objEstoque = value; }

        public frmConta()
        {
            InitializeComponent();

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtQuantidade, clnUtilValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(txtValor, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.DOUBLE });
            _validar.addValidacao(mtbValidade, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.DATA });
            _validar.addValidacao(mtbFornCNPJ, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.CNPJ });

            mtbFornCNPJ.Mask = clnUtil.MASK_CNPJ;
            mtbValidade.Mask = clnUtil.MASK_DATA;
        }

        private void salvar()
        {
            if (_validar.valido())
            {
                if (ObjEstoque.Cod == -1)
                {
                    ObjEstoque = new clnEstoque
                    {
                        CodFornecedor = ObjEstoque.CodFornecedor,
                        CodIngrediente = ObjEstoque.CodIngrediente,
                        Entrada = DateTime.Now.Date,
                        Quantidade = clnUtilConvert.ToInt(txtQuantidade.Text),
                        Validade = clnUtilConvert.ToDateTime(mtbValidade.Text),
                        Total = clnUtilConvert.ToInt(txtQuantidade.Text),
                        Valor = clnUtilConvert.ToDouble(txtValor.Text)
                    };
                    ObjEstoque.gravar();

                    clnUtilMensagem.mostrarOk("Cadastro de Estoque", "Estoque cadastrado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                }
                else
                {
                    ObjEstoque.Quantidade = clnUtilConvert.ToInt(txtQuantidade.Text);

                    ObjEstoque.alterar();
                    clnUtilMensagem.mostrarOk("Altereção de Estoque", "Estoque alterado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
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
            if (clnUtil.validarCNPJ(mtbFornCNPJ.Text))
            {
                clnFornecedor objFornecedor = new clnFornecedor
                {
                    Cnpj = clnUtil.retirarFormatacao(mtbFornCNPJ.Text)
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
                clnUtilMensagem.mostrarOk("Fornecedor", "O CNPJ informado é inválido.", clnUtilMensagem.MensagemIcone.ERRO);
            }
            return false;
        }

        private void definirFornecedor(clnFornecedor objFornecedor)
        {
            ObjEstoque.CodFornecedor = objFornecedor.Cod;
            lblFornecedor.Text = "Fornecedor " + objFornecedor.Cod +
                            "\n" + "Razão Social: " + objFornecedor.RazaoSocial +
                            "\n" + "CNPJ: " + clnUtil.formatarCNPJ(objFornecedor.Cnpj);
        }

        private void definirIngrediente(clnIngrediente objIngrediente)
        {
            ObjEstoque.CodIngrediente = objIngrediente.Cod;

            int estoqueAtual = new clnEstoque
            {
                CodIngrediente = objIngrediente.Cod
            }.obterQuantidadePorIngrediente();

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

            if(objSelecionar.Selecionado != null)
            {
                definirIngrediente(objSelecionar.Selecionado);
            }
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            UIX.uixButton.btnApply(btnVoltar, App.VisualStyle.ButtonWarningColor);

            if (ObjEstoque != null)
            {
                hdrUIX.Title = App.Name + " - Alterando Estoque " + ObjEstoque.Cod;

                txtQuantidade.Text = clnUtilConvert.ToString(ObjEstoque.Quantidade);
                txtValor.Text = ObjEstoque.Valor.ToString();
                mtbValidade.Text = clnUtil.formatarData(ObjEstoque.Validade);

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
                    Cod = ObjEstoque.CodIngrediente
                }.obterPorCod();

                if(objIngrediente != null)
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
