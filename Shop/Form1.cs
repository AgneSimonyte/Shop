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


namespace Shop
{
    public partial class Form1 : Form
    {
        // SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop2;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2Sellers form2 = new Form2Sellers();
            form2.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Items form3 = new Form3Items();
            form3.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4Customers form4 = new Form4Customers();
            form4.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
