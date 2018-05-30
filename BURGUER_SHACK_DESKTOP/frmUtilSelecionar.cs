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

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmUtilSelecionar : Form
    {

        private String _selecionando;
        private clnUtilSelecionar _objSelecionar;
        private clnUtilValidar _validar;

        private List<object> _opcoes;
        private int _quantidade;

        public String Selecionando
        {
            get => _selecionando;
            set
            {
                _selecionando = value;
                value = App.AppName + " :: " + value;
                Text = value;
                hdrUIX.Title = value;
            }
        }
        public Image Icone { set => hdrUIX.Image = value; }
        internal clnUtilSelecionar ObjSelecionar { get => _objSelecionar; set => _objSelecionar = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public frmUtilSelecionar()
        {
            InitializeComponent();

            Quantidade = 1;

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtQuantidade, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.INT });

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
                    Description = ObjSelecionar.getNome(obj),
                    Name = "btnSelecionar" + ObjSelecionar.getCod(obj),
                    Size = new Size(110, 110),
                    Image = ObjSelecionar.getImagem(obj)
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
                    UIX.uixButton.btnApply(btn, App.AppVisualStyle.ButtonImageColor);
                    btn.ForeColor = App.AppVisualStyle.ButtonImageColor.ContentColor;
                }
            }
            opcoesControles.Clear();

            pnlOpcoes.BackColor = grbOpcoes.BackColor;
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

            picImagem.Image = ObjSelecionar.getImagem(obj);
            lblNome.Text = ObjSelecionar.getNome(obj);
            lblDesc.Text = ObjSelecionar.getDetalhes(obj);
            txtQuantidade.Text = "1";

            grbDetalhes.Show();
            btnConfirmar.Show();
        }

        private void realizaPesquisa()
        {
            _opcoes.Clear();

            String pesquisa = txtPesquisa.Text.ToLower();
            foreach (object opcao in ObjSelecionar.getOpcoes())
            {
                if (clnUtil.vazio(pesquisa) || ObjSelecionar.getNome(opcao).ToLower().Contains(pesquisa))
                {
                    _opcoes.Add(opcao);
                }
            }
            exibirOpcoes();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_validar.valido())
            {
                Quantidade = Convert.ToInt32(txtQuantidade.Text);

                Close();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            if (clnUtilMensagem.mostrarSimNao(Selecionando, "Deseja realmente cancelar?", clnUtilMensagem.MensagemIcone.INFO))
            {
                ObjSelecionar.setSelecionado(null);

                Close();
            }
        }

        private void frmSelecionar_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);
            clnUtil.abrirNumBoard(txtQuantidade);

            grbDetalhes.Hide();
            btnConfirmar.Hide();

            realizaPesquisa();

            if (ObjSelecionar.getSelecionado() != null)
            {
                exibirOpcao(ObjSelecionar.getSelecionado());
                txtQuantidade.Text = Convert.ToString(Quantidade);
            }
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