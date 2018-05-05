using System;
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

        private clnSelecionar _objSelecionar;

        public frmSelecionar()
        {
            InitializeComponent();
        }

        public String Titulo
        {
            set
            {
                value = clnApp.AppName + " :: " + value;
                Text = value;
                hdrUIX.Text = value;
            }
        }

        public Image Icone
        {
            set
            {
                hdrUIX.Image = value;
            }
        }

        internal clnSelecionar ObjSelecionar { get => _objSelecionar; set => _objSelecionar = value; }

        private void frmSelecionar_Load(object sender, EventArgs e)
        {
            mostrarOpcoes();

            grbDetalhes.Hide();
            btnConfirmar.Hide();

            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
        }

        private void mostrarOpcoes()
        {
            List<Control> opcoesControles = new List<Control>();
            foreach (object obj in ObjSelecionar.getOpcoes())
            {
                UIX.btnUIX btn = new UIX.btnUIX();
                btn.Description = ObjSelecionar.getNome(obj);
                btn.Name = "btnProduto" + ObjSelecionar.getCod(obj);
                btn.Size = new Size(110, 110);
                btn.Image = ObjSelecionar.getImagem(obj);
                btn.Click += (object sender, EventArgs e) =>
                {
                    selecionaOpcao(obj);
                };

                opcoesControles.Add(btn);
            }

            clnUtil.adicionarControles(pnlOpcoes, opcoesControles, 20);
            clnApp.AppVisualTemplate.pnlApply(pnlOpcoes);

            pnlOpcoes.BackColor = grbOpcoes.BackColor;
        }

        private void selecionaOpcao(object obj)
        {
            if (ObjSelecionar.setSelecionado(obj))
            {
                grbDetalhes.Hide();

                picImagem.Image = ObjSelecionar.getImagem(obj);
                lblNome.Text = ObjSelecionar.getNome(obj);
                lblDesc.Text = ObjSelecionar.getDetalhes(obj);
                txtQuantidade.Text = "1";

                grbDetalhes.Show();
                btnConfirmar.Show();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            if (clnMensagem.mostrarSimNao("", "Deseja realmente cancelar?", clnMensagem.MensagemIcone.INFO))
            {
                ObjSelecionar.setSelecionado(null);

                Close();
            }
        }
    }
}