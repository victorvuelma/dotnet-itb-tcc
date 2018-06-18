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
    public partial class frmFuncionario : Form
    {

        private clnUtilValidar _validar;

        private int _codFuncionario;
        private clnFuncionario _objFuncionario;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        internal clnFuncionario ObjFuncionario { get => _objFuncionario; set => _objFuncionario = value; }

        public frmFuncionario()
        {
            InitializeComponent();

            _validar = new clnUtilValidar();
            _validar.addValidacao(txtNome, clnUtilValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(mtbCPF, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.CPF });
            _validar.addValidacao(txtRG, clnUtilValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(mtbDataNasc, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.DATA, clnUtilValidar.ValidarTipo.DATA_NASC });
            _validar.addValidacao(mtbTelCel, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.CELULAR });
            _validar.addValidacao(mtbTelRes, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.TELEFONE });
            _validar.addValidacao(txtEmail, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.EMAIL });
            _validar.addValidacao(cboGenero, clnUtilValidar.ValidarTipo.OBRIGATORIO);

            _validar.addValidacao(txtSalario, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.DOUBLE });
            _validar.addValidacao(cboSituacao, clnUtilValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(cboCargo, clnUtilValidar.ValidarTipo.OBRIGATORIO);

            _validar.addValidacao(mtbEndCEP, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.CEP });
            _validar.addValidacao(txtEndLogradouro, clnUtilValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(txtEndNr, new clnUtilValidar.ValidarTipo[] { clnUtilValidar.ValidarTipo.OBRIGATORIO, clnUtilValidar.ValidarTipo.INT, clnUtilValidar.ValidarTipo.INT_MAIOR_0 });
            _validar.addValidacao(txtEndBairro, clnUtilValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(txtEndCidade, clnUtilValidar.ValidarTipo.OBRIGATORIO);
            _validar.addValidacao(cboEndUF, clnUtilValidar.ValidarTipo.OBRIGATORIO);

            mtbCPF.Mask = clnUtil.MASK_CPF;
            mtbDataNasc.Mask = clnUtil.MASK_DATA;
            cboGenero.Items.AddRange(new String[] { "M", "F" });
            mtbTelCel.Mask = clnUtil.MASK_CEL;
            mtbTelRes.Mask = clnUtil.MASK_TEL;
            mtbEndCEP.Mask = clnUtil.MASK_CEP;
        }

        private void salvar()
        {
            if (_validar.valido())
            {
                //    clnCliente objClienteCPF = new clnCliente
                //    {
                //        Cpf = clnUtil.retirarFormatacao(mtbCPF.Text)
                //    }.obterPorCPF();

                //    if (ObjFuncionario == null)
                //    {
                //        if (objClienteCPF == null)
                //        {
                //            clnCliente objCliente = new clnCliente
                //            {
                //                CodFuncionario = CodFuncionario,
                //                Nome = txtNome.Text,
                //                Cpf = clnUtil.retirarFormatacao(mtbCPF.Text),
                //                DataNascimento = clnUtilConvert.ObterNullableData(mtbDataNasc.Text),
                //                Email = txtEmail.Text,
                //                TelCelular = clnUtil.retirarFormatacao(mtbTelCel.Text),
                //                Genero = cboGenero.Text,
                //                Cadastro = DateTime.Now
                //            };
                //            objCliente.gravar();
                //            ObjFuncionario = objCliente;
                //            clnUtilMensagem.mostrarOk("Cadastro de Cliente", "Cliente cadastrado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                //            Close();
                //        }
                //        else
                //        {
                //            clnUtilMensagem.mostrarOk("Cadastro de Cliente", "Não foi possível cadastrar o cliente, o CPF já está cadastrado!", clnUtilMensagem.MensagemIcone.ERRO);
                //            mtbCPF.Focus();
                //        }
                //    }
                //    else
                //    {
                //        ObjFuncionario.Nome = txtNome.Text;
                //        ObjFuncionario.DataNascimento = clnUtilConvert.ObterNullableData(mtbDataNasc.Text);
                //        ObjFuncionario.Email = txtEmail.Text;
                //        ObjFuncionario.TelCelular = clnUtil.retirarFormatacao(mtbTelCel.Text);
                //        ObjFuncionario.Genero = cboGenero.Text;
                //        ObjFuncionario.alterar();
                //        clnUtilMensagem.mostrarOk("Alteração de Cliente", "Cliente alterado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                //        Close();
                //    }
            }
        }

        private void fechar()
        {
            if (ObjFuncionario == null)
            {
                if (clnUtilMensagem.mostrarSimNao("Cadastro de Funcionário", "Deseja cancelar o cadastro?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
            else
            {
                if (clnUtilMensagem.mostrarSimNao("Alteração de Funcionário", "Deseja cancelar as alterações?", clnUtilMensagem.MensagemIcone.ERRO))
                {
                    Close();
                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            UIX.uixButton.btnApply(btnVoltar, App.AppVisualStyle.ButtonWarningColor);

            clnUtil.definirNumBoard(mtbCPF, frmUtilNumBoard.NumBoardMode.INT);
            clnUtil.definirNumBoard(txtRG, frmUtilNumBoard.NumBoardMode.INT);
            clnUtil.definirNumBoard(mtbTelCel, frmUtilNumBoard.NumBoardMode.INT);
            clnUtil.definirNumBoard(mtbTelRes, frmUtilNumBoard.NumBoardMode.INT);
            clnUtil.definirNumBoard(mtbDataNasc, frmUtilNumBoard.NumBoardMode.INT);

            clnUtil.definirNumBoard(txtSalario);

            clnUtil.definirNumBoard(mtbEndCEP, frmUtilNumBoard.NumBoardMode.INT);
            clnUtil.definirNumBoard(txtEndNr);

            clnUtil.definirCEP(mtbEndCEP, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF.cbo, txtEndNr);

            if (ObjFuncionario == null)
            {
                hdrUIX.Title = App.AppName + " - Novo Funcionário";
            }
            else
            {
                hdrUIX.Title = App.AppName + " - Alterando Funcionário " + ObjFuncionario.Cod;
                mtbCPF.Enabled = false;
                txtNome.Text = ObjFuncionario.Nome;
                mtbCPF.Text = ObjFuncionario.Cpf;
                txtRG.Text = ObjFuncionario.Rg;
                mtbDataNasc.Text = clnUtil.formatarData(ObjFuncionario.DataNascimento);
                cboGenero.Text = clnUtilConvert.ToString(ObjFuncionario.Genero);
                txtEmail.Text = ObjFuncionario.Email;
                mtbTelCel.Text = ObjFuncionario.TelCel;
                mtbTelRes.Text = ObjFuncionario.TelRes;

                txtSalario.Text = clnUtilConvert.ToString(ObjFuncionario.Salario);
                cboSituacao.Text = clnUtilConvert.ToString(ObjFuncionario.Situacao);

                mtbEndCEP.Text = ObjFuncionario.EndCEP;
                txtEndLogradouro.Text = ObjFuncionario.EndLogradouro;
                txtEndNr.Text = ObjFuncionario.EndNumero;
                txtEndComplemento.Text = ObjFuncionario.EndComplemento;
                txtEndBairro.Text = ObjFuncionario.EndBairro;
                txtEndCidade.Text = ObjFuncionario.EndLocalidade;
                cboEndUF.Text = ObjFuncionario.EndUF;

                clnCargo objCargo = new clnCargo
                {
                    Cod = ObjFuncionario.Cod
                }.obterPorCod();
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
