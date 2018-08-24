using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop
{
    public partial class frmIngrediente : Form
    {

        private clnUtilFormValidar _validar;

        private clnIngrediente _objIngrediente;

        public clnIngrediente ObjIngrediente { get => _objIngrediente; set => _objIngrediente = value; }

        public frmIngrediente()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtNome, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtValor, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.VALOR });
            _validar.addValidacao(cboTipo, clnUtilFormValidar.Validacao.OBRIGATORIO);

        }

        private void abrirTipos()
        {
            frmTipo frmTipo = new frmTipo
            {
                Tipo = clnTipo.tipo.INGREDIENTE
            };
            frmTipo.ShowDialog();

            carregarTipos();
            if (frmTipo.ObjTipo != null)
                definirTipo(frmTipo.ObjTipo);
        }

        private void removerImagem()
        {
            if (UtilMensagem.mostrarSimNao("Ingrediente", "Deseja realmente remover a imagem?", UtilMensagem.MensagemIcone.INFO))
            {
                definirImagemPadrao();
            }
        }

        private void definirImagemPadrao()
        {
            picImagem.ImageLocation = clnArquivo.tempImage(Properties.Resources.imagem);
        }

        private void adicionarImagem()
        {
            OpenFileDialog objDialog = new OpenFileDialog
            {
                Filter = "png|*.png"
            };
            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                picImagem.ImageLocation = objDialog.FileName;
            }
        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                if (ObjIngrediente == null)
                {
                    clnArquivo objArquivo = new clnArquivo
                    {
                        Local = picImagem.ImageLocation
                    };
                    objArquivo.gravar();

                    ObjIngrediente = new clnIngrediente
                    {
                        Situacao = clnIngrediente.ingredienteSituacao.FORADEESTOQUE,
                        Nome = txtNome.Text,
                        CodTipo = cboTipo.SelectedItem.Id,
                        CodImagem = objArquivo.Cod,
                        Valor = UtilConvert.ToDecimal(txtValor.Text)
                    };

                    ObjIngrediente.gravar();
                    UtilMensagem.mostrarOk("Cadastro de Ingrediente", "Ingrediente cadastrado com sucesso!");
                }
                else
                {
                    clnArquivo objArquivo = new clnArquivo
                    {
                        Cod = ObjIngrediente.CodImagem
                    }.obterPorCodigo();

                    if (!objArquivo.Local.Equals(picImagem.ImageLocation))
                    {
                        objArquivo = new clnArquivo
                        {
                            Local = picImagem.ImageLocation
                        };
                        objArquivo.gravar();
                        ObjIngrediente.CodImagem = objArquivo.Cod;
                    }
                    ObjIngrediente.CodTipo = UtilConvert.ToInt(cboTipo.Text.Split('-')[0]);
                    ObjIngrediente.Nome = txtNome.Text;
                    ObjIngrediente.Valor = UtilConvert.ToDecimal(txtValor.Text);
                    ObjIngrediente.Situacao = (clnIngrediente.ingredienteSituacao)Enum.Parse(typeof(clnIngrediente.ingredienteSituacao), cboSituacao.Text);

                    ObjIngrediente.alterar();

                    clnEstoque objEstoque = new clnEstoque
                    {
                        CodMercadoria = ObjIngrediente.Cod
                    };
                    objEstoque.atualizarIngredientes();

                    UtilMensagem.mostrarOk("Altereção de Ingrediente", "Ingrediente alterado com sucesso!");
                }
                Close();
            }
        }

        private void definirTipo(clnTipo objTipo)
        {
            cboTipo.Text = objTipo.Cod + " - " + objTipo.Nome;
        }

        private void carregarTipos()
        {
            cboTipo.clear();

            foreach (clnTipo objTipo in new clnTipo { Tipo = clnTipo.tipo.INGREDIENTE }.obterTipos())
            {
                cboTipo.add(objTipo.Cod, objTipo.Cod + " - " + objTipo.Nome);
                if (ObjIngrediente != null && ObjIngrediente.CodTipo.Equals(objTipo.Cod))
                {
                    definirTipo(objTipo);
                }
            }
        }

        private void fechar()
        {
            if (ObjIngrediente == null)
            {
                if (UtilMensagem.mostrarSimNao("Cadastro de Ingrediente", "Deseja cancelar o cadastro?", UtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (UtilMensagem.mostrarSimNao("Alteração de Ingrediente", "Deseja cancelar as alterações?", UtilMensagem.MensagemIcone.ERRO))
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void excluir()
        {
            if (UtilMensagem.mostrarSimNao("Ingrediente", "Você deseja realmente excluir este ingrediente?", UtilMensagem.MensagemIcone.ERRO))
            {
                ObjIngrediente.Ativo = false;
                ObjIngrediente.alterar();

                btnAlterar.Hide();
                UtilButton.restaurar(btnExcluir);
                UtilForm.Disable(this);
            }
        }

        private void restaurar()
        {
            if (UtilMensagem.mostrarSimNao("Ingrediente", "Você deseja realmente restaurar este ingrediente?", UtilMensagem.MensagemIcone.OK))
            {
                ObjIngrediente.Ativo = true;
                ObjIngrediente.alterar();

                btnAlterar.Show();
                UtilButton.excluir(btnExcluir);
            }
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);
            uixButton.btnApply(btnExcluir, AppDesktop.VisualStyle.ButtonWarningColor);

            if (ObjIngrediente != null)
            {
                hdrUIX.Title = App.Name + " - Ingrediente " + ObjIngrediente.Cod;

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = ObjIngrediente.CodImagem
                }.obterPorCodigo();

                txtNome.Text = ObjIngrediente.Nome;
                txtValor.Text = ObjIngrediente.Valor.ToString();
                picImagem.ImageLocation = objArquivo.Local;

                int ingredienteEstoque = new clnEstoque
                {
                    CodMercadoria = ObjIngrediente.Cod
                }.obterQuantidadePorMercadoria();

                if (ObjIngrediente.Situacao == clnIngrediente.ingredienteSituacao.FORADEESTOQUE)
                {
                    cboSituacao.Enabled = false;
                    cboSituacao.add(clnIngrediente.ingredienteSituacao.FORADEESTOQUE);
                }
                else
                {
                    cboSituacao.addRange(new object[] { clnIngrediente.ingredienteSituacao.DISPONIVEL, clnIngrediente.ingredienteSituacao.INDISPONIVEL });
                }
                cboSituacao.Text = ObjIngrediente.Situacao.ToString();
                lblEstoque.Text = "Estoque: " + ingredienteEstoque;

                UtilForm.Disable(this);

                if (AppDesktop.FuncionarioAtual.CodCargo >= 3)
                {
                    btnExcluir.Show();
                    UtilButton.alterar(btnAlterar);
                    UtilButton.voltar(btnVoltar);
                    if (ObjIngrediente.Ativo)
                    {
                        UtilButton.excluir(btnExcluir);
                    }
                    else
                    {
                        btnAlterar.Hide();
                        UtilButton.restaurar(btnExcluir);
                    }
                }
            }
            else
            {
                hdrUIX.Title = App.Name + " - Novo Ingrediente";

                definirImagemPadrao();

                grbSituacao.Enabled = false;
                btnExcluir.Hide();
            }

            carregarTipos();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            abrirTipos();
        }

        private void btnImgRemover_Click(object sender, EventArgs e)
        {
            removerImagem();
        }

        private void btnImgAdicionar_Click(object sender, EventArgs e)
        {
            adicionarImagem();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
            {
                salvar();
            }
            else
            {
                UtilForm.Enable(this);
                grbImagem.Visible = false;

                UtilButton.cancelar(btnVoltar);
                UtilButton.salvar(btnAlterar);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ObjIngrediente.Ativo)
            {
                excluir();
            }
            else
            {
                restaurar();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }
    }
}
