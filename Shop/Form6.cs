using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            using (ShopEntities context = new ShopEntities())
            {
                string name = txtName.Text;
                string lastName = txtLastName.Text;
                DateTime data = Convert.ToDateTime(txtDate.Text);
                context.Purchases.Add(new Purchase { Name = txtName.Text, LastName = txtLastName.Text, ItemNr = Form3Items.nr, Date = Convert.ToDateTime(txtDate.Text) });
            }

        }
    }
}
