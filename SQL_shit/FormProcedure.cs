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

namespace SQL_shit
{
    public partial class FormProcedure : Form
    {
        public FormProcedure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var sqlcmd = sqlCommand1;
            sqlcmd.Parameters["@Type_rest"].Value = string.Format(textBox1.Text);
            using (SqlDataReader reader = sqlcmd.ExecuteReader())
            {

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    DataTable dt = new DataTable();
                    adapter.SelectCommand = sqlcmd;
                    reader.Close();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }

            }

            sqlConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var sqlcmd = sqlCommand2;
            sqlcmd.Parameters["@data1"].Value = Convert.ToDateTime(textBox2.Text);
            sqlcmd.Parameters["@data2"].Value = Convert.ToDateTime(textBox3.Text);
            using (SqlDataReader reader = sqlcmd.ExecuteReader())
            {

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    DataTable dt = new DataTable();
                    adapter.SelectCommand = sqlcmd;
                    reader.Close();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }

            }

            sqlConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var sqlcmd = sqlCommand3;
            sqlcmd.Parameters["@data1"].Value = Convert.ToDateTime(textBox2.Text);
            sqlcmd.Parameters["@data2"].Value = Convert.ToDateTime(textBox3.Text);
            using (SqlDataReader reader = sqlcmd.ExecuteReader())
            {

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    DataTable dt = new DataTable();
                    adapter.SelectCommand = sqlcmd;
                    reader.Close();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }

            }

            sqlConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var sqlcmd = sqlCommand4;
            sqlcmd.Parameters["@num1"].Value = Convert.ToInt32(textBox4.Text);
            sqlcmd.Parameters["@num2"].Value = Convert.ToInt32(textBox5.Text);
            using (SqlDataReader reader = sqlcmd.ExecuteReader())
            {

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    DataTable dt = new DataTable();
                    adapter.SelectCommand = sqlcmd;
                    reader.Close();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }

            }

            sqlConnection1.Close();

        }
    }
}
