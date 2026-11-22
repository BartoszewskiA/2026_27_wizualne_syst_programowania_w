namespace w02p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("Musisz zgodzić się na wszystko co chcemy.");
                return;
            }
            else if (radioButton1.Checked)
            {
                MessageBox.Show("Dziękujemy za zgodę.");
            }
        }
    }
}
