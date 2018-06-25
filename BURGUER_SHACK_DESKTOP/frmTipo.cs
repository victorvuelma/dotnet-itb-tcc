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
    public partial class frmTipo : Form
    {

        private clnTipo.tipo _tipo;
        private List<clnTipo> _objTipos;
        private clnTipo _objTipo;

        internal clnTipo.tipo Tipo { get => _tipo; set => _tipo = value; }
        internal List<clnTipo> ObjTipos { get => _objTipos; set => _objTipos = value; }
        internal clnTipo ObjTipo { get => _objTipo; set => _objTipo = value; }

        public frmTipo()
        {
            InitializeComponent();
        }

        private void exibirTipos()
        {
            ObjTipos = new clnTipo
            {
                Tipo = Tipo
            }.obterTipos();

            atualizarDataGrid();
        }

        private void atualizarDataGrid()
        {
            dgvTipos.Rows.Clear();
            dgvTipos.ClearSelection();

            foreach (clnTipo objTipo in ObjTipos)
            {
                dgvTipos.Rows.Add(new String[] { Convert.ToString(objTipo.Cod), objTipo.Nome });
            }
        }

        private void definirNovo()
        {
            ObjTipo = null;
            btnAcao.Description = "Salvar";
            btnAcao.Image = Properties.Resources.salvar;
            txtNome.Text = "";
            grbEditar.Show();
            btnAcao.Show();
        }

        private void definirEditar(clnTipo objTipo)
        {
            ObjTipo = objTipo;
            txtNome.Text = ObjTipo.Nome;
            grbEditar.Show();
            btnAcao.Show();
            btnAcao.Description = "Salvar";
            btnAcao.Image = Properties.Resources.salvar;
        }

        private void definirAlterar()
        {
            ObjTipo = null;
            grbEditar.Hide();
            btnAcao.Show();
            btnAcao.Description = "Alterar";
            btnAcao.Image = Properties.Resources.alterar;
        }

        private void definirPadrao()
        {
            ObjTipo = null;
            btnAcao.Hide();
            grbEditar.Hide();
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            App.VisualTemplate.frmApply(this, hdrUIX);

            clnUtil.atualizarForm(this);

            exibirTipos();

            hdrUIX.Title = App.Name + " - Tipos de  " + Tipo.ToString().ToLower();
        }

        private void dgvTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                definirAlterar();
            }
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (ObjTipo != null)
            {
                if (!clnUtil.vazio(txtNome.Text))
                {
                    ObjTipo.Nome = txtNome.Text;
                    ObjTipo.alterar();

                    clnUtilMensagem.mostrarOk("Tipo", "Tipo alterado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                    exibirTipos();
                    definirPadrao();
                }
                else
                {
                    clnUtilMensagem.mostrarOk("Tipo", "É necessário informar uma descrição para o tipo.", clnUtilMensagem.MensagemIcone.ERRO);
                }
            }
            else if (grbEditar.Visible)
            {
                if (!clnUtil.vazio(txtNome.Text))
                {
                    clnTipo objTipo = new clnTipo
                    {
                        Nome = txtNome.Text,
                        Tipo = Tipo
                    };
                    objTipo.gravar();
                    clnUtilMensagem.mostrarOk("Tipo", "Tipo gravado com sucesso!", clnUtilMensagem.MensagemIcone.OK);
                    exibirTipos();
                    definirPadrao();
                }
                else
                {
                    clnUtilMensagem.mostrarOk("Tipo", "É necessário informar uma descrição para o tipo.", clnUtilMensagem.MensagemIcone.ERRO);
                }
            }
            else if(dgvTipos.SelectedRows.Count > 0)
            {
                object cod = dgvTipos.CurrentRow.Cells[0].Value;

                clnTipo objTipo = new clnTipo
                {
                    Tipo = Tipo,
                    Cod = Convert.ToInt32(cod)
                }.obterPorCodigo();

                if (objTipo != null)
                {
                    definirEditar(objTipo);
                }
            }
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            ObjTipo = null;
            Close();
        }

        private void dgvTipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cod = dgvTipos.CurrentRow.Cells[0].Value;

                clnTipo objTipo = new clnTipo
                {
                    Tipo = Tipo,
                    Cod = Convert.ToInt32(cod)
                }.obterPorCodigo();

                if (objTipo != null)
                {
                    ObjTipo = objTipo;
                    Close();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            definirNovo();
        }
    }
}
