﻿using Microsoft.AspNetCore.Mvc;

namespace CalculatorTest.Web.Controllers {

    public class HomeController : Controller {

        public HomeController() {

        }

        public IActionResult Index() {
            return View();
        }

    }

}