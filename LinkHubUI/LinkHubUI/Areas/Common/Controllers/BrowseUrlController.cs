using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace LinkHubUI.Areas.Common.Controllers
{
    public class BrowseUrlController : Controller
    {
        private UrlBs _objBs;
        //konstruktor...
        public BrowseUrlController()
        {
            this._objBs = new UrlBs();
        }

        // GET: Common/BrowseUrl
        public ActionResult Index()
        {
            var urls = _objBs.GetAll();
            return View(urls); 
        }
    }
}