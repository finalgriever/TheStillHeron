using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStillHeron.Models
{
    public class BlogsViewModel
    {
        public IList<BlogModel> Blogs { get; set; }

        public BlogModel LastBlog
        {
            get
            {
                return Blogs.OrderByDescending(x => x.DatePublished)
                            .FirstOrDefault();
            }
        }
    }
}
