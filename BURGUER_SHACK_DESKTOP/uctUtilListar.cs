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
    public partial class uctUtilListar : UserControl
    {

        private List<Button> _itens;
        private int _espacamento = 16;
        private int _posX, _posY;
        private bool _loaded;

        public uctUtilListar()
        {
            InitializeComponent();

            Itens = new List<Button>();
        }

        private List<Button> Itens { get => _itens; set => _itens = value; }

        public int Espacamento
        {
            get => _espacamento;
            set
            {
                _espacamento = value;
                if (Loaded)
                {
                    reexibir();
                }
            }
        }
        private int PosX { get => _posX; set => _posX = value; }
        private int PosY { get => _posY; set => _posY = value; }
        private bool Loaded { get => _loaded; set => _loaded = value; }

        private void uctUtilListar_SizeChanged(object sender, EventArgs e)
        {
            atualizaTamanho();
        }

        private void atualizaTamanho()
        {
            MaximumSize = new Size(Size.Width, 10000);
            if (Loaded)
            {
                reexibir();
            }
        }

        public void adicionarItem(String nome, String imagem, UIX.uixSet colorSet)
        {
            Button itemNovo = new UIX.btnUIX
            {
                Size = new Size(110, 110),
                Description = nome,
                ImageLocation = imagem
            };
            UIX.uixButton.btnApply(itemNovo, colorSet, App.VisualStyle.BoldFont);

            Itens.Add(itemNovo);
            exibirItem(itemNovo);
        }

        public void limpar()
        {
            Itens.Clear();
            Controls.Clear();

            posicaoInicial();
        }

        public void reexibir()
        {
            Controls.Clear();
            posicaoInicial();

            foreach (Button item in Itens)
            {
                exibirItem(item);
            }
        }

        private void posicaoInicial()
        {
            PosX = Espacamento / 2;
            PosY = Espacamento / 2;
        }

        private void exibirItem(Button item)
        {
            Controls.Add(item);
            item.Location = new Point(PosX, PosY);

            PosX += Espacamento;
            PosX += item.Width;
            if ((PosX + item.Width) >= MaximumSize.Width)
            {
                PosX = Espacamento / 2;
                PosY += Espacamento;
                PosY += item.Height;
            }

            clnUtil.atualizarIndex(Controls);
        }

        private void uctUtilListar_Load(object sender, EventArgs e)
        {
            Loaded = true;

            posicaoInicial();
            atualizaTamanho();

            foreach (Button item in Itens)
            {
                exibirItem(item);
            }
        }

    }
}
