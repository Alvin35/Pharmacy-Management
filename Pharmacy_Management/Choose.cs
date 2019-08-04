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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Log_In ob = new Log_In();
            this.Hide();
            ob.Show();
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            Product ob = new Product();
            this.Hide();
            ob.Show();
        }
    }
}
