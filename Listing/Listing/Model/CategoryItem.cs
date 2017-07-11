using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing.Model
{
    public class CategoryItem
    {
        public CategoryItem()
        {

        }

        public int CategoryItemId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public IList<Item> Items { get; set; }

    }
}
