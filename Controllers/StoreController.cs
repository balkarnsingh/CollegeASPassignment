using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using College.Models;
using Microsoft.AspNetCore.Mvc;

namespace College.Controllers
{
    public class StoreController : Controller
    {
        
        public IActionResult Index()
        {
            var Detail = new List<Detail>();
            for (int i = 0; i < 10; i++)
            {
                Detail.Add(new Detail { Timing = "Timing" + i.ToString() });
            }
            return View(Detail);
        }
        public IActionResult Details(string detail)
        {
            ViewBag.detail = detail;
            return View();
        }
    }
}