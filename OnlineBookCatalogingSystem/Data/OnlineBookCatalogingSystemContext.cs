using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBookCatalogingSystem.Models;

namespace OnlineBookCatalogingSystem.Data
{
    public class OnlineBookCatalogingSystemContext : DbContext
    {
        public OnlineBookCatalogingSystemContext (DbContextOptions<OnlineBookCatalogingSystemContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineBookCatalogingSystem.Models.Book> Books { get; set; } = default!;
    }
}
