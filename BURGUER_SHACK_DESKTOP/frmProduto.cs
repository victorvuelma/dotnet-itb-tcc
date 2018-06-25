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
    public partial class frmProduto : Form
    {

        private clnUtilValidar _validar;

        private clnProduto _objProduto;
        private List<clnProdutoIngrediente> _objProdutoIngredientes;

        public clnProduto ObjProduto { get => _objProduto; set => _objProduto = value; }
        public List<clnProdutoIngrediente> ObjProdutoIngredientes { get => _objProdutoIngredientes; set => _objProdutoIngredientes = value; }

        public frmProduto()
        {
            InitializeComponent();

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtNome, clnUtilValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(txtValor, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.VALOR });
            _validar.addValidacao(cboTipo, clnUtilValidar.ValidarTipo.OBRIGATORIO);
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
            if (clnUtilMensagem.mostrarSimNao("Produto", "Deseja realmente remover a imagem?", clnUtilMensagem.MensagemIcone.INFO))
            {
                definirImagemPadrao();
            }
        }

        private void definirImagemPadrao()
        {
            picImagem.ImageLocation = clnArquivo.tempImage(Properties.Resources.produto);
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
            if (_validar.valido())
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
                        CodTipo = clnUtilConvert.ToInt(cboTipo.Text.Split('-')[0]),
                        CodImagem = objArquivo.Cod,
                        Valor = clnUtilConvert.ToDouble(txtValor.Text),
                        Descricao = txtDesc.Text
                    };
                    ObjProduto.gravar();

                    foreach (clnProdutoIngrediente objProdutoIngrediente in ObjProdutoIngredientes)
                    {
                        objProdutoIngrediente.CodProduto = ObjProduto.Cod;
                        objProdutoIngrediente.gravar();
                    }

                    ObjProduto.atualizarEstoque();

                    clnUtilMensagem.mostrarOk("Cadastro de Produto", "Produto cadastrado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
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
                    ObjProduto.CodTipo = clnUtilConvert.ToInt(cboTipo.Text.Split('-')[0]);
                    ObjProduto.Nome = txtNome.Text;
                    ObjProduto.Valor = clnUtilConvert.ToDouble(txtValor.Text);
                    ObjProduto.Descricao = txtDesc.Text;
                    ObjProduto.Situacao = (clnProduto.produtoSituacao)Enum.Parse(typeof(clnProduto.produtoSituacao), cboSituacao.Text);

                    ObjProduto.alterar();

                    ObjProduto.atualizarEstoque();

                    clnUtilMensagem.mostrarOk("Altereção de Produto", "Produto alterado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
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
            cboTipo.Items.Clear();

            foreach (clnTipo objTipo in new clnTipo { Tipo = clnTipo.tipo.PRODUTO }.obterTipos())
            {
                String nome = objTipo.Cod + " - " + objTipo.Nome;
                cboTipo.Items.Add(nome);
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
                if (clnUtilMensagem.mostrarSimNao("Cadastro de Produto", "Deseja cancelar o cadastro?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (clnUtilMensagem.mostrarSimNao("Alteração de Produto", "Deseja cancelar as alterações?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
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
                CallbackClick = new CallbackAdicionar(),
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
                    CallbackClick = new CallbackRemover()
                };

                frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
                {
                    ObjVisualizar = objVisualizar
                };
                frmVisualizar.ShowDialog();
            }
            else if (clnUtilMensagem.mostrarSimNao("Produto", "Este produto não conta com ingredientes, deseja adicionar?", clnUtilMensagem.MensagemIcone.INFO))
            {
                adicionarIngrediente();
            }
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            UIX.uixButton.btnApply(btnVoltar, App.VisualStyle.ButtonWarningColor);
            UIX.uixButton.btnApply(btnExcluir, App.VisualStyle.ButtonWarningColor);

            if (ObjProduto != null)
            {
                hdrUIX.Title = App.Name + " - Alterando Produto " + ObjProduto.Cod;

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
                    cboSituacao.Items.Add(clnUtilConvert.ToString(clnProduto.produtoSituacao.FORADEESTOQUE));
                }
                else
                {
                    cboSituacao.Items.AddRange(new String[] { clnUtilConvert.ToString(clnProduto.produtoSituacao.DISPONIVEL), clnUtilConvert.ToString(clnProduto.produtoSituacao.INDISPONIVEL) });
                }
                cboSituacao.Text = ObjProduto.Situacao.ToString();
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

        private void btnIngredienteAdd_Click(object sender, EventArgs e)
        {
            adicionarIngrediente();
        }

        private void btnIngredienteRemover_Click(object sender, EventArgs e)
        {
            exibirIngredientes();
        }

        private class CallbackRemover : clnUtilCallback<clnUtilVisualizar, clnProdutoIngrediente>
        {

            public bool call(clnUtilVisualizar objVisualizar, clnProdutoIngrediente objProdutoIngrediente)
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
                }
                return false;
            }
        }

        private class CallbackAdicionar : clnUtilCallback<frmProduto, clnIngrediente>
        {

            public bool call(frmProduto frmProduto, clnIngrediente objIngrediente)
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
                    clnUtilMensagem.mostrarOk("Produto", "Ingrediente adicionado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                    return true;
                }
                return false;
            }
        }

    }
}
