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

        private frmPedidoProduto _form;

        private clnPedidoProduto _pedidoProduto;

        public frmPedidoProduto Form { get => _form; set => _form = value; }
        public clnPedidoProduto PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }

        public uctPedidoProdutoDetalhes()
        {
            InitializeComponent();
        }

        private void exibirIngredientes()
        {
            dgvIngredientes.Rows.Clear();

            foreach (clnPedidoProdutoIngrediente objPedidoIngrediente in PedidoProduto.Ingredientes)
            {
                clnIngrediente objIngrediente = new clnIngrediente();
                objIngrediente.Cod = objPedidoIngrediente.Ingrediente;
                objIngrediente = objIngrediente.obterPorCodigo();

                dgvIngredientes.Rows.Add(objIngrediente.Nome, objPedidoIngrediente.Quantidade);
            }
        }

        private void alterarIngrediente(clnPedidoProdutoIngrediente objIngrediente)
        {
            uctPedidoProdutoIngrediente uctAlterarIngrediente = new uctPedidoProdutoIngrediente();

            uctAlterarIngrediente.Form = Form;
            uctAlterarIngrediente.PedidoIngredienteSubstituir = objIngrediente;

            Form.alterarConteudo(uctAlterarIngrediente, "Produto :: Alterar Ingrediente");
        }

        private void abrirAdicionarIngrediente()
        {
            uctPedidoProdutoIngrediente uctAdicionarIngrediente = new uctPedidoProdutoIngrediente();
            uctAdicionarIngrediente.Form = Form;
            uctAdicionarIngrediente.btnRemover.Visible = false;
            uctAdicionarIngrediente.grbIngrediente.Visible = false;
            uctAdicionarIngrediente.txtQuantidade.Text = "1";

            Form.alterarConteudo(uctAdicionarIngrediente, "Produto :: Adicionar Ingrediente");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //valida quantidade
            PedidoProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            Form.abrirVisualizar();
        }

        private void dgvIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            alterarIngrediente(PedidoProduto.Ingredientes[e.RowIndex]);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            abrirAdicionarIngrediente();
        }

        private void uctPedidoProdutoDetalhes_Load(object sender, EventArgs e)
        {
            txtQuantidade.Text = Convert.ToString(PedidoProduto.Quantidade);

            exibirIngredientes();
        }
    }
}
