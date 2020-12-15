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
    public partial class FormDeliveries : Form
    {
        public FormDeliveries()
        {
            InitializeComponent();
        }

        private void FormDeliveries_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this.dB_BOOKSDataSet.Deliveries);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.Filter = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = string.Format(@"Name_delivery Like '%{0}%'", dataGridView1[1, bb].Value);
            deliveriesBindingSource.Filter = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = string.Format(@"Name_company Like '%{0}%'", dataGridView1[2, bb].Value);
            deliveriesBindingSource.Filter = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            deliveriesBindingSource.Filter = "Code_delivery = " +
            dataGridView1[0, bb].Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = string.Format(@"Address Like '%{0}%'", dataGridView1[3, bb].Value);
            deliveriesBindingSource.Filter = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = "Phone = " + Convert.ToString(dataGridView1[4, bb].Value);
            deliveriesBindingSource.Filter = str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = string.Format(@"INN Like '%{0}%'", dataGridView1[5, bb].Value);
            deliveriesBindingSource.Filter = str;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
