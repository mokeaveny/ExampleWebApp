using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExampleWebApp.Models;

namespace ExampleWebApp.Controllers
{
    public class FormController : Controller
    {
        private DataContext context;

        public FormController(DataContext dbContext)
        {
            context = dbContext;
        }

        public async Task<IActionResult> Index(long id = 1)
        {
            return View("Form", await context.Products.FindAsync(id));
        }

        [HttpPost]
        public IActionResult SubmitForm()
        {
            foreach (string key in Request.Form.Keys
                    .Where(k => !k.StartsWith("_")))
            {
                TempData[key] = string.Join(", ", Request.Form[key]);
            }
            return RedirectToAction(nameof(Results));
        }

        public IActionResult Results()
        {
            return View(TempData);
        }
    }
}
