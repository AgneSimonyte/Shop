using Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    class Program  //static?
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (ShopEntities context = new ShopEntities())
            {
                //context.Sellers.Add(new Seller { Name = "Akvile", LastName = "Saviokaite", Employed = new DateTime(2016, 8, 2), Salary = 300m, Number = "+37066622288" });
                //context.Sellers.Add(new Seller { Name = "Aiste", LastName = "Dindaite", Employed = new DateTime(2015, 1, 15), Salary = 353m, Number = "+37013245584" });
                //context.Sellers.Add(new Seller { Name = "Danute", LastName = "Budryte", Employed = new DateTime(2014, 5, 13), Salary = 500.35m, Number = "+37012345655" });
                //context.Sellers.Add(new Seller { Name = "Ema", LastName = "Ragelyte", Employed = new DateTime(2016, 1, 31), Salary = 330.5m, Number = "+37056840220" });

                //context.Customers.Add(new Customer { Name = "Bronius", LastName = "Asmena", Email = "bronius.asmena@yahoo.com" });
                //context.Customers.Add(new Customer { Name = "Jonas", LastName = "Juodelis", Email = "jonce04@gmail.com" });
                //context.Customers.Add(new Customer { Name = "Ona", LastName = "Maciulyte", Email = "ona.maciulyte@gmail.com" });
                //context.Customers.Add(new Customer { Name = "Marius", LastName = "Marcelijus" });
                //context.Customers.Add(new Customer { Name = "Brigita", LastName = "Jurgela", Email = "brigitux1996@yahoo.com" });

                //context.Items.Add(new Item { Name = "J10 Dzinsai", Price = 34.99m });
                //context.Items.Add(new Item { Name = "J15 Dzinsai", Price = 49.99m });
                //context.Items.Add(new Item { Name = "T05 Maikute", Price = 20.99m });
                //context.Items.Add(new Item { Name = "T10 Maikute", Price = 19.99m });
                //context.Items.Add(new Item { Name = "T20 Maikute", Price = 23.49m });
                //context.Items.Add(new Item { Name = "S100 Batai", Price = 74.75m });
                //context.Items.Add(new Item { Name = "S115 Batai", Price = 34.55m });

                //context.Purchases.Add(new Purchase { Name = "Bronius", LastName = "Asmena", ItemNr = 2, SellerId = 4, Date = new DateTime(2016, 11, 25) });
                //context.Purchases.Add(new Purchase { Name = "Bronius", LastName = "Asmena", ItemNr = 1, SellerId = 2, Date = new DateTime(2016, 7, 11) });
                //context.Purchases.Add(new Purchase { Name = "Jonas", LastName = "Juodelis", ItemNr = 3, SellerId = 2, Date = new DateTime(2016, 1, 5) });
                //context.Purchases.Add(new Purchase { Name = "Ona", LastName = "Maciulyte", ItemNr = 3, SellerId = 3, Date = new DateTime(2016, 11, 25) });
                //context.Purchases.Add(new Purchase { Name = "Ona", LastName = "Maciulyte", ItemNr = 7, SellerId = 1, Date = new DateTime(2016, 8, 28) });
                //context.Purchases.Add(new Purchase { Name = "Ona", LastName = "Maciulyte", ItemNr = 5, SellerId = 4, Date = new DateTime(2016, 2, 24) });
                //context.Purchases.Add(new Purchase { Name = "Marius", LastName = "Marcelijus", ItemNr = 4, SellerId = 3, Date = new DateTime(2015, 12, 15) });
                //context.Purchases.Add(new Purchase { Name = "Brigita", LastName = "Jurgela", ItemNr = 7, SellerId = 1, Date = new DateTime(2016, 11, 25) });
                //context.Purchases.Add(new Purchase { Name = "Brigita", LastName = "Jurgela", ItemNr = 1, SellerId = 2, Date = new DateTime(2016, 11, 25) });
                //context.Purchases.Add(new Purchase { Name = "Brigita", LastName = "Jurgela", ItemNr = 3, SellerId = 3, Date = new DateTime(2016, 12, 02) });



                context.SaveChanges();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }



    }
}
