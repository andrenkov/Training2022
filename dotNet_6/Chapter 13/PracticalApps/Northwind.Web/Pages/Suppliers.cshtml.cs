using Microsoft.AspNetCore.Mvc;//IActionResult
using Microsoft.AspNetCore.Mvc.RazorPages;//PageModel
using Packt.Shared;//ref to DbContext

namespace Northwind.Web.Pages
{
    public class SuppliersModel : PageModel
    {
        //
        //for posting - it links webpage HTML elements to properties in teh Supplier class
        //
        [BindProperty]
        public Supplier? Supplier { get; set; }
        //

        //public IEnumerable<string>? Suppliers { get; set; }
        public IEnumerable<Supplier>? Suppliers { get; set; }
        private northwindContext db;

        public SuppliersModel(northwindContext injectedContext)
        {
            db = injectedContext;
        }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Suppliers";
            //Suppliers = new[]
            //{
            //    "TCSC", "Notocactus", "CSSA"
            //};
            Suppliers = db.Suppliers
                .OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
        }

        public IActionResult OnPost()
        {
            if ((Supplier is not null) && ModelState.IsValid)//validation here as per the Model Data Annotations
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            else
            {
                return Page();//return to original page
            }
        }

    }
}
