﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURGUER_SHACK_DESKTOP
{
    public class clnItem
    {

        private int _cod;

        private int _codProduto;
        private int _codPedido;

        private int _quantidade;
        private String _adicional;

        public int Cod { get => _cod; set => _cod = value; }
        public int CodProduto { get => _codProduto; set => _codProduto = value; }
        public int CodPedido { get => _codPedido; set => _codPedido = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public string Adicional { get => _adicional; set => _adicional = value; }

        public List<clnItem> obterPorPedido()
        {
            List<clnItem> pedidoProdutos = new List<clnItem>();

            return pedidoProdutos;
        }
    }
}