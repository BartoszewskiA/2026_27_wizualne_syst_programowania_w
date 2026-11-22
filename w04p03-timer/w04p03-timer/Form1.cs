namespace w04p03_timer
{
    public partial class Form1 : Form
    {
        int licznik = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            licznik++;
            if(licznik>=100) timer1.Enabled=false;
            if(timer1.Interval>10) timer1.Interval -= 5;
            label1.Text = licznik.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            licznik = 0;
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Konie czasu.\n Kup wersję premium");
            Close();
        }
    }
}
