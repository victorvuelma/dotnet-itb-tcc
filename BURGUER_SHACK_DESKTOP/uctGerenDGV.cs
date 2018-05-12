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
    public partial class uctGerenDGV : UserControl
    {
        private Control[] uctGeren;
        private DataGridView[] dgvGeren;
        public uctGerenDGV() 
        {
            InitializeComponent();
            uctGeren = new Control[] { uctGerenFuncionario, uctGerenTerceirizada, uctGerenProduto};
            dgvGeren = new DataGridView[] { dgvFuncionario, dgvTercerizada, dgvProduto };
        }

        private void uctGerenDGV_Load(object sender, EventArgs e)
        {
            atualizarConteudo();
        }
        public void atualizarConteudo()
        {
            uctGeren[0].Visible = false; uctGeren[1].Visible = false; uctGeren[2].Visible = false;
            dgvGeren[0].Visible = false; dgvGeren[1].Visible = false; dgvGeren[2].Visible = false;
            if (msgGerenciador.adicionarVar[1] == true)
            {
                uctGerenTerceirizada.Visible = false;
                uctGerenProduto.Visible = false;

                uctGerenFuncionario.Size = pnlConteudo.Size;
                uctGerenFuncionario.Location = pnlConteudo.Location;
                uctGerenFuncionario.Visible = true;
            }
            else if (msgGerenciador.adicionarVar[2] == true)
            {
                uctGerenFuncionario.Visible = false;
                uctGerenProduto.Visible = false;

                uctGerenTerceirizada.Size = pnlConteudo.Size;
                uctGerenTerceirizada.Location = pnlConteudo.Location;
                uctGerenTerceirizada.Visible = true;
            }
            else if (msgGerenciador.adicionarVar[3] == true)
            {
                uctGerenFuncionario.Visible = false;
                uctGerenTerceirizada.Visible = false;

                uctGerenProduto.Size = pnlConteudo.Size;
                uctGerenProduto.Location = pnlConteudo.Location;
                uctGerenProduto.Visible = true;
            }
            else if (msgGerenciador.listagemVar[1] == true)
            {

            }
            else if (msgGerenciador.listagemVar[2] == true)
            {

            }
            else if (msgGerenciador.listagemVar[3] == true)
            {

            }
        }

        private void uctGerenDGV_VisibleChanged(object sender, EventArgs e)
        {
            atualizarConteudo();
        }
    }
}
