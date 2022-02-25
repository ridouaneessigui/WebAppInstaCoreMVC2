using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppInstaCoreMVC.Data;
using WebAppInstaCoreMVC.Models;

namespace WebAppInstaCoreMVC.Controllers
{
    public class ClientController : Controller
    {
        private readonly MydbContext db;


        public ClientController(MydbContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [ActionName("Create")]
        [Route("create")]
        public IActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {

                db.Add(client);
                db.SaveChanges();
                return RedirectToAction(nameof(ReturnData));

            }
            return View(client);
        }


        public IActionResult ReturnData()
        {
            return View(db.Client.ToList());
        }
        public IActionResult Test()
        {
            return View("Test");
        }

        public ActionResult Delete(int id)
        {
            var client = db.Client.Find(id);
            db.Client.Remove(client!);
            db.SaveChanges();
            return RedirectToAction(nameof(ReturnData));
        }
    }
}
