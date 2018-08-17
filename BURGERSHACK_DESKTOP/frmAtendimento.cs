using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;

namespace BurgerShack.Desktop
{
    public partial class frmAtendimento : Form
    {

        private clnAtendimento _objAtendimento;

        public clnAtendimento ObjAtendimento { get => _objAtendimento; set => _objAtendimento = value; }

        public frmAtendimento()
        {
            InitializeComponent();
        }

        public void alterarConteudo(UserControl uctConteudo, String titulo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, "Atendimento " + ObjAtendimento.Cod + " :: " + titulo);
        }

        public void abrirPedidos()
        {
            List<clnPedido> objPedidos = new clnPedido
            {
                CodAtendimento = ObjAtendimento.Cod
            }.obterPorAtendimento();

            uctAtendimentoPedidos uctPedidos = new uctAtendimentoPedidos
            {
                CodAtendimento = ObjAtendimento.Cod,
                ObjPedidos = objPedidos
            };
            alterarConteudo(uctPedidos, "Pedidos");
        }

        private void abrirConta()
        {
            clnConta objConta = new clnConta
            {
                CodAtendimento = ObjAtendimento.Cod
            }.obterPorCodAtendimento();

            frmConta frmConta = new frmConta
            {
                ObjAtendimento = ObjAtendimento,
                ObjConta = objConta
            };
            frmConta.ShowDialog();
            if(frmConta.ObjAtendimento.Situacao == clnAtendimento.atendimentoSituacao.FINALIZADO)
            {
                Close();
            }
        }

        private void abrirMesas()
        {
            uctAtendimentoMesas uctMesas = new uctAtendimentoMesas
            {
                ObjAtendimento = ObjAtendimento
            };

            alterarConteudo(uctMesas, "Mesas");
        }

        private void frmMesa_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            abrirPedidos();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            abrirPedidos();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            abrirConta();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            abrirMesas();
        }

    }
}
