using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Listing.Model
{
    public class ListModelContext : DbContext
    {
        public ListModelContext() : base("TestListDb")
        {
           
        }

        public DbSet<Item> Items{ get; set; }
        public DbSet<CategoryItem> CategoryItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ItemList> ItemLists { get; set; }
    }
}
