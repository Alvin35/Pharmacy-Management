using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management
{
    public partial class Price_List : Form
    {
        public Price_List()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ALVIN-PC\SQLEXPRESS;Initial Catalog=PharmacyManagement;Integrated Security=True");
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
