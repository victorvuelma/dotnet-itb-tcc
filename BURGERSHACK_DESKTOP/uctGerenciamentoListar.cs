using System;
using System.Windows.Forms;
using vitorrdgs.Util;

namespace BurgerShack.Desktop
{
    public partial class uctGerenciamentoListar : UserControl
    {

        private String[] _colunas;
        private bool _inativos;

        private IUtilCallback<DataGridView, String, bool> _callbackObter;
        private IUtilCallback _callbackNovo;
        private IUtilCallback<DataGridViewRow> _callbackAlterar;

        public string[] Colunas { get => _colunas; set => _colunas = value; }
        internal IUtilCallback<DataGridView, string, bool> CallbackObter { get => _callbackObter; set => _callbackObter = value; }
        internal IUtilCallback CallbackNovo { get => _callbackNovo; set => _callbackNovo = value; }
        internal IUtilCallback<DataGridViewRow> CallbackAlterar { get => _callbackAlterar; set => _callbackAlterar = value; }
        public bool Inativos { get => _inativos; set => _inativos = value; }

        public uctGerenciamentoListar()
        {
            InitializeComponent();
        }

        private void pesquisar()
        {
            dgvItens.Rows.Clear();
            dgvItens.ClearSelection();

            CallbackObter.call(dgvItens, txtPesquisar.Text, !chkInativo.Checked);
            exibirResultados();
        }

        private void exibirResultados()
        {
            if (dgvItens.Rows.Count == 1)
            {
                lblPesquisaRes.Text = "1 resultado encontrado.";
            }
            else if (dgvItens.Rows.Count == 0)
            {
                lblPesquisaRes.Text = "Nenhum resultado encontrado.";
            }
            else
            {
                lblPesquisaRes.Text = dgvItens.Rows.Count + " resultados encontrados.";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (CallbackNovo.call())
            {
                pesquisar();
            }
        }
        
        public void atualizar()
        {
            dgvItens.Rows.Clear();
            dgvItens.Columns.Clear();
            foreach (string coluna in Colunas)
            {
                dgvItens.Columns.Add(coluna.ToLower(), coluna);
            }
            AppDesktop.VisualTemplate.ctlApply(dgvItens);

            chkInativo.Visible = Inativos;
            chkInativo.Checked = false;
            btnNovo.Visible = CallbackNovo != null;
            txtPesquisar.Text = "";

            pesquisar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CallbackAlterar != null && CallbackAlterar.call(dgvItens.CurrentRow))
            {
                pesquisar();
            }
        }

        private void txtPesquisar_TextChange(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void chkInativo_CheckedChanged(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void uctGerenciamentoListar_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
        }
    }
}
