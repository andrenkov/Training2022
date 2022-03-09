using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace EntFrame.Shared.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        [Column(TypeName = "ntext")]
        public string? Description { get; set; }

        //defines the navigation property for related rows
        //The HashSet<T> class provides high-performance set operations.
        //A set is a collection that contains no duplicate elements, and whose elements are in no particular order.
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            //init Products for being able to add a Product into the Catergory
            Products = new HashSet<Product>();
        }
    }
}
