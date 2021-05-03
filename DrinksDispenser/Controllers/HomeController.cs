using DrinksDispenser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrinksDispenser.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IDrinksDispenserBusinessLayer businessLayer = new DrinksDispenserBusinessLayer();
            DrinksDispenserViewModel model = new DrinksDispenserViewModel(businessLayer);
            
            return View(model);
        }


    }
}