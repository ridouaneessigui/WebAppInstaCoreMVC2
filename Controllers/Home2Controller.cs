using Microsoft.AspNetCore.Mvc;

namespace WebAppInstaCoreMVC.Controllers
{
    public class Home2Controller : Controller
    {
        [Route("messi3")]
        public IActionResult Test3()
        {
            ViewData["age4"] = TempData["age"];
            return View();

        }
    }
}
