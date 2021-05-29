using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Html;

namespace ExampleWebApp.Components
{
    public class CitySummary : ViewComponent
    {
        private CitiesData data;

        public CitySummary(CitiesData cdata)
        {
            data = cdata;
        }

        public IViewComponentResult Invoke(string themeName)
        {
            ViewBag.Theme = themeName;

            return View(new CityViewModel
            {
                Cities = data.Cities.Count(),
                Population = data.Cities.Sum(c => c.Population)
            });
        }
    }
}
