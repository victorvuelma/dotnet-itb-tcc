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
    public partial class frmGerenciamento : Form
    {
        public frmGerenciamento()
        {
            InitializeComponent();
        }

        private void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, " - Gerenciamento :: " + titulo);
        }

        private void abrirLista(String tipo, clnUtilCallback callbackNovo, clnUtilCallback<DataGridView, String> callbackObter, String[] colunas)
        {
            uctGerenciamentoListar objListar = new uctGerenciamentoListar
            {
                CallbackNovo = callbackNovo,
                Colunas = colunas,
                CallbackObter = callbackObter
            };
            alterarConteudo(objListar, tipo);
        }

        private void abrirIngredientes()
        {
            abrirLista("Ingredientes", new CallbackIngredienteNovo(), new CallbackIngredienteObter(), new String[] { "Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor" });
        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            hdrUIX.Title = App.AppName + " - Gerenciamento";

            abrirIngredientes();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            abrirIngredientes();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {

        }

        private class CallbackIngredienteNovo : clnUtilCallback
        {
            public bool call()
            {
                frmIngrediente frmNovoIngrediente = new frmIngrediente { };
                frmNovoIngrediente.ShowDialog();
                return frmNovoIngrediente.ObjIngrediente != null;
            }
        }

        private class CallbackIngredienteObter : clnUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                clnIngrediente objIngredientes = new clnIngrediente
                {
                    Nome = pesquisa
                };
                foreach (clnIngrediente objIngrediente in objIngredientes.obterPorNome())
                {
                    clnTipo objTipo = new clnTipo
                    {
                        Cod = objIngrediente.CodTipo,
                        Tipo = clnTipo.tipo.INGREDIENTE
                    }.obterPorCodigo();

                    int estoque = 0;

                    //"Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor"
                    dgv.Rows.Add(new object[] { objIngrediente.Cod, objIngrediente.Nome, objIngrediente.Situacao, objTipo.Cod + " - " + objTipo.Nome, estoque, objIngrediente.Valor });
                }
                return false;
            }
        }

    }
}
