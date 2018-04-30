using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class uctPedidoNovo : UserControl
    {

        private int mesaAtual;

        public uctPedidoNovo()
        {
            InitializeComponent();
        }

        public int MesaAtual { get => mesaAtual; set => mesaAtual = value; }
    }
}
