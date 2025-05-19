namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salesman_Click(object sender, EventArgs e)
        {
            Salesmen salesmen = new Salesmen();
            salesmen.Show();
        }

        private void manager_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
        }
    }
}