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
    public partial class frmItemIngrediente : Form
    {

        private clnUtilValidar _validar;

        private clnItemIngrediente _ingredienteAntigo;
        private clnItemIngrediente _ingredienteNovo;

        public clnItemIngrediente IngredienteAntigo { get => _ingredienteAntigo; set => _ingredienteAntigo = value; }
        public clnItemIngrediente IngredienteNovo { get => _ingredienteNovo; set => _ingredienteNovo = value; }

        public frmItemIngrediente()
        {
            InitializeComponent();

            hdrUIX.Title = App.AppName + " - Ingredientes";

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.INT, clnUtilValidar.ValidarTipo.INT_MAIOR_0 });
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

            List<clnItemIngrediente> objPedidoIngredientes = new List<clnItemIngrediente>();
            foreach (clnIngrediente objIngrediente in objIngredientes.obterPorTipo())
            {
                clnItemIngrediente objPedidoIngrediente = new clnItemIngrediente
                {
                    Quantidade = IngredienteAntigo.Quantidade,
                    CodProdutoIngrediente = IngredienteAntigo.CodProdutoIngrediente,
                    CodIngrediente = objIngrediente.Cod
                };
                objPedidoIngredientes.Add(objPedidoIngrediente);
            }

            clnItemIngrediente.clnSelecionar objSelecionar = new clnItemIngrediente.clnSelecionar
            {
                Opcoes = objPedidoIngredientes,
                Selecionado = IngredienteNovo,
                Quantidade = ((IngredienteNovo == null) ? IngredienteAntigo.Quantidade : IngredienteNovo.Quantidade),
                Icone = Properties.Resources.ingrediente,
                Titulo = "Selecione o ingrediente"
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
            {
                ObjSelecionar = objSelecionar
            };
            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                objSelecionar.Selecionado.Quantidade = objSelecionar.Quantidade;
                IngredienteNovo = objSelecionar.Selecionado;

                exibirIngrediente(objSelecionar.Selecionado);
            }
        }

        private void exibirIngrediente(clnItemIngrediente objPedidoIngrediente)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = objPedidoIngrediente.CodIngrediente
            }.obterPorCodigo();

            clnArquivo objArquivo = new clnArquivo
            {
                Cod = objIngrediente.CodImagem
            }.obterPorCodigo();

            picIngrediente.ImageLocation = objArquivo.Local;
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
            clnUtil.definirNumBoard(txtQuantidade);

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
            if (_validar.valido())
            {
                if (IngredienteNovo == null)
                {
                    IngredienteNovo = IngredienteAntigo;
                }

                Close();
            }
        }

    }
}
