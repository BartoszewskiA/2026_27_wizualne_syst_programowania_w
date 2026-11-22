namespace w03p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Move(object sender, EventArgs e)
        {

            var active = Form1.ActiveForm;
            if (active == null) return;
                    String x =Form1.ActiveForm.Location.X.ToString();
            String y = Form1.ActiveForm.Location.Y.ToString();
            label1.Text = "X: " + x + " Y: " + y;
        }
    }
}
