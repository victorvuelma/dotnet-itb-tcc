using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGUER_SHACK_DESKTOP
{
    public partial class msgGerenciador : Form
    {
        public msgGerenciador()
        {
            InitializeComponent();
        }
        public static bool[] listagemVar = new bool[10];
        public static bool[] adicionarVar = new bool[10];

        private void msgGerenciador_Load(object sender, EventArgs e)
        {
            listagemVar[1] = false;
            adicionarVar[1] = false;
            clnApp.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);
        }

        private void btnFuncionário_Click(object sender, EventArgs e)
        {
            if (hdrUIX.Title == "Adicionar")
            {
                adicionarVar[1] = true;
                listagemVar[1] = false;
                Close();
            }
            else if (hdrUIX.Title == "Listagem")
            {
                listagemVar[1] = true;
                adicionarVar[1] = false;
                Close();
            }
        }

        private void btnTerceirizada_Click(object sender, EventArgs e)
        {
            if (hdrUIX.Title == "Adicionar")
            {
                adicionarVar[2] = true;
                listagemVar[2] = false;
                Close();
            }
            else if (hdrUIX.Title == "Listagem")
            {
                listagemVar[2] = true;
                adicionarVar[2] = false;
                Close();
            }

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (hdrUIX.Title == "Adicionar")
            {
                adicionarVar[3] = true;
                listagemVar[3] = false;
                Close();
            }
            else if (hdrUIX.Title == "Listagem")
            {
                listagemVar[3] = true;
                adicionarVar[3] = false;
                Close();
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            adicionarVar[1] = false; adicionarVar[2] = false; adicionarVar[3] = false;
            listagemVar[1] = false; listagemVar[2] = false; listagemVar[3] = false;
            Close();
        }
    }
}
