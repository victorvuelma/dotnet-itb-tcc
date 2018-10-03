using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;

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
            lstMesas.LimparOpcoes();
            foreach (int codMesa in ObjAtendimento.CodMesas)
            {
                lstMesas.Adicionar(codMesa, "Mesa #" + codMesa, Properties.Resources.mesauso, AppDesktop.VisualStyle.ButtonColor, () =>
                {
                    return (removerMesa(codMesa)) ? UIXItemsList.ListResult.REMOVER : UIXItemsList.ListResult.NENHUM;
                });
            }
            lstMesas.exibirItens();
        }

        private bool removerMesa(int codMesa)
        {
            if (ObjAtendimento.CodMesas.Count > 1)
            {
                if (UtilMensagem.mostrarSimNao("Atendimento", "Deseja remover a mesa " + codMesa + " do atendimento?", UtilMensagem.MensagemIcone.ERRO))
                {
                    ObjAtendimento.removerMesa(codMesa);

                    return true;
                }
            }
            else
            {
                UtilMensagem.mostrarOk("Atendimento", "Não é possível remover a única mesa do Atendimento atual.");
            }
            return false;
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

            btnAdicionar.Focus();
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
