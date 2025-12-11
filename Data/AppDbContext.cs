using Microsoft.EntityFrameworkCore;
using FirstApiRest.Models;

namespace FirstApiRest.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}