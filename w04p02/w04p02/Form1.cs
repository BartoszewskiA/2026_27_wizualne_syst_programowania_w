namespace w04p02
{
    public partial class Form1 : Form
    {
        Color kolor_1;
        Color kolor_2 = Color.BurlyWood;

        public Form1()
        {
            InitializeComponent();
            kolor_1 = panel1.BackColor;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //label1.Text += e.KeyChar;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            panel1.BackColor = kolor_2;
            
            if(e.KeyCode == Keys.Delete)
            {
                if (label1.Text.Length > 0)
                {
                    label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
                }
            }
            else
            {
                label1.Text += e.KeyCode.ToString();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            panel1.BackColor = kolor_1;
        }
    }
}
