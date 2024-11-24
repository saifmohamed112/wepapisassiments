using Microsoft.EntityFrameworkCore;
using wepapisassiment.Models;

namespace wepapisassiment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Directors> Directors { get; set; }
        public DbSet<Catigory> Catigories { get; set; }
        public DbSet<Nationalty> Nationalties { get; set; }

    }
}
