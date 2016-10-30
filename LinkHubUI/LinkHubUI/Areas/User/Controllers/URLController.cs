using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LinkHubUI.Areas.User.Controllers
{
    public class URLController : Controller
    {
        // GET: User/URL
        public ActionResult Index()
        {
            LinkHubDbEntities db = new LinkHubDbEntities();
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: User/URL
        public ActionResult Create(Url objUrl)
        {
            LinkHubDbEntities db = new LinkHubDbEntities();
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }
    }
}