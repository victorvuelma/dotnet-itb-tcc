using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnItemIngrediente
    {

        private int _cod;

        private int _codIngrediente;
        private int _codProdutoIngrediente;
        private int _codItem;

        private int _quantidade;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodIngrediente { get => _codIngrediente; set => _codIngrediente = value; }
        public int CodProdutoIngrediente { get => _codProdutoIngrediente; set => _codProdutoIngrediente = value; }
        public int CodItem { get => _codItem; set => _codItem = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public clnItemIngrediente localizarPorItem()
        {
            clnItemIngrediente objPedidoIngrediente = new clnItemIngrediente();
            objPedidoIngrediente.CodItem = CodItem;
            objPedidoIngrediente.CodIngrediente = 1;
            objPedidoIngrediente.Quantidade = 1;

            return objPedidoIngrediente;
        }

        public List<clnItemIngrediente> obterPorItem()
        {
            return new List<clnItemIngrediente>();
        }

        public class clnSelecionar : clnUtilSelecionar<clnItemIngrediente>
        {
            internal override int Cod(clnItemIngrediente obj)
            {
                return obj.Cod;
            }

            internal override string Detalhes(clnItemIngrediente obj)
            {
                string detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;

                return detalhes;
            }

            internal override string Imagem(clnItemIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = objIngrediente.CodImagem
                }.obterPorCodigo();

                return objArquivo.Arquivo;
            }

            internal override string Nome(clnItemIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Nome;
            }
        }

        public class clnVisualizar : clnUtilVisualizar<clnItemIngrediente>
        {

            internal override string Detalhes(clnItemIngrediente obj)
            {
                String detalhes = "";
                detalhes += "Quantidade: " + obj.Quantidade;
                detalhes += "\n";
                detalhes += "Código: " + obj.Cod;

                return detalhes;
            }

            internal override String Imagem(clnItemIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = objIngrediente.CodImagem
                }.obterPorCodigo();

                return objArquivo.Arquivo;
            }

            internal override string Nome(clnItemIngrediente obj)
            {
                clnIngrediente objIngrediente = new clnIngrediente
                {
                    Cod = obj.CodIngrediente
                }.obterPorCodigo();

                return objIngrediente.Nome;
            }

            internal override int Cod(clnItemIngrediente obj)
            {
                return obj.Cod;
            }

        }

    }
}
