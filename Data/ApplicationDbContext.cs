using BlogApp.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
    }
}
