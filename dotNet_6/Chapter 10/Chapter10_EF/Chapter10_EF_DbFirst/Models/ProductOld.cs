using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntFrame.Shared.Models
{
    public class ProductOld
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        [Column("UnitPrice", TypeName = "money")]//property name != actual column name
        public decimal Cost { get; set; }
        [Column("UnitsInStock")]
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }

        //two below define the foriegn key to Category
        public int CategoryId { get; set; }
        public virtual CategoryOld Category { get; set; } = null!;
    }
}
