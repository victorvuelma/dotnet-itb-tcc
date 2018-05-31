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
    public partial class frmReserva : Form
    {

        private clnUtilValidar _validar;

        private int _codFuncionario;
        private int? _codCliente;

        private clnReserva _objReserva;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        public int? CodCliente { get => _codCliente; set => _codCliente = value; }
        internal clnReserva ObjReserva { get => _objReserva; set => _objReserva = value; }

        public frmReserva()
        {
            InitializeComponent();

            mtbCliCPF.Mask = clnUtil.MASK_CPF;
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnVoltar, App.AppVisualStyle.ButtonWarningColor);

            if(ObjReserva == null)
            {
                hdrUIX.Title = App.AppName + " :: Nova Reserva";
            } else
            {
                hdrUIX.Title = App.AppName + " :: Alterando Reserva #" + ObjReserva.Cod;
            }
        }

        private void encontrarCliente()
        {
            if (clnUtil.validarCPF(mtbCliCPF.Text))
            {
                clnCliente objCliente = new clnCliente
                {
                    Cpf = clnUtil.retirarFormatacao(mtbCliCPF.Text)
                }.obterPorCPF();
                if (objCliente != null)
                {
                    definirCliente(objCliente);
                }
                else
                {
                    if (clnUtilMensagem.mostrarSimNao("Cliente", "Cliente não encontrado, deseja cadastrar?", clnUtilMensagem.MensagemIcone.INFO))
                    {
                        frmCliente frmNovoCliente = new frmCliente
                        {
                            CodFuncionario = CodFuncionario
                        };
                        frmNovoCliente.ShowDialog();

                        if (frmNovoCliente.ObjCliente != null)
                        {
                            definirCliente(frmNovoCliente.ObjCliente);
                        }
                    }
                }
            }
            else
            {
                mtbCliCPF.Focus();
            }
        }

        private void definirCliente(clnCliente objCliente)
        {
            CodCliente = objCliente.Cod;
            lblCliente.Text = "Cliente #" + objCliente.Cod + "\n"
                              + "Nome: " + objCliente.Nome + "\n"
                              + "Celular: " + clnUtil.formatarCelular(objCliente.TelCelular);
        }

        private void btnCliEncontrar_Click(object sender, EventArgs e)
        {
            encontrarCliente();
        }
    }
}
