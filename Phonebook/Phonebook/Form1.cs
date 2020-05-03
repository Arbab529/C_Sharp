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
            string query = "insert into Phonebook (Name,Number,Gender,Age,Address) values('"+textBox2.Text+"','"+textBox3.Text+"','"+comboBox1.Text+"','"+textBox5.Text+"','"+textBox4.Text+"')";
            SqlDataAdapter SDA = new SqlDataAdapter(query,con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully ! ");
        }
    }
}
