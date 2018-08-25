using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public partial class frmUtilVisualizar : Form
    {


        private clnUtilVisualizar _objVisualizar;

        private List<object> _opcoes;

        internal clnUtilVisualizar ObjVisualizar { get => _objVisualizar; set => _objVisualizar = value; }

        public frmUtilVisualizar()
        {
            InitializeComponent();

            _opcoes = new List<object>();
        }

        private void exibirOpcoes()
        {
            lstOpcoes.LimparOpcoes();
            foreach (object obj in _opcoes)
            {
                lstOpcoes.Adicionar(ObjVisualizar.ObjListar.getCod(obj), ObjVisualizar.ObjListar.getNome(obj), ObjVisualizar.ObjListar.getImagem(obj), AppDesktop.VisualStyle.ButtonImageColor, () =>
                {
                    switch (ObjVisualizar.execute(obj))
                    {
                        case clnUtilVisualizar.VisualizarResult.REMOVER:
                            ObjVisualizar.ObjListar.getOpcoes().Remove(obj);
                            _opcoes.Remove(obj);
                            exibirResultados();
                            return UIXItemsList.ListResult.REMOVER;
                        default:
                            return UIXItemsList.ListResult.NENHUM;
                    }
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

        private void realizaPesquisa()
        {
            _opcoes.Clear();

            String pesquisa = txtPesquisar.Text.ToLower();
            foreach (object opcao in ObjVisualizar.ObjListar.getOpcoes())
            {
                if (UtilValidar.vazio(pesquisa) || ObjVisualizar.ObjListar.getNome(opcao).ToLower().Contains(pesquisa))
                {
                    _opcoes.Add(opcao);
                }
            }
            exibirOpcoes();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUtilVisualizar_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);

            realizaPesquisa();
            hdrUIX.Title = App.Name + " - " + ObjVisualizar.ObjListar.Titulo;
            hdrUIX.Image = ObjVisualizar.ObjListar.Icone;

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