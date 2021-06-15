using Microsoft.EntityFrameworkCore;
using PsDevs.Models;

namespace PsDevs.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Career> Careers { get; set; }
    }
}
