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
                int codCargo = clnUtilConvert.ToInt(cboCargo.Text.Split('-')[0]);
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
                        Cpf = clnUtil.retirarFormatacao(mtbCPF.Text)
                    }.obterPorCPF();

                    if (objFuncionarioCpf == null)
                    {
                        clnFuncionario objFuncionario = new clnFuncionario
                        {
                            CodCargo = codCargo,
                            CodFoto = objArquivo.Cod,
                            Nome = txtNome.Text,
                            Cpf = clnUtil.retirarFormatacao(mtbCPF.Text),
                            Rg = txtRG.Text,
                            Genero = cboGenero.Text,
                            DataNascimento = clnUtilConvert.ObterData(mtbDataNasc.Text),
                            TelRes = clnUtil.retirarFormatacao(mtbTelRes.Text),
                            TelCel = clnUtil.retirarFormatacao(mtbTelCel.Text),
                            Email = txtEmail.Text,
                            Salario = clnUtilConvert.ToDouble(txtSalario.Text),
                            DataContratacao = DateTime.Now,
                            Situacao = (clnFuncionario.funcionarioSituacao)Enum.Parse(typeof(clnFuncionario.funcionarioSituacao), cboSituacao.Text),
                            EndCEP = clnUtil.retirarFormatacao(mtbEndCEP.Text),
                            EndLogradouro = txtEndLogradouro.Text,
                            EndNumero = txtEndNr.Text,
                            EndComplemento = txtEndComplemento.Text,
                            EndBairro = txtEndBairro.Text,
                            EndLocalidade = txtEndCidade.Text,
                            EndUF = cboEndUF.Text
                        };
                        objFuncionario.gravar();
                        ObjFuncionario = objFuncionario;
                        clnUtilMensagem.mostrarOk("Cadastro de Funcionário", "Funcionário cadastrado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                        Close();
                    }
                    else
                    {
                        clnUtilMensagem.mostrarOk("Cadastro de Funcionário", "Não foi possível cadastrar o funcionário, o CPF já está cadastrado!", clnUtilMensagem.MensagemIcone.ERRO);
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
                    ObjFuncionario.TelRes = clnUtil.retirarFormatacao(mtbTelRes.Text);
                    ObjFuncionario.TelCel = clnUtil.retirarFormatacao(mtbTelCel.Text);
                    ObjFuncionario.Salario = clnUtilConvert.ToDouble(txtSalario.Text);
                    ObjFuncionario.Situacao = (clnFuncionario.funcionarioSituacao)Enum.Parse(typeof(clnFuncionario.funcionarioSituacao), cboSituacao.Text);
                    ObjFuncionario.EndCEP = clnUtil.retirarFormatacao(mtbEndCEP.Text);
                    ObjFuncionario.EndLogradouro = txtEndLogradouro.Text;
                    ObjFuncionario.EndNumero = txtEndNr.Text;
                    ObjFuncionario.EndComplemento = txtEndComplemento.Text;
                    ObjFuncionario.EndBairro = txtEndBairro.Text;
                    ObjFuncionario.EndLocalidade = txtEndCidade.Text;
                    ObjFuncionario.EndUF = cboEndUF.Text;
                    ObjFuncionario.alterar();
                    clnUtilMensagem.mostrarOk("Alteração de Funcionário", "Funcionário alterado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
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
            picImagem.ImageLocation = clnArquivo.tempImage(global::BURGUER_SHACK_DESKTOP.Properties.Resources.ingrediente);
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            UIX.uixButton.btnApply(btnVoltar, App.VisualStyle.ButtonWarningColor);

            clnUtil.definirCEP(mtbEndCEP, txtEndLogradouro, txtEndBairro, txtEndCidade, cboEndUF.cbo, txtEndNr);

            foreach (clnCargo objCargo in new clnCargo().obterCargos())
            {
                cboCargo.Items.Add(objCargo.Cod + " - " + objCargo.Nome);
            }
            cboSituacao.Items.AddRange(new object[] { clnFuncionario.funcionarioSituacao.TREINAMENTO, clnFuncionario.funcionarioSituacao.PLENO });

            if (ObjFuncionario == null)
            {
                hdrUIX.Title = App.Name + " - Novo Funcionário";

                definirImagemPadrao();
            }
            else
            {
                hdrUIX.Title = App.Name + " - Alterando Funcionário " + ObjFuncionario.Cod;
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
    }
}
