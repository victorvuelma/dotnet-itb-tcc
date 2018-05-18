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

        private frmPedidoProduto _formProduto;

        private clnUtilValidar _validar;

        private clnPedidoProduto _pedidoProduto;

        public frmPedidoProduto FormProduto { get => _formProduto; set => _formProduto = value; }
        public clnPedidoProduto PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }

        public uctPedidoProdutoDetalhes()
        {
            InitializeComponent();

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.VAZIO, clnUtilValidar.ValidarTipo.INT });
        }

        private void exibirIngredientes()
        {
            dgvIngredientes.Rows.Clear();

            //foreach (clnPedidoReceita objPedidoIngrediente in erro)
            //{
            //    clnIngrediente objIngrediente = new clnIngrediente
            //    {
            //        Cod = objPedidoIngrediente.CodIngrediente
            //    }.obterPorCodigo();

            //    dgvIngredientes.Rows.Add(objIngrediente.Nome, objPedidoIngrediente.Quantidade);
            //}
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_validar.valido())
            {
                PedidoProduto.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            }
        }

        private void uctPedidoProdutoDetalhes_Load(object sender, EventArgs e)
        {
            txtQuantidade.Text = Convert.ToString(PedidoProduto.Quantidade);

            exibirIngredientes();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
