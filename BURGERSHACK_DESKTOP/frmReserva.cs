using BurgerShack.Common;
using BurgerShack.Common.UTIL;
using BurgerShack.Desktop.UTIL;
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
    public partial class frmReserva : Form
    {

        private clnUtilFormValidar _validar;

        private int _codFuncionario;
        private clnReserva _objReserva;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }
        internal clnReserva ObjReserva { get => _objReserva; set => _objReserva = value; }

        public frmReserva()
        {
            InitializeComponent();

            _validar = new clnUtilFormValidar();
            _validar.addValidacao(mtbData, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.DATA, clnUtilFormValidar.Validacao.DATA_FUTURA });
            _validar.addValidacao(mtbHora, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.HORA });
            _validar.addValidacao(txtPessoas, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.INT, clnUtilFormValidar.Validacao.QUANTIDADE });
            _validar.addValidacao(mtbCliCPF, new clnUtilFormValidar.Validacao[] { clnUtilFormValidar.Validacao.OBRIGATORIO, clnUtilFormValidar.Validacao.CPF });

            mtbCliCPF.Mask = clnUtil.MASK_CPF;
            mtbData.Mask = clnUtil.MASK_DATA;
            mtbHora.Mask = clnUtil.MASK_HORA;
        }

        private bool encontrarCliente()
        {
            if (clnUtilValidar.validarCPF(mtbCliCPF.Text))
            {
                clnCliente objCliente = new clnCliente
                {
                    Cpf = clnUtilFormatar.retirarFormatacao(mtbCliCPF.Text)
                }.obterPorCPF();
                if (objCliente != null)
                {
                    definirCliente(objCliente);
                    return true;
                }
                else
                {
                    if (clnUtilMensagem.mostrarSimNao("Cliente", "Cliente não encontrado, deseja cadastrar?", clnUtilMensagem.MensagemIcone.INFO))
                    {
                        frmCliente frmNovoCliente = new frmCliente
                        {
                            CodFuncionario = CodFuncionario
                        };
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
                clnUtilMensagem.mostrarOk("Cliente", "O CPF informado é inválido.");
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
                                          + "Celular: " + clnUtilFormatar.formatarCelular(objCliente.TelCelular);
        }

        private void fechar()
        {
            if (ObjReserva.Cod != -1)
            {
                if (clnUtilMensagem.mostrarSimNao("Alteração de Reserva", "Deseja descartar as alterações realizadas?", clnUtilMensagem.MensagemIcone.INFO))
                {
                    Close();
                }
            }
            else
            {
                if (clnUtilMensagem.mostrarSimNao("Nova Reserva", "Deseja cancelar a reserva?", clnUtilMensagem.MensagemIcone.INFO))
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
                    }.obterPorCodigo();

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
            else if (clnUtilMensagem.mostrarSimNao("Mesas", "Esta reserva não possui nenhuma mesa, deseja adicionar?", clnUtilMensagem.MensagemIcone.OK))
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
                    clnUtilMensagem.mostrarOk("Mesas", "Não há mais mesas disponiveis para esta data.");
                }
            }
            else
            {
                clnUtilMensagem.mostrarOk("Mesas", "É necessário informar a data da reserva antes de adicionar mesas.");
            }
        }

        private DateTime? obterDataAgendada()
        {
            if (clnUtilValidar.validarData(mtbData.Text) && clnUtilValidar.validarDataFutura(mtbData.Text))
            {
                return clnUtilConvert.ObterNullableData(mtbData.Text);
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
                            DateTime horaAgendada = clnUtilConvert.ObterHora(mtbHora.Text);
                            dataAgendada = dataAgendada.AddHours(horaAgendada.Hour);
                            dataAgendada = dataAgendada.AddMinutes(horaAgendada.Minute);

                            ObjReserva.CodFuncionario = CodFuncionario;
                            ObjReserva.Situacao = clnReserva.reservaSituacao.MARCADA;
                            ObjReserva.Pessoas = clnUtilConvert.ToInt(txtPessoas.Text);
                            ObjReserva.Agendado = dataAgendada;
                            ObjReserva.Agendamento = DateTime.Now;

                            ObjReserva.gravar();

                            clnUtilMensagem.mostrarOk("Nova Reserva", "Reserva realizada com sucesso!");
                            Close();
                        }
                    }
                    else if (txtPessoas.Enabled)
                    {
                        ObjReserva.Pessoas = clnUtilConvert.ToInt(txtPessoas.Text);
                        ObjReserva.alterar();

                        clnUtilMensagem.mostrarOk("Alteração de Reserva", "Reserva alterada com sucesso!");
                        Close();
                    }
                    else
                    {
                        clnUtilMensagem.mostrarOk("Alteração de Reserva", "Não é possivel alterar esta reserva.");
                    }
                }
                else
                {
                    clnUtilMensagem.mostrarOk("Mesas", "É necessário selecionar pelo menos 1 mesa.");
                }
            }
        }

        private void tentarDefinirData()
        {
            if (clnUtilValidar.validarData(mtbData.Text) && clnUtilValidar.validarDataFutura(mtbData.Text))
            {
                DateTime dataAgendada = clnUtilConvert.ObterData(mtbData.Text).Date;
                if (!ObjReserva.Agendado.Equals(dataAgendada))
                {
                    ObjReserva.Agendado = dataAgendada;

                    if (ObjReserva.CodMesas.Count > 0)
                    {
                        ObjReserva.CodMesas.Clear();
                        clnUtilMensagem.mostrarOk("Mesas", "Como você alterou a data da reserva, sera necessário redefinir as mesas");
                    }
                }
            }
        }

        private void iniciarAtendimento()
        {
            if (clnUtilMensagem.mostrarSimNao("Reserva", "Deseja iniciar um atendimento para esta reserva?", clnUtilMensagem.MensagemIcone.OK))
            {
                List<int> objMesasIndisponiveis = new List<int>();

                foreach (int codMesa in ObjReserva.CodMesas)
                {
                    clnMesa objMesa = new clnMesa
                    {
                        Cod = codMesa
                    }.obterPorCodigo();

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
                        CodFuncionario = CodFuncionario,
                        Situacao = clnAtendimento.atendimentoSituacao.ANDAMENTO
                    };
                    objAtendimento.gravar();

                    ObjReserva.Situacao = clnReserva.reservaSituacao.UTILIZADA;
                    ObjReserva.alterar();

                    foreach (int codMesa in ObjReserva.CodMesas)
                    {
                        objAtendimento.adicionarMesa(codMesa);
                    }

                    clnUtilMensagem.mostrarOk("Reserva", "O atendimento foi iniciado para a(s) mesa(s) " + String.Join(",", ObjReserva.CodMesas.ToArray()));
                    Close();
                }
                else
                {
                    clnUtilMensagem.mostrarOk("Reserva", "Não foi possível iniciar o atendimento, a(s) mesa(s) " + String.Join(",", objMesasIndisponiveis.ToArray()) + " estão ocupadas.");
                }
            }
        }

        private void confirmarReserva()
        {
            if (clnUtilMensagem.mostrarSimNao("Reserva", "Voce deseja CONFIRMAR esta reserva?", clnUtilMensagem.MensagemIcone.INFO))
            {
                ObjReserva.Situacao = clnReserva.reservaSituacao.CONFIRMADA;
                ObjReserva.alterar();
                clnUtilMensagem.mostrarOk("Reserva", "Reserva CONFIRMADA com sucesso!");
                grbSituacao.Hide();
            }
        }

        private void cancelarReserva()
        {
            if (clnUtilMensagem.mostrarSimNao("Reserva", "Voce deseja CANCELAR esta reserva?", clnUtilMensagem.MensagemIcone.INFO))
            {
                ObjReserva.Situacao = clnReserva.reservaSituacao.CANCELADA;
                ObjReserva.alterar();
                clnUtilMensagem.mostrarOk("Reserva", "Reserva CANCELADA com sucesso!");
                Close();
            }
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
                hdrUIX.Title = App.Name + " - Alterando Reserva " + ObjReserva.Cod;
                mtbCliCPF.Enabled = false;
                mtbHora.Enabled = false;
                mtbData.Enabled = false;
                btnCliEncontrar.Hide();

                clnCliente objCliente = new clnCliente
                {
                    Cod = ObjReserva.CodCliente
                }.obterPorCod();
                exibirCliente(objCliente);
                mtbCliCPF.Text = objCliente.Cpf;

                mtbData.Text = clnUtilFormatar.formatarData(ObjReserva.Agendado);
                mtbHora.Text = clnUtilFormatar.formatarHora(ObjReserva.Agendado);
                txtPessoas.Text = clnUtilConvert.ToString(ObjReserva.Pessoas);

                if (ObjReserva.Situacao != clnReserva.reservaSituacao.MARCADA)
                {
                    grbMesas.Hide();
                }
                if (ObjReserva.Situacao == clnReserva.reservaSituacao.CANCELADA || ObjReserva.Situacao == clnReserva.reservaSituacao.UTILIZADA)
                {
                    txtPessoas.Enabled = false;
                    btnSalvar.Hide();
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
            }
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
            salvar();
        }

        private void mtbData_Validated(object sender, EventArgs e)
        {
            tentarDefinirData();
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
                if (clnUtilMensagem.mostrarSimNao("Reserva", "Deseja realmente remover a mesa " + objMesa.Cod + " da Reserva?", clnUtilMensagem.MensagemIcone.INFO))
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
                if (clnUtilMensagem.mostrarSimNao("Mesas", "Mesa " + objMesa.Cod + " adicionada a reserva. Deseja adicionar mais mesas?", clnUtilMensagem.MensagemIcone.INFO))
                {
                    return clnUtilVisualizar.VisualizarResult.REMOVER;
                }
                return clnUtilVisualizar.VisualizarResult.NENHUM;
            }
        }

    }
}
