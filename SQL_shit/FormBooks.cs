﻿using System;
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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Publishing_house". При необходимости она может быть перемещена или удалена.
            this.publishing_houseTableAdapter.Fill(this.dB_BOOKSDataSet.Publishing_house);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.dB_BOOKSDataSet.Authors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.dB_BOOKSDataSet.Books);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.booksTableAdapter.Update(this.dB_BOOKSDataSet.Books);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Code_Publish = " +
            dataGridView1[4, bb].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int bb = dataGridView1.CurrentCell.RowIndex;
            string str = string.Format(@"Title_book Like '%{0}%'", dataGridView1[1, bb].Value);
            booksBindingSource.Filter = str;
           
        }
            
        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            string fuck = "Code_Author = "+ dataGridView1[2, bb].Value;
            booksBindingSource.Filter = fuck;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Pages = " +
            dataGridView1[3, bb].Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "";
        }
    }
}
