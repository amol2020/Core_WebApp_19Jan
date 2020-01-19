using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_WebApp.Models
{
    public class CoreAppDBContext: DbContext
    {
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public CoreAppDBContext(DbContextOptions<CoreAppDBContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
