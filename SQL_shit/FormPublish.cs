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
    public partial class FormPublish : Form
    {
        public FormPublish()
        {
            InitializeComponent();
        }

        private void FormPublish_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Publishing_house". При необходимости она может быть перемещена или удалена.
            this.publishing_houseTableAdapter.Fill(this.dB_BOOKSDataSet.Publishing_house);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            publishinghouseBindingSource.Filter = "Code_Publish = " +
            dataGridView1[0, bb].Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = string.Format(@"City Like '%{0}%'", dataGridView1[2, bb].Value);
            publishinghouseBindingSource.Filter = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = string.Format(@"Publish Like '%{0}%'", dataGridView1[1, bb].Value);
            publishinghouseBindingSource.Filter = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           publishinghouseBindingSource.Filter = "";
        }
    }
}
