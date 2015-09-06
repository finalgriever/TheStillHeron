using TheStillHeron.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStillHeron.DataModel
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogModel> Blogs { get; set; }

        public DbSet<TopicModel> Topics { get; set; }

        public BlogsViewModel BlogsModel
        {
            get
            {
                return new BlogsViewModel
                {
                    Blogs = Blogs.ToList()
                };
            }
        }
    }
}
