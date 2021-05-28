using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExampleWebApp.Models;

namespace ExampleWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private DataContext context;

        public Product Product { get; set; }

        public IndexModel(DataContext ctx)
        {
            context = ctx;
        }

        public async Task<IActionResult> OnGetAsync(long id = 1)
        {
            Product = await context.Products.FindAsync(id);
            if (Product == null)
            {
                return RedirectToPage("NotFound");
            }
            return Page();
        }
    }
}
