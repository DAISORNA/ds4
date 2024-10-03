namespace Laboratorio11
{
    public partial class btnClickThis : Form
    {
        public btnClickThis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }
    }
}
