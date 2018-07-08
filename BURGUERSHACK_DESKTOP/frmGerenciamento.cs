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
using UIX;

namespace BURGUERSHACK_DESKTOP
{
    public partial class frmGerenciamento : Form
    {

        private int _codFuncionario;

        public int CodFuncionario { get => _codFuncionario; set => _codFuncionario = value; }

        public frmGerenciamento()
        {
            InitializeComponent();
        }

        private void alterarConteudo(UserControl uctConteudo, String titulo, bool ignorarTipo)
        {
            clnUtil.alterarConteudo(pnlConteudo, uctConteudo, hdrUIX, "Gerenciamento :: " + titulo, ignorarTipo);
        }

        private void abrirLista(String tipo, IUtilCallback<int> callbackNovo, IUtilCallback<DataGridView, String> callbackObter, IUtilCallback<DataGridViewRow> callbackAlterar, String[] colunas)
        {
            uctGerenciamentoListar objListar = new uctGerenciamentoListar
            {
                CallbackNovo = callbackNovo,
                Colunas = colunas,
                CallbackObter = callbackObter,
                CallbackAlterar = callbackAlterar,
                CodFuncionario = CodFuncionario
            };
            alterarConteudo(objListar, tipo, true);
        }

        private void abrirIngredientes()
        {
            abrirLista("Ingredientes", new CallbackIngredienteNovo(), new CallbackIngredienteObter(), new CallbackIngredienteAlterar(), new String[] { "Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor" });
        }

        private void abrirProdutos()
        {
            abrirLista("Produtos", new CallbackProdutoNovo(), new CallbackProdutoObter(), new CallbackProdutoAlterar(), new String[] { "Código", "Nome", "Situação", "Tipo", "Valor" });
        }

        private void abrirClientes()
        {
            abrirLista("Clientes", new CallbackClienteNovo(), new CallbackClienteObter(), new CallbackClienteAlterar(), new String[] { "Código", "Nome", "CPF", "Celular", "Data Nasc.", "Gênero", "Email" });
        }

        private void abrirFuncionarios()
        {
            abrirLista("Funcionários", new CallbackFuncionarioNovo(), new CallbackFuncionarioObter(), new CallbackFuncionarioAlterar(), new String[] { "Código", "Nome", "CPF", "RG", "Data Nasc.", "Gênero", "Cargo", "Salário", "Situação" });
        }

        private void abrirFornecedores()
        {
            abrirLista("Fornecedores", new CallbackFornecedorNovo(), new CallbackFornecedorObter(), new CallbackFornecedorAlterar(), new String[] { "Código", "Razão Social", "CNPJ", "Telefone", "Email" });
        }

        private void abrirReservas()
        {
            abrirLista("Reservas", new CallbackReservaNovo(), new CallbackReservaObter(), new CallbackReservaAlterar(), new String[] { "Código", "Pessoas", "Data", "Situação" });
        }

        private void abrirEstoques()
        {
            abrirLista("Estoques", new CallbackEstoqueNovo(), new CallbackEstoqueObter(), new CallbackEstoqueAlterar(), new String[] { "Código", "Ingrediente", "Fornecedor", "Quantidade", "Validade", "Valor" });
        }

        private void sair()
        {
            Close();
        }

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarForm(this);
            UIX.uixButton.btnApply(btnVoltar, AppDesktop.VisualStyle.ButtonWarningColor);

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

        private class CallbackIngredienteNovo : IUtilCallback<int>
        {
            public bool call(int x)
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
                    Cod = clnUtilConvert.ToInt(row.Cells[0].Value)
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

