﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApp.Controllers
{
    public class CubedController : Controller
    {
        public IActionResult Index()
        {
            return View("Cubed");
        }

        public IActionResult Cube(double num)
        {
            TempData["value"] = num.ToString();
            TempData["result"] = Math.Pow(num, 3).ToString();
            return RedirectToAction(nameof(Index));
        }
    }
}
