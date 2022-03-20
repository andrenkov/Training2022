using Packt.Shared;//Categories and Products
using System.ComponentModel.DataAnnotations;

namespace Northwind.Mvc.Models
{
    public record HomeIndexViewModel
    {
        public HomeIndexViewModel(int VisitorsCount, List<Category> Categories, List<Product> Products)
        {
            this.VisitorsCount = VisitorsCount;
            this.Categories = Categories;
            this.Products = Products;
        }
        [Range(0,999)]
        public int VisitorsCount { get; set; }
        [Required]
        public IList<Category>? Categories { get; set; }
        public IList<Product>? Products { get; set; }
    }
}
