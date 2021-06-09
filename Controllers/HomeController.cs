﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ExampleWebApp.Filters;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ExampleWebApp.Controllers
{
    [HttpsOnly]
    [ResultDiagnostics]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Message", "This is the Index action on the Home controller");
        }

        public IActionResult Secure()
        {
            return View("Message", "This is the Secure action on the Home controller");
        }

        //[ChangeArg]
        public IActionResult Messages(string message1, string message2 = "None")
        {
            return View("Message", $"{message1}, {message2}");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.ContainsKey("message1"))
            {
                context.ActionArguments["message1"] = "New message";
            }
        }
    }
}
