using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using BurgerShack.Desktop.Util;

namespace BurgerShack.Desktop
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
                UIXButton btn = new UIXButton
                {
                    Description = "Mesa #" + codMesa,
                    Name = "btnMesa" + codMesa,
                    Size = new Size(110, 110),
                    Image = Properties.Resources.mesauso
                };
                btn.Click += (object sender, EventArgs e) =>
                {
                    removerMesa(codMesa);
                };

                pedidosControles.Add(btn);
            }
            clnUtil.adicionarControles(pnlMesas, pedidosControles, 20);
            pedidosControles.Clear();
        }

        private void removerMesa(int codMesa)
        {
            if (ObjAtendimento.CodMesas.Count > 1)
            {
                if (UtilMensagem.mostrarSimNao("Atendimento", "Deseja remover a mesa " + codMesa + " do atendimento?", UtilMensagem.MensagemIcone.ERRO))
                {
                    ObjAtendimento.removerMesa(codMesa);

                    exibirMesas();
                }
            }
            else
            {
                UtilMensagem.mostrarOk("Atendimento", "Não é possível remover a única mesa do Atendimento atual.");
            }
        }

        private void adicionarMesa()
        {
            clnMesa objMesas = new clnMesa
            {
                Situacao = clnMesa.mesaSituacao.DISPONIVEL
            };

            clnMesa.clnListar objListar = new clnMesa.clnListar
            {
                Opcoes = objMesas.obterPorSituacao(),
                Titulo = "Adicionar uma Mesa",
                Icone = Properties.Resources.mesa
            };
            clnUtilVisualizar<clnAtendimento, clnMesa> objVisualizar = new clnUtilVisualizar<clnAtendimento, clnMesa>
            {
                ObjListar = objListar,
                Obj = ObjAtendimento,
                Callback = new CallBackAdicionar()
            };

            frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
            {
                ObjVisualizar = objVisualizar
            };
            frmVisualizar.ShowDialog();

            exibirMesas();
        }

        private void uctAtendimentoPedidos_Load(object sender, EventArgs e)
        {
            exibirMesas();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionarMesa();
        }

        private class CallBackAdicionar : clnUtilVisualizar.IVisualizarCallback<clnAtendimento, clnMesa>
        {

            public clnUtilVisualizar.VisualizarResult call(clnAtendimento objAtendimento, clnMesa objMesa)
            {
                objAtendimento.adicionarMesa(objMesa.Cod);
                UtilMensagem.mostrarOk("Atendimento", "Mesa " + objMesa.Cod + " adicionada ao atendimento.");
                return clnUtilVisualizar.VisualizarResult.FECHAR;
            }
        }
    }
}
