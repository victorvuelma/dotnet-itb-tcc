using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vitorrdgs.UiX.Property;
using vitorrdgs.UiX.Component;
using vitorrdgs.UiX.Manager;

namespace BURGERSHACK_DESKTOP
{
    public partial class uctUtilListar : UserControl
    {

        private List<ListarItem> _itens;
        private int _espacamento = 10;
        private int _posX;
        private int _posY;
        private int _posIndex;
        private bool _loaded;

        public uctUtilListar()
        {
            InitializeComponent();

            Itens = new List<ListarItem>();
        }

        private List<ListarItem> Itens { get => _itens; set => _itens = value; }

        public int Espacamento
        {
            get => _espacamento;
            set
            {
                _espacamento = value;
                if (Loaded)
                {
                    resetarExibicao();
                }
            }
        }
        private int PosX { get => _posX; set => _posX = value; }
        private int PosY { get => _posY; set => _posY = value; }
        private bool Loaded { get => _loaded; set => _loaded = value; }
        public int PosIndex { get => _posIndex; set => _posIndex = value; }

        private void uctUtilListar_SizeChanged(object sender, EventArgs e)
        {
            atualizaTamanho();
        }

        private void atualizaTamanho()
        {
            MaximumSize = new Size(Size.Width, 10000);
            if (Loaded)
            {
                resetarExibicao();
            }
        }

        public void adicionarItem(int cod, String nome, String imagem, uixSet colorSet, Func<ListarResult> callback)
        {
            ListarItem item = new ListarItem
            {
                Nome = nome,
                Imagem = imagem,
                UixSet = colorSet,
                Callback = callback,
                Cod = cod
            };
            Itens.Add(item);

            exibirItem(item);
        }

        public void limpar()
        {
            Itens.Clear();

            resetarExibicao();
        }

        private void resetarExibicao()
        {
            posicaoInicial();
            Controls.Clear();
        }

        public void exibirItens()
        {
            PosIndex = 0;

            foreach (ListarItem item in Itens)
            {
                exibirItem(item);
            }
        }

        private void posicaoInicial()
        {
            PosX = Espacamento / 2;
            PosY = Espacamento / 2;
        }

        private void exibirItem(ListarItem item)
        {
            btnUIX btn = null;
            if (Controls.Count <= PosIndex)
            {
                btn = new btnUIX();
                btn.Size = new Size(100, 100);
                btn.Location = new Point(PosX, PosY);

                PosX += Espacamento;
                PosX += btn.Width;
                if ((PosX + btn.Width) >= MaximumSize.Width)
                {
                    PosX = Espacamento / 2;
                    PosY += Espacamento;
                    PosY += btn.Height;
                }
                uixButton.btnApply(btn, item.UixSet, AppDesktop.VisualStyle.BoldFont);

                btn.Click += (object sender, EventArgs args) =>
                {
                    ListarItem actionItem = Itens[btn.TabIndex - 1];

                    switch (actionItem.Callback())
                    {
                        case ListarResult.REMOVER:
                            removerItem(actionItem);
                            break;
                    }
                };

                Controls.Add(btn);
            }
            else
            {
                btn = (btnUIX)Controls[PosIndex];
            }

            btn.Name = "btnListar" + item.Cod;
            btn.ImageLocation = item.Imagem;
            btn.Description = item.Nome;

            clnUtil.atualizarIndex(Controls);

            PosIndex++;
        }

        private void removerItem(ListarItem item)
        {
            Itens.Remove(item);

            exibirItens();

            if (Controls.Count > 0)
                Controls.RemoveAt(Controls.Count - 1);
        }

        private void uctUtilListar_Load(object sender, EventArgs e)
        {
            Loaded = true;

            atualizaTamanho();

            exibirItens();
        }

        class ListarItem
        {

            private int _cod;
            private string _nome;

            private string _imagem;
            private Func<ListarResult> _callback;

            private uixSet _uixSet;

            public int Cod { get => _cod; set => _cod = value; }
            public string Nome { get => _nome; set => _nome = value; }
            public string Imagem { get => _imagem; set => _imagem = value; }
            public uixSet UixSet { get => _uixSet; set => _uixSet = value; }
            public Func<ListarResult> Callback { get => _callback; set => _callback = value; }
        }

        public enum ListarResult
        {

            NENHUM,
            REMOVER

        }

    }
}
