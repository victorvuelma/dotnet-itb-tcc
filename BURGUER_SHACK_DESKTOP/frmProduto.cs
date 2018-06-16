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
            _validar.addValidacao(txtValor, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.DOUBLE });
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
            picImagem.ImageLocation = clnArquivo.tempImage(global::BURGUER_SHACK_DESKTOP.Properties.Resources.produto);
        }

        private void adicionarImagem()
        {
            OpenFileDialog objDialog = new OpenFileDialog();
            objDialog.Filter = "png|*.png";
            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                picImagem.ImageLocation = objDialog.FileName;
            }
        }

        private void salvar()
        {
            if (_validar.valido())
            {
                if (ObjProduto == null)
                {
                    clnArquivo objArquivo = new clnArquivo
                    {
                        Local = picImagem.ImageLocation
                    };
                    objArquivo.gravar();

                    ObjProduto = new clnProduto
                    {
                        Situacao = clnProduto.produtoSituacao.FORADEESTOQUE,
                        Nome = txtNome.Text,
                        CodTipo = clnUtilConvert.ToInt(cboTipo.Text.Split('-')[0]),
                        CodImagem = objArquivo.Cod,
                        Valor = clnUtilConvert.ToDouble(txtValor.Text)
                    };

                    ObjProduto.gravar();

                    foreach (clnProdutoIngrediente objProdutoIngrediente in ObjProdutoIngredientes)
                    {
                        objProdutoIngrediente.CodProduto = ObjProduto.Cod;
                        objProdutoIngrediente.gravar();
                    }
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
                    ObjProduto.Situacao = (clnProduto.produtoSituacao)Enum.Parse(typeof(clnProduto.produtoSituacao), cboSituacao.Text);

                    ObjProduto.alterar();
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

            foreach (clnTipo objTipo in new clnTipo { Tipo = clnTipo.tipo.PRODUTO }.obter())
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

            clnIngrediente.clnSelecionar objSelecionar = new clnIngrediente.clnSelecionar
            {
                Opcoes = objIngredientes,
                Titulo = "Selecione um ingrediente",
                Icone = Properties.Resources.ingrediente
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
            {
                ObjSelecionar = objSelecionar
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                clnProdutoIngrediente objProdutoIngrediente = new clnProdutoIngrediente
                {
                    Cod = -1,
                    Alterar = true,
                    Remover = true,
                    CodIngrediente = objSelecionar.Selecionado.Cod,
                    CodProduto = ObjProduto.Cod,
                    Quantidade = 1
                };
                frmProdutoIngrediente frmProdutoIngrediente = new frmProdutoIngrediente
                {
                    ObjProdutoIngrediente = objProdutoIngrediente
                };
                frmProdutoIngrediente.ShowDialog();
                if (frmProdutoIngrediente.ObjProdutoIngrediente != null)
                {
                    if (ObjProduto.Cod == -1)
                    {
                        ObjProdutoIngredientes.Add(objProdutoIngrediente);
                    }
                    else
                    {
                        objProdutoIngrediente.gravar();
                    }
                    clnUtilMensagem.mostrarOk("Produto", "Ingrediente adicionado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                }
            }
        }

        private void verIngredientes()
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

            clnProdutoIngrediente.clnVisualizar objVisualizar = new clnProdutoIngrediente.clnVisualizar
            {
                Opcoes = objProdutoIngredientes,
                Icone = Properties.Resources.ingrediente,
                Titulo = "Selecione um ingrediente"
            };

            frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
            {
                ObjVisualizar = objVisualizar
            };

        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            UIX.uixButton.btnApply(btnVoltar, App.AppVisualStyle.ButtonWarningColor);
            UIX.uixButton.btnApply(btnExcluir, App.AppVisualStyle.ButtonWarningColor);
            clnUtil.atualizarTabIndex(Controls);

            if (ObjProduto != null)
            {
                hdrUIX.Title = App.AppName + " - Alterando Produto " + ObjProduto.Cod;

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = ObjProduto.CodImagem
                }.obterPorCodigo();

                txtNome.Text = ObjProduto.Nome;
                txtValor.Text = ObjProduto.Valor.ToString();
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
                ObjProduto = new clnProduto
                {
                    Cod = -1
                };
                ObjProdutoIngredientes = new List<clnProdutoIngrediente>();

                hdrUIX.Title = App.AppName + " - Novo Produto";

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
            verIngredientes();
        }

    }
}
