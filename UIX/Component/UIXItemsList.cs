using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;
using vitorrdgs.UiX.Property;
using vitorrdgs.Util.Form;

namespace vitorrdgs.UiX.Component
{
    public partial class UIXItemsList : UserControl
    {

        private List<ListarItem> _items;
        private int _itemsSpace = 10;
        private int _itemsSize = 100;
        private int _posX;
        private int _posY;
        private int _posIndex;
        private bool _loaded;
        private bool _autoRender = false;

        public UIXItemsList()
        {
            InitializeComponent();

            Items = new List<ListarItem>();
        }

        private List<ListarItem> Items { get => _items; set => _items = value; }

        public int ItemsSpace
        {
            get => _itemsSpace;
            set
            {
                _itemsSpace = value;
                if (_loaded)
                    resetarExibicao();
            }
        }
        public int PosIndex { get => _posIndex; set => _posIndex = value; }
        public int ItemsSize
        {
            get => _itemsSize;
            set
            {
                _itemsSize = value;
                if (_loaded)
                    resetarExibicao();
            }
        }

        public bool AutoRender { get => _autoRender; set => _autoRender = value; }

        private void uctUtilListar_SizeChanged(object sender, EventArgs e)
        {
            atualizaTamanho();
        }

        private void atualizaTamanho()
        {
            MaximumSize = new Size(Size.Width, 10000);
        }

        public void Adicionar(int cod, String nome, object imagem, uixSet colorSet, Func<ListResult> callback)
        {
            ListarItem item = new ListarItem
            {
                Nome = nome,
                Imagem = imagem,
                UixSet = colorSet,
                Callback = callback,
                Cod = cod
            };
            Items.Add(item);

            if (AutoRender)
                exibirItem(item);
        }

        public void LimparOpcoes()
        {
            Items.Clear();

            AutoRender = false;
        }

        public void LimparTudo()
        {
            Items.Clear();

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
            posicaoInicial();

            foreach (ListarItem item in Items)
            {
                exibirItem(item);
            }

            while (Controls.Count > Items.Count)
            {
                Controls.RemoveAt(Controls.Count - 1);
            }
            AutoRender = true;
        }

        private void posicaoInicial()
        {
            _posX = ItemsSpace / 2;
            _posY = ItemsSpace / 2;
        }

        private void exibirItem(ListarItem item)
        {
            UIXButton btn = null;

            if (Controls.Count <= PosIndex)
            {
                btn = new UIXButton
                {
                    Size = new Size(ItemsSize, ItemsSize),
                    Location = new Point(_posX, _posY)
                };
                uixButton.btnApply(btn, item.UixSet);

                btn.Click += (object sender, EventArgs args) =>
                {
                    ListarItem actionItem = Items[btn.TabIndex - 1];

                    switch (actionItem.Callback())
                    {
                        case ListResult.REMOVER:
                            removerItem(actionItem);
                            break;
                    }
                };

                Controls.Add(btn);
            }
            else
            {
                btn = (UIXButton)Controls[PosIndex];
            }

            btn.Name = "btnListar" + item.Cod;
            if (item.Imagem != null)
            {
                if (item.Imagem is string location)
                {
                    btn.ImageLocation = location;
                }
                else if (item.Imagem is Image img)
                {
                    btn.Image = img;
                }
            }
            btn.Description = item.Nome;

            PosIndex++;
            _posX += ItemsSpace;
            _posX += ItemsSize;
            if ((_posX + ItemsSize) >= MaximumSize.Width)
            {
                _posX = ItemsSpace / 2;
                _posY += ItemsSpace;
                _posY += ItemsSize;
            }

            UtilForm.UpdateIndexes(Controls);
        }

        private void removerItem(ListarItem item)
        {
            Items.Remove(item);

            exibirItens();
        }

        private void uctUtilListar_Load(object sender, EventArgs e)
        {
            _loaded = true;

            atualizaTamanho();

            exibirItens();
        }

        class ListarItem
        {

            private int _cod;
            private string _nome;

            private object _imagem;
            private Func<ListResult> _callback;

            private uixSet _uixSet;

            public int Cod { get => _cod; set => _cod = value; }
            public string Nome { get => _nome; set => _nome = value; }
            public object Imagem { get => _imagem; set => _imagem = value; }
            public uixSet UixSet { get => _uixSet; set => _uixSet = value; }
            public Func<ListResult> Callback { get => _callback; set => _callback = value; }
        }

        public enum ListResult
        {

            NENHUM,
            REMOVER

        }

    }
}
