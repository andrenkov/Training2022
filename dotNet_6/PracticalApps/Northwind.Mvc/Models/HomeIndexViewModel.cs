using Packt.Shared;//Categories and Products


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

        public int VisitorsCount { get; set; }
        public IList<Category>? Categories { get; set; }
        public IList<Product>? Products { get; set; }
    }
}
