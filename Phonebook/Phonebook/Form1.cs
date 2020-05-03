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

namespace Phonebook
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ARBAB\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into PhonebookRecord (ID,Name,Number,Gender,Age,Address) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+comboBox1.Text+"','"+textBox5.Text+"','"+textBox4.Text+"')";
            SqlDataAdapter SDA = new SqlDataAdapter(query,con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully ! ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from PhonebookRecord";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con); //Taking Data from Databse
            DataTable dt = new DataTable();//creating Temporary data table
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update PhonebookRecord set Name='"+textBox2.Text+"',Number='"+textBox3.Text+ "',Gender='"+comboBox1.Text+ "',Age='"+textBox5.Text+ "',Address='"+textBox4.Text+ "' where ID='"+textBox1.Text+"'";
            SqlDataAdapter SDA= new SqlDataAdapter(query,con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Susseccfully ! ");

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Delete from PhonebookRecord where ID='"+textBox1.Text+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query,con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully ! ");
        }
    }
}
