﻿using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionss.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public string Display()
        {
            return "Hey this is abhishek";
        }

        public int Displayid(int id)
        {
            return id;
        }
    }
}
