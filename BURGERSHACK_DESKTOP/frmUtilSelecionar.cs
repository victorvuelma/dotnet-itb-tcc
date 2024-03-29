﻿using BurgerShack.Common;

using BurgerShack.Desktop.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public partial class frmUtilSelecionar : Form
    {

        private clnUtilFormValidar _validar;
        private List<object> _opcoes;

        private clnUtilSelecionar _objSelecionar;

        internal clnUtilSelecionar ObjSelecionar { get => _objSelecionar; set => _objSelecionar = value; }

        public frmUtilSelecionar()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.INT });

            _opcoes = new List<object>();
        }

        private void exibirOpcoes()
        {
            lstOpcoes.LimparOpcoes();
            foreach (object obj in _opcoes)
            {
                lstOpcoes.Adicionar(ObjSelecionar.ObjListar.getCod(obj), ObjSelecionar.ObjListar.getNome(obj), ObjSelecionar.ObjListar.getImagem(obj), AppDesktop.VisualStyle.ButtonImageColor, () =>
                {
                    selecionaOpcao(obj);
                    return UIXItemsList.ListResult.NENHUM;
                });
            }
            lstOpcoes.exibirItens();

            exibirResultados();
        }

        private void exibirResultados()
        {
            if (_opcoes.Count == 1)
            {
                lblPesquisaRes.Text = "1 resultado encontrado.";
            }
            else if (_opcoes.Count == 0)
            {
                lblPesquisaRes.Text = "Nenhum resultado encontrado.";
            }
            else
            {
                lblPesquisaRes.Text = _opcoes.Count + " resultados encontrados.";
            }
        }

        private void selecionaOpcao(object obj)
        {
            if (ObjSelecionar.selecionar(obj))
            {
                exibirOpcao(obj);

                txtQuantidade.Focus();
            }
        }

        private void exibirOpcao(object obj)
        {
            grbDetalhes.Hide();

            picImagem.ImageLocation = ObjSelecionar.ObjListar.getImagem(obj);
            lblNome.Text = ObjSelecionar.ObjListar.getNome(obj);
            lblDesc.Text = ObjSelecionar.ObjListar.getDetalhes(obj);
            txtQuantidade.Text = "1";

            grbDetalhes.Show();
            btnConfirmar.Show();

            txtQuantidade.Focus();
        }

        private void realizaPesquisa()
        {
            _opcoes.Clear();

            String pesquisa = txtPesquisar.Text.ToLower();
            foreach (object opcao in ObjSelecionar.ObjListar.getOpcoes())
            {
                if (UtilValidar.vazio(pesquisa) || ObjSelecionar.ObjListar.getNome(opcao).ToLower().Contains(pesquisa))
                {
                    _opcoes.Add(opcao);
                }
            }
            exibirOpcoes();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!txtQuantidade.Visible || _validar.validar(this))
            {
                ObjSelecionar.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                Close();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            if (UtilMensagem.mostrarSimNao(ObjSelecionar.ObjListar.Titulo, "Deseja realmente cancelar?", UtilMensagem.MensagemIcone.INFO))
            {
                ObjSelecionar.selecionar(null);

                Close();
            }
        }

        private void frmSelecionar_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);

            grbDetalhes.Hide();
            btnConfirmar.Hide();

            realizaPesquisa();

            if (ObjSelecionar.Quantidade == 0)
            {
                txtQuantidade.Hide();
            }

            if (ObjSelecionar.getSelecionado() != null)
            {
                exibirOpcao(ObjSelecionar.getSelecionado());
                txtQuantidade.Text = Convert.ToString(ObjSelecionar.Quantidade);
            }

            hdrUIX.Title = App.Name + " - " + ObjSelecionar.ObjListar.Titulo;
            hdrUIX.Image = ObjSelecionar.ObjListar.Icone;

            txtPesquisar.Focus();
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            realizaPesquisa();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            realizaPesquisa();
        }

        private void txtPesquisar_TextChange(object sender, EventArgs e)
        {
            realizaPesquisa();
        }
    }
}