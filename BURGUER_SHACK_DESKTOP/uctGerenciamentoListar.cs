﻿using System;
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
    public partial class uctGerenciamentoListar : UserControl
    {

        private String[] colunas;
        private clnUtilCallback<DataGridView, String> _callbackObter;
        private clnUtilCallback _callbackNovo;
        private clnUtilCallback<DataGridViewRow> _callbackAlterar;

        public string[] Colunas { get => colunas; set => colunas = value; }
        internal clnUtilCallback<DataGridView, string> CallbackObter { get => _callbackObter; set => _callbackObter = value; }
        internal clnUtilCallback CallbackNovo { get => _callbackNovo; set => _callbackNovo = value; }
        internal clnUtilCallback<DataGridViewRow> CallbackAlterar { get => _callbackAlterar; set => _callbackAlterar = value; }

        public uctGerenciamentoListar()
        {
            InitializeComponent();
        }

        private void pesquisar()
        {
            dgvItens.Rows.Clear();
            dgvItens.ClearSelection();

            CallbackObter.call(dgvItens, txtPesquisar.Text);
            lblPesquisaRes.Text = dgvItens.Rows.Count + " resultados encontrados.";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (CallbackNovo.call())
            {
                pesquisar();
            }
        }

        private void uctGerenciamentoListar_Load(object sender, EventArgs e)
        {
            foreach (string coluna in Colunas)
            {
                dgvItens.Columns.Add(coluna.ToLower(), coluna);
            }
            App.AppVisualTemplate.dgvApply(dgvItens);

            btnNovo.Visible = CallbackNovo != null;

            pesquisar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(CallbackAlterar != null && CallbackAlterar.call(dgvItens.CurrentRow))
            {
                pesquisar();
            }
        }
    }
}