        private class CallbackIngredienteObter : IUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                clnIngrediente objIngredientes = new clnIngrediente
                {
                    Nome = pesquisa
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
                        CodIngrediente = objIngrediente.Cod
                    }.obterQuantidadePorIngrediente();
                    //"Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor"
                    dgv.Rows.Add(new object[] { objIngrediente.Cod, objIngrediente.Nome, objIngrediente.Situacao, objTipo.Cod + " - " + objTipo.Nome, estoque, clnUtilFormatar.formatarValor(objIngrediente.Valor) });
                }
                return false;
            }
        }

        private class CallbackProdutoNovo : IUtilCallback<int>
        {
            public bool call(int x)
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
                    Cod = clnUtilConvert.ToInt(row.Cells[0].Value)
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

        private class CallbackProdutoObter : IUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                clnProduto objProdutos = new clnProduto
                {
                    Nome = pesquisa
                };
                foreach (clnProduto objProduto in objProdutos.obterPorNome())
                {
                    clnTipo objTipo = new clnTipo
                    {
                        Cod = objProduto.CodTipo,
                        Tipo = clnTipo.tipo.PRODUTO
                    }.obterPorCodigo();
                    //"Código", "Nome", "Situacao", "Tipo", "Estoque", "Valor"
                    dgv.Rows.Add(new object[] { objProduto.Cod, objProduto.Nome, objProduto.Situacao, objTipo.Cod + " - " + objTipo.Nome, clnUtilFormatar.formatarValor(objProduto.Valor) });
                }
                return false;
            }
        }

        private class CallbackClienteNovo : IUtilCallback<int>
        {
            public bool call(int codFuncionario)
            {
                frmCliente frmNovoCliente = new frmCliente
                {
                    CodFuncionario = codFuncionario
                };
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
                    Cod = clnUtilConvert.ToInt(row.Cells[0].Value)
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

        private class CallbackClienteObter : IUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                clnCliente objClientes = new clnCliente
                {
                    Nome = pesquisa,
                    Cpf = pesquisa
                };
                foreach (clnCliente objCliente in objClientes.obterPorNomeCPF())
                {
                    //"Código", "Nome", "CPF", "Celular", "Data Nasc", "Genero", "Email"
                    dgv.Rows.Add(new object[] { objCliente.Cod, objCliente.Nome, clnUtilFormatar.formatarCPF(objCliente.Cpf), clnUtilFormatar.formatarCelular(objCliente.TelCelular), clnUtilFormatar.formatarData(objCliente.DataNascimento), objCliente.Genero, objCliente.Email });
                }
                return false;
            }
        }

        private class CallbackFuncionarioNovo : IUtilCallback<int>
        {
            public bool call(int codFuncionario)
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
                    Cod = clnUtilConvert.ToInt(row.Cells[0].Value)
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

        private class CallbackFuncionarioObter : IUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                clnFuncionario objFuncionarios = new clnFuncionario
                {
                    Nome = pesquisa,
                    Cpf = pesquisa
                };
                foreach (clnFuncionario objFuncionario in objFuncionarios.obterPorNomeCPF())
                {
                    clnCargo objCargo = new clnCargo
                    {
                        Cod = objFuncionario.CodCargo
                    }.obterPorCod();

                    //"Código", "Nome", "CPF", "RG", "Data Nasc", "Genero", "Email","Celular", "Cargo", "Salario", "Situacao"
                    dgv.Rows.Add(new object[] { objFuncionario.Cod, objFuncionario.Nome, clnUtilFormatar.formatarCPF(objFuncionario.Cpf), objFuncionario.Rg, clnUtilFormatar.formatarData(objFuncionario.DataNascimento), objFuncionario.Genero, objCargo.Nome, clnUtilFormatar.formatarValor(objFuncionario.Salario), objFuncionario.Situacao });
                }
                return false;
            }
        }

        private class CallbackFornecedorNovo : IUtilCallback<int>
        {
            public bool call(int codFuncionario)
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
                    Cod = clnUtilConvert.ToInt(row.Cells[0].Value)
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

        private class CallbackFornecedorObter : IUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                clnFornecedor objFornecedores = new clnFornecedor
                {
                    RazaoSocial = pesquisa,
                    Cnpj = pesquisa
                };
                foreach (clnFornecedor objFornecedor in objFornecedores.obterPorRazaoCNPJ())
                {
                    //"Código", "Razão Social", "CNPJ", "Telefone", "Email"
                    dgv.Rows.Add(new object[] { objFornecedor.Cod, objFornecedor.RazaoSocial, clnUtilFormatar.formatarCNPJ(objFornecedor.Cnpj), clnUtilFormatar.formatarTelefone(objFornecedor.Telefone), objFornecedor.Email });
                }
                return false;
            }
        }

        private class CallbackReservaNovo : IUtilCallback<int>
        {
            public bool call(int codFuncionario)
            {
                frmReserva frmNovoReserva = new frmReserva
                {
                    CodFuncionario = codFuncionario
                };
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
                    Cod = clnUtilConvert.ToInt(row.Cells[0].Value)
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

        private class CallbackReservaObter : IUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                DateTime? data = clnUtilConvert.ObterNullableData(pesquisa);
                List<clnReserva> objReservas = null;
                if (data != null)
                {
                    objReservas = new clnReserva
                    {
                        Agendado = (DateTime)data
                    }.obterPorDataAgendada();
                }
                else
                {
                    objReservas = new clnReserva().obterReservas();
                }
                foreach (clnReserva objReserva in objReservas)
                {
                    //"Código", "Pessoas", "Data", "Situação"
                    dgv.Rows.Add(new object[] { objReserva.Cod, objReserva.Pessoas, clnUtilFormatar.formatarData(objReserva.Agendado), objReserva.Situacao });
                }
                return false;
            }
        }

        private class CallbackEstoqueNovo : IUtilCallback<int>
        {
            public bool call(int codFuncionario)
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
                    Cod = clnUtilConvert.ToInt(row.Cells[0].Value)
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

        private class CallbackEstoqueObter : IUtilCallback<DataGridView, String>
        {
            public bool call(DataGridView dgv, string pesquisa)
            {
                clnEstoque objEstoques = new clnEstoque();
                foreach (clnEstoque objEstoque in objEstoques.obterEstoques())
                {
                    clnIngrediente objIngrediente = new clnIngrediente
                    {
                        Cod = objEstoque.CodIngrediente
                    }.obterPorCod();

                    clnFornecedor objFornecedor = new clnFornecedor
                    {
                        Cod = objEstoque.CodFornecedor
                    }.obterPorCod();

                    //"Código", "Ingrediente", "Fornecedor", "Quantidade", "Validade", "Valor"
                    dgv.Rows.Add(new object[] { objEstoque.Cod, objIngrediente.Nome, objFornecedor.RazaoSocial, objEstoque.Quantidade, clnUtilFormatar.formatarData(objEstoque.Validade), clnUtilFormatar.formatarValor(objEstoque.Valor) });
                }
                return false;
            }
        }


    }
}
