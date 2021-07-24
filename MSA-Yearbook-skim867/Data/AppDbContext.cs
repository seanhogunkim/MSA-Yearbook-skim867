using Microsoft.EntityFrameworkCore;
using MSAYearbook.Models;

namespace MSAYearbook.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}