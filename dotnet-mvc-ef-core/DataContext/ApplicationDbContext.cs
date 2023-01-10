using System;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace dotnet_mvc_ef_core.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        // injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
        public DbSet<CustomerEntity> CustomerEntities => Set<CustomerEntity>();
    }
}
