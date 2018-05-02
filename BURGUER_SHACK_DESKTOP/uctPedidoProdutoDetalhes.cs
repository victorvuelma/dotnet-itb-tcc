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
    public partial class uctPedidoProdutoDetalhes : UserControl
    {
        
        private frmPedidoProduto _frm;
        private clnPedidoProduto _objPedidoProduto;
        
        public frmPedidoProduto Frm { get => _frm; set => _frm = value; }
        public clnPedidoProduto ObjPedidoProduto { get => _objPedidoProduto; set => _objPedidoProduto = value; }

        public uctPedidoProdutoDetalhes()
        {
            InitializeComponent();

            clnUtil.atualizarTabIndex(Controls);

            dgvIngredientes.Rows.Add("Ingrediente 1",1);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Frm.abrirVisualizar();
        }

        private void dgvIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uctPedidoProdutoIngrediente alterarIngrediente = new uctPedidoProdutoIngrediente();

            alterarIngrediente.Frm = Frm;

            Frm.alterarConteudo(alterarIngrediente, "Produto :: Alterar Ingrediente");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            uctPedidoProdutoIngrediente adicionarIngrediente = new uctPedidoProdutoIngrediente();

            adicionarIngrediente.Frm = Frm;
            adicionarIngrediente.btnAlterar.Visible = false;
            adicionarIngrediente.btnRemover.Visible = false;
            adicionarIngrediente.grbIngrediente.Visible = false;
            adicionarIngrediente.txtQuantidade.Text = "1";

            Frm.alterarConteudo(adicionarIngrediente, "Produto :: Adicionar Ingrediente");
        }
    }
}
