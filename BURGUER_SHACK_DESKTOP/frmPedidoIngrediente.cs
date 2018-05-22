using System;
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
    public partial class frmPedidoIngrediente : Form
    {

        private clnPedidoReceita _ingredienteAntigo;
        private clnPedidoReceita _ingredienteNovo;

        public clnPedidoReceita IngredienteAntigo { get => _ingredienteAntigo; set => _ingredienteAntigo = value; }
        public clnPedidoReceita IngredienteNovo { get => _ingredienteNovo; set => _ingredienteNovo = value; }

        public frmPedidoIngrediente()
        {
            InitializeComponent();

            hdrUIX.Title = App.AppName + " :: Ingredientes";
        }

        private void escolherAlterar()
        {
            clnIngrediente objIngredienteAntigo = new clnIngrediente
            {
                Cod = IngredienteAntigo.CodIngrediente
            }.obterPorCodigo();

            clnIngrediente objIngredientes = new clnIngrediente
            {
                CodTipo = objIngredienteAntigo.CodTipo
            };

            List<clnPedidoReceita> objPedidoIngredientes = new List<clnPedidoReceita>();
            foreach (clnIngrediente objIngrediente in objIngredientes.obterPorTipo())
            {
                clnPedidoReceita objPedidoIngrediente = new clnPedidoReceita
                {
                    Quantidade = IngredienteAntigo.Quantidade,
                    CodReceita = IngredienteAntigo.CodReceita,
                    CodIngrediente = objIngrediente.Cod
                };
                objPedidoIngredientes.Add(objPedidoIngrediente);
            }

            clnPedidoReceita.clnSelecionarPedidoIngrediente objSelecionar = new clnPedidoReceita.clnSelecionarPedidoIngrediente
            {
                Opcoes = objPedidoIngredientes,
                Selecionado = IngredienteNovo
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
            {
                ObjSelecionar = objSelecionar,
                Quantidade = ((IngredienteNovo == null) ? IngredienteAntigo.Quantidade : IngredienteNovo.Quantidade)
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                objSelecionar.Selecionado.Quantidade = frmSelecionar.Quantidade;
                IngredienteNovo = objSelecionar.Selecionado;

                exibirIngrediente(objSelecionar.Selecionado);
            }
        }

        private void exibirIngrediente(clnPedidoReceita objPedidoIngrediente)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = objPedidoIngrediente.CodIngrediente
            }.obterPorCodigo();

            picIngrediente.Image = objIngrediente.Imagem;
            lblNome.Text = objIngrediente.Nome;
            txtQuantidade.Text = Convert.ToString(objPedidoIngrediente.Quantidade);

            picIngrediente.Show();
            lblNome.Show();
            txtQuantidade.Show();
        }

        private void finalizar()
        {
            if (clnUtilMensagem.mostrarSimNao("Ingredientes", "Deseja cancelar as alterações de ingredientes?", clnUtilMensagem.MensagemIcone.ERRO))
            {
                Close();
            }
        }

        private void removerIngrediente()
        {
            if (clnUtilMensagem.mostrarSimNao("Ingrediente", "Você deseja realmente remover este ingrediente?", clnUtilMensagem.MensagemIcone.INFO))
            {
                IngredienteNovo = null;

                Close();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            finalizar();
        }

        private void frmAlteraIngrediente_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);
            clnUtil.abrirNumBoard(txtQuantidade);

            UIX.uixButton.btnApply(btnRemover, App.AppVisualStyle.ButtonWarningColor);

            picIngrediente.Hide();
            lblNome.Hide();
            txtQuantidade.Hide();

            if (IngredienteAntigo != null)
            {
                IngredienteNovo = IngredienteAntigo;

                exibirIngrediente(IngredienteAntigo);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            removerIngrediente();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            escolherAlterar();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(IngredienteNovo == null)
            {
                IngredienteNovo = IngredienteAntigo;
            }

            Close();
        }

    }
}
