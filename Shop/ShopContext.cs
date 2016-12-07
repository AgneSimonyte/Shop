using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class ShopContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase>Purchases { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)    // throw new UnintentionalCodeFirstException();
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Purchase>()
                            .HasRequired(a => a.Item)
                            .WithMany(a => a.Purchases)
                            .HasForeignKey(u => u.ItemNr).WillCascadeOnDelete(false);

            modelBuilder.Entity<Purchase>()
                        .HasRequired(a => a.Seller)
                        .WithMany(a => a.Purchases)
                        .HasForeignKey(u => u.SellerId).WillCascadeOnDelete(false);

        }
    }
    //class DbInitializer : DropCreateDatabaseAlways<ShopEntities>
    //{
    //    protected override void Seed(ShopEntities context)
    //    {
    //        context.Database.ExecuteSqlCommand("ALTER TABLE Purchases ADD CONSTRAINT uc_itemNr UNIQUE(itemNr)");
    //        context.Database.ExecuteSqlCommand("ALTER TABLE Purchases ADD CONSTRAINT uc_sellerId UNIQUE(sellerId)");
    //    }
    //}
    }
