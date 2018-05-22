using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnPedidoProdutoIngrediente
    {

        private int _cod;

        private int _codIngrediente;
        private int _codProdutoIngrediente;
        private int _codPedidoProduto;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodIngrediente { get => _codIngrediente; set => _codIngrediente = value; }
        public int CodProdutoIngrediente { get => _codProdutoIngrediente; set => _codProdutoIngrediente = value; }
        public int CodPedidoProduto { get => _codPedidoProduto; set => _codPedidoProduto = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public clnPedidoProdutoIngrediente localizaPorPedidoProduto()
        {
            clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente();
            objPedidoIngrediente.CodPedidoProduto = CodPedidoProduto;
            objPedidoIngrediente.CodIngrediente = 1;
            objPedidoIngrediente.Quantidade = 1;

            return objPedidoIngrediente;
        }

        public List<clnPedidoProdutoIngrediente> obterPorPedidoProduto()
        {
            return new List<clnPedidoProdutoIngrediente>();
        }

        public class clnSelecionar : clnUtilSelecionar<clnPedidoProdutoIngrediente>
        {
            internal override int Cod(clnPedidoProdutoIngrediente obj)
            {
                return obj.Cod;
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
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Imagem;
            }

            internal override string Nome(clnPedidoProdutoIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Nome;
            }
        }

        public class clnVisualizar : clnUtilVisualizar<clnPedidoProdutoIngrediente>
        {

            internal override string Detalhes(clnPedidoProdutoIngrediente obj)
            {
                String detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;
                detalhes += "\n";
                detalhes += "Código: " + obj.Cod;

                return detalhes;
            }

            internal override Image Imagem(clnPedidoProdutoIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Imagem;
            }

            internal override string Nome(clnPedidoProdutoIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Nome;
            }

            internal override int Cod(clnPedidoProdutoIngrediente obj)
            {
                return obj.Cod;
            }

            internal override void Abrir(clnPedidoProdutoIngrediente obj)
            {
                clnProdutoIngrediente objProdutoReceita = new clnProdutoIngrediente
                {
                    Cod = obj.CodProdutoIngrediente
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
