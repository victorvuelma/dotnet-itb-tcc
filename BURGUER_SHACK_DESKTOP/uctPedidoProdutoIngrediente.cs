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
    public partial class uctPedidoProdutoIngrediente : UserControl
    {

        private frmPedidoProduto _form;

        private clnValidar _validar;

        private bool _add;
        private clnPedidoProdutoIngrediente _pedidoIngrediente;
        private clnPedidoProdutoIngrediente _pedidoIngredienteSubstituir;

        public frmPedidoProduto Form { get => _form; set => _form = value; }
        public bool Add { get => _add; set => _add = value; }
        public clnPedidoProdutoIngrediente PedidoIngrediente { get => _pedidoIngrediente; set => _pedidoIngrediente = value; }
        public clnPedidoProdutoIngrediente PedidoIngredienteSubstituir { get => _pedidoIngredienteSubstituir; set => _pedidoIngredienteSubstituir = value; }

        public uctPedidoProdutoIngrediente()
        {
            InitializeComponent();

            _validar = new clnValidar();
            _validar.addValidacao(txtQuantidade, new clnValidar.ValidarTipo[] { clnValidar.ValidarTipo.VAZIO, clnValidar.ValidarTipo.INT });
        }

        private void selecionaIngrediente(clnIngrediente ingrediente)
        {
            exibirIngrediente(ingrediente);

            txtQuantidade.Text = "1";

            PedidoIngrediente = new clnPedidoProdutoIngrediente
            {
                Quantidade = 1,
                Ingrediente = ingrediente.Cod
            };
            if (PedidoIngredienteSubstituir != null && PedidoIngredienteSubstituir.Substituindo)
            {
                PedidoIngrediente.Substituindo = true;
            }
            else
            {
                PedidoIngrediente.Substituindo = false;
            }
        }

        private void exibirIngrediente(clnIngrediente ingrediente)
        {
            picIngrediente.Image = ingrediente.Imagem;
            lblIngredienteNome.Text = ingrediente.Nome;
            lblIngredienteDesc.Visible = false;

            grbIngrediente.Visible = true;
        }

        private void confirmarIngrediente()
        {
            if (PedidoIngrediente != null)
            {
                if (_validar.valido())
                {
                    PedidoIngrediente.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                    if (PedidoIngredienteSubstituir != null)
                    {
                        Form.substiuiIngrediente(PedidoIngredienteSubstituir, PedidoIngrediente);
                    }
                    else
                    {
                        Form.adicionaIngrediente(PedidoIngrediente);
                    }
                }
            }
            else
            {
                clnMensagem.mostrarOk("Ingrediente", "Selecione um ingrediente", clnMensagem.MensagemIcone.INFO);
            }
        }

        private void exibirIngredientes()
        {
            pnlIngredientes.Controls.Clear();

            clnIngrediente objIngredientes = new clnIngrediente();
            //definir o tipo do ingrediente

            List<Control> ingredienteControles = new List<Control>();
            foreach (clnIngrediente ingrediente in objIngredientes.obterPorTipo())
            {
                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = ingrediente.Nome,
                    Image = ingrediente.Imagem,
                    Name = "btnIngrediente" + ingrediente.Cod,
                    Size = new Size(75, 75)
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    selecionaIngrediente(ingrediente);
                };

                ingredienteControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlIngredientes, ingredienteControles, 10);
        }

        private void removerIngrediente()
        {
            if (clnMensagem.mostrarSimNao("Ingrediente", "Deseja realmente remover esse ingrediente do produto?", clnMensagem.MensagemIcone.ERRO))
            {
                if (PedidoIngredienteSubstituir != null)
                {
                    Form.removerIngrediente(PedidoIngredienteSubstituir);
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmarIngrediente();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            removerIngrediente();
        }

        private void uctPedidoProdutoIngrediente_Load(object sender, EventArgs e)
        {
            exibirIngredientes();

            if (PedidoIngredienteSubstituir != null)
            {
                txtQuantidade.Text = Convert.ToString(PedidoIngredienteSubstituir.Quantidade);
                if (PedidoIngredienteSubstituir.Substituindo)
                {
                    txtQuantidade.Enabled = false;
                }

                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = PedidoIngredienteSubstituir.Ingrediente
                };
                objIngrediente = objIngrediente.obterPorCodigo();

                exibirIngrediente(objIngrediente);
            }
            else
            {
                txtQuantidade.Text = "1";
            }

            UIX.uixButton.btnApply(btnRemover, clnApp.AppVisualStyle.WarningButtonColor);
        }
    }
}
