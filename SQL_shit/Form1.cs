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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.dB_BOOKSDataSet.Purchases);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Publishing_house". При необходимости она может быть перемещена или удалена.
            this.publishing_houseTableAdapter.Fill(this.dB_BOOKSDataSet.Publishing_house);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this.dB_BOOKSDataSet.Deliveries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.dB_BOOKSDataSet.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_BOOKSDataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.dB_BOOKSDataSet.Authors);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormPublish myForm6 = new FormPublish();
            myForm6.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormAuthors myForm2 = new FormAuthors();
            myForm2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormPurchases myForm3 = new FormPurchases();
            myForm3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormBooks myForm4 = new FormBooks();
            myForm4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormDeliveries myForm5 = new FormDeliveries();
            myForm5.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormProcedure myForm7 = new FormProcedure();
            myForm7.Show();
        }
    }
}   
