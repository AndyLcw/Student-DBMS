using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ID_CARD
{
    public partial class update : Form
    {
        string sql;
        string y;
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //      SqlConnection conn = new SqlConnection("Data Source=(local);AttachDbFilename=" + fullPath_class.fullPath + ";Integrated Security=True;Connect Timeout=30;User Instance=True");

            String connectionString = "server=lcw;database=StudentMannergerDB;integrated security=SSPI";
            SqlConnection conn;
            conn = new SqlConnection(connectionString);
            conn.Open();
            String x = comboBox1.Text.ToString();
            

            // if (x == "Name" || x == "Father's Name" || x == "Mother's Name" || x == "Class and Section" || x == "DOB" || x == "Blood Group" || x == "Address")
            if (x == "姓名" || x == "父亲名" || x == "母亲名" || x == "班级学号" || x == "出生日期" || x == "血型" || x == "家庭住址" || x== "父亲电话" || x== "母亲电话")
            {
                //if (x == "Name")
                //    y = "name";
                //else if (x == "Father's Name")
                //    y = "father_name";
                //else if (x == "Mother's Name")
                //    y = "mother_name";
                //else if (x == "Class and Section")
                //    y = "class_sec";
                //else if (x == "DOB")
                //    y = "dob";
                //else if (x == "Blood Group")
                //    y = "blood_group";
                //else if (x== "Address")
                //    y = "address";
                ////
                //else if (x == "Father's Phone Number")
                //    y = "father_num";
                //else
                //    y = "mother_num";
                //sql = "update student set " + y + "='" + this.textBox2.Text + "' where name='" + this.textBox1.Text + "' and father_name='" + this.textBox3.Text + "'";

                if (x == "姓名")
                    y = "name";
                else if (x == "父亲名")
                    y = "father_name";
                else if (x == "母亲名")
                    y = "mother_name";
                else if (x == "班级学号")
                    y = "class_sec";
                else if (x == "出生日期")
                    y = "dob";
                else if (x == "血型")
                    y = "blood_group";
                else if (x == "家庭住址")
                    y = "address";
                //
                else if (x == "父亲电话")
                    y = "father_num";
                else
                    y = "mother_num";
              

          
            //else
            //{
            //    if (x == "Father's Phone Number")
            //        y = "father_num";
            //    else
            //        y = "mother_num";
            //    sql = "update student set " +y+ "=" + this.textBox2.Text + " where name='" + this.textBox1.Text + "' and and father_name='" + this.textBox3.Text + "'";
            //}

            sql = "update student set " + y + "='" + this.textBox2.Text + "' where name='" + this.textBox1.Text + "' and father_name='" + this.textBox3.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            int ct = cmd.ExecuteNonQuery();
            if (ct == 0)
                MessageBox.Show("No such record");
            else 
                MessageBox.Show("Update complete");

            conn.Close();

            }
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
