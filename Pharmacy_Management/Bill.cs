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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Product ob = new Product();
            this.Hide();
            ob.Show();
        }
    }
}
