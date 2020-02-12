using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ID_CARD
{
    public partial class add_db : Form

    {
        string sql;
        public add_db()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_db_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            String connectionString="server=lcw;database=StudentMannergerDB;integrated security=SSPI";
            SqlConnection conn;
            conn = new SqlConnection(connectionString);
           // conn.ConnectionString = "Data Source=(local);Initial Catalog=StudentMannergerDB;User ID=sa;Password=1605010201;";

            sql = "insert into student VALUES('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox7.Text + "', '" + this.textBox8.Text + "', '" + this.textBox9.Text + "', '" + this.textBox4.Text + "', '" + this.textBox5.Text + "', '" + this.textBox6.Text + "', '" + this.textBox11.Text + "', '" + this.textBox10.Text+"', '', '')";
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            int ct = command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Added");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
