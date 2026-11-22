namespace w03p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           przerysuj();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            przerysuj();
        }

        void przerysuj()
        {
            int x = this.ClientSize.Width / 2;
            int y = this.ClientSize.Height / 2;
            panel1.Width = x;
            panel1.Height = y;
            panel1.Location = new Point(x - panel1.Width / 2, y - panel1.Height / 2);
        }
    }
}
