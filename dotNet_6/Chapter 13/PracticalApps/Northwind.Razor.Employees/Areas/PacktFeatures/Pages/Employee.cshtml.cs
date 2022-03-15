using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace Northwind.Razor.Employees.PacktFeatures.Pages
{
    public class EmployeesPageModel : PageModel
    {
        private northwindContext db;
        public Employee[] Employees { get; set; } = null!;
        public EmployeesPageModel(northwindContext injectedContext)
        {
            db = injectedContext;
        }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Employees";
            Employees = db.Employees.OrderBy(e => e.LastName)
                .ThenBy(e => e.FirstName).ToArray();
        }
    }
}