using PhotoSharingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoSharingApplication.Controllers
{
    public class PhotoController : Controller
    {
        private PhotoSharingContext context = new PhotoSharingContext();
        // GET: Photo
        public ActionResult Index()
        {
            //hien view /Views/Photo/Index.cshtml
            return View("Index", context.Photos.ToList());
        }
        public ActionResult Display(int id)
        {
            //Views/Photo/Display.cshtml
            Photo photo = context.Photos.Find(id);

        }
    }
}