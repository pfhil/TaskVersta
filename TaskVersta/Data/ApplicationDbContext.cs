using Microsoft.EntityFrameworkCore;
using TaskVersta.Models;

namespace TaskVersta.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
    }
}
