using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheStillHeron.DataModel;
using TheStillHeron.Models;

namespace TheStillHeron.DataLogic
{
    public static class Fetcher
    {
        public static BlogModel RetrieveBlogById(BlogContext context, int id)
        {
            return context.Blogs.Where(x => x.Id == id).FirstOrDefault();
        }

        public static IList<BlogModel> RetrieveBlogs(BlogContext context)
        {
            return context.Blogs.ToList();
        }
    }
}