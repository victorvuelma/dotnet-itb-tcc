using BURGERSHACK_COMMON;
using BURGERSHACK_COMMON.UTIL;
using BURGERSHACK_DESKTOP.UTIL;
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

namespace BURGERSHACK_DESKTOP
{
    public partial class frmFuncionario : Form
    {

        private clnUtilFormValidar _validar;

        private int _codFuncionario;
        private clnFuncionario _objFuncionario;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        internal clnFuncionario ObjFuncionario { get => _objFuncionario; set => _objFuncionario = value; }

        public frmFuncionario()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(txtNome, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(mtbCPF, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CPF });
            _validar.addValidacao(txtRG, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(mtbDataNasc, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.DATA, clnUtilFormValidar.Validacao.DATA_NASC });
            _validar.addValidacao(mtbTelCel, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CELULAR });
            _validar.addValidacao(mtbTelRes, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.TELEFONE });
            _validar.addValidacao(txtEmail, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.EMAIL });
            _validar.addValidacao(cboGenero, clnUtilFormValidar.Validacao.OBRIGATORIO);

            _validar.addValidacao(txtSalario, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.VALOR });
            _validar.addValidacao(cboSituacao, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(cboCargo, clnUtilFormValidar.Validacao.OBRIGATORIO);

            _validar.addValidacao(mtbEndCEP, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CEP });
            _validar.addValidacao(txtEndLogradouro, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtEndNr, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.INT, clnUtilFormValidar.Validacao.QUANTIDADE });
            _validar.addValidacao(txtEndBairro, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(txtEndCidade, clnUtilFormValidar.Validacao.OBRIGATORIO);
            _validar.addValidacao(cboEndUF, clnUtilFormValidar.Validacao.OBRIGATORIO);

            mtbCPF.Mask = clnUtil.MASK_CPF;
            mtbDataNasc.Mask = clnUtil.MASK_DATA;
            cboGenero.addRange(new String[] { "M", "F" });
            mtbTelCel.Mask = clnUtil.MASK_CEL;
            mtbTelRes.Mask = clnUtil.MASK_TEL;
            mtbEndCEP.Mask = clnUtil.MASK_CEP;
        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                int codCargo = cboCargo.SelectedItem.Id;
                clnArquivo objArquivo = null;
                if (ObjFuncionario != null)
                {
                    clnArquivo objArquivoAtual = new clnArquivo
                    {
                        Cod = ObjFuncionario.CodFoto
                    }.obterPorCodigo();
                    if (!objArquivoAtual.Local.Equals(picImagem.ImageLocation))
                    {
                        objArquivo = new clnArquivo
                        {
                            Local = picImagem.ImageLocation
                        };
                        objArquivo.gravar();
                    }
                    else
                    {
                        objArquivo = objArquivoAtual;
                    }
                }
                else
                {
                    objArquivo = new clnArquivo
                    {
                        Local = picImagem.ImageLocation
                    };
                    objArquivo.gravar();
                }

                if (ObjFuncionario == null)
                {
                    clnFuncionario objFuncionarioCpf = new clnFuncionario
                    {
                        Cpf = clnUtilFormatar.retirarFormatacao(mtbCPF.Text)
                    }.obterPorCPF();

                    if (objFuncionarioCpf == null)
                    {
                        clnFuncionario objFuncionario = new clnFuncionario
                        {
                            CodCargo = codCargo,
                            CodFoto = objArquivo.Cod,
                            Nome = txtNome.Text,
                            Cpf = clnUtilFormatar.retirarFormatacao(mtbCPF.Text),
                            Rg = txtRG.Text,
                            Genero = cboGenero.Text,
                            DataNascimento = clnUtilConvert.ObterData(mtbDataNasc.Text),
                            TelRes = clnUtilFormatar.retirarFormatacao(mtbTelRes.Text),
                            TelCel = clnUtilFormatar.retirarFormatacao(mtbTelCel.Text),
                            Email = txtEmail.Text,
                            Salario = clnUtilConvert.ToDecimal(txtSalario.Text),
                            DataContratacao = DateTime.Now,
                            Situacao = (clnFuncionario.funcionarioSituacao)Enum.Parse(typeof(clnFuncionario.funcionarioSituacao), cboSituacao.Text),
                            EndCEP = clnUtilFormatar.retirarFormatacao(mtbEndCEP.Text),
                            EndLogradouro = txtEndLogradouro.Text,
                            EndNumero = txtEndNr.Text,
                            EndComplemento = txtEndComplemento.Text,
                            EndBairro = txtEndBairro.Text,
                            EndLocalidade = txtEndCidade.Text,
                            EndUF = cboEndUF.Text
                        };
                        objFuncionario.gravar();
                        ObjFuncionario = objFuncionario;
                        clnUtilMensagem.mostrarOk("Cadastro de Funcionário", "Funcionário cadastrado com sucesso!");
                        Close();
                    }
                    else
                    {
                        clnUtilMensagem.mostrarOk("Cadastro de Funcionário", "Não foi possível cadastrar o funcionário, o CPF já está cadastrado!");
                        mtbCPF.Focus();
                    }
                }
                else
                {
                    ObjFuncionario.Nome = txtNome.Text;
                    ObjFuncionario.CodCargo = codCargo;
                    ObjFuncionario.CodFoto = objArquivo.Cod;
                    ObjFuncionario.DataNascimento = clnUtilConvert.ObterData(mtbDataNasc.Text);
                    ObjFuncionario.Email = txtEmail.Text;
                    ObjFuncionario.Genero = cboGenero.Text;
                    ObjFuncionario.TelRes = clnUtilFormatar.retirarFormatacao(mtbTelRes.Text);
                    ObjFuncionario.TelCel = clnUtilFormatar.retirarFormatacao(mtbTelCel.Text);
                    ObjFuncionario.Salario = clnUtilConvert.ToDecimal(txtSalario.Text);
                    ObjFuncionario.Situacao = (clnFuncionario.funcionarioSituacao)Enum.Parse(typeof(clnFuncionario.funcionarioSituacao), cboSituacao.Text);
                    ObjFuncionario.EndCEP = clnUtilFormatar.retirarFormatacao(mtbEndCEP.Text);
                    ObjFuncionario.EndLogradouro = txtEndLogradouro.Text;
                    ObjFuncionario.EndNumero = txtEndNr.Text;
                    ObjFuncionario.EndComplemento = txtEndComplemento.Text;
                    ObjFuncionario.EndBairro = txtEndBairro.Text;
                    ObjFuncionario.EndLocalidade = txtEndCidade.Text;
                    ObjFuncionario.EndUF = cboEndUF.Text;
                    ObjFuncionario.alterar();
                    clnUtilMensagem.mostrarOk("Alteração de Funcionário", "Funcionário alterado com sucesso!");
                    Close();
                }
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

        private void definirImagemPadrao()
        {
            picImagem.ImageLocation = clnArquivo.tempImage(global::BURGERSHACK_DESKTOP.Properties.Resources.ingrediente);
        }

        private void adicionarImagem()
        {
            OpenFileDialog objDialog = new OpenFileDialog
            {
                Filter = "png|*.png"
            };
            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                picImagem.ImageLocation = objDialog.FileName;
            }
        }

        private void abrirAcesso()
        {
            clnAcesso objAcesso = new clnAcesso
            {
                CodFuncionario = ObjFuncionario.Cod
            }.obterPorFuncionario();

            if (objAcesso == null)
            {
                objAcesso = new clnAcesso
                {
                    CodFuncionario = ObjFuncionario.Cod
                };
            }
            frmAcesso frmAcesso = new frmAcesso
            {
                ObjAcesso = objAcesso
            };
            frmAcesso.ShowDialog();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            clnUtil.definirCEP(mtbEndCEP, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF.cbo, txtEndNr, txtEndComplemento);

            foreach (clnCargo objCargo in new clnCargo().obterCargos())
            {
                cboCargo.add(objCargo.Cod, objCargo.Cod + " - " + objCargo.Nome);
            }
            cboSituacao.addRange(new object[] { clnFuncionario.funcionarioSituacao.TREINAMENTO, clnFuncionario.funcionarioSituacao.PLENO });

            if (ObjFuncionario == null)
            {
                hdrUIX.Title = App.Name + " - Novo Funcionário";

                definirImagemPadrao();
                btnAcesso.Hide();
            }
            else
            {
                hdrUIX.Title = App.Name + " - Alterando Funcionário " + ObjFuncionario.Cod;
                mtbCPF.Enabled = false;

                txtNome.Text = ObjFuncionario.Nome;
                mtbCPF.Text = ObjFuncionario.Cpf;
                txtRG.Text = ObjFuncionario.Rg;
                mtbDataNasc.Text = clnUtilFormatar.formatarData(ObjFuncionario.DataNascimento);
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
                    Cod = ObjFuncionario.CodCargo
                }.obterPorCod();
                cboCargo.Text = objCargo.Cod + " - " + objCargo.Nome;

                clnArquivo objFoto = new clnArquivo
                {
                    Cod = ObjFuncionario.CodFoto
                }.obterPorCodigo();
                picImagem.ImageLocation = objFoto.Local;
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

        private void btnImgAdicionar_Click(object sender, EventArgs e)
        {
            adicionarImagem();
        }

        private void btnImgRemover_Click(object sender, EventArgs e)
        {
            if (clnUtilMensagem.mostrarSimNao("Imagem", "Deseja realmente remover a imagem?", clnUtilMensagem.MensagemIcone.INFO))
            {
                definirImagemPadrao();
            }
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            abrirAcesso();
        }
    }
}
