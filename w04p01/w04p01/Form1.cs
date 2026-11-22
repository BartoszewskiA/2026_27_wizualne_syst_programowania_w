namespace w04p01
{
    public partial class Form1 : Form
    {

        Color kolor_1;
        Color kolor_2 = Color.FromArgb(200, 0, 48);
        public Form1()
        {
            InitializeComponent();
            kolor_1 = panel1.BackColor;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text +="Panel clicked!\n";
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

            richTextBox1.Text += e.Button.ToString() + "  " + e.X.ToString() + "  " + e.Y.ToString() + "\n";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //panel1.BackColor = kolor_2;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //panel1.BackColor = kolor_1;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //panel1.BackColor = kolor_2;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = kolor_1;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = kolor_2;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = e.X.ToString() + "  " + e.Y.ToString();
        }
    }
}
