using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class uctPedidoAdicionar : UserControl
    {

        private int _mesa;

        private int _produtoTipo;
        private int _produtoCodigo;

        public int Mesa { get => _mesa; set => _mesa = value; }

        public uctPedidoAdicionar()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);

            grbProduto.Hide();
            esconderDetalhes();
        }

        private void selecionaTipo(int tipo)
        {
            _produtoTipo = tipo;

            clnUtil.resetarCampos(grbProduto.Controls);
            grbProduto.Show();

            esconderDetalhes();
        }

        private void selecionaProduto(int produto)
        {
            _produtoCodigo = produto;

            clnUtil.resetarCampos(grbDetalhes.Controls);
            grbDetalhes.Show();

            clnUtil.resetarCampos(grbAdicional.Controls);
            grbAdicional.Show();
        }

        private void esconderDetalhes()
        { 
            grbDetalhes.Hide();
            grbAdicional.Hide();
        }

        private void btnLanche_Click(object sender, EventArgs e)
        {
            selecionaTipo(1);
        }

        private void btnAcompanhamento_Click(object sender, EventArgs e)
        {
            selecionaTipo(2);
        }

        private void btnBebida_Click(object sender, EventArgs e)
        {
            selecionaTipo(3);
        }

        private void btnSobremesa_Click(object sender, EventArgs e)
        {
            selecionaTipo(4);
        }
    }
}
