using PhotoGallery.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoGallery.Web.Controllers
{
    public class AlbumController : Controller
    {
        PhotoGalleryContext context = new PhotoGalleryContext();

        // GET: /Album/
        public ActionResult Index()
        {
            return View(context.Albums.ToList());
        }
	}
}