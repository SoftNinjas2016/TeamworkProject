using MVC_Blog_ALV.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Blog_ALV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var db = new ApplicationDbContext();
            var post = db.Posts.Include(p => p.Author)
                               .OrderByDescending(p => p.Date)
                               .Take(3);
            return View(post.ToList());
        }

        public ActionResult PostDetailsById(int id)
        {
            var db = new ApplicationDbContext();
            var postDetails = db.Posts
                .Where(p => p.Id == id)
                .Select(PostDetailsViewModel.ViewModel)
                .FirstOrDefault();

            return this.PartialView("_PostDetails", postDetails);
        }
    }
}