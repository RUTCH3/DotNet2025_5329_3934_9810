using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            s.Show();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.Show();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            Products d = new Products();
            d.Show();
        }
    }
}
