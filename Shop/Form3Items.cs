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
    public partial class Form3Items : Form
    {
        public static int nr = 0;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop2;Integrated Security=True");
        public Form3Items()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Items", connection))
            {
                DataTable itemsTable = new DataTable();
                adapter.Fill(itemsTable);
                dataGridView1.DataSource = itemsTable;
                connection.Close();
                txtName.Clear();
                txtPrice.Clear();
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                context.Items.Add(new Item { Name = txtName.Text, Price = Convert.ToDecimal(txtPrice.Text) });
                context.SaveChanges();
            }
            DisplayData();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                nr = Int32.Parse(Convert.ToString(selectedRow.Cells["Nr"].Value));
                var item = context.Items.FirstOrDefault(s => s.Nr == nr);
                context.Items.Remove(item);
                context.SaveChanges();
                DisplayData();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                nr = Int32.Parse(Convert.ToString(selectedRow.Cells["Nr"].Value));
                var item = context.Items.FirstOrDefault(s => s.Nr == nr);
                txtName.Text = item.Name;
                txtPrice.Text = Convert.ToString(item.Price);
            }
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                var item = context.Items.FirstOrDefault(s => s.Nr == nr);
                item.Name = txtName.Text;
                item.Price = Convert.ToDecimal(txtPrice.Text);
                context.SaveChanges();
                DisplayData();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                nr = Int32.Parse(Convert.ToString(selectedRow.Cells["Nr"].Value));
                var item = context.Items.FirstOrDefault(s => s.Nr == nr);
                Form6 form6 = new Form6();
                form6.Show();


             //   txtName.Text = item.Name;
             //   txtPrice.Text = Convert.ToString(item.Price);
            }
        }
    }
}

