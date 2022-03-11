using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LinqWithEF.Models
{
    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; } = null!;
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        [StringLength(20)]
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public virtual Category? Category { get; set; }
    }
}
