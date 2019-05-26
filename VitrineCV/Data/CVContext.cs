using VitrineCV.Models;
using Microsoft.EntityFrameworkCore;

namespace VitrineCV.Data
{
    public class CVContext : DbContext
    {
        public CVContext(DbContextOptions<CVContext> options) : base(options)
        {
        }

        public DbSet<Formation> Formations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formation>().ToTable("Formation");
        }
    }
}