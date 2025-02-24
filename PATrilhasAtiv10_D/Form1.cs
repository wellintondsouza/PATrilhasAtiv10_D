namespace PATrilhasAtiv10_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }
    }
}
