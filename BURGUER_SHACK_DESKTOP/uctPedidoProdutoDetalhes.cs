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
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //valida quantidade
            ObjPedidoProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            Frm.abrirVisualizar();
        }

        private void dgvIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uctPedidoProdutoIngrediente alterarIngrediente = new uctPedidoProdutoIngrediente();

            alterarIngrediente.Frm = Frm;
            alterarIngrediente.PedidoIngrediente = ObjPedidoProduto.Ingredientes[e.RowIndex];

            Frm.alterarConteudo(alterarIngrediente, "Produto :: Alterar Ingrediente");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            uctPedidoProdutoIngrediente adicionarIngrediente = new uctPedidoProdutoIngrediente();

            adicionarIngrediente.Frm = Frm;
            adicionarIngrediente.btnRemover.Visible = false;
            adicionarIngrediente.grbIngrediente.Visible = false;
            adicionarIngrediente.txtQuantidade.Text = "1";

            Frm.alterarConteudo(adicionarIngrediente, "Produto :: Adicionar Ingrediente");
        }

        private void exibirIngredientes()
        {
            dgvIngredientes.Rows.Clear();

            foreach (clnPedidoProdutoIngrediente objPedidoIngrediente in ObjPedidoProduto.Ingredientes)
            {
                clnIngrediente objIngrediente = new clnIngrediente();
                objIngrediente.Cod = objPedidoIngrediente.Ingrediente;
                objIngrediente = objIngrediente.obterPorCodigo();

                dgvIngredientes.Rows.Add(objIngrediente.Nome, objPedidoIngrediente.Quantidade);
            }
        }

        private void uctPedidoProdutoDetalhes_Load(object sender, EventArgs e)
        {
            txtQuantidade.Text = Convert.ToString(ObjPedidoProduto.Quantidade);

            exibirIngredientes();
        }
    }
}
