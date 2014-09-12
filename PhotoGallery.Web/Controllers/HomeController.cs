using PhotoGallery.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoGallery.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            PhotoGalleryContext pgc = new PhotoGalleryContext();
            return View(pgc.Albums.ToList());
        }
	}
}