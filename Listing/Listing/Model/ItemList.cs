using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing.Model
{
    public class ItemList
    {
        public ItemList()
        {
          
        }

        public int ItemListId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDue { get; set; }
        public int AmountItems { get; set; }
        public decimal? PricePerItek { get; set; }
    }
}
