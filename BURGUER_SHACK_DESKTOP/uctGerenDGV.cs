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
        public uctGerenDGV()
        {
            InitializeComponent();
        }

        private void uctGerenDGV_Load(object sender, EventArgs e)
        {
            //uctGerenDGV uctGerenDGV = new uctGerenDGV();
            //switch (msgGerenciador.adicionar)
            //{
            //    case 1:
            //        uctGerenDGV.Visible = true;
            //        dgvProduto.Visible = false;
            //        dgvTercerizada.Visible = false;
            //        dgvFuncionario.Visible = false;

            //        uctGerenFuncionario.Size = pnlConteudo.Size;
            //        uctGerenFuncionario.Location = pnlConteudo.Location;
            //        uctGerenFuncionario.Visible = true;
            //        uctGerenTerceirizada.Visible = false;
            //        uctGerenProduto.Visible = false;
            //        break;
            //    case 2:
            //        uctGerenDGV.Visible = true;
            //        dgvProduto.Visible = false;
            //        dgvTercerizada.Visible = false;
            //        dgvFuncionario.Visible = false;

            //        uctGerenTerceirizada.Size = pnlConteudo.Size;
            //        uctGerenTerceirizada.Location = pnlConteudo.Location;
            //        uctGerenFuncionario.Visible = false;
            //        uctGerenTerceirizada.Visible = true;
            //        uctGerenProduto.Visible = false;
            //        break;
            //    case 3:
            //        uctGerenDGV.Visible = true;
            //        dgvProduto.Visible = false;
            //        dgvTercerizada.Visible = false;
            //        dgvFuncionario.Visible = false;

            //        uctGerenProduto.Size = pnlConteudo.Size;
            //        uctGerenProduto.Location = pnlConteudo.Location;
            //        uctGerenFuncionario.Visible = false;
            //        uctGerenProduto.Visible = false;
            //        uctGerenTerceirizada.Visible = true;
            //        break;
            //}
        }

        private void uctGerenDGV_VisibleChanged(object sender, EventArgs e)
        {
            uctGerenDGV uctGerenDGV = new uctGerenDGV();
            if (hdrUIX.Title == "arroz")
            {
                switch (msgGerenciador.adicionar)
                {
                    case 1:
                        uctGerenDGV.Visible = true;
                        dgvProduto.Visible = false;
                        dgvTercerizada.Visible = false;
                        dgvFuncionario.Visible = false;

                        uctGerenFuncionario.Size = pnlConteudo.Size;
                        uctGerenFuncionario.Location = pnlConteudo.Location;
                        uctGerenFuncionario.Visible = true;
                        uctGerenTerceirizada.Visible = false;
                        uctGerenProduto.Visible = false;
                        break;
                    case 2:
                        uctGerenDGV.Visible = true;
                        dgvProduto.Visible = false;
                        dgvTercerizada.Visible = false;
                        dgvFuncionario.Visible = false;

                        uctGerenTerceirizada.Size = pnlConteudo.Size;
                        uctGerenTerceirizada.Location = pnlConteudo.Location;
                        uctGerenFuncionario.Visible = false;
                        uctGerenTerceirizada.Visible = true;
                        uctGerenProduto.Visible = false;
                        break;
                    case 3:
                        uctGerenDGV.Visible = true;
                        dgvProduto.Visible = false;
                        dgvTercerizada.Visible = false;
                        dgvFuncionario.Visible = false;

                        uctGerenProduto.Size = pnlConteudo.Size;
                        uctGerenProduto.Location = pnlConteudo.Location;
                        uctGerenFuncionario.Visible = false;
                        uctGerenProduto.Visible = false;
                        uctGerenTerceirizada.Visible = true;
                        break;
                }
            }

            if (hdrUIX.Title == "batata")
            {
                switch (msgGerenciador.clicouEm)
                {
                    case 1:
                        uctGerenFuncionario.Visible = false;
                        uctGerenProduto.Visible = false;
                        uctGerenTerceirizada.Visible = false;

                        uctGerenDGV.Visible = true;
                        dgvFuncionario.Size = pnlConteudo.Size;
                        dgvFuncionario.Location = pnlConteudo.Location;
                        dgvFuncionario.Visible = true;
                        dgvProduto.Visible = false;
                        dgvTercerizada.Visible = false;
                        break;
                    case 2:
                        uctGerenFuncionario.Visible = false;
                        uctGerenProduto.Visible = false;
                        uctGerenTerceirizada.Visible = false;

                        uctGerenDGV.Visible = true;
                        dgvTercerizada.Size = pnlConteudo.Size;
                        dgvTercerizada.Location = pnlConteudo.Location;
                        dgvTercerizada.Visible = true;
                        dgvFuncionario.Visible = false;
                        dgvProduto.Visible = false;
                        break;
                    case 3:

                        uctGerenFuncionario.Visible = false;
                        uctGerenProduto.Visible = false;
                        uctGerenTerceirizada.Visible = false;

                        uctGerenDGV.Visible = true;
                        dgvProduto.Size = pnlConteudo.Size;
                        dgvProduto.Location = pnlConteudo.Location;
                        dgvProduto.Visible = true;
                        dgvFuncionario.Visible = false;
                        dgvTercerizada.Visible = false;
                        break;
                }
            }
        }
    }
}
