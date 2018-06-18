﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIX;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmGerenciamento : Form
    {
        public frmGerenciamento()
        {
            InitializeComponent();
        }

        private void alterarConteudo(UserControl uctConteudo, String titulo, bool ignorarTipo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, "Gerenciamento :: " + titulo, ignorarTipo);
        }

        private void abrirLista(String tipo, clnUtilCallback callbackNovo, clnUtilCallback<DataGridView, String> callbackObter, clnUtilCallback<DataGridViewRow> callbackAlterar, String[] colunas)
        {
            uctGerenciamentoListar objListar = new uctGerenciamentoListar
            {
                CallbackNovo = callbackNovo,
                Colunas = colunas,
                CallbackObter = callbackObter,
                CallbackAlterar = callbackAlterar
            };
            alterarConteudo(objListar, tipo, true);
        }

        private void abrirIngredientes()
        {
            abrirLista("Ingredientes", new CallbackIngredienteNovo(), new CallbackIngredienteObter(), new CallbackIngredienteAlterar(), new String[] { "Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor" });
        }

        private void abrirProdutos()
        {
            abrirLista("Produtos", new CallbackProdutoNovo(), new CallbackProdutoObter(), new CallbackProdutoAlterar(), new String[] { "Código", "Nome", "Situacao", "Tipo", "Valor" });
        }

        private void sair()
        {

        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnSair, App.AppVisualStyle.ButtonWarningColor);
            hdrUIX.Title = App.AppName + " - Gerenciamento";

            abrirIngredientes();
        }
        private void hdrUIX_Close(object sender, EventArgs e)
        {
            sair();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            abrirIngredientes();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            abrirProdutos();
        }

        private class CallbackIngredienteNovo : clnUtilCallback
        {
            public bool call()
            {
                frmIngrediente frmNovoIngrediente = new frmIngrediente { };
                frmNovoIngrediente.ShowDialog();
                return frmNovoIngrediente.ObjIngrediente != null;
            }
        }

        private class CallbackIngredienteAlterar : clnUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = clnUtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCodigo();

                if (objIngrediente != null)
                {
                    frmIngrediente frmAlterarIngrediente = new frmIngrediente
                    {
                        ObjIngrediente = objIngrediente
                    };
                    frmAlterarIngrediente.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackIngredienteObter : clnUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                clnIngrediente objIngredientes = new clnIngrediente
                {
                    Nome = pesquisa
                };
                foreach (clnIngrediente objIngrediente in objIngredientes.obterPorNome())
                {
                    clnTipo objTipo = new clnTipo
                    {
                        Cod = objIngrediente.CodTipo,
                        Tipo = clnTipo.tipo.INGREDIENTE
                    }.obterPorCodigo();

                    int estoque = 0;

                    //"Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor"
                    dgv.Rows.Add(new object[] { objIngrediente.Cod, objIngrediente.Nome, objIngrediente.Situacao, objTipo.Cod + " - " + objTipo.Nome, estoque, objIngrediente.Valor });
                }
                return false;
            }
        }

        private class CallbackProdutoNovo : clnUtilCallback
        {
            public bool call()
            {
                frmProduto frmNovoProduto = new frmProduto { };
                frmNovoProduto.ShowDialog();
                return frmNovoProduto.ObjProduto != null;
            }
        }

        private class CallbackProdutoAlterar : clnUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnProduto objProduto = new clnProduto
                {
                    Cod = clnUtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCodigo();

                if (objProduto != null)
                {
                    frmProduto frmAlterarProduto = new frmProduto
                    {
                        ObjProduto = objProduto
                    };
                    frmAlterarProduto.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackProdutoObter : clnUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                clnProduto objProdutos = new clnProduto
                {
                    Nome = pesquisa
                };
                foreach (clnProduto objProduto in objProdutos.obterPorNome())
                {
                    clnTipo objTipo = new clnTipo
                    {
                        Cod = objProduto.CodTipo,
                        Tipo = clnTipo.tipo.INGREDIENTE
                    }.obterPorCodigo();

                    //"Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor"
                    dgv.Rows.Add(new object[] { objProduto.Cod, objProduto.Nome, objProduto.Situacao, objTipo.Cod + " - " + objTipo.Nome, objProduto.Valor });
                }
                return false;
            }
        }

    }
}
