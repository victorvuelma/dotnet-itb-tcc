﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnPedidoProdutoIngrediente
    {

        private int _pedidoProduto;
        private int _ingrediente;

        private int _quantidade;

        private bool _substituindo;

        public int Ingrediente { get => _ingrediente; set => _ingrediente = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public int PedidoProduto { get => _pedidoProduto; set => _pedidoProduto = value; }
        public bool Substituindo { get => _substituindo; set => _substituindo = value; }

        public clnPedidoProdutoIngrediente localizaPorPedidoProduto()
        {
            clnPedidoProdutoIngrediente objPedidoIngrediente = new clnPedidoProdutoIngrediente();
            objPedidoIngrediente.PedidoProduto = PedidoProduto;
            objPedidoIngrediente.Ingrediente = 1;
            objPedidoIngrediente.Quantidade = 1;

            return objPedidoIngrediente;
        }

    }
}