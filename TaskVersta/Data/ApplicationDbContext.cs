using Microsoft.EntityFrameworkCore;
using TaskVersta.Models;

namespace TaskVersta.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
    }
}
