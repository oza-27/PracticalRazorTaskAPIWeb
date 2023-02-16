using Microsoft.EntityFrameworkCore;
using PracticalRazorTaskAPI.Model;
using System.Collections.Generic;

namespace PracticalRazorTaskAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
