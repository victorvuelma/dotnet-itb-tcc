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
    public partial class frmSelecionar : Form
    {

        private String _selecionando;
        private clnSelecionar _objSelecionar;
        private clnValidar _validar;

        private List<object> _opcoes;
        private int _quantidade;

        public String Selecionando
        {
            get => _selecionando;
            set
            {
                _selecionando = value;
                value = clnApp.AppName + " :: " + value;
                Text = value;
                hdrUIX.Title = value;
            }
        }
        public Image Icone { set => hdrUIX.Image = value; }
        internal clnSelecionar ObjSelecionar { get => _objSelecionar; set => _objSelecionar = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public frmSelecionar()
        {
            InitializeComponent();

            _validar = new clnValidar();
            _validar.addValidacao(txtQuantidade, new clnValidar.ValidarTipo[] { clnValidar.ValidarTipo.VAZIO, clnValidar.ValidarTipo.INT });

            _opcoes = new List<object>();
        }

        private void mostrarOpcoes()
        {
            pnlOpcoes.Controls.Clear();

            List<Control> opcoesControles = new List<Control>();
            foreach (object obj in _opcoes)
            {
                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = ObjSelecionar.getNome(obj),
                    Name = "btnProduto" + ObjSelecionar.getCod(obj),
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
                    UIX.uixButton.btnApply(btn, clnApp.AppVisualStyle.ButtonImageColor);
                    btn.ForeColor = clnApp.AppVisualStyle.ButtonImageColor.ContentColor;
                }
            }

            pnlOpcoes.BackColor = grbOpcoes.BackColor;
        }

        private void selecionaOpcao(object obj)
        {
            if (ObjSelecionar.setSelecionado(obj))
            {
                exibirOpcao(obj);
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
            String pesquisa = txtPesquisa.Text;
            _opcoes.Clear();

            foreach (object opcao in ObjSelecionar.getOpcoes())
            {
                if (clnUtil.vazio(pesquisa) || ObjSelecionar.getNome(opcao).Contains(pesquisa))
                {
                    _opcoes.Add(opcao);
                }
            }
            mostrarOpcoes();
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
            if (clnMensagem.mostrarSimNao(Selecionando, "Deseja realmente cancelar?", clnMensagem.MensagemIcone.INFO))
            {
                ObjSelecionar.setSelecionado(null);

                Close();
            }
        }

        private void frmSelecionar_Load(object sender, EventArgs e)
        {
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
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