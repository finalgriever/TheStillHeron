using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStillHeron.Models
{
    class BlogsModel
    {
        public IList<BlogModel> Blogs { get; set; }

        public BlogModel RecentBlog
        {
            get
            {
                return Blogs.OrderByDescending(x => x.DatePublished)
                            .FirstOrDefault();
            }
        }
    }
}
