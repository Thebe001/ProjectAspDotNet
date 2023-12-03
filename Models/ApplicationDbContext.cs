using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspCoreApplication2023.Models
{
    // Models/ApplicationDbContext.cs
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie>? Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }

}
