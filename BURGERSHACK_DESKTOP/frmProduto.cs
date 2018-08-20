using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop
{
    public partial class frmProduto : Form
    {

        private clnUtilFormValidar _validar;

        private clnProduto _objProduto;
        private List<clnProdutoIngrediente> _objProdutoIngredientes;

        public clnProduto ObjProduto { get => _objProduto; set => _objProduto = value; }
        public List<clnProdutoIngrediente> ObjProdutoIngredientes { get => _objProdutoIngredientes; set => _objProdutoIngredientes = value; }

        public frmProduto()
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
                Tipo = clnTipo.tipo.PRODUTO
            };
            frmTipo.ShowDialog();

            carregarTipos();
            if (frmTipo.ObjTipo != null)
                definirTipo(frmTipo.ObjTipo);
        }

        private void removerImagem()
        {
            if (UtilMensagem.mostrarSimNao("Produto", "Deseja realmente remover a imagem?", UtilMensagem.MensagemIcone.INFO))
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
                if (ObjProduto.Cod == -1)
                {
                    clnArquivo objArquivo = new clnArquivo
                    {
                        Local = picImagem.ImageLocation
                    };
                    objArquivo.gravar();

                    ObjProduto = new clnProduto
                    {
                        Situacao = ((ObjProdutoIngredientes.Count == 0) ? clnProduto.produtoSituacao.DISPONIVEL : clnProduto.produtoSituacao.FORADEESTOQUE),
                        Nome = txtNome.Text,
                        CodTipo = cboTipo.SelectedItem.Id,
                        CodImagem = objArquivo.Cod,
                        Valor = UtilConvert.ToDecimal(txtValor.Text),
                        Descricao = txtDesc.Text
                    };
                    ObjProduto.gravar();

                    foreach (clnProdutoIngrediente objProdutoIngrediente in ObjProdutoIngredientes)
                    {
                        objProdutoIngrediente.CodProduto = ObjProduto.Cod;
                        objProdutoIngrediente.gravar();
                    }

                    ObjProduto.atualizarEstoque();

                    UtilMensagem.mostrarOk("Cadastro de Produto", "Produto cadastrado com sucesso!");
                }
                else
                {
                    clnArquivo objArquivo = new clnArquivo
                    {
                        Cod = ObjProduto.CodImagem
                    }.obterPorCodigo();

                    if (!objArquivo.Local.Equals(picImagem.ImageLocation))
                    {
                        objArquivo = new clnArquivo
                        {
                            Local = picImagem.ImageLocation
                        };
                        objArquivo.gravar();
                        ObjProduto.CodImagem = objArquivo.Cod;
                    }
                    ObjProduto.CodTipo = UtilConvert.ToInt(cboTipo.Text.Split('-')[0]);
                    ObjProduto.Nome = txtNome.Text;
                    ObjProduto.Valor = UtilConvert.ToDecimal(txtValor.Text);
                    ObjProduto.Descricao = txtDesc.Text;
                    ObjProduto.Situacao = (clnProduto.produtoSituacao)Enum.Parse(typeof(clnProduto.produtoSituacao), cboSituacao.Text);

                    ObjProduto.alterar();

                    ObjProduto.atualizarEstoque();

                    UtilMensagem.mostrarOk("Altereção de Produto", "Produto alterado com sucesso!");
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

            foreach (clnTipo objTipo in new clnTipo { Tipo = clnTipo.tipo.PRODUTO }.obterTipos())
            {
                cboTipo.add(objTipo.Cod, objTipo.Cod + " - " + objTipo.Nome);
                if (ObjProduto != null && ObjProduto.CodTipo.Equals(objTipo.Cod))
                {
                    definirTipo(objTipo);
                }
            }
        }

        private void fechar()
        {
            if (ObjProduto.Cod == -1)
            {
                if (UtilMensagem.mostrarSimNao("Cadastro de Produto", "Deseja cancelar o cadastro?", UtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (btnAlterar.Text == "Salvar")
                {
                    if (UtilMensagem.mostrarSimNao("Alteração de Produto", "Deseja cancelar as alterações?", UtilMensagem.MensagemIcone.ERRO))
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
            if (UtilMensagem.mostrarSimNao("Produto", "Você deseja realmente excluir este produto?", UtilMensagem.MensagemIcone.ERRO))
            {
                ObjProduto.Ativo = false;
                ObjProduto.alterar();

                btnAlterar.Hide();
                UtilButton.restaurar(btnExcluir);
                UtilForm.Disable(this);
                grbIngredientes.Visible = false;
                grbImagem.Visible = false;
            }
        }

        private void restaurar()
        {
            if (UtilMensagem.mostrarSimNao("Produto", "Você deseja realmente restaurar este produto?", UtilMensagem.MensagemIcone.OK))
            {
                ObjProduto.Ativo = true;
                ObjProduto.alterar();

                btnAlterar.Show();
                UtilButton.excluir(btnExcluir);
            }
        }

        private void adicionarIngrediente()
        {
            List<clnIngrediente> objIngredientes = new clnIngrediente().obterIngredientes();

            if (ObjProduto.Cod != -1)
            {
                List<clnProdutoIngrediente> objProdutoIngredientes = new clnProdutoIngrediente
                {
                    CodProduto = ObjProduto.Cod
                }.obterPorProduto();

                foreach (clnProdutoIngrediente objProdutoIngrediente in objProdutoIngredientes)
                {
                    objIngredientes.RemoveAll(objIngrediente => objProdutoIngrediente.CodIngrediente.Equals(objIngrediente.Cod));
                }
            }
            else
            {
                foreach (clnProdutoIngrediente objProdutoIngrediente in ObjProdutoIngredientes)
                {
                    objIngredientes.RemoveAll(objIngrediente => objProdutoIngrediente.CodIngrediente.Equals(objIngrediente.Cod));
                }
            }

            clnIngrediente.clnListar objListar = new clnIngrediente.clnListar
            {
                Opcoes = objIngredientes,
                Titulo = "Adicionar um Ingrediente",
                Icone = Properties.Resources.ingrediente
            };
            clnUtilVisualizar<frmProduto, clnIngrediente> objVisualizar = new clnUtilVisualizar<frmProduto, clnIngrediente>
            {
                Obj = this,
                Callback = new CallbackAdicionar(),
                ObjListar = objListar
            };

            frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
            {
                ObjVisualizar = objVisualizar
            };
            frmVisualizar.ShowDialog();
        }

        private void exibirIngredientes()
        {
            List<clnProdutoIngrediente> objProdutoIngredientes = null;
            if (ObjProduto.Cod == -1)
            {
                objProdutoIngredientes = ObjProdutoIngredientes;
            }
            else
            {
                objProdutoIngredientes = new clnProdutoIngrediente
                {
                    CodProduto = ObjProduto.Cod
                }.obterPorProduto();
            }

            if (objProdutoIngredientes.Count > 0)
            {
                clnProdutoIngrediente.clnListar objListar = new clnProdutoIngrediente.clnListar
                {
                    Opcoes = objProdutoIngredientes,
                    Icone = Properties.Resources.ingrediente,
                    Titulo = "Selecione o Ingrediente",
                };

                clnUtilVisualizar objVisualizar = new clnUtilVisualizar<clnUtilVisualizar, clnProdutoIngrediente>
                {
                    ObjListar = objListar,
                    Callback = new CallbackVisualizar()
                };

                frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
                {
                    ObjVisualizar = objVisualizar
                };
                frmVisualizar.ShowDialog();
            }
            else if (UtilMensagem.mostrarSimNao("Produto", "Este produto não conta com ingredientes, deseja adicionar?", UtilMensagem.MensagemIcone.INFO))
            {
                adicionarIngrediente();
            }
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);
            uixButton.btnApply(btnExcluir, AppDesktop.VisualStyle.ButtonWarningColor);

            if (ObjProduto != null)
            {
                hdrUIX.Title = App.Name + " - Produto " + ObjProduto.Cod;

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = ObjProduto.CodImagem
                }.obterPorCodigo();

                txtNome.Text = ObjProduto.Nome;
                txtValor.Text = ObjProduto.Valor.ToString();
                txtDesc.Text = ObjProduto.Descricao;
                picImagem.ImageLocation = objArquivo.Local;

                if (ObjProduto.Situacao == clnProduto.produtoSituacao.FORADEESTOQUE)
                {
                    cboSituacao.Enabled = false;
                    cboSituacao.add(clnProduto.produtoSituacao.FORADEESTOQUE);
                }
                else
                {
                    cboSituacao.addRange(new object[] { clnProduto.produtoSituacao.DISPONIVEL, clnProduto.produtoSituacao.INDISPONIVEL });
                }
                cboSituacao.Text = ObjProduto.Situacao.ToString();

                UtilForm.Disable(this);
                grbIngredientes.Visible = false;
                grbImagem.Visible = false;

                if (AppDesktop.FuncionarioAtual.CodCargo >= 3)
                {
                    btnExcluir.Show();
                    UtilButton.alterar(btnAlterar);
                    UtilButton.voltar(btnVoltar);
                    if (ObjProduto.Ativo)
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
                ObjProduto = new clnProduto();
                ObjProdutoIngredientes = new List<clnProdutoIngrediente>();

                hdrUIX.Title = App.Name + " - Novo Produto";

                definirImagemPadrao();

                cboSituacao.Hide();
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
            if (btnAlterar.Text.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
            {
                salvar();
            }
            else
            {
                UtilForm.Enable(this);
                grbImagem.Visible = true;
                grbIngredientes.Visible = true;

                UtilButton.cancelar(btnVoltar);
                UtilButton.salvar(btnAlterar);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ObjProduto.Ativo)
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

        private void btnIngredienteAdd_Click(object sender, EventArgs e)
        {
            adicionarIngrediente();
        }

        private void btnIngredienteRemover_Click(object sender, EventArgs e)
        {
            exibirIngredientes();
        }

        private class CallbackVisualizar : clnUtilVisualizar.IVisualizarCallback<clnUtilVisualizar, clnProdutoIngrediente>
        {

            public clnUtilVisualizar.VisualizarResult call(clnUtilVisualizar objVisualizar, clnProdutoIngrediente objProdutoIngrediente)
            {
                frmProdutoIngrediente frmProdutoIngrediente = new frmProdutoIngrediente
                {
                    ObjProdutoIngrediente = objProdutoIngrediente
                };
                frmProdutoIngrediente.ShowDialog();
                if (frmProdutoIngrediente.ObjProdutoIngrediente != null)
                {
                    frmProdutoIngrediente.ObjProdutoIngrediente.alterar();
                }
                else
                {
                    objProdutoIngrediente.remover();
                    objVisualizar.ObjListar.getOpcoes().Remove(objProdutoIngrediente);
                    return clnUtilVisualizar.VisualizarResult.REMOVER;
                }
                return clnUtilVisualizar.VisualizarResult.FECHAR;
            }
        }

        private class CallbackAdicionar : clnUtilVisualizar.IVisualizarCallback<frmProduto, clnIngrediente>
        {

            public clnUtilVisualizar.VisualizarResult call(frmProduto frmProduto, clnIngrediente objIngrediente)
            {
                clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                {
                    Alterar = true,
                    Remover = true,
                    Quantidade = 1,
                    CodIngrediente = objIngrediente.Cod,
                    CodProduto = frmProduto.ObjProduto.Cod
                };
                frmProdutoIngrediente frmProdutoIngrediente = new frmProdutoIngrediente
                {
                    ObjProdutoIngrediente = objProdutoIngrediente
                };
                frmProdutoIngrediente.ShowDialog();
                if (frmProdutoIngrediente.ObjProdutoIngrediente != null)
                {
                    if (frmProduto.ObjProduto.Cod == -1)
                    {
                        frmProduto.ObjProdutoIngredientes.Add(objProdutoIngrediente);
                    }
                    else
                    {
                        objProdutoIngrediente.gravar();
                    }
                    UtilMensagem.mostrarOk("Produto", "Ingrediente adicionado com sucesso!");
                    return clnUtilVisualizar.VisualizarResult.REMOVER;
                }
                return clnUtilVisualizar.VisualizarResult.NENHUM;
            }
        }

    }
}
