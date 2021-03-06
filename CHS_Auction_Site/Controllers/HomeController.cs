﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CHS_Auction_Site.Models;

namespace CHS_Auction_Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            ViewData["Message"] = "Check In";

            return View();
        }

        public IActionResult Payments()
        {
            ViewData["Message"] = "Payment";

            return View();
        }

        public IActionResult NewItem()
        {
            ViewData["Message"] = "NewItem";

            return View();
        }

        public IActionResult Event()
        {
            ViewData["Message"] = "Event";

            return View();
        }

        public IActionResult EventItems()
        {
            ViewData["Message"] = "Event Items";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
