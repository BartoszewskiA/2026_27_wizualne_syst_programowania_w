namespace w01p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            //x = int.Parse(textBox1.Text);
            //y = int.Parse(textBox2.Text);
            if (!int.TryParse(textBox1.Text, out x) || !int.TryParse(textBox2.Text, out y))
            {
                textBox3.Text = "Niepoprawne dane";
                return;
            }
            int wynik = x + y;
            textBox3.Text = wynik.ToString();
        }
    }
}
