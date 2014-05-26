using GuestBookMVC.Clients.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuestBookMVC.Clients.Web.Controllers
{
    public class GuestBookController : Controller
    {
        private GuestBookDbContext context = new GuestBookDbContext();

        //
        // GET: /GuestBook/
        public ActionResult Index()
        {
            var entries = context.entries.ToList();
            return View(entries);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(GuestBookEntry entry) 
        {
            entry.InsertDate = DateTime.Now;
            context.entries.Add(entry);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
	}
}