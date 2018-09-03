using BurgerShack.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.Util;
using vitorrdgs.Util.Data;

namespace BurgerShack.Desktop
{
    public partial class frmGerenciamento : Form
    {

        public frmGerenciamento()
        {
            InitializeComponent();
        }

        private void abrirLista(String titulo, IUtilCallback callbackNovo, IUtilCallback<DataGridView, String, bool> callbackObter, IUtilCallback<DataGridViewRow> callbackAlterar, bool inativos, String[] colunas)
        {
            titulo = App.Name + " - Gerenciamento :: " + titulo;
            if (!hdrUIX.Title.Equals(titulo, StringComparison.InvariantCultureIgnoreCase))
            {
                uctListar.CallbackNovo = callbackNovo;
                uctListar.Colunas = colunas;
                uctListar.CallbackObter = callbackObter;
                uctListar.CallbackAlterar = callbackAlterar;
                uctListar.Inativos = inativos;

                hdrUIX.Title = titulo;

                uctListar.atualizar();
            }
        }

        private void abrirIngredientes()
        {
            abrirLista("Ingredientes", new CallbackIngredienteNovo(), new CallbackIngredienteObter(), new CallbackIngredienteAlterar(), true, new String[] { "Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor" });
        }

        private void abrirProdutos()
        {
            abrirLista("Produtos", new CallbackProdutoNovo(), new CallbackProdutoObter(), new CallbackProdutoAlterar(), true, new String[] { "Código", "Nome", "Situação", "Tipo", "Valor" });
        }

        private void abrirClientes()
        {
            abrirLista("Clientes", new CallbackClienteNovo(), new CallbackClienteObter(), new CallbackClienteAlterar(), true, new String[] { "Código", "Nome", "CPF", "Celular", "Data Nasc.", "Gênero", "Email" });
        }

        private void abrirFuncionarios()
        {
            abrirLista("Funcionários", new CallbackFuncionarioNovo(), new CallbackFuncionarioObter(), new CallbackFuncionarioAlterar(), true, new String[] { "Código", "Nome", "CPF", "RG", "Data Nasc.", "Gênero", "Cargo", "Salário", "Situação" });
        }

        private void abrirFornecedores()
        {
            abrirLista("Fornecedores", new CallbackFornecedorNovo(), new CallbackFornecedorObter(), new CallbackFornecedorAlterar(), true, new String[] { "Código", "Razão Social", "CNPJ", "Telefone", "Email" });
        }

        private void abrirReservas()
        {
            abrirLista("Reservas", new CallbackReservaNovo(), new CallbackReservaObter(), new CallbackReservaAlterar(), true, new String[] { "Código", "Pessoas", "Data", "Situação" });
        }

        private void abrirEstoques()
        {
            abrirLista("Estoques", new CallbackEstoqueNovo(), new CallbackEstoqueObter(), new CallbackEstoqueAlterar(), false, new String[] { "Código", "Mercadoria", "Fornecedor", "Quantidade", "Validade", "Valor" });
        }

        private void abrirMesas()
        {
            abrirLista("Mesas", new CallbackMesaNovo(), new CallbackMesaObter(), new CallbackMesaAlterar(), true, new String[] { "Código", "Número", "Lugares", "Situação" });
        }

        private void abrirAtendimentos()
        {
            abrirLista("Atendimentos", null, new CallbackAtendimentoObter(), new CallbackAtendimentoAlterar(), false, new String[] { "Código", "Número", "Lugares", "Situação" });
        }

        private void abrirPedidos()
        {
            abrirLista("Pedidos", null, new CallbackPedidoObter(), null, false, new String[] { "Código", "Valor", "Situação" });
        }

        private void abrirMercadorias()
        {
            abrirLista("Mercadorias", new CallbackMercadoriaNovo(), new CallbackMercadoriaObter(), new CallbackMercadoriaAlterar(), true, new String[] { "Código", "Descrição", "Código de Barras" });
        }

        private void abrirPagamentos()
        {
            abrirLista("Pagamentos", null, new CallbackPagamentoObter(), null, false, new String[] { "Código", "Data", "Forma", "Valor", "Cpf" });
        }

        private void sair()
        {
            Close();
        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

            abrirFuncionarios();
        }
        private void hdrUIX_Close(object sender, EventArgs e)
        {
            sair();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            abrirIngredientes();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirClientes();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            abrirProdutos();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            abrirFuncionarios();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            abrirFornecedores();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            abrirEstoques();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            abrirReservas();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            abrirMesas();
        }

        private void btnAtendimentos_Click(object sender, EventArgs e)
        {
            abrirAtendimentos();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            abrirPedidos();
        }

        private void btnMercadorias_Click(object sender, EventArgs e)
        {
            abrirMercadorias();
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            abrirPagamentos();
        }

