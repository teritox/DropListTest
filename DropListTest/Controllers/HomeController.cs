using DropListTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DropListTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string filterSetting, IndexViewModel model)
        {
            if (model != null)
            {
                ViewData["filterSetting"] = model.selectedVendor;
                ViewData["filterSetting"] = model.selectedFruit;

            }


            var selectVendorList = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Ett"},
                new SelectListItem { Value = "2", Text = "Två"},
                new SelectListItem { Value = "3", Text = "Tre"},
                new SelectListItem { Value = "4", Text = "Fyra"},
                new SelectListItem { Value = "5", Text = "Fem"}
            };

            var selectFruitList = new List<SelectListItem>
            {
                new SelectListItem { Value = "Banan", Text = "Banan"},
                new SelectListItem { Value = "Äpple", Text = "Äpple"},
                new SelectListItem { Value = "Plommon", Text = "Plommon"},
                new SelectListItem { Value = "Vindruvor", Text = "Vindruvor"},
                new SelectListItem { Value = "Melon", Text = "Melon"}
            };

            var viewmodel = new IndexViewModel();

            viewmodel.Vendors = selectVendorList;
            viewmodel.Fruits = selectFruitList; 


            return View(viewmodel);
        }
        public ActionResult ShowAllMobileDetails()
        {
            IndexViewModel MV = new IndexViewModel();

            return View(MV);
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
