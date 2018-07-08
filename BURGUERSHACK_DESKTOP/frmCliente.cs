using BURGUERSHACK_COMMON;
using BURGUERSHACK_COMMON.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUERSHACK_DESKTOP
{
    public partial class frmCliente : Form
    {

        private clnUtilFormValidar _validar;

        private int _codFuncionario;
        private clnCliente _objCliente;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        internal clnCliente ObjCliente { get => _objCliente; set => _objCliente = value; }

        public frmCliente()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtNome, clnUtilFormValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(mtbCPF, new clnUtilFormValidar.ValidarTipo[] { clnUtilFormValidar.ValidarTipo.OBRIGATORIO, clnUtilFormValidar.ValidarTipo.CPF });
            _validar.addValidacao(mtbDataNasc, new clnUtilFormValidar.ValidarTipo[] { clnUtilFormValidar.ValidarTipo.DATA, clnUtilFormValidar.ValidarTipo.DATA_NASC });
            _validar.addValidacao(mtbTelCel, new clnUtilFormValidar.ValidarTipo[] { clnUtilFormValidar.ValidarTipo.OBRIGATORIO, clnUtilFormValidar.ValidarTipo.CELULAR });
            _validar.addValidacao(txtEmail, clnUtilFormValidar.ValidarTipo.EMAIL);
            _validar.addValidacao(cboGenero, clnUtilFormValidar.ValidarTipo.OBRIGATORIO);

            mtbCPF.Mask = clnUtil.MASK_CPF;
            mtbDataNasc.Mask = clnUtil.MASK_DATA;
            cboGenero.addRange(new String[] { "M", "F" });
            mtbTelCel.Mask = clnUtil.MASK_CEL;
        }

        private void salvar()
        {
            if (_validar.valido())
            {
                clnCliente objClienteCPF = new clnCliente
                {
                    Cpf = clnUtilFormatar.retirarFormatacao(mtbCPF.Text)
                }.obterPorCPF();

                if (ObjCliente == null)
                {
                    if (objClienteCPF == null)
                    {
                        clnCliente objCliente = new clnCliente
                        {
                            CodFuncionario = CodFuncionario,
                            Nome = txtNome.Text,
                            Cpf = clnUtilFormatar.retirarFormatacao(mtbCPF.Text),
                            DataNascimento = clnUtilConvert.ObterNullableData(mtbDataNasc.Text),
                            Email = txtEmail.Text,
                            TelCelular = clnUtilFormatar.retirarFormatacao(mtbTelCel.Text),
                            Genero = cboGenero.Text,
                            Cadastro = DateTime.Now
                        };
                        objCliente.gravar();
                        ObjCliente = objCliente;
                        clnUtilMensagem.mostrarOk("Cadastro de Cliente", "Cliente cadastrado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                        Close();
                    }
                    else
                    {
                        clnUtilMensagem.mostrarOk("Cadastro de Cliente", "Não foi possível cadastrar o cliente, o CPF já está cadastrado!", clnUtilMensagem.MensagemIcone.ERRO);
                        mtbCPF.Focus();
                    }
                }
                else
                {
                    ObjCliente.Nome = txtNome.Text;
                    ObjCliente.DataNascimento = clnUtilConvert.ObterNullableData(mtbDataNasc.Text);
                    ObjCliente.Email = txtEmail.Text;
                    ObjCliente.TelCelular = clnUtilFormatar.retirarFormatacao(mtbTelCel.Text);
                    ObjCliente.Genero = cboGenero.Text;
                    ObjCliente.alterar();
                    clnUtilMensagem.mostrarOk("Alteração de Cliente", "Cliente alterado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                    Close();
                }
            }
        }

        private void fechar()
        {
            if (ObjCliente == null)
            {
                if (clnUtilMensagem.mostrarSimNao("Cadastro de Cliente", "Deseja cancelar o cadastro?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (clnUtilMensagem.mostrarSimNao("Alteração de Cliente", "Deseja cancelar as alterações?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            UIX.uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            if (ObjCliente == null)
            {
                hdrUIX.Title = App.Name + " - Novo Cliente";
            }
            else
            {
                hdrUIX.Title = App.Name + " - Alterando Cliente " + ObjCliente.Cod;
                mtbCPF.Enabled = false;
                txtNome.Text = ObjCliente.Nome;
                mtbCPF.Text = ObjCliente.Cpf;
                if (ObjCliente.DataNascimento != null)
                {
                    mtbDataNasc.Text = ((DateTime)ObjCliente.DataNascimento).ToString("dd/MM/yyyy");
                }
                mtbTelCel.Text = ObjCliente.TelCelular;
                txtEmail.Text = ObjCliente.Email;
                if (ObjCliente.Genero != null)
                {
                    cboGenero.Text = ObjCliente.Genero;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }
    }
}
