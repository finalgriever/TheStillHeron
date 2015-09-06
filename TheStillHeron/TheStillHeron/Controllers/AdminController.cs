using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheStillHeron.DataLogic;
using TheStillHeron.DataModel;
using TheStillHeron.Models;

namespace TheStillHeron.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        private BlogContext _context
        {
            get { return _context ?? new BlogContext(); }
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Blog()
        {
            var blog = new BlogModel();
            return View(blog);
        }

        public ActionResult Blog(int blogId)
        {
            var blog = Fetcher.RetrieveBlogById(_context, blogId);

            return View(blog);
        }

        public ActionResult Blog(BlogModel blog)
        {
            return View(blog);
        }

        [HttpPost]
        public ActionResult Blog(BlogModel blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChangesAsync();
            return View("Index");
        }
    }
}