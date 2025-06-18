using Microsoft.EntityFrameworkCore;
using simple_blog_api_with_C_.Models;

namespace simple_blog_api_with_C_.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;


    }
}
