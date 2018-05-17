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
    public partial class frmVisualizar : Form
    {

        private String _selecionando;
        private clnUtilVisualizar _objVisualizar;

        private List<object> _opcoes;

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
        internal clnUtilVisualizar ObjVisualizar { get => _objVisualizar; set => _objVisualizar = value; }

        public frmVisualizar()
        {
            InitializeComponent();

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
                    Description = ObjVisualizar.getNome(obj),
                    Name = "btnVisualizar" + ObjVisualizar.getCod(obj),
                    Size = new Size(110, 110),
                    Image = ObjVisualizar.getImagem(obj)
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    ObjVisualizar.abrir(obj);
                    realizaPesquisa();
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

        private void realizaPesquisa()
        {
            _opcoes.Clear();

            String pesquisa = txtPesquisa.Text.ToLower();
            foreach (object opcao in ObjVisualizar.getOpcoes())
            {
                if (clnUtil.vazio(pesquisa) || ObjVisualizar.getNome(opcao).ToLower().Contains(pesquisa))
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

        private void frmSelecionar_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            realizaPesquisa();
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