namespace w02p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "ON";
                panel1.BackColor = Color.White;
            }
            else
            {
                checkBox1.Text = "OFF";
                panel1.BackColor = Color.Black;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "ON";
                panel1.BackColor = Color.White;
            }
            else
            {
                checkBox1.Text = "OFF";
                panel1.BackColor = Color.Black;
            }
        }
    }
}
