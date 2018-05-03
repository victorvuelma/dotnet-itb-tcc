﻿using System;
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
    public partial class frmPedidoProduto : Form
    {

        private clnPedidoProduto _pedidoProduto;
        private bool _remover;

        public clnPedidoProduto PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public bool Remover { get => _remover; set => _remover = value; }

        public frmPedidoProduto()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        internal void abrirVisualizar()
        {
            uctPedidoProdutoVer uctVer = new uctPedidoProdutoVer();
            uctVer.Form = this;
            uctVer.PedidoProduto = PedidoProduto;

            alterarConteudo(uctVer, "Produto :: Visualizar");
        }

        internal void removerIngrediente(clnPedidoProdutoIngrediente pedidoIngrediente)
        {
            if (PedidoProduto.Ingredientes.Count > 1)
            {
                PedidoProduto.Ingredientes.Remove(pedidoIngrediente);

                abrirDetalhes();

                clnMensagem.mostrarOk("Produto", "Ingrediente removido do produto.", clnMensagem.MensagemIcone.ERRO);
            } else
            {
                PedidoProduto.Ingredientes.Remove(pedidoIngrediente);

                abrirDetalhes();

                clnMensagem.mostrarOk("Produto", "Você não pode remover o unico ingrediente do produto.", clnMensagem.MensagemIcone.ERRO);
            }
        }

        internal void adicionaIngrediente(clnPedidoProdutoIngrediente pedidoIngrediente)
        {
            PedidoProduto.Ingredientes.Add(pedidoIngrediente);

            abrirDetalhes();

            clnMensagem.mostrarOk("Produto", "Ingrediente adicionado com sucesso.", clnMensagem.MensagemIcone.OK);
        }

        internal void substiuiIngrediente(clnPedidoProdutoIngrediente pedidoIngredienteSubstituir, clnPedidoProdutoIngrediente pedidoIngrediente)
        {
            clnUtil.trocarValor(PedidoProduto.Ingredientes, pedidoIngredienteSubstituir, pedidoIngrediente);

            abrirDetalhes();

            clnMensagem.mostrarOk("Produto", "Ingrediente alterado com sucesso.", clnMensagem.MensagemIcone.OK);
        }

        private void abrirDetalhes()
        {
            uctPedidoProdutoDetalhes uctAlterar = new uctPedidoProdutoDetalhes();
            uctAlterar.PedidoProduto = PedidoProduto;
            uctAlterar.Form = this;

            alterarConteudo(uctAlterar, "Produto :: Alterar");

            PedidoProduto = uctAlterar.PedidoProduto;
        }

        private void fechar()
        {
            if (clnMensagem.mostrarSimNao("Produto", "Deseja cancelar as alterações realizadas no produto?", clnMensagem.MensagemIcone.INFO))
            {
                //Novo Pedido - Cancelado
                //Edicao - Sem alteracoes.
                PedidoProduto = null;
                Remover = false;

                Close();
            }
        }

        private void removerProduto()
        {
            if (clnMensagem.mostrarSimNao("Produto", "Deseja realmente remover esse produto do produto?", clnMensagem.MensagemIcone.ERRO))
            {
                PedidoProduto = null;
                Remover = true;

                //faz e tal
                Close();
            }
        }

        private void frmPedidoProduto_Load(object sender, EventArgs e)
        {
            clnApp.AppVisualTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnRemover, clnApp.AppVisualStyle.WarningButtonColor);

            abrirVisualizar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            abrirVisualizar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            abrirDetalhes();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            removerProduto();
        }

    }
}