using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Windows.Forms;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Property;

namespace BurgerShack.Desktop
{
    public partial class uctPrincipalMesas : UserControl
    {

        public uctPrincipalMesas()
        {
            InitializeComponent();
        }

        private void exibirMesas()
        {
            lstMesas.LimparOpcoes();
            foreach (clnMesa objMesa in new clnMesa().obterMesas())
            {
                lstMesas.Adicionar(objMesa.Cod, "Mesa " + objMesa.Cod, (objMesa.Situacao == clnMesa.mesaSituacao.DISPONIVEL ? Properties.Resources.mesa : Properties.Resources.mesauso), AppDesktop.VisualStyle.ButtonColor, () =>
                {
                    abrirMesa(objMesa);
                    return UIXItemsList.ListResult.NENHUM;
                });
            }
            lstMesas.exibirItens();
        }

        private void abrirMesa(clnMesa objMesa)
        {
            clnAtendimento objAtendimento = null;
            if (objMesa.Situacao == clnMesa.mesaSituacao.OCUPADA)
            {
                int? codAtendimento = objMesa.obterCodAtendimento();

                if (codAtendimento != null)
                {
                    objAtendimento = new clnAtendimento
                    {
                        Cod = (int)codAtendimento
                    }.obterPorCod();
                }
            }
            else
            {
                if (UtilMensagem.mostrarSimNao("Atendimento", "Você deseja iniciar um novo atendimento para a Mesa " + objMesa.Cod + "?", UtilMensagem.MensagemIcone.INFO))
                {
                    objAtendimento = new clnAtendimento
                    {
                        Inicio = DateTime.Now,
                        Situacao = clnAtendimento.atendimentoSituacao.ANDAMENTO,
                        CodFuncionario = AppDesktop.FuncionarioAtual.Cod
                    };
                    objAtendimento.gravar();

                    objAtendimento.adicionarMesa(objMesa.Cod);

                    objMesa.Situacao = clnMesa.mesaSituacao.OCUPADA;
                    objMesa.alterar();
                }
                else
                {
                    return;
                }
            }
            frmAtendimento frmAtendimento = new frmAtendimento
            {
                ObjAtendimento = objAtendimento
            };
            frmAtendimento.ShowDialog();

            exibirMesas();
        }

        private void uctPedidoMesa_Load(object sender, EventArgs e)
        {
            pnlLivre.BackColor = uixColor.WHITE;
            pnlOcupada.BackColor = uixColor.INDIGO_DARK;

            exibirMesas();
        }

    }
}
