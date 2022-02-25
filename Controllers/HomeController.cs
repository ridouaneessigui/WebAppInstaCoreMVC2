using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppInstaCoreMVC.Data;
using WebAppInstaCoreMVC.Models;

namespace WebAppInstaCoreMVC.Controllers
{
    public class HomeController : Controller
    {


        [Route("ContentResult")]
        public IActionResult ContentResult()
        {
            return Content("{ <h1>I'am good boy</h1>}");
        }
        [Route("WelcomeEmp")]
        public EmptyResult EmptyResult()
        {
           return new EmptyResult();
        }

        
        [Route("WelcomeJson")]
        public JsonResult WelcomeNot()
        {
            bool isAdmin = false;
            string output = isAdmin ? "Welcomme evryone " : " WelcomeEveyone to the USer";
            return Json(output);
        }

        public ViewResult Index()
        {
              ViewData["Nom"] = "LIG";
              ViewData["Message"] = "PSG";
            TempData["age"] = "test data ";
            var data = TempData["age"];
            ViewData["age"] = data;
            TempData.Keep();
            return View();
             ViewBag.nom = "CLili";
             ViewBag.message = "Bonjour";
            return View();
        }

        [Route("messi")]
        public IActionResult Test()
        {
            ViewData["age2"] = TempData["age"];
            TempData.Keep();
            return View();

        }
        [Route("messi2")]
        public IActionResult Test2()
        {
            ViewData["age3"] = TempData["age"];
            TempData.Keep();
            return View();

        }

        [Route("messi4")]
        public ActionResult Welcome()

        {
            ViewData["Number"]= 10 + 20;
            var maChaine = ViewData["Number"];

            return View();
        }

    /*    public IActionResult Index()
        {
            Client P = new Client();
            {
                P.RCS = "233333";
                P.Email = "email222";

            }*/



    }

  
}