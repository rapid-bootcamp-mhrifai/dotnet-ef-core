using System;
using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_core.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        // injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CategoryEntity> categories { get; set; }
    }
}
