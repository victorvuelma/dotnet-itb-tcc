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
            pnlOpcoes.Controls.Clear();

            List<Control> opcoesControles = new List<Control>();
            foreach (object obj in _opcoes)
            {
                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = ObjVisualizar.ObjListar.getNome(obj),
                    Name = "btnVisualizar" + ObjVisualizar.ObjListar.getCod(obj),
                    Size = new Size(110, 110),
                    ImageLocation = ObjVisualizar.ObjListar.getImagem(obj)
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    if (ObjVisualizar.click(obj))
                    {
                        Close();
                    }
                    else
                    {
                        realizaPesquisa();
                    }
                };

                opcoesControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlOpcoes, opcoesControles, 20);

            foreach (Control control in opcoesControles)
            {
                if (control is Button btn)
                {
                    UIX.uixButton.btnApply(btn, App.VisualStyle.ButtonImageColor);
                }
            }
            opcoesControles.Clear();

            lblPesquisaRes.Text = _opcoes.Count + " resultados encontrados.";
        }

        private void realizaPesquisa()
        {
            _opcoes.Clear();

            String pesquisa = txtPesquisar.Text.ToLower();
            foreach (object opcao in ObjVisualizar.ObjListar.getOpcoes())
            {
                if (clnUtil.vazio(pesquisa) || ObjVisualizar.ObjListar.getNome(opcao).ToLower().Contains(pesquisa))
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
            App.VisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarForm(this);

            realizaPesquisa();
            hdrUIX.Title = App.ConfigName + " - " + ObjVisualizar.ObjListar.Titulo;
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
    }
}