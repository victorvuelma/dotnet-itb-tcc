using BurgerShack.Common;
using BurgerShack.Desktop.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util.Data;
using vitorrdgs.Util.Form;

namespace BurgerShack.Desktop
{
    public partial class frmReserva : Form
    {

        private clnUtilFormValidar _validar;

        private clnReserva _objReserva;

        internal clnReserva ObjReserva { get => _objReserva; set => _objReserva = value; }

        public frmReserva()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(mtbData, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.DATA, clnUtilFormValidar.Validacao.DATA_FUTURA });
            _validar.addValidacao(mtbHora, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.HORA });
            _validar.addValidacao(txtPessoas, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.INT, clnUtilFormValidar.Validacao.QUANTIDADE });
            _validar.addValidacao(mtbCliCPF, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CPF });

            mtbCliCPF.Mask = UtilMask.MASK_CPF;
            mtbData.Mask = UtilMask.MASK_DATA;
            mtbHora.Mask = UtilMask.MASK_HORA;
        }

        private bool encontrarCliente()
        {
            if (UtilValidar.validarCPF(mtbCliCPF.Text))
            {
                clnCliente objCliente = new clnCliente
                {
                    Cpf = UtilFormatar.retirarFormatacao(mtbCliCPF.Text)
                }.obterPorCPF();
                if (objCliente != null)
                {
                    definirCliente(objCliente);
                    return true;
                }
                else
                {
                    if (UtilMensagem.mostrarSimNao("Cliente", "Cliente não encontrado, deseja cadastrar?", UtilMensagem.MensagemIcone.INFO))
                    {
                        frmCliente frmNovoCliente = new frmCliente { };
                        frmNovoCliente.mtbCPF.Text = mtbCliCPF.Text;
                        frmNovoCliente.ShowDialog();

                        if (frmNovoCliente.ObjCliente != null)
                        {
                            definirCliente(frmNovoCliente.ObjCliente);
                            return true;
                        }
                    }
                }
            }
            else
            {
                UtilMensagem.mostrarOk("Cliente", "O CPF informado é inválido.");
            }
            return false;
        }

        private void definirCliente(clnCliente objCliente)
        {
            ObjReserva.CodCliente = objCliente.Cod;
            exibirCliente(objCliente);
        }

        private void exibirCliente(clnCliente objCliente)
        {
            lblCliente.Text = "Cliente #" + objCliente.Cod + "\n"
                                          + "Nome: " + objCliente.Nome + "\n"
                                          + "Celular: " + UtilFormatar.formatarCelular(objCliente.TelCelular);
        }

        private void fechar()
        {
            if (ObjReserva.Cod != -1)
            {
                if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (UtilMensagem.mostrarSimNao("Alteração de Reserva", "Deseja descartar as alterações realizadas?", UtilMensagem.MensagemIcone.INFO))
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
            else
            {
                if (UtilMensagem.mostrarSimNao("Nova Reserva", "Deseja cancelar a reserva?", UtilMensagem.MensagemIcone.INFO))
                {
                    ObjReserva = null;
                    Close();
                }
            }
        }

        private void abrirMesas()
        {
            if (ObjReserva.CodMesas.Count > 0)
            {
                List<clnMesa> objMesas = new List<clnMesa>();

                foreach (int codMesa in ObjReserva.CodMesas)
                {
                    clnMesa objMesa = new clnMesa
                    {
                        Cod = codMesa
                    }.obterPorCod();

                    if (objMesa != null)
                    {
                        objMesas.Add(objMesa);
                    }
                }

                clnMesa.clnListar objListar = new clnMesa.clnListar
                {
                    Icone = Properties.Resources.mesa,
                    Opcoes = objMesas,
                    Titulo = "Selecione a Mesa"
                };
                clnUtilVisualizar<clnReserva, clnMesa> objVisualizar = new clnUtilVisualizar<clnReserva, clnMesa>
                {
                    Obj = ObjReserva,
                    Callback = new CallbackRemover(),
                    ObjListar = objListar
                };

                frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
                {
                    ObjVisualizar = objVisualizar
                };
                frmVisualizar.ShowDialog();
            }
            else if (UtilMensagem.mostrarSimNao("Mesas", "Esta reserva não possui nenhuma mesa, deseja adicionar?", UtilMensagem.MensagemIcone.OK))
            {
                adicionarMesa();
            }
        }

        private void adicionarMesa()
        {
            if (obterDataAgendada() != null)
            {
                List<clnMesa> objMesas = new clnMesa().obterMesas();

                List<int> codMesasReservadas = new clnReserva
                {
                    Agendado = (DateTime)obterDataAgendada()
                }.obterMesasReservadas();

                objMesas.RemoveAll(objMesa => (codMesasReservadas.Contains(objMesa.Cod) || ObjReserva.CodMesas.Contains(objMesa.Cod)));

                if (objMesas.Count > 0)
                {
                    clnMesa.clnListar objListar = new clnMesa.clnListar
                    {
                        Opcoes = objMesas,
                        Titulo = "Adicionar uma Mesa",
                        Icone = Properties.Resources.mesa
                    };
                    clnUtilVisualizar<clnReserva, clnMesa> objVisualizar = new clnUtilVisualizar<clnReserva, clnMesa>
                    {
                        ObjListar = objListar,
                        Callback = new CallbackAdicionar(),
                        Obj = ObjReserva
                    };

                    frmUtilVisualizar frmVisualizar = new frmUtilVisualizar
                    {
                        ObjVisualizar = objVisualizar
                    };
                    frmVisualizar.ShowDialog();
                }
                else
                {
                    UtilMensagem.mostrarOk("Mesas", "Não há mais mesas disponiveis para esta data.");
                }
            }
            else
            {
                UtilMensagem.mostrarOk("Mesas", "É necessário informar a data da reserva antes de adicionar mesas.");
            }
        }

        private DateTime? obterDataAgendada()
        {
            if (UtilValidar.validarData(mtbData.Text) && UtilValidar.validarDataFutura(mtbData.Text))
            {
                return UtilConvert.ObterNullableData(mtbData.Text);
            }
            return null;
        }

        private void salvar()
        {
            if (_validar.validar(this))
            {
                if (ObjReserva.CodMesas.Count > 0)
                {
                    if (ObjReserva.Cod == -1)
                    {
                        if (ObjReserva.CodCliente != -1 || encontrarCliente())
                        {
                            DateTime dataAgendada = (DateTime)obterDataAgendada();
                            DateTime horaAgendada = UtilConvert.ObterHora(mtbHora.Text);
                            dataAgendada = dataAgendada.AddHours(horaAgendada.Hour);
                            dataAgendada = dataAgendada.AddMinutes(horaAgendada.Minute);

                            ObjReserva.CodFuncionario = AppDesktop.FuncionarioAtual.Cod;
                            ObjReserva.Situacao = clnReserva.reservaSituacao.MARCADA;
                            ObjReserva.Pessoas = UtilConvert.ToInt(txtPessoas.Text);
                            ObjReserva.Agendado = dataAgendada;
                            ObjReserva.Agendamento = DateTime.Now;
                            ObjReserva.Informacoes = txtInformacoes.Text;

                            ObjReserva.gravar();

                            UtilMensagem.mostrarOk("Nova Reserva", "Reserva realizada com sucesso!");
                            Close();
                        }
                    }
                    else if (txtPessoas.Enabled)
                    {
                        ObjReserva.Pessoas = UtilConvert.ToInt(txtPessoas.Text);
                        ObjReserva.Informacoes = txtInformacoes.Text;
                        ObjReserva.alterar();

                        UtilMensagem.mostrarOk("Alteração de Reserva", "Reserva alterada com sucesso!");
                        Close();
                    }
                    else
                    {
                        UtilMensagem.mostrarOk("Alteração de Reserva", "Não é possivel alterar esta reserva.");
                    }
                }
                else
                {
                    UtilMensagem.mostrarOk("Mesas", "É necessário selecionar pelo menos 1 mesa.");
                }
            }
        }

        private void tentarDefinirData()
        {
            if (UtilValidar.validarData(mtbData.Text) && UtilValidar.validarDataFutura(mtbData.Text))
            {
                DateTime dataAgendada = UtilConvert.ObterData(mtbData.Text).Date;
                if (!ObjReserva.Agendado.Equals(dataAgendada))
                {
                    ObjReserva.Agendado = dataAgendada;

                    if (ObjReserva.CodMesas.Count > 0)
                    {
                        ObjReserva.CodMesas.Clear();
                        UtilMensagem.mostrarOk("Mesas", "Como você alterou a data da reserva, sera necessário redefinir as mesas");
                    }
                }
            }
        }

        private void iniciarAtendimento()
        {
            if (UtilMensagem.mostrarSimNao("Reserva", "Deseja iniciar um atendimento para esta reserva?", UtilMensagem.MensagemIcone.OK))
            {
                List<int> objMesasIndisponiveis = new List<int>();

                foreach (int codMesa in ObjReserva.CodMesas)
                {
                    clnMesa objMesa = new clnMesa
                    {
                        Cod = codMesa
                    }.obterPorCod();

                    if (objMesa.Situacao == clnMesa.mesaSituacao.OCUPADA)
                    {
                        objMesasIndisponiveis.Add(codMesa);
                    }
                }

                if (objMesasIndisponiveis.Count == 0)
                {
                    clnAtendimento objAtendimento = new clnAtendimento
                    {
                        CodCliente = ObjReserva.CodCliente,
                        CodReserva = ObjReserva.Cod,
                        Inicio = DateTime.Now,
                        CodFuncionario = AppDesktop.FuncionarioAtual.Cod,
                        Situacao = clnAtendimento.atendimentoSituacao.ANDAMENTO
                    };
                    objAtendimento.gravar();

                    ObjReserva.Situacao = clnReserva.reservaSituacao.UTILIZADA;
                    ObjReserva.alterar();

                    foreach (int codMesa in ObjReserva.CodMesas)
                    {
                        objAtendimento.adicionarMesa(codMesa);
                    }

                    UtilMensagem.mostrarOk("Reserva", "O atendimento foi iniciado para a(s) mesa(s) " + String.Join(",", ObjReserva.CodMesas.ToArray()));
                    Close();
                }
                else
                {
                    UtilMensagem.mostrarOk("Reserva", "Não foi possível iniciar o atendimento, a(s) mesa(s) " + String.Join(",", objMesasIndisponiveis.ToArray()) + " estão ocupadas.");
                }
            }
        }

        private void confirmarReserva()
        {
            if (UtilMensagem.mostrarSimNao("Reserva", "Voce deseja CONFIRMAR esta reserva?", UtilMensagem.MensagemIcone.INFO))
            {
                ObjReserva.Situacao = clnReserva.reservaSituacao.CONFIRMADA;
                ObjReserva.alterar();
                UtilMensagem.mostrarOk("Reserva", "Reserva CONFIRMADA com sucesso!");
                grbSituacao.Hide();
            }
        }

        private void cancelarReserva()
        {
            if (UtilMensagem.mostrarSimNao("Reserva", "Voce deseja CANCELAR esta reserva?", UtilMensagem.MensagemIcone.INFO))
            {
                ObjReserva.Situacao = clnReserva.reservaSituacao.CANCELADA;
                ObjReserva.alterar();
                UtilMensagem.mostrarOk("Reserva", "Reserva CANCELADA com sucesso!");
                Close();
            }
        }

        private void excluir()
        {
            if (UtilMensagem.mostrarSimNao("Reserva", "Você deseja realmente excluir esta reserva?", UtilMensagem.MensagemIcone.ERRO))
            {
                ObjReserva.Ativo = false;
                ObjReserva.Situacao = clnReserva.reservaSituacao.CANCELADA;
                ObjReserva.alterar();

                btnAlterar.Hide();
                UtilButton.restaurar(btnExcluir);
                UtilForm.Disable(this);
            }
        }

        private void restaurar()
        {
            if (UtilMensagem.mostrarSimNao("Reserva", "Você deseja realmente restaurar esta reserva?", UtilMensagem.MensagemIcone.OK))
            {
                ObjReserva.Ativo = true;
                ObjReserva.alterar();

                if (ObjReserva.Situacao == clnReserva.reservaSituacao.CANCELADA || ObjReserva.Situacao == clnReserva.reservaSituacao.UTILIZADA)
                {
                    txtPessoas.Enabled = false;
                    btnAlterar.Hide();
                } else
                {
                    btnAlterar.Show();
                }
                UtilButton.excluir(btnExcluir);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ObjReserva.Ativo)
            {
                excluir();
            }
            else
            {
                restaurar();
            }
            UtilButton.voltar(btnVoltar);
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            btnAtendimento.Hide();
            grbSituacao.Hide();

            if (ObjReserva == null)
            {
                hdrUIX.Title = App.Name + " - Nova Reserva";

                ObjReserva = new clnReserva();
            }
            else
            {
                hdrUIX.Title = App.Name + " - Reserva " + ObjReserva.Cod;
                mtbCliCPF.Enabled = false;
                btnCliEncontrar.Hide();

                clnCliente objCliente = new clnCliente
                {
                    Cod = ObjReserva.CodCliente
                }.obterPorCod();
                exibirCliente(objCliente);
                mtbCliCPF.Text = objCliente.Cpf;

                mtbData.Text = UtilFormatar.formatarData(ObjReserva.Agendado);
                mtbHora.Text = UtilFormatar.formatarHora(ObjReserva.Agendado);
                txtPessoas.Text = UtilConvert.ToString(ObjReserva.Pessoas);
                txtInformacoes.Text = ObjReserva.Informacoes;

                UtilForm.Disable(this);

                if (ObjReserva.Situacao != clnReserva.reservaSituacao.MARCADA)
                {
                    grbMesas.Hide();
                }
                if (ObjReserva.Situacao == clnReserva.reservaSituacao.CANCELADA || ObjReserva.Situacao == clnReserva.reservaSituacao.UTILIZADA)
                {
                    txtPessoas.Enabled = false;
                    btnAlterar.Hide();
                }
                else
                {
                    if (ObjReserva.Situacao == clnReserva.reservaSituacao.MARCADA)
                    {
                        grbSituacao.Show();
                    }
                    if (ObjReserva.Agendado.Day.Equals(DateTime.Now.Day))
                    {
                        btnAtendimento.Show();
                    }
                }

                if (AppDesktop.FuncionarioAtual.CodCargo >= 3)
                {
                    btnExcluir.Show();
                    UtilButton.alterar(btnAlterar);
                    UtilButton.voltar(btnVoltar);
                    if (ObjReserva.Ativo)
                    {
                        UtilButton.excluir(btnExcluir);
                    }
                    else
                    {
                        btnAlterar.Hide();
                        UtilButton.restaurar(btnExcluir);
                    }
                }
            }

            mtbCliCPF.Focus();
        }

        private void btnCliEncontrar_Click(object sender, EventArgs e)
        {
            encontrarCliente();
        }

        private void btnMesaVer_Click(object sender, EventArgs e)
        {
            abrirMesas();
        }

        private void btnMesaAdd_Click(object sender, EventArgs e)
        {
            adicionarMesa();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Description.Equals("Salvar", StringComparison.InvariantCultureIgnoreCase))
            {
                salvar();
            }
            else
            {
                UtilForm.Enable(this);
                mtbCliCPF.Enabled = false;

                UtilButton.cancelar(btnVoltar);
                UtilButton.salvar(btnAlterar);
            }
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            iniciarAtendimento();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmarReserva();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelarReserva();
        }

        private class CallbackRemover : clnUtilVisualizar.IVisualizarCallback<clnReserva, clnMesa>
        {
            public clnUtilVisualizar.VisualizarResult call(clnReserva objReserva, clnMesa objMesa)
            {
                if (UtilMensagem.mostrarSimNao("Reserva", "Deseja realmente remover a mesa " + objMesa.Cod + " da Reserva?", UtilMensagem.MensagemIcone.INFO))
                {
                    objReserva.removerMesa(objMesa.Cod);
                    return clnUtilVisualizar.VisualizarResult.REMOVER;
                }
                return clnUtilVisualizar.VisualizarResult.NENHUM;
            }
        }

        private class CallbackAdicionar : clnUtilVisualizar.IVisualizarCallback<clnReserva, clnMesa>
        {
            public clnUtilVisualizar.VisualizarResult call(clnReserva objReserva, clnMesa objMesa)
            {
                objReserva.addMesa(objMesa.Cod);
                if (UtilMensagem.mostrarSimNao("Mesas", "Mesa " + objMesa.Cod + " adicionada a reserva. Deseja adicionar mais mesas?", UtilMensagem.MensagemIcone.INFO))
                {
                    return clnUtilVisualizar.VisualizarResult.REMOVER;
                }
                return clnUtilVisualizar.VisualizarResult.NENHUM;
            }
        }

        private void mtbData_TextChange(object sender, EventArgs e)
        {
            tentarDefinirData();
        }
    }
}
