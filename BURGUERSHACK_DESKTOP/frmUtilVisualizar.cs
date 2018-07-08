using BURGUERSHACK_COMMON;
using BURGUERSHACK_COMMON.UTIL;
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

namespace BURGUERSHACK_DESKTOP
{
    public partial class frmUtilVisualizar : Form
    {

        public enum visualizarAction
        {
            FECHAR,
            REMOVER_ITEM,
            NADA
        }

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
            uctOpcoes.limpar();

            foreach (object obj in _opcoes)
            {
                uctOpcoes.adicionarItem(ObjVisualizar.ObjListar.getCod(obj), ObjVisualizar.ObjListar.getNome(obj), ObjVisualizar.ObjListar.getImagem(obj), AppDesktop.VisualStyle.ButtonImageColor, () =>
                {
                    switch (ObjVisualizar.action(obj))
                    {
                        case clnUtilVisualizar.visualizarAction.REMOVER_ITEM:
                            ObjVisualizar.ObjListar.getOpcoes().Remove(obj);
                            _opcoes.Remove(obj);
                            lblPesquisaRes.Text = _opcoes.Count + " resultados encontrados.";
                            return uctUtilListar.ListarResult.REMOVER;
                        default:
                            return uctUtilListar.ListarResult.NENHUM;
                    }
                });
            }
        }

        private void realizaPesquisa()
        {
            _opcoes.Clear();

            String pesquisa = txtPesquisar.Text.ToLower();
            foreach (object opcao in ObjVisualizar.ObjListar.getOpcoes())
            {
                if (clnUtilValidar.vazio(pesquisa) || ObjVisualizar.ObjListar.getNome(opcao).ToLower().Contains(pesquisa))
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