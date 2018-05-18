using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnPedidoReceita
    {

        private int _cod;

        private int _codIngrediente;
        private int _codReceita;
        private int _codPedido;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodIngrediente { get => _codIngrediente; set => _codIngrediente = value; }
        public int CodReceita { get => _codReceita; set => _codReceita = value; }
        public int CodPedido { get => _codPedido; set => _codPedido = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public clnPedidoReceita localizaPorPedidoProduto()
        {
            clnPedidoReceita objPedidoIngrediente = new clnPedidoReceita();
            objPedidoIngrediente.CodPedido = CodPedido;
            objPedidoIngrediente.CodIngrediente = 1;
            objPedidoIngrediente.Quantidade = 1;

            return objPedidoIngrediente;
        }

        public class clnSelecionarPedidoIngrediente : clnUtilSelecionar<clnPedidoReceita>
        {
            internal override int Cod(clnPedidoReceita obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnPedidoReceita obj)
            {
                string detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;

                return detalhes;
            }

            internal override Image Imagem(clnPedidoReceita obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Imagem;
            }

            internal override string Nome(clnPedidoReceita obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Nome;
            }
        }

        public class clnVisualizarPedidoIngrediente : clnUtilVisualizar<clnPedidoReceita>
        {

            internal override string Detalhes(clnPedidoReceita obj)
            {
                String detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;
                detalhes += "\n";
                detalhes += "Código: " + obj.Cod;

                return detalhes;
            }

            internal override Image Imagem(clnPedidoReceita obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Imagem;
            }

            internal override string Nome(clnPedidoReceita obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Nome;
            }

            internal override int Cod(clnPedidoReceita obj)
            {
                return obj.Cod;
            }

            internal override void Abrir(clnPedidoReceita obj)
            {
                clnProdutoReceita objProdutoReceita = new clnProdutoReceita
                {
                    Cod = obj.CodReceita
                }.obterPorCodigo();

                if (objProdutoReceita.Alterar || objProdutoReceita.Remover)
                {
                    frmPedidoIngrediente frmIngrediente = new frmPedidoIngrediente
                    {
                        IngredienteAntigo = obj
                    };
                    frmIngrediente.btnAlterar.Visible = objProdutoReceita.Alterar;
                    frmIngrediente.btnRemover.Visible = objProdutoReceita.Remover;
                    frmIngrediente.ShowDialog();

                    if (frmIngrediente.IngredienteNovo == null)
                    {
                        Opcoes.Remove(frmIngrediente.IngredienteAntigo);
                    }
                    else if (frmIngrediente.IngredienteAntigo != frmIngrediente.IngredienteNovo)
                    {
                        clnUtil.listTrocar(Opcoes, frmIngrediente.IngredienteAntigo, frmIngrediente.IngredienteNovo);
                    }
                }
                else
                {
                    clnUtilMensagem.mostrarOk("Ingredientes", "Esse ingrediente não pode ser alterado ou removido.", clnUtilMensagem.MensagemIcone.ERRO);
                }

            }
        }

    }
}
