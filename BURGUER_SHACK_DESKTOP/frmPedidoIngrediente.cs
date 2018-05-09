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

namespace BURGUER_SHACK_DESKTOP
{
    public partial class frmPedidoIngrediente : Form
    {

        private List<clnPedidoProdutoIngrediente> _ingredientes;

        private bool _remover;
        private clnPedidoProdutoIngrediente _ingredienteAntigo;
        private clnPedidoProdutoIngrediente _ingredienteNovo;

        public List<clnPedidoProdutoIngrediente> Ingredientes { get => _ingredientes; set => _ingredientes = value; }
        public bool Remover { get => _remover; set => _remover = value; }
        public clnPedidoProdutoIngrediente IngredienteAntigo { get => _ingredienteAntigo; set => _ingredienteAntigo = value; }
        public clnPedidoProdutoIngrediente IngredienteNovo { get => _ingredienteNovo; set => _ingredienteNovo = value; }

        public frmPedidoIngrediente()
        {
            InitializeComponent();

            hdrUIX.Title = clnApp.AppName + " :: Ingredientes";
        }

        private void esconderBotoes()
        {
            btnConfirmar.Hide();
            btnRemover.Hide();
        }

        private void escolherAlterar()
        {
            clnIngrediente objIngredienteAntigo = new clnIngrediente
            {
                Cod = IngredienteAntigo.Ingrediente
            }.obterPorCodigo();

            clnIngrediente objIngredientes = new clnIngrediente
            {
                Tipo = objIngredienteAntigo.Tipo
            };

            List<clnPedidoProdutoIngrediente> objPedidoIngredientes = new List<clnPedidoProdutoIngrediente>();
            foreach (clnIngrediente objIngrediente in objIngredientes.obterPorTipo())
            {
                clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente
                {
                    Quantidade = IngredienteAntigo.Quantidade,
                    ProdutoQuantidade = IngredienteAntigo.ProdutoQuantidade,
                    Ingrediente = objIngrediente.Cod
                };
                objPedidoIngredientes.Add(objPedidoIngrediente);
            }

            clnSelecionarIngrediente objSelecionar = new clnSelecionarIngrediente
            {
                Opcoes = objPedidoIngredientes,
                Selecionado = IngredienteNovo
            };

            frmSelecionar frmSelecionar = new frmSelecionar
            {
                ObjSelecionar = objSelecionar,
                Quantidade = ((IngredienteNovo == null) ? IngredienteAntigo.Quantidade : IngredienteNovo.Quantidade)
            };
            frmSelecionar.ShowDialog();

            esconderBotoes();
            btnConfirmar.Show();

            if (objSelecionar.Selecionado != null)
            {
                objSelecionar.Selecionado.Quantidade = frmSelecionar.Quantidade;
                IngredienteNovo = objSelecionar.Selecionado;

                exibirIngredienteNovo(objSelecionar.Selecionado);
            }
        }

        private void escolherAdicionar()
        {
            clnIngrediente objIngredientes = new clnIngrediente
            {
            };

            List<clnPedidoProdutoIngrediente> objPedidoIngredientes = new List<clnPedidoProdutoIngrediente>();
            foreach (clnIngrediente objIngrediente in objIngredientes.obterIngredientes())
            {
                clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente
                {
                    Quantidade = 1,
                    ProdutoQuantidade = 0,
                    Ingrediente = objIngrediente.Cod
                };
                objPedidoIngredientes.Add(objPedidoIngrediente);
            }

            clnSelecionarIngrediente objSelecionar = new clnSelecionarIngrediente
            {
                Opcoes = objPedidoIngredientes,
                Selecionado = IngredienteNovo
            };

            frmSelecionar frmSelecionar = new frmSelecionar
            {
                ObjSelecionar = objSelecionar,                
                Quantidade = ((IngredienteNovo == null) ? 1 : IngredienteNovo.Quantidade)
            };
            frmSelecionar.ShowDialog();

            esconderBotoes();
            btnConfirmar.Show();

            if (objSelecionar.Selecionado != null)
            {
                grbAntigo.Hide();

                objSelecionar.Selecionado.Quantidade = frmSelecionar.Quantidade;

                IngredienteNovo = objSelecionar.Selecionado;

                exibirIngredienteNovo(objSelecionar.Selecionado);
            }
        }

