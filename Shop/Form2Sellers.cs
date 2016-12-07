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
using System.Data.Entity;

namespace Shop
{
   
    public partial class Form2Sellers : Form
    {
        public static int id = 0;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop2;Integrated Security=True");
        public Form2Sellers()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sellers", connection))
            {
                DataTable sellersTable = new DataTable();
                adapter.Fill(sellersTable);
                dataGridView1.DataSource = sellersTable;
                connection.Close();
                txtName.Clear();
                txtLastName.Clear();
                txtNumber.Clear();
                txtSalary.Clear();
                txtEmployed.Clear();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())     
            {
                context.Sellers.Add(new Seller { Name = txtName.Text, LastName = txtLastName.Text, Employed = Convert.ToDateTime(txtEmployed.Text), Salary = Convert.ToDecimal(txtSalary.Text), Number = txtNumber.Text });
                context.SaveChanges();
            }
                DisplayData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          using (var context = new ShopEntities())
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                 id = Int32.Parse(Convert.ToString(selectedRow.Cells["Id"].Value));
                var seller = context.Sellers.FirstOrDefault(s => s.Id == id);
                context.Sellers.Remove(seller);
                context.SaveChanges();
                DisplayData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                id = Int32.Parse(Convert.ToString(selectedRow.Cells["Id"].Value));
                var seller = context.Sellers.FirstOrDefault(s => s.Id == id);
                txtName.Text = seller.Name;
                txtLastName.Text = seller.LastName;
                txtEmployed.Text = Convert.ToString(seller.Employed);
                txtSalary.Text = Convert.ToString(seller.Salary);
                txtNumber.Text = seller.Number;
            }
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                    var seller = context.Sellers.FirstOrDefault(s => s.Id == id);
                    seller.Name = txtName.Text;
                    seller.LastName = txtLastName.Text;
                    seller.Employed = Convert.ToDateTime(txtEmployed.Text);
                    seller.Salary = Convert.ToDecimal(txtSalary.Text);
                    seller.Number = txtNumber.Text;
                    context.SaveChanges();
                    DisplayData();
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                var statistics = (from s in context.Sellers
                                  select new
                                  {
                                      SellerId = s.Id,
                                      SellerName = s.Name,
                                      SellerLastName = s.LastName,
                                      SellerSales = context.Purchases.Count(t => t.SellerId == s.Id)
                                  }).ToList();
                dataGridView1.DataSource = statistics;
                context.SaveChanges();
                connection.Close();
            }
       }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

    }
}
