namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private CircleStorage _storage = new CircleStorage();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                CCircle? clicked = null;
                for (int i = 0; i < _storage.GetCount(); i++)
                {
                    if (_storage.GetObject(i).HitTest(e.X, e.Y))
                    {
                        clicked = _storage.GetObject(i);
                    }
                }

                if (clicked != null)
                {
                    if (Control.ModifierKeys == Keys.Control)
                    {
                        clicked.IsSelected = !clicked.IsSelected;
                    }
                    else
                    {
                        for (int i = 0; i < _storage.GetCount(); i++)
                            _storage.GetObject(i).IsSelected = false;
                        clicked.IsSelected = true;
                    }
                }
                else
                {
                    for (int i = 0; i < _storage.GetCount(); i++)
                        _storage.GetObject(i).IsSelected = false;
                    _storage.Add(new CCircle(e.X, e.Y));
                }

                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < _storage.GetCount(); i++)
                _storage.GetObject(i).Draw(e.Graphics);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = _storage.GetCount() - 1; i >= 0; i--)
                {
                    if (_storage.GetObject(i).IsSelected)
                        _storage.Remove(_storage.GetObject(i));
                }
                Invalidate();
            }
        }
    }
}