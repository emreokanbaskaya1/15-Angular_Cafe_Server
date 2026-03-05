using _15_AngularCafeServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace _15_AngularCafeServer.Context
{
    public class AppDbContext(DbContextOptions options): DbContext(options)
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}
