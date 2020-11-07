using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_8.Models;

namespace Project_8.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILogger<HomeController> _logger;

      public HomeController(ILogger<HomeController> logger)
      {
         _logger = logger;
      } 

      public IActionResult Index()
      {
         return View();
      }

      [HttpGet]
      public IActionResult AddStaff()
      {
         return View();
      }

      [HttpPost]
      public IActionResult AddStaff(Staff p)
      {
         if (ModelState.IsValid)
         {
            return View("StaffDetail", p);
           // return RedirectToAction("StaffDetail", p);
         }
         else
         {
            return View(p);
         }
      }
      [HttpGet]
      public IActionResult EditStaff()
      {
         Staff p = new Staff();
         p.Id = 1;
         p.Name = "Gordon";
         p.Age = "Twenty";
         return View(p);
      }

      [HttpPost]
      public IActionResult EditStaff(Staff p)
      {
         if (ModelState.IsValid)
         {
            return View("StaffDetail", p);
            // return RedirectToAction("StaffDetail", p);
         }
         else
         {
            return View(p);
         }
         return View();
      }

      public IActionResult MemberProfile()
      {
         return View();
      }
      public IActionResult Privacy()
      {
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
