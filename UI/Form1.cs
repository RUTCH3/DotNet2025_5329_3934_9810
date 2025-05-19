namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saleman saleman = new Saleman();
            saleman.Show();
        }
    }
}
