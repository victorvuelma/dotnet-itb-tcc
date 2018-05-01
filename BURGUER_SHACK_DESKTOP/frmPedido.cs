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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            clnTemplate.CommonTemplate.frmApply(this, uctUIX);

            UIX.uixButton.btnApply(btnSair, clnTemplate.CommonTemplate.Style.WarningButtonColor);

            abrirProdutos();
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, uctUIX, titulo);
        }

        private void abrirProdutos()
        {
            alterarConteudo(new uctPedidoProdutos(), "Pedido :: Produtos"); 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void uctUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void fechar()
        {
            if(clnMensagem.mostrarSimNao("Pedido","Deseja cancelar o pedido?", clnMensagem.MSG_ERRO))
            {
                Close();
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            abrirProdutos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            alterarConteudo(new uctPedidoAdicionar(), "Add");
        }
    }
}
