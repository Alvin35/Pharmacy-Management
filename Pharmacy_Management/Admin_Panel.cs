using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stock ob = new Stock();
            this.Hide();
            ob.Show();
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sales_Search ob = new Sales_Search();
            this.Hide();
            ob.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employee ob = new Employee();
            this.Hide();
            ob.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Accounts ob = new Accounts();
            this.Hide();
            ob.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Supplier ob = new Supplier();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            this.Hide();
            ob.Show();
        }
    }
}
