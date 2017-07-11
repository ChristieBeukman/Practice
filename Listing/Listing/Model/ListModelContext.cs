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
    }
}
