using TheStillHeron.Models;
using System;
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
    }
}
