using Microsoft.EntityFrameworkCore;
using OnlineBookCatalogingSystem.Models;

namespace OnlineBookCatalogingSystem.Data
{
    public class OnlineBookCatalogingSystemContext : DbContext
    {
        public OnlineBookCatalogingSystemContext(DbContextOptions<OnlineBookCatalogingSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ensure primary key is correctly configured
            modelBuilder.Entity<Books>()
                .HasKey(b => b.BookID); // Explicitly define the primary key
        }
    }
}

