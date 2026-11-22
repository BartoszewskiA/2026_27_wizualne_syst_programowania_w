namespace w01p01
{
    public partial class Form1 : Form
    {

        private int liczniuk = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Cześć";
           
            liczniuk++;
            label2.Text = liczniuk.ToString();
        }
    }
}
