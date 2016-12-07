using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form5Purchases : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop2;Integrated Security=True");

        public Form5Purchases()
        {
            InitializeComponent();
        }
      
        private void btnAllPurchases_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from Purchases where name = @name and lastName = @lastName";
            connection.Open();
            using (var context = new ShopContext())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                string name = txtName.Text;
                string lastName = txtLastName.Text;
                var customer = context.Purchases.FirstOrDefault(s => s.Name == name && s.LastName == lastName);
                if (customer != null)
                {
                    command.Parameters.Add("@name", txtName.Text);
                    command.Parameters.Add("@lastName", txtLastName.Text);
                    DataTable PurchasesTable = new DataTable();
                    adapter.Fill(PurchasesTable);
                    dataGridView1.DataSource = PurchasesTable;
                    connection.Close();
                }
                else MessageBox.Show("Toks klientas neegzistuoja");
            }
          }

        private void btnLastWeek_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from Purchases where name = @name and lastName = @lastName and date >= @now1 and date <= @now2";
            connection.Open();
            using (ShopEntities context = new ShopEntities())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                string name = txtName.Text;
                string lastName = txtLastName.Text;
                DateTime now2 = DateTime.Now;
                DateTime now1 = now2.AddDays(-7);
                var customer = context.Purchases.FirstOrDefault(s => s.Name == name && s.LastName == lastName);
                if (customer != null)
                {
                    command.Parameters.Add("@name", txtName.Text);
                    command.Parameters.Add("@lastName", txtLastName.Text);
                    command.Parameters.Add("@now1", now1);
                    command.Parameters.Add("@now2", now2);
                    DataTable PurchasesTable = new DataTable();
                    adapter.Fill(PurchasesTable);
                    dataGridView1.DataSource = PurchasesTable;
                    connection.Close();
                }
                else MessageBox.Show("Toks klientas neegzistuoja");
            }
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from Purchases where name = @name and lastName = @lastName and date >= @now1 and date <= @now2";
            connection.Open();
            using (ShopEntities context = new ShopEntities())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                string name = txtName.Text;
                string lastName = txtLastName.Text;
                DateTime now2 = DateTime.Now;
                DateTime now1 = now2.AddMonths(-1);
                var customer = context.Purchases.FirstOrDefault(s => s.Name == name && s.LastName == lastName);
                if (customer != null)
                {
                    command.Parameters.Add("@name", txtName.Text);
                    command.Parameters.Add("@lastName", txtLastName.Text);
                    command.Parameters.Add("@now1", now1);
                    command.Parameters.Add("@now2", now2);
                    DataTable PurchasesTable = new DataTable();
                    adapter.Fill(PurchasesTable);
                    dataGridView1.DataSource = PurchasesTable;
                    connection.Close();
                }
                else MessageBox.Show("Toks klientas neegzistuoja");
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                var details = (from s in context.Sellers
                       join p in context.Purchases on s.Id equals p.SellerId
                       join i in context.Items on p.ItemNr equals i.Nr
                       join c in context.Customers on p.Name equals c.Name  
                               where c.Name == txtName.Text  && c.LastName == txtLastName.Text           
                       select new { Name = c.Name, LastName = c.LastName, SellerName = String.Concat(s.Name+" "+s.LastName), ItemsName = i.Name, Price =  i.Price, Date= p.Date}).ToList();

                dataGridView1.DataSource = details;
                context.SaveChanges();
                connection.Close();            
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