        private void exibirIngredienteNovo(clnPedidoProdutoIngrediente objPedidoIngrediente)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = objPedidoIngrediente.Ingrediente
            }.obterPorCodigo();

            picNovo.Image = objIngrediente.Imagem;
            lblNovoNome.Text = objIngrediente.Nome;
            txtQuantidade.Text = Convert.ToString(objPedidoIngrediente.Quantidade);

            picNovo.Show();
            lblNovoNome.Show();
            txtQuantidade.Show();
        }

        private void escolherAntigo()
        {
            clnSelecionarIngrediente objSelecionar = new clnSelecionarIngrediente
            {
                Opcoes = Ingredientes,
                Selecionado = IngredienteAntigo
            };

            frmSelecionar frmSelecionar = new frmSelecionar
            {
                ObjSelecionar = objSelecionar,
                Selecionando = "Selecione o ingrediente para alterar",
            };
            frmSelecionar.txtQuantidade.Hide();
            frmSelecionar.ShowDialog();

            esconderBotoes();
            btnAlterar.Text = "&Alterar";
            btnRemover.Show();

            if (objSelecionar.Selecionado != null)
            {
                exibirIngredienteAntigo(objSelecionar.Selecionado);
                IngredienteAntigo = objSelecionar.Selecionado;

                IngredienteNovo = null;

                picNovo.Hide();
                lblNovoNome.Hide();
                txtQuantidade.Hide();
            }
        }

        private void exibirIngredienteAntigo(clnPedidoProdutoIngrediente objPedidoIngrediente)
        {
            clnIngrediente objIngrediente = new clnIngrediente
            {
                Cod = objPedidoIngrediente.Ingrediente
            }.obterPorCodigo();

            picAntigo.Image = objIngrediente.Imagem;
            lblAntigoNome.Text = objIngrediente.Nome;
            lblQuantidade.Text = "Quantidade: " + objPedidoIngrediente.Quantidade;

            picAntigo.Show();
            lblAntigoNome.Show();
            lblQuantidade.Show();
        }

        private void finalizar()
        {
            if (clnMensagem.mostrarSimNao("Ingredientes", "Deseja cancelar as alterações de ingredientes?", clnMensagem.MensagemIcone.ERRO))
            {
                IngredienteAntigo = null;

                Close();
            }
        }

        private void removerIngrediente()
        {
            if (IngredienteAntigo != null)
            {
                if (clnMensagem.mostrarSimNao("Ingrediente", "Você deseja realmente remover este ingrediente?", clnMensagem.MensagemIcone.INFO))
                {
                    Remover = true;

                    Close();
                }
            }
            else
            {
                clnMensagem.mostrarOk("Ingrediente", "Selecione um ingrediente para remover.", clnMensagem.MensagemIcone.ERRO);
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            finalizar();
        }

        private void frmAlteraIngrediente_Load(object sender, EventArgs e)
        {
            clnUtil.atualizarTabIndex(Controls);
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.abrirNumBoard(txtQuantidade);

            UIX.uixButton.btnApply(btnRemover, clnApp.AppVisualStyle.ButtonWarningColor);

            picAntigo.Hide();
            lblAntigoNome.Hide();
            lblQuantidade.Hide();

            picNovo.Hide();
            lblNovoNome.Hide();
            txtQuantidade.Hide();

            esconderBotoes();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            escolherAntigo();
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            removerIngrediente();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (IngredienteAntigo != null)
            {
                escolherAlterar();
            }
            else
            {
                escolherAdicionar();
            }
        }

        class clnSelecionarIngrediente : clnSelecionar<clnPedidoProdutoIngrediente>
        {
            internal override int Cod(clnPedidoProdutoIngrediente obj)
            {
                return obj.Ingrediente;
            }

            internal override string Detalhes(clnPedidoProdutoIngrediente obj)
            {
                string detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;

                return detalhes;
            }

            internal override Image Imagem(clnPedidoProdutoIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.Ingrediente
                }.obterPorCodigo();

                return objIngrediente.Imagem;
            }

            internal override string Nome(clnPedidoProdutoIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.Ingrediente
                }.obterPorCodigo();

                return objIngrediente.Nome;
            }
        }

    }
}
