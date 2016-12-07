using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form4Customers : Form
    {
        public static string name;
        public static string lastName;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop2;Integrated Security=True");
        public Form4Customers()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", connection))
            {
                DataTable CustomersTable = new DataTable();
                adapter.Fill(CustomersTable);
                dataGridView1.DataSource = CustomersTable;
                connection.Close();
                txtName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtItemNr.Clear();
                txtSellerId.Clear();
                txtDate.Clear();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                context.Customers.Add(new Customer { Name = txtName.Text, LastName = txtLastName.Text, Email = txtEmail.Text});
                context.SaveChanges();
            }
            DisplayData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                name = Convert.ToString(selectedRow.Cells["Name"].Value);
                lastName = Convert.ToString(selectedRow.Cells["LastName"].Value);
                var customer = context.Customers.FirstOrDefault(s => s.Name == name && s.LastName == lastName);
                txtName.Text = customer.Name;
                txtLastName.Text = customer.LastName;
                txtEmail.Text = customer.Email;
                DisplayData();
            }
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                var customer = context.Customers.FirstOrDefault(s => s.Name == name && s.LastName == lastName);
                customer.Name = txtName.Text;
                customer.LastName = txtLastName.Text;
                customer.Email = txtEmail.Text;
                DisplayData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string lastName = Convert.ToString(selectedRow.Cells["LastName"].Value);
                var customer = context.Customers.FirstOrDefault(s => s.Name == name && s.LastName == lastName);
                context.Customers.Remove(customer);
                context.SaveChanges();
                DisplayData();
            }  
        }

        private void btnNewPurchase_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                context.Purchases.Add(new Purchase { Name = txtName.Text, LastName = txtLastName.Text, ItemNr = Convert.ToInt32(txtItemNr.Text), SellerId = Convert.ToInt32(txtSellerId.Text), Date = Convert.ToDateTime(txtDate.Text)});
                context.SaveChanges();
            }
            DisplayData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            Form5Purchases form5 = new Form5Purchases();
            form5.Show();
        }
    }
}
