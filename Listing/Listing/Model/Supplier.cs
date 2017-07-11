using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing.Model
{
    public class Supplier
    {
        public Supplier()
        {

        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierLocation { get; set; }
        public string SupplierDescription { get; set; }

        public IList<ItemList> ItemLists { get; set; }

    }
}
