using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheStillHeron.DataModel;
using TheStillHeron.DataLogic;

namespace TheStillHeron.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext _context
        {
            get { return _context ?? new BlogContext(); }
        }

        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(int blogId)
        {
            var blog = Fetcher.RetrieveBlogById(_context, blogId);

            return View(blog);
        }
    }
}