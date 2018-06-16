using System;
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
    public partial class uctAtendimentoMesas : UserControl
    {

        private clnAtendimento _objAtendimento;

        public clnAtendimento ObjAtendimento { get => _objAtendimento; set => _objAtendimento = value; }

        public uctAtendimentoMesas()
        {
            InitializeComponent();
        }

        private void exibirMesas()
        {
            pnlMesas.Controls.Clear();

            List<Control> pedidosControles = new List<Control>();
            foreach (int codMesa in ObjAtendimento.CodMesas)
            {
                UIX.btnUIX btn = new UIX.btnUIX
                {
                    Description = "Mesa #" + codMesa,
                    Name = "btnMesa" + codMesa,
                    Size = new Size(110, 110),
                    Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.mesauso
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    removerMesa(codMesa);
                };

                pedidosControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlMesas, pedidosControles, 20);
            pedidosControles.Clear();

            pnlMesas.BackColor = grbMesas.BackColor;
        }

        private void removerMesa(int codMesa)
        {
            if (clnUtilMensagem.mostrarSimNao("Atendimento", "Deseja remover a mesa " + codMesa + " do atendimento?", clnUtilMensagem.MensagemIcone.ERRO))
            {
                ObjAtendimento.removerMesa(codMesa);

                clnMesa objMesa = new clnMesa
                {
                    Cod = codMesa,
                    Situacao = clnMesa.mesaSituacao.DISPONIVEL
                };
                objMesa.alterar();

                exibirMesas();
            }
        }

        private void adicionarMesa()
        {
            clnMesa objMesas = new clnMesa
            {
                Situacao = clnMesa.mesaSituacao.DISPONIVEL
            };

            clnMesa.clnSelecionar objSelecionar = new clnMesa.clnSelecionar
            {
                Opcoes = objMesas.obterPorSituacao(),
                Quantidade = 0,
                Titulo = "Selecione uma mesa",
                Icone = Properties.Resources.mesa
            };

            frmUtilSelecionar frmSelecionar = new frmUtilSelecionar
            {
                ObjSelecionar = objSelecionar
            };
            frmSelecionar.txtQuantidade.Hide();

            frmSelecionar.ShowDialog();

            if (objSelecionar.Selecionado != null)
            {
                clnMesa objMesa = objSelecionar.Selecionado;

                ObjAtendimento.adicionarMesa(objMesa.Cod);

                objMesa.Situacao = clnMesa.mesaSituacao.OCUPADA;
                objMesa.alterar();

                exibirMesas();
            }
        }

        private void uctAtendimentoPedidos_Load(object sender, EventArgs e)
        {
            exibirMesas();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionarMesa();
        }
    }
}
