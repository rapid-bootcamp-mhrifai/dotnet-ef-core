using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace dotnet_ef_core.DataContext
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // injection
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CategoryEntity> categories { get; set; }
    }
}
