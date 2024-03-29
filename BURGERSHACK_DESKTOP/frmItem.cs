﻿using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public partial class frmItem : Form
    {
        private clnUtilFormValidar _validar;

        private clnItem _objItem;
        private List<clnItemIngrediente> _objIngredientes;

        public clnItem ObjItem { get => _objItem; set => _objItem = value; }
        public List<clnItemIngrediente> ObjItemIngredientes { get => _objIngredientes; set => _objIngredientes = value; }

        public frmItem()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.INT, clnUtilFormValidar.Validacao.QUANTIDADE });
        }

        private List<clnItemIngrediente> obterIngredientes()
        {
            if (ObjItem == null || ObjItem.CodPedido == -1)
            {
                return ObjItemIngredientes;
            }
            else
            {
                return new clnItemIngrediente
                {
                    CodItem = ObjItem.Cod
                }.obterPorItem();
            }
        }

        private void fechar()
        {
            if (UtilMensagem.mostrarSimNao("Item", "Deseja cancelar as alterações realizadas no item?", UtilMensagem.MensagemIcone.INFO))
            {
                Close();
            }
        }

        private void abrirIngredientes()
        {
            List<clnItemIngrediente> objItemIngredientes = obterIngredientes();

            clnProduto objProduto = new clnProduto
            {
                Cod = ObjItem.CodProduto
            }.obterPorCod();

            if (objItemIngredientes.Count > 0)
            {
                clnItemIngrediente.clnListar objListar = new clnItemIngrediente.clnListar
                {
                    Opcoes = objItemIngredientes,
                    Icone = Properties.Resources.ingrediente,
                    Titulo = "Selecione um Ingrediente"
                };

                clnUtilVisualizar<frmItem, clnItemIngrediente> objVisualizar = new clnUtilVisualizar<frmItem, clnItemIngrediente>
                {
                    ObjListar = objListar,
                    Callback = new CallbackAlterar(),
                    Obj = this
                };

                frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
                {
                    ObjVisualizar = objVisualizar
                };
                frmVisualizar.ShowDialog();
            }
            else if (UtilMensagem.mostrarSimNao("Item", "Não foi encontrado nenhum ingrediente, deseja adicionar?", UtilMensagem.MensagemIcone.OK))
            {
                abrirAdicionarIngrediente();
            }
        }

        private void exibirProduto(clnProduto objProduto, clnItem objItem)
        {
            clnArquivo objArquivo = new clnArquivo
            {
                Cod = objProduto.CodImagem
            }.obterPorCod();

            picProduto.ImageLocation = objArquivo.Local;
            lblProdutoNome.Text = objProduto.Nome;
            txtQuantidade.Text = Convert.ToString(objItem.Quantidade);
            txtAdicional.Text = objItem.Adicional;
        }

        private void abrirAdicionarIngrediente()
        {
            clnIngrediente objIngredientes = new clnIngrediente();

            clnIngrediente.clnListar objListar = new clnIngrediente.clnListar
            {
                Opcoes = objIngredientes.obterIngredientes(),
                Titulo = "Adicionar um Ingrediente",
                Icone = Properties.Resources.ingrediente
            };
            clnUtilSelecionar<clnIngrediente> objSelecionar = new clnUtilSelecionar<clnIngrediente>
            {
                ObjListar = objListar,
                Quantidade = UtilConvert.ToInt(txtQuantidade.Text)
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
            {
                ObjSelecionar = objSelecionar
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                clnItemIngrediente objItemIngrediente = new clnItemIngrediente
                {
                    Quantidade = objSelecionar.Quantidade,
                    CodIngrediente = objSelecionar.Selecionado.Cod,
                    CodItem = ((ObjItem != null) ? ObjItem.Cod : -1)
                };
                if (objItemIngrediente.CodItem != -1)
                {
                    clnUtilPedido.adicionarIngrediente(ObjItem, objItemIngrediente);
                }
                else
                {
                    clnUtilPedido.adicionarIngrediente(ObjItemIngredientes, objItemIngrediente);
                }

                UtilMensagem.mostrarOk("Ingrediente", "Ingrediente adicionado com sucesso!");
            }
        }

        private void removerItem()
        {
            if (UtilMensagem.mostrarSimNao("Pedido", "Deseja realmente remover esse item do pedido?", UtilMensagem.MensagemIcone.INFO))
            {
                if (ObjItem != null && ObjItem.Cod != -1)
                {
                    ObjItem.remover();
                }
                ObjItem = null;

                Close();
            }
        }

        private void frmPedidoProduto_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnRemover, AppDesktop.VisualStyle.ButtonWarningColor);

            hdrUIX.Title = App.Name + " - Pedido :: Alterando Item " + ObjItem.Cod;

            clnProduto objProduto = new clnProduto
            {
                Cod = ObjItem.CodProduto
            }.obterPorCod();

            exibirProduto(objProduto, ObjItem);

            if (objProduto.CodMercadoria != null)
            {
                grbIngredientes.Hide();
            }

            txtQuantidade.Focus();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            abrirIngredientes();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            removerItem();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_validar.validar(this))
            {
                ObjItem.Quantidade = UtilConvert.ToInt(txtQuantidade.Text);
                ObjItem.Adicional = txtAdicional.Text;

                if (ObjItem != null && ObjItem.Cod != -1)
                {
                    ObjItem.alterar();
                }

                Close();
            }
        }

        private void btnIngredienteAdd_Click(object sender, EventArgs e)
        {
            abrirAdicionarIngrediente();
        }

        private class CallbackAlterar : clnUtilVisualizar.IVisualizarCallback<frmItem, clnItemIngrediente>
        {
            public clnUtilVisualizar.VisualizarResult call(frmItem frmItem, clnItemIngrediente objItemIngrediente)
            {
                clnProdutoIngrediente objProdutoIngrediente = null;
                if (objItemIngrediente.CodProdutoIngrediente != null)
                {
                    objProdutoIngrediente = new clnProdutoIngrediente
                    {
                        Cod = (int)objItemIngrediente.CodProdutoIngrediente
                    }.obterPorCod();
                }

                if (objProdutoIngrediente == null || objProdutoIngrediente.Alterar || objProdutoIngrediente.Remover)
                {
                    frmItemIngrediente frmIngrediente = new frmItemIngrediente
                    {
                        ObjItemIngrediente = objItemIngrediente
                    };
                    frmIngrediente.btnAlterar.Visible = objProdutoIngrediente == null || objProdutoIngrediente.Alterar;
                    frmIngrediente.btnRemover.Visible = objProdutoIngrediente == null || objProdutoIngrediente.Remover;
                    frmIngrediente.ShowDialog();

                    if (frmIngrediente.ObjItemIngrediente == null)
                    {
                        if (objItemIngrediente.CodItem != -1)
                        {
                            objItemIngrediente.remover();
                        }
                        frmItem.ObjItemIngredientes.Remove(objItemIngrediente);
                    }
                    else
                    {
                        if (objItemIngrediente.CodItem != -1)
                        {
                            if (frmIngrediente.ObjItemIngrediente.CodIngrediente != objItemIngrediente.CodIngrediente)
                            {
                                objItemIngrediente.remover();
                                frmIngrediente.ObjItemIngrediente.gravar();
                            }
                            else
                            {
                                frmIngrediente.ObjItemIngrediente.CodProdutoIngrediente = objItemIngrediente.CodIngrediente;
                                frmIngrediente.ObjItemIngrediente.alterar();
                            }
                        }
                        clnUtil.listTrocar(frmItem.ObjItemIngredientes, objItemIngrediente, frmIngrediente.ObjItemIngrediente);
                    }
                }
                else
                {
                    UtilMensagem.mostrarOk("Ingredientes", "Esse ingrediente não pode ser alterado ou removido.");
                }
                return clnUtilVisualizar.VisualizarResult.FECHAR;
            }
        }
    }
}
