namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Model _model = new Model();
        private int _updateCount = 0;

        public Form1()
        {
            InitializeComponent();

            trackBarA.Minimum = 0;
            trackBarA.Maximum = 100;
            trackBarB.Minimum = 0;
            trackBarB.Maximum = 100;
            trackBarC.Minimum = 0;
            trackBarC.Maximum = 100;

            numericUpDownA.Minimum = 0;
            numericUpDownA.Maximum = 100;
            numericUpDownB.Minimum = 0;
            numericUpDownB.Maximum = 100;
            numericUpDownC.Minimum = 0;
            numericUpDownC.Maximum = 100;
        }

        private void UpdateView()
        {
            _updateCount++;
            labelCount.Text = $"Обновлений: {_updateCount}";

            textBoxA.Text = _model.A.ToString();
            numericUpDownA.Value = _model.A;
            trackBarA.Value = _model.A;

            textBoxB.Text = _model.B.ToString();
            numericUpDownB.Value = _model.B;
            trackBarB.Value = _model.B;

            textBoxC.Text = _model.C.ToString();
            numericUpDownC.Value = _model.C;
            trackBarC.Value = _model.C;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _model.Load();
            UpdateView();
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            _model.SetA(trackBarA.Value);
            UpdateView();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            _model.SetB(trackBarB.Value);
            UpdateView();
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            _model.SetC(trackBarC.Value);
            UpdateView();
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            _model.SetA((int)numericUpDownA.Value);
            UpdateView();
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            _model.SetB((int)numericUpDownB.Value);
            UpdateView();
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            _model.SetC((int)numericUpDownC.Value);
            UpdateView();
        }

        private void textBoxA_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxA.Text, out int value))
            {
                _model.SetA(value);
            }
            UpdateView();
        }

        private void textBoxB_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxB.Text, out int value))
            {
                _model.SetB(value);
            }
            UpdateView();
        }

        private void textBoxC_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxC.Text, out int value))
            {
                _model.SetC(value);
            }
            UpdateView();
        }
    }
}