        private class CallbackIngredienteNovo : IUtilCallback
        {
            public bool call()
            {
                frmIngrediente frmNovoIngrediente = new frmIngrediente { };
                frmNovoIngrediente.ShowDialog();
                return frmNovoIngrediente.ObjIngrediente != null;
            }
        }

        private class CallbackIngredienteAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objIngrediente != null)
                {
                    frmIngrediente frmAlterarIngrediente = new frmIngrediente
                    {
                        ObjIngrediente = objIngrediente
                    };
                    frmAlterarIngrediente.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackIngredienteObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnIngrediente objIngredientes = new clnIngrediente
                {
                    Nome = pesquisa,
                    Ativo = ativo
                };
                foreach (clnIngrediente objIngrediente in objIngredientes.obterPorNome())
                {
                    clnTipo objTipo = new clnTipo
                    {
                        Cod = objIngrediente.CodTipo,
                        Tipo = clnTipo.tipo.INGREDIENTE
                    }.obterPorCodigo();

                    int estoque = new clnEstoque
                    {
                        CodMercadoria = objIngrediente.Cod
                    }.obterQuantidadePorMercadoria();

                    //"Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor"
                    dgv.Rows.Add(new object[] { objIngrediente.Cod, objIngrediente.Nome, objIngrediente.Situacao, objTipo.Cod + " - " + objTipo.Nome, estoque, UtilFormatar.formatarValor(objIngrediente.Valor) });
                }
                return false;
            }
        }

        private class CallbackProdutoNovo : IUtilCallback
        {
            public bool call()
            {
                frmProduto frmNovoProduto = new frmProduto { };
                frmNovoProduto.ShowDialog();
                return frmNovoProduto.ObjProduto != null;
            }
        }

        private class CallbackProdutoAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnProduto objProduto = new clnProduto
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objProduto != null)
                {
                    frmProduto frmAlterarProduto = new frmProduto
                    {
                        ObjProduto = objProduto
                    };
                    frmAlterarProduto.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackProdutoObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnProduto objProdutos = new clnProduto
                {
                    Nome = pesquisa,
                    Ativo = ativo
                };
                foreach (clnProduto objProduto in objProdutos.obterPorNome())
                {
                    clnTipo objTipo = new clnTipo
                    {
                        Cod = objProduto.CodTipo,
                        Tipo = clnTipo.tipo.PRODUTO
                    }.obterPorCodigo();
                    //"Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor"
                    dgv.Rows.Add(new object[] { objProduto.Cod, objProduto.Nome, objProduto.Situacao, objTipo.Cod + " - " + objTipo.Nome, UtilFormatar.formatarValor(objProduto.Valor) });
                }
                return false;
            }
        }

        private class CallbackClienteNovo : IUtilCallback
        {
            public bool call()
            {
                frmCliente frmNovoCliente = new frmCliente { };
                frmNovoCliente.ShowDialog();
                return frmNovoCliente.ObjCliente != null;
            }
        }

        private class CallbackClienteAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnCliente objCliente = new clnCliente
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objCliente != null)
                {
                    frmCliente frmAlterarCliente = new frmCliente
                    {
                        ObjCliente = objCliente
                    };
                    frmAlterarCliente.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackClienteObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnCliente objClientes = new clnCliente
                {
                    Nome = pesquisa,
                    Cpf = pesquisa,
                    Ativo = ativo
                };
                foreach (clnCliente objCliente in objClientes.obterPorNomeCPF())
                {
                    //"Código", "Nome", "CPF", "Celular", "Data Nasc", "Genero", "Email"
                    dgv.Rows.Add(new object[] { objCliente.Cod, objCliente.Nome, UtilFormatar.formatarCPF(objCliente.Cpf), UtilFormatar.formatarCelular(objCliente.TelCelular), UtilFormatar.formatarData(objCliente.DataNascimento), objCliente.Genero, objCliente.Email });
                }
                return false;
            }
        }

        private class CallbackFuncionarioNovo : IUtilCallback
        {
            public bool call()
            {
                frmFuncionario frmNovoFuncionario = new frmFuncionario();
                frmNovoFuncionario.ShowDialog();
                return frmNovoFuncionario.ObjFuncionario != null;
            }
        }

        private class CallbackFuncionarioAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnFuncionario objFuncionario = new clnFuncionario
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objFuncionario != null)
                {
                    frmFuncionario frmAlterarFuncionario = new frmFuncionario
                    {
                        ObjFuncionario = objFuncionario
                    };
                    frmAlterarFuncionario.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackFuncionarioObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnFuncionario objFuncionarios = new clnFuncionario
                {
                    Nome = pesquisa,
                    Cpf = pesquisa,
                    Ativo = ativo
                };
                foreach (clnFuncionario objFuncionario in objFuncionarios.obterPorNomeCPF())
                {
                    clnCargo objCargo = new clnCargo
                    {
                        Cod = objFuncionario.CodCargo
                    }.obterPorCod();

                    //"Código", "Nome", "CPF", "RG", "Data Nasc", "Genero", "Email","Celular", "Cargo", "Salario", "Situacao"
                    dgv.Rows.Add(new object[] { objFuncionario.Cod, objFuncionario.Nome, UtilFormatar.formatarCPF(objFuncionario.Cpf), objFuncionario.Rg, UtilFormatar.formatarData(objFuncionario.DataNascimento), objFuncionario.Genero, objCargo.Nome, UtilFormatar.formatarValor(objFuncionario.Salario), objFuncionario.Situacao });
                }
                return false;
            }
        }

        private class CallbackFornecedorNovo : IUtilCallback
        {
            public bool call()
            {
                frmFornecedor frmNovoFornecedor = new frmFornecedor();
                frmNovoFornecedor.ShowDialog();
                return frmNovoFornecedor.ObjFornecedor != null;
            }
        }

        private class CallbackFornecedorAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnFornecedor objFornecedor = new clnFornecedor
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objFornecedor != null)
                {
                    frmFornecedor frmAlterarFornecedor = new frmFornecedor
                    {
                        ObjFornecedor = objFornecedor
                    };
                    frmAlterarFornecedor.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackFornecedorObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnFornecedor objFornecedores = new clnFornecedor
                {
                    RazaoSocial = pesquisa,
                    Cnpj = pesquisa,
                    Ativo = ativo
                };
                foreach (clnFornecedor objFornecedor in objFornecedores.obterPorRazaoCNPJ())
                {
                    //"Código", "Razão Social", "CNPJ", "Telefone", "Email"
                    dgv.Rows.Add(new object[] { objFornecedor.Cod, objFornecedor.RazaoSocial, UtilFormatar.formatarCNPJ(objFornecedor.Cnpj), UtilFormatar.formatarTelefone(objFornecedor.Telefone), objFornecedor.Email });
                }
                return false;
            }
        }

        private class CallbackReservaNovo : IUtilCallback
        {
            public bool call()
            {
                frmReserva frmNovoReserva = new frmReserva { };
                frmNovoReserva.ShowDialog();
                return frmNovoReserva.ObjReserva != null;
            }
        }

        private class CallbackReservaAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnReserva objReserva = new clnReserva
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objReserva != null)
                {
                    frmReserva frmAlterarReserva = new frmReserva
                    {
                        ObjReserva = objReserva
                    };
                    frmAlterarReserva.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackReservaObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                DateTime? data = UtilConvert.ObterNullableData(pesquisa);
                List<clnReserva> objReservas = null;
                if (data != null)
                {
                    objReservas = new clnReserva
                    {
                        Agendado = (DateTime)data,
                        Ativo = ativo
                    }.obterPorDataAgendada();
                }
                else
                {
                    objReservas = new clnReserva
                    {
                        Ativo = ativo
                    }.obterReservas();
                }
                foreach (clnReserva objReserva in objReservas)
                {
                    //"Código", "Pessoas", "Data", "Situação"
                    dgv.Rows.Add(new object[] { objReserva.Cod, objReserva.Pessoas, UtilFormatar.formatarData(objReserva.Agendado), objReserva.Situacao });
                }
                return false;
            }
        }

        private class CallbackEstoqueNovo : IUtilCallback
        {
            public bool call()
            {
                frmEstoque frmNovoEstoque = new frmEstoque();
                frmNovoEstoque.ShowDialog();
                return frmNovoEstoque.ObjEstoque != null;
            }
        }

        private class CallbackEstoqueAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnEstoque objEstoque = new clnEstoque
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objEstoque != null)
                {
                    frmEstoque frmAlterarEstoque = new frmEstoque
                    {
                        ObjEstoque = objEstoque
                    };
                    frmAlterarEstoque.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackEstoqueObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnEstoque objEstoques = new clnEstoque();
                foreach (clnEstoque objEstoque in objEstoques.obterEstoques())
                {
                    clnMercadoria objMercadoria = new clnMercadoria
                    {
                        Cod = objEstoque.CodMercadoria
                    }.obterPorCod();

                    clnFornecedor objFornecedor = new clnFornecedor
                    {
                        Cod = objEstoque.CodFornecedor
                    }.obterPorCod();

                    //"Código", "Mercadoria", "Fornecedor", "Quantidade", "Validade", "Valor"
                    dgv.Rows.Add(new object[] { objEstoque.Cod, objMercadoria.Descricao, objFornecedor.RazaoSocial, objEstoque.Quantidade, UtilFormatar.formatarData(objEstoque.Validade), UtilFormatar.formatarValor(objEstoque.Valor) });
                }
                return false;
            }
        }

        private class CallbackMesaNovo : IUtilCallback
        {
            public bool call()
            {
                frmMesa frmMesaNovo = new frmMesa();
                frmMesaNovo.ShowDialog();
                return frmMesaNovo.ObjMesa != null;
            }
        }

        private class CallbackMesaAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnMesa objMesa = new clnMesa
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objMesa != null)
                {
                    frmMesa frmAlterarMesa = new frmMesa
                    {
                        ObjMesa = objMesa
                    };
                    frmAlterarMesa.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackMesaObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnMesa objMesas = new clnMesa
                {
                    Ativo = ativo
                };
                foreach (clnMesa objMesa in objMesas.obterMesas())
                {
                    //"Código", "Número", "Lugares", "Situação"
                    dgv.Rows.Add(new object[] { objMesa.Cod, objMesa.Numero, objMesa.Lugares, objMesa.Situacao });
                }
                return false;
            }
        }

        private class CallbackAtendimentoAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnAtendimento objAtendimento = new clnAtendimento
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objAtendimento != null)
                {
                    frmAtendimento frmAlterarAtendimento = new frmAtendimento
                    {
                        ObjAtendimento = objAtendimento
                    };
                    frmAlterarAtendimento.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackAtendimentoObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnAtendimento objAtendimentos = new clnAtendimento
                {

                };
                foreach (clnAtendimento objAtendimento in objAtendimentos.obterAtendimentos())
                {
                    //"Código", "Inicio", "Fim", "Situação"
                    dgv.Rows.Add(new object[] { objAtendimento.Cod, UtilFormatar.formatarDataHora(objAtendimento.Inicio), UtilFormatar.formatarDataHora(objAtendimento.Fim), objAtendimento.Situacao });
                }
                return false;
            }
        }

        private class CallbackPedidoObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnPedido objPedidos = new clnPedido
                {
                };
                foreach (clnPedido objPedido in objPedidos.obterPedidos())
                {
                    //"Código", "Valor", "Situação"
                    dgv.Rows.Add(new object[] { objPedido.Cod, UtilFormatar.formatarValor(objPedido.Valor), objPedido.Situacao });
                }
                return false;
            }
        }

        private class CallbackMercadoriaNovo : IUtilCallback
        {
            public bool call()
            {
                frmMercadoria frmMercadoria = new frmMercadoria();
                frmMercadoria.ShowDialog();
                return frmMercadoria.ObjMercadoria != null;
            }
        }

        private class CallbackMercadoriaAlterar : IUtilCallback<DataGridViewRow>
        {
            public bool call(DataGridViewRow row)
            {
                clnMercadoria objMercadoria = new clnMercadoria
                {
                    Cod = UtilConvert.ToInt(row.Cells[0].Value)
                }.obterPorCod();

                if (objMercadoria != null)
                {
                    frmMercadoria frmAlterarMercadoria = new frmMercadoria
                    {
                        ObjMercadoria = objMercadoria
                    };
                    frmAlterarMercadoria.ShowDialog();
                    return true;
                }
                return false;
            }
        }

        private class CallbackMercadoriaObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnMercadoria objMercadorias = new clnMercadoria
                {
                    Ativo = ativo,
                    Descricao = pesquisa,
                    CodigoBarras = pesquisa
                };
                foreach (clnMercadoria objMercadoria in objMercadorias.obterMercadorias())
                {
                    //"Código", "Descrição", "Código de Barras"
                    dgv.Rows.Add(new object[] { objMercadoria.Cod, objMercadoria.Descricao, objMercadoria.CodigoBarras });
                }
                return false;
            }
        }

        private class CallbackPagamentoObter : IUtilCallback<DataGridView, String, bool>
        {
            public bool call(DataGridView dgv, string pesquisa, bool ativo)
            {
                clnPagamento objPagamentos = new clnPagamento
                {
                    Cpf = UtilFormatar.retirarFormatacao(pesquisa)
                };
                foreach (clnPagamento objPagamento in objPagamentos.obterPagamentosPorCpf())
                {
                    //"Código", "Data", "Forma", "Valor", "Cpf"

                    clnPagamentoForma objForma = new clnPagamentoForma
                    {
                        Cod = objPagamento.CodForma
                    }.obterPorCodigo();

                    dgv.Rows.Add(new object[] { objPagamento.Cod, UtilFormatar.formatarData(objPagamento.Data), objForma.Nome, UtilFormatar.formatarValor(objPagamento.Valor), UtilFormatar.formatarCPF(objPagamento.Cpf) });
                }
                return false;
            }
        }


    }
}
