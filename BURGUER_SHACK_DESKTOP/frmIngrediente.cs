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
    public partial class frmIngrediente : Form
    {

        private clnIngrediente _objIngrediente;

        public clnIngrediente ObjIngrediente { get => _objIngrediente; set => _objIngrediente = value; }

        public frmIngrediente()
        {
            InitializeComponent();
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            clnUtil.atualizarTabIndex(Controls);

            if (ObjIngrediente != null)
            {
                txtNome.Text = ObjIngrediente.Nome;
                txtValor.Text = ObjIngrediente.Valor.ToString();
                picImagem.Image = ObjIngrediente.Imagem;

            }

            foreach (clnTipo objTipo in new clnTipo().obter())
            {
                String nome = objTipo.Cod + " - " + objTipo.Nome;
                cboTipo.Items.Add(nome);
                if (ObjIngrediente != null && ObjIngrediente.CodTipo.Equals(objTipo.Cod))
                {
                    cboTipo.Text = nome;
                }
            }
        }
    }
}
