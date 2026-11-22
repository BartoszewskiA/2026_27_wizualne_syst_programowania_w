namespace w03p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text += "Zdarzenie onLoad\n";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            richTextBox1.Text += "Zdarzenie onShown\n";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            richTextBox1.Text += "Zdarzenie onActivated\n";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            richTextBox1.Text += "Zdarzenie onDeactivate\n";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy zamknąć okno", "Zamykanie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
