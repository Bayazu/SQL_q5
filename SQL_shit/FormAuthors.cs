using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_shit
{
    public partial class FormAuthors : Form
    {
        public FormAuthors()
        {
            InitializeComponent();
        }

        private void FormAuthors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.dB_BOOKSDataSet.Authors);

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string fuck = "Code_Author = " + dataGridView1[0, bb].Value;
            authorsBindingSource.Filter = fuck;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = string.Format(@"name_author Like '%{0}%'", dataGridView1[1, bb].Value);
            authorsBindingSource.Filter = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           authorsBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = string.Format(@" Birthday = '{0:dd.MM.yyyy}'", dataGridView1[2, bb].Value);
            authorsBindingSource.Filter = str;
        }
    }
}
