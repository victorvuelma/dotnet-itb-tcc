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

        private clnItemIngrediente _objItemIngrediente;

        public clnItemIngrediente ObjItemIngrediente { get => _objItemIngrediente; set => _objItemIngrediente = value; }

        public frmItemIngrediente()
        {
            InitializeComponent();

            hdrUIX.Title = App.ConfigName + " - Ingredientes";

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.INT, clnUtilValidar.ValidarTipo.INT_MAIOR_0 });
        }

        private void escolherAlterar()
        {
            clnIngrediente objIngredienteAntigo = new clnIngrediente
            {
                Cod = ObjItemIngrediente.CodIngrediente
            }.obterPorCod();

            List<clnIngrediente> objIngredientes = new clnIngrediente
            {
                CodTipo = objIngredienteAntigo.CodTipo,
                Situacao = clnIngrediente.ingredienteSituacao.DISPONIVEL
            }.obterPorTipoSituacao();
            objIngredientes.RemoveAll(obj => obj.Cod.Equals(objIngredienteAntigo.Cod));

            if (objIngredientes.Count > 0)
            {
                List<clnItemIngrediente> objItemIngredientes = new List<clnItemIngrediente>();
                foreach (clnIngrediente objIngrediente in objIngredientes)
                {
                    clnItemIngrediente objItemIngrediente = new clnItemIngrediente
                    {
                        Quantidade = ObjItemIngrediente.Quantidade,
                        CodProdutoIngrediente = ObjItemIngrediente.CodProdutoIngrediente,
                        CodIngrediente = objIngrediente.Cod,
                        CodItem = ObjItemIngrediente.CodItem
                    };
                    objItemIngredientes.Add(objItemIngrediente);
                }

                clnItemIngrediente.clnListar objListar = new clnItemIngrediente.clnListar
                {
                    Opcoes = objItemIngredientes,
                    Icone = Properties.Resources.ingrediente,
                    Titulo = "Selecione o Ingrediente"
                };
                clnUtilSelecionar<clnItemIngrediente> objSelecionar = new clnUtilSelecionar<clnItemIngrediente>
                {
                    Selecionado = ObjItemIngrediente,
                    Quantidade = ObjItemIngrediente.Quantidade,
                    ObjListar = objListar
                };

                frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
                {
                    ObjSelecionar = objSelecionar
                };
                frmSelecionar.ShowDialog();

                if (objSelecionar.Selecionado != null)
                {
                    objSelecionar.Selecionado.Quantidade = objSelecionar.Quantidade;
                    ObjItemIngrediente = objSelecionar.Selecionado;

                    exibirIngrediente(objSelecionar.Selecionado);
                }
            }
            else
            {
                clnUtilMensagem.mostrarOk("Produto", "Não há outros produtos disponiveis.", clnUtilMensagem.MensagemIcone.ERRO);
            }
        }

        private void exibirIngrediente(clnItemIngrediente objPedidoIngrediente)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = objPedidoIngrediente.CodIngrediente
            }.obterPorCod();

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
                ObjItemIngrediente = null;

                Close();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            finalizar();
        }

        private void frmAlteraIngrediente_Load(object sender, EventArgs e)
        {
            App.VisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarForm(this);
            clnUtil.definirNumBoard(txtQuantidade);

            UIX.uixButton.btnApply(btnRemover, App.VisualStyle.ButtonWarningColor);

            picIngrediente.Hide();
            lblNome.Hide();
            txtQuantidade.Hide();

            exibirIngrediente(ObjItemIngrediente);
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
                ObjItemIngrediente.Quantidade = clnUtilConvert.ToInt(txtQuantidade.Text);

                Close();
            }
        }

    }
}
