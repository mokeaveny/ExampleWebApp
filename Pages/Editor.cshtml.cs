using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExampleWebApp.Models;

namespace ExampleWebApp.Pages
{
    public class EditorModel : PageModel
    {
        private DataContext context;

        public Product Product { get; set; }

        public EditorModel(DataContext ctx)
        {
            context = ctx;
        }

        public async Task OnGetAsync(long id)
        {
            Product = await context.Products.FindAsync(id);
        }

        public async Task<IActionResult> OnPostAsync(long id, decimal price)
        {
            Product p = await context.Products.FindAsync(id);
            p.Price = price;
            await context.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}
