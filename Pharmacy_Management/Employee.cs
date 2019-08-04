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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ALVIN-PC\SQLEXPRESS;Initial Catalog=PharmacyManagement;Integrated Security=True");

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Panel ob = new Admin_Panel();
            this.Hide();
            ob.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO Employee (EmployeeId,EmployeeName,EmployeeType,Salary,JoiningDate,Address,Email,MobileNo,Gender) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "','" + richTextBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            richTextBox1.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
            MessageBox.Show("INSERTION Complete ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM Employee";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE employee SET EmployeeId='" + textBox1.Text + "',EmployeeName='" + textBox2.Text + "',EmployeeType='" + textBox5.Text + "',Salary='" + textBox7.Text + "',JoiningDate='" + dateTimePicker1.Text + "',Address='" + richTextBox1.Text + "',Email='" + textBox3.Text + "',MobileNo='" + textBox4.Text + "',Gender='" + comboBox1.Text + "'WHERE EmployeeId = '" + textBox1.Text + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            richTextBox1.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
            MessageBox.Show("Succcessfully Updated");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM Employee where EmployeeId='"+textBox1.Text+"' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM Employee where EmployeeId='"+textBox1.Text+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
