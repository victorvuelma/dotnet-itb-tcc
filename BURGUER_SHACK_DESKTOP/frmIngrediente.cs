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

        private clnUtilValidar _validar;

        private clnIngrediente _objIngrediente;

        public clnIngrediente ObjIngrediente { get => _objIngrediente; set => _objIngrediente = value; }

        public frmIngrediente()
        {
            InitializeComponent();

            _validar = new clnUtilValidar();
        }

        private static void abrirTipos()
        {
            new frmTipo { Tipo = clnTipo.tipo.INGREDIENTE }.ShowDialog();
        }

        private void removerImagem()
        {
            if (clnUtilMensagem.mostrarSimNao("Ingrediente", "Deseja realmente remover a imagem?", clnUtilMensagem.MensagemIcone.INFO))
            {
                picImagem.Image = global::BURGUER_SHACK_DESKTOP.Properties.Resources.ingrediente;
            }
        }

        private void adicionarImagem()
        {
            OpenFileDialog objDialog = new OpenFileDialog();
            objDialog.Filter = "png|*.png";
            if (objDialog.ShowDialog() == DialogResult.OK)
            {
                picImagem.ImageLocation = objDialog.FileName;
            }
        }

        private void salvar()
        {
            if (ObjIngrediente == null)
            {
                clnArquivo objArquivo = new clnArquivo
                {
                    Arquivo = picImagem.ImageLocation
                };
                objArquivo.gravar();

                ObjIngrediente = new clnIngrediente
                {
                    Situacao = clnIngrediente.ingredienteSituacao.FORADEESTOQUE,
                    Nome = txtNome.Text,
                    CodTipo = clnUtilConvert.ToInt(cboTipo.Text.Split('-')[0]),
                    CodImagem = objArquivo.Cod,
                    Valor = clnUtilConvert.ToDouble(txtValor.Text)
                };
                ObjIngrediente.gravar();
            }
            else
            {
                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = ObjIngrediente.CodImagem
                }.obterPorCodigo();

                if (!objArquivo.Arquivo.Equals(picImagem.ImageLocation))
                {
                    objArquivo = new clnArquivo
                    {
                        Arquivo = picImagem.ImageLocation
                    };
                    objArquivo.gravar();
                    ObjIngrediente.CodImagem = objArquivo.Cod;
                }
            }
        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            App.AppVisualTemplate.frmApply(this, hdrUIX);
            UIX.uixButton.btnApply(btnVoltar, App.AppVisualStyle.ButtonWarningColor);
            clnUtil.atualizarTabIndex(Controls);

            if (ObjIngrediente != null)
            {
                clnArquivo objArquivo = new clnArquivo
                {
                    Cod = ObjIngrediente.CodImagem
                }.obterPorCodigo();

                txtNome.Text = ObjIngrediente.Nome;
                txtValor.Text = ObjIngrediente.Valor.ToString();
                picImagem.ImageLocation = objArquivo.Arquivo;
                cboSituacao.Text = ObjIngrediente.Situacao.ToString();
            }

            foreach (clnTipo objTipo in new clnTipo { Tipo = clnTipo.tipo.INGREDIENTE }.obter())
            {
                String nome = objTipo.Cod + " - " + objTipo.Nome;
                cboTipo.Items.Add(nome);
                if (ObjIngrediente != null && ObjIngrediente.CodTipo.Equals(objTipo.Cod))
                {
                    cboTipo.Text = nome;
                }
            }
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            abrirTipos();
        }

        private void btnImgRemover_Click(object sender, EventArgs e)
        {
            removerImagem();
        }

        private void btnImgAdicionar_Click(object sender, EventArgs e)
        {
            adicionarImagem();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

    }
}
