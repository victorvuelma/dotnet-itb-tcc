using BURGUERSHACK_COMMON;
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
            _validar.addValidacao(txtQuantidade, new clnUtilFormValidar.ValidarTipo[] { clnUtilFormValidar.ValidarTipo.OBRIGATORIO, clnUtilFormValidar.ValidarTipo.INT });

            _opcoes = new List<object>();
        }

        private void exibirOpcoes()
        {
            pnlOpcoes.Controls.Clear();

            List<Control> opcoesControles = new List<Control>();
            foreach (object obj in _opcoes)
            {
                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = ObjSelecionar.ObjListar.getNome(obj),
                    Name = "btnSelecionar" + ObjSelecionar.ObjListar.getCod(obj),
                    Size = new Size(110, 110),
                    ImageLocation = ObjSelecionar.ObjListar.getImagem(obj)
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    selecionaOpcao(obj);
                };

                opcoesControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlOpcoes, opcoesControles, 20);

            foreach (Control control in opcoesControles)
            {
                if (control is Button btn)
                {
                    UIX.uixButton.btnApply(btn, AppDesktop.VisualStyle.ButtonImageColor);
                }
            }
            opcoesControles.Clear();

            lblPesquisaRes.Text = _opcoes.Count + " resultados encontrados.";
        }

        private void selecionaOpcao(object obj)
        {
            if (ObjSelecionar.setSelecionado(obj))
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
        }

        private void realizaPesquisa()
        {
            _opcoes.Clear();

            String pesquisa = txtPesquisar.Text.ToLower();
            foreach (object opcao in ObjSelecionar.ObjListar.getOpcoes())
            {
                if (clnUtilValidar.vazio(pesquisa) || ObjSelecionar.ObjListar.getNome(opcao).ToLower().Contains(pesquisa))
                {
                    _opcoes.Add(opcao);
                }
            }
            exibirOpcoes();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!txtQuantidade.Visible || _validar.valido())
            {
                ObjSelecionar.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                Close();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            if (clnUtilMensagem.mostrarSimNao(ObjSelecionar.ObjListar.Titulo, "Deseja realmente cancelar?", clnUtilMensagem.MensagemIcone.INFO))
            {
                ObjSelecionar.setSelecionado(null);

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
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            realizaPesquisa();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            realizaPesquisa();
        }
    }
}