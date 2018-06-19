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
    public partial class frmAtendimento : Form
    {

        private clnAtendimento _objAtendimento;
        private int _codFuncionario;

        public clnAtendimento ObjAtendimento { get => _objAtendimento; set => _objAtendimento = value; }
        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }

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
            uctMesaConta uctConta = new uctMesaConta
            {
                Atendimento = ObjAtendimento.Cod
            };
            alterarConteudo(uctConta, "Conta");
        }

        private void abrirNovoPedido()
        {
            frmPedido frmNovoPedido = new frmPedido
            {
                CodAtendimento = ObjAtendimento.Cod,
                CodFuncionario = CodFuncionario,
                ObjPedido = new clnPedido(),
                ObjItens = new Dictionary<clnItem, List<clnItemIngrediente>>()
            };
            frmNovoPedido.ShowDialog();
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
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnSair, App.AppVisualStyle.ButtonWarningColor);

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

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            abrirNovoPedido();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            abrirMesas();
        }

    }
}
